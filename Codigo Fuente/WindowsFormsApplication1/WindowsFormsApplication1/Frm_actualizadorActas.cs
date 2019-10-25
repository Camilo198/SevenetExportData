using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RegistrosActas
{
    public partial class actualizadorActasControlador : Form
    {
        public actualizadorActasControlador()
        {
            InitializeComponent();
            
        }

  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                this.Close();
            }
        }
        
        private void b1Actualizar_Click(object sender, EventArgs e)
        {
            // crea un objeto nuevo por cada actualizacion
            //Esto garantiza que no se hagan updates con datos reciclados.
            Actualizacion act = new Actualizacion();
            // ejecutamos el metodo que actualiza
            //y le pasamos el parametro String que se recibe del formulario
            act.actualizar(t1Acta.Text);
            t1Acta.Text = ""; //Limpia el campo para generar una nueva solicitud
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void l2Info_Click(object sender, EventArgs e)
        {
            
        }

        private void b2Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_actLoad(object sender, EventArgs e)
        {

        }

        private void actualizadorActasControlador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='s') {
                this.Close();
            }
            else if (e.KeyChar == 'S') {
                this.Close();
            }
        }


    }
}
