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
    
    public partial class rango_guia
    {
        public int id_rango_guia { get; set; }
        public Nullable<int> id_sede { get; set; }
        public Nullable<int> id_contrato_courier { get; set; }
        public Nullable<int> numero { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string prefijo { get; set; }
        public Nullable<int> rango_inicial { get; set; }
        public Nullable<int> rango_final { get; set; }
        public string observaciones { get; set; }
        public string estado { get; set; }
    }
}
