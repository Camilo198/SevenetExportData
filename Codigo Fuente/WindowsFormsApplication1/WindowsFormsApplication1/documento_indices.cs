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
    
    public partial class documento_indices
    {
        public int id_indice { get; set; }
        public int id_documento { get; set; }
        public string valor { get; set; }
        public string texto { get; set; }
        public string archivo { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> numero { get; set; }
        public Nullable<int> consecutivo { get; set; }
        public string opciones { get; set; }
    }
}
