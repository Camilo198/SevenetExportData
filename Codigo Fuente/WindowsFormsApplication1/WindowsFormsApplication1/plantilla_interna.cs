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
    
    public partial class plantilla_interna
    {
        public plantilla_interna()
        {
            this.item_interna = new HashSet<item_interna>();
        }
    
        public int id_plantilla { get; set; }
        public string nombre { get; set; }
        public string nbd { get; set; }
        public Nullable<int> estado { get; set; }
        public string carpeta { get; set; }
    
        public virtual ICollection<item_interna> item_interna { get; set; }
    }
}