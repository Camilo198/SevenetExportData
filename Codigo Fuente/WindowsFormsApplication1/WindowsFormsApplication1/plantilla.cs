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
    
    public partial class plantilla
    {
        public plantilla()
        {
            this.item = new HashSet<item>();
            this.plantilla_usuarios = new HashSet<plantilla_usuarios>();
            this.pto_usuarios = new HashSet<pto_usuarios>();
        }
    
        public int id_plantilla { get; set; }
        public Nullable<int> id_dependencia { get; set; }
        public string nombre { get; set; }
        public string nbd { get; set; }
        public Nullable<int> estado { get; set; }
        public string carpeta { get; set; }
    
        public virtual dependencias dependencias { get; set; }
        public virtual ICollection<item> item { get; set; }
        public virtual ICollection<plantilla_usuarios> plantilla_usuarios { get; set; }
        public virtual ICollection<pto_usuarios> pto_usuarios { get; set; }
    }
}
