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
    
    public partial class flujo
    {
        public flujo()
        {
            this.flujo_act_estado = new HashSet<flujo_act_estado>();
            this.flujo_doc = new HashSet<flujo_doc>();
            this.flujo_paso_estado = new HashSet<flujo_paso_estado>();
            this.flujo_seguimiento = new HashSet<flujo_seguimiento>();
            this.flujo_seguimiento_paso = new HashSet<flujo_seguimiento_paso>();
        }
    
        public int id_flujo { get; set; }
        public int temporada { get; set; }
        public System.DateTime fecha { get; set; }
        public string hora { get; set; }
        public string estado { get; set; }
        public string consecutivo_corr { get; set; }
        public string tipo_correspondencia { get; set; }
        public Nullable<int> id_tipo { get; set; }
        public string nombre { get; set; }
        public string observacion { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
        public string hora_fin { get; set; }
        public Nullable<int> id_tiposenvio { get; set; }
        public string coddependencia { get; set; }
        public string login { get; set; }
        public Nullable<int> consecutivo { get; set; }
        public string origen { get; set; }
        public Nullable<int> id_origen { get; set; }
        public string referencia { get; set; }
        public Nullable<int> id_sede { get; set; }
    
        public virtual flujo_tipo flujo_tipo { get; set; }
        public virtual flujo_temporada flujo_temporada { get; set; }
        public virtual ICollection<flujo_act_estado> flujo_act_estado { get; set; }
        public virtual flujo_cancelado_observacion flujo_cancelado_observacion { get; set; }
        public virtual ICollection<flujo_doc> flujo_doc { get; set; }
        public virtual ICollection<flujo_paso_estado> flujo_paso_estado { get; set; }
        public virtual ICollection<flujo_seguimiento> flujo_seguimiento { get; set; }
        public virtual ICollection<flujo_seguimiento_paso> flujo_seguimiento_paso { get; set; }
    }
}
