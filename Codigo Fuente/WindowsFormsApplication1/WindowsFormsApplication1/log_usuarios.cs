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
    
    public partial class log_usuarios
    {
        public int id_log { get; set; }
        public string login { get; set; }
        public Nullable<System.DateTime> fecha_entrada { get; set; }
        public string hora_entrada { get; set; }
        public Nullable<System.DateTime> fecha_salida { get; set; }
        public string hora_salida { get; set; }
        public string sess_id { get; set; }
        public string tipo { get; set; }
    }
}