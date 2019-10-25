using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.IO; // para exportar data

namespace RegistrosActas
{// clase que actualiza registros en la base de datos
    class Actualizacion
    {
        String F_Acta;
        String consulta;
        SqlCommand comando;
        Conexion c;
        String registrosAfectados;
        SqlDataReader lecturaDatos;
        SqlDataReader lecturaOpciones;
        ArrayList lecturaSelectOpcionesIndizadas =new ArrayList();
        ArrayList lecturaSelectIndices = new ArrayList();
        ArrayList  listaOpcionesTemporales  = new ArrayList();
        ArrayList salidaOpcionesDesIndizadas = new ArrayList();

        public void actualizar(String FrmElemento)
        {
            // Recibe el parametro del formulario y se lo pasa a una variable local
            F_Acta = FrmElemento;
            try
            {

                c = Conexion.getConexionObj(); // Obtiene el Objeto Singleton de conexion con la base de datos
                // valida que el campo recibido no sea Nulo ni vacio
                if (F_Acta != null && F_Acta != "")
                {
                    //consulta SQL
                    //consulta = "UPDATE HISTORICO set ID_ACTIVO = SUBSTRING(PLACA,4,1)+SUBSTRING(PLACA,6,10) where ACTA_ENTREGA =" + F_Acta;// + "or [actcompania]="+F_Name;
                    consulta = "SELECT ISNULL(LOWER(ri.opciones), '') AS 'TIPO DOCUMENTO' ,ri.id_indice FROM recibida AS r inner JOIN recibida_dependencias AS rd ON (r.id_recibida = rd.id_recibida) INNER JOIN dependencias AS ds  ON (ds.id_dependencia = rd.id_dependencia) LEFT JOIN recibida_indices AS ri ON (r.id_recibida = ri.id_recibida)where r.temporada=2019-- and consecutivo_gral in (9918,9924,9926,9927,9928)";
                    // consulta = "SELECT * FROM recibida AS r inner JOIN recibida_dependencias AS rd ON (r.id_recibida = rd.id_recibida) INNER JOIN dependencias AS ds  ON (ds.id_dependencia = rd.id_dependencia) LEFT JOIN recibida_indices AS ri ON (r.id_recibida = ri.id_recibida)where r.temporada=2019";
                   // consulta = "Select consecutivo_gral from recibida -- where consecutivo_gral=469";
                }
                else { MessageBox.Show("Ingrese un Numero de Acta Por favor", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                comando = new SqlCommand(consulta, c.crearConexion());// comando SQLque ejecuta la consulta

                c.conectar();// conecta a la base de datos
                registrosAfectados = comando.ExecuteNonQuery().ToString();//identifica cuantos registros fueron afectados por el Query
                lecturaDatos = comando.ExecuteReader();// Registros Leidos del Select
                Console.Write("Salida\n");
                while (lecturaDatos.Read())
                {
                    lecturaSelectOpcionesIndizadas .Add(lecturaDatos[0]);
                    lecturaSelectIndices.Add(lecturaDatos[1]);
                    
                }
                c.desconectar();// Cerrar la conexion con la base de datos

                //---------
                String palabraEntrada;
                String Silaba;
                String numero="";
                String indice;
                String palabraSalida="";
                for (int j = 0; j <lecturaSelectOpcionesIndizadas.Count; j++) {
                    palabraEntrada = lecturaSelectOpcionesIndizadas[j].ToString();
                    indice = lecturaSelectIndices[j].ToString();
                    Console.Write(palabraEntrada+" Palabra\n");
                    Console.Write(indice + " Indice\n");
                    for (int k = 0; k < palabraEntrada.Length; k++) {
                        
                        Silaba=palabraEntrada.Substring(k, 1);
                        if (Silaba != "<" && Silaba != ">")
                        {
                            Console.Write(Silaba + " Silaba\n");
                            numero += Silaba;
                            
                        }
                        else
                        {
                           
                            if (numero != "")
                            {
                                Console.Write(numero + " Numero\n");
                                listaOpcionesTemporales.Add(Int32.Parse(numero));                                

                            }                            
                                
                            numero = "";
                        }
                        
                    }
                    Console.Write(numero + " Numero\n");

                    if(numero!=""){
                    
                    listaOpcionesTemporales.Add(Int32.Parse(numero));
                    

                    listaOpcionesTemporales.Sort(); // ordena las opciones encontradas.
                    int cont=listaOpcionesTemporales.Count;;
                    for (int i = 0; i < listaOpcionesTemporales.Count; i++) {
                        
                        Console.Write(listaOpcionesTemporales[i] + " Numero-Opcion concultada\n");
                     
                            consulta = "SELECT titulo from opcion_indice where valor =" + listaOpcionesTemporales[i] + " and id_indice=" + indice;
                             comando = new SqlCommand(consulta, c.crearConexion());// comando SQLque ejecuta la consulta
                             c.conectar();// conecta a la base de datos
                             Console.Write("Indices Consultados\n");
                             //  registrosAfectados = comando.ExecuteNonQuery().ToString();
                             lecturaOpciones = comando.ExecuteReader();
                       

                             while (lecturaOpciones.Read())// este while solo se utiliza 1 vez
                             {
                                 Console.WriteLine(lecturaOpciones[0] + " opcion desindizada\n");
                                 if (cont > 1)
                                 {
                                     palabraSalida += lecturaOpciones[0] + "<>";
                                     cont--;
                                 }
                                 else { palabraSalida += lecturaOpciones[0];
                                 cont--;
                                 }
                             
                             }
                             c.desconectar();
                    }
                    Console.WriteLine(palabraSalida + " -PalabraDesindizada\n");
                    salidaOpcionesDesIndizadas.Add(palabraSalida);
                    }

                    else
                    {
                        Console.WriteLine(palabraSalida + " -PalabraDesindizada\n");
                        salidaOpcionesDesIndizadas.Add(palabraSalida);
                    }
                    palabraSalida = "";
                    listaOpcionesTemporales.Clear();
                    numero = "";
   
                    //-----------------------


                }                    
                
                //Indica si se actualizaron o no los datos asociados al numero de actta
                if (registrosAfectados != "0")
                {
                    MessageBox.Show("Se actualizaron "+registrosAfectados+"  registros del Acta # " + F_Acta,"Actualización Correcta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("No hay registros asociados al acta # " + F_Acta, "Sin Actualización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                

            }
            // Manejo de actas
            catch (SqlException)
            {
                MessageBox.Show("Ingrese solo numeros", "Letras detectadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Muestras excepcion si ingresa algo que no sean numeros

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No se encontro este Numero de Acta \n","Acta No Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Si no existe ese registro saltara este error
            }
           catch (InvalidOperationException)
            {
                MessageBox.Show("Entrada Invalida ","Datos Inapropiados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Muestras excepcion si no ingresa nada
            }
            //----------Exportar Array a SQL.
            for (int l = 0; l < salidaOpcionesDesIndizadas.Count; l++)
            {
                consulta = "INSERT INTO opcionesDesindizadasTemp (Id,OpcionDesindizada) VALUES("+l+","+"'"+salidaOpcionesDesIndizadas[l]+"'"+")";
                comando = new SqlCommand(consulta, c.crearConexion());// comando SQLque ejecuta la consulta

                c.conectar();// conecta a la base de datos
                registrosAfectados = comando.ExecuteNonQuery().ToString();//identifica cuantos registros fueron afectados por el Query
                c.desconectar();
            }
            MessageBox.Show("Registros Afectados: " + salidaOpcionesDesIndizadas.Count);
            //


       }
    }
}
