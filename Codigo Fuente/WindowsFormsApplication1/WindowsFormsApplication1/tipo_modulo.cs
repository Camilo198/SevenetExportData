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
    
    public partial class tipo_modulo
    {
        public tipo_modulo()
        {
            this.notificacion = new HashSet<notificacion>();
            this.notificacion1 = new HashSet<notificacion>();
            this.permisos_correspondencias = new HashSet<permisos_correspondencias>();
            this.permisos_correspondencias1 = new HashSet<permisos_correspondencias>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
    
        public virtual ICollection<notificacion> notificacion { get; set; }
        public virtual ICollection<notificacion> notificacion1 { get; set; }
        public virtual ICollection<permisos_correspondencias> permisos_correspondencias { get; set; }
        public virtual ICollection<permisos_correspondencias> permisos_correspondencias1 { get; set; }
    }
}
