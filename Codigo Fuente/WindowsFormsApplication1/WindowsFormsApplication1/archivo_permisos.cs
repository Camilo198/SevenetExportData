//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrosActasActivos
{
    using System;
    using System.Collections.Generic;
    
    public partial class archivo_permisos
    {
        public int id_archivo { get; set; }
        public string login { get; set; }
        public Nullable<int> consultar { get; set; }
        public Nullable<int> registrar { get; set; }
        public Nullable<int> modificar { get; set; }
        public Nullable<int> borrar { get; set; }
        public Nullable<int> administrar { get; set; }
        public Nullable<int> guardar { get; set; }
        public Nullable<int> imprimir { get; set; }
        public Nullable<int> enviar { get; set; }
        public Nullable<int> transferir { get; set; }
    }
}
