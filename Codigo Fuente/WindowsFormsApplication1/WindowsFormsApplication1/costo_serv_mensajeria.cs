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
    
    public partial class costo_serv_mensajeria
    {
        public int id_costo_serv_mensajeria { get; set; }
        public Nullable<int> id_contrato_courier { get; set; }
        public Nullable<int> id_servicio_mensajeria { get; set; }
        public Nullable<int> id_tipo_trayecto { get; set; }
        public Nullable<int> rango_inicial { get; set; }
        public Nullable<int> rango_final { get; set; }
        public Nullable<decimal> valor_rango { get; set; }
        public Nullable<decimal> valor_embolsado { get; set; }
        public Nullable<decimal> valor_kilo { get; set; }
        public Nullable<decimal> valor_kilo_adicional { get; set; }
        public Nullable<int> horas_entrega { get; set; }
        public string estado { get; set; }
    }
}
