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
    
    public partial class interna_indices
    {
        public int id_interna { get; set; }
        public int id_indice { get; set; }
        public string valor { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string texto { get; set; }
        public string archivo { get; set; }
        public Nullable<double> numero { get; set; }
        public Nullable<int> consecutivo { get; set; }
        public string opciones { get; set; }
        public Nullable<int> longitud { get; set; }
        public string ruta_adjunto { get; set; }
        public Nullable<System.DateTime> fecha_con_vencimiento { get; set; }
        public string fecha_con_vencimiento_users { get; set; }
        public Nullable<int> archivo_oid { get; set; }
    
        public virtual documentos_especiales_indices documentos_especiales_indices { get; set; }
        public virtual interna interna { get; set; }
    }
}
