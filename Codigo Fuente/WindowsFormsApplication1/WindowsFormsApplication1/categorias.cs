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
    
    public partial class categorias
    {
        public categorias()
        {
            this.categorias_usuarios = new HashSet<categorias_usuarios>();
            this.registro_carpetas = new HashSet<registro_carpetas>();
        }
    
        public int id_categoria { get; set; }
        public Nullable<int> id_dependencia { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string carpeta { get; set; }
    
        public virtual ICollection<categorias_usuarios> categorias_usuarios { get; set; }
        public virtual dependencias dependencias { get; set; }
        public virtual ICollection<registro_carpetas> registro_carpetas { get; set; }
    }
}
