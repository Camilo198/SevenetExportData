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
    
    public partial class registro_carpetas_indices
    {
        public int id_registro_carpetas { get; set; }
        public int id_indice { get; set; }
        public string valor { get; set; }
    
        public virtual documentos_especiales_indices documentos_especiales_indices { get; set; }
        public virtual registro_carpetas registro_carpetas { get; set; }
    }
}
