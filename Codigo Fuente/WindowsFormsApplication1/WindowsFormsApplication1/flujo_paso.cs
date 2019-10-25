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
    
    public partial class flujo_paso
    {
        public flujo_paso()
        {
            this.flujo_paso_estado = new HashSet<flujo_paso_estado>();
            this.flujo_seguimiento_paso = new HashSet<flujo_seguimiento_paso>();
            this.flujo_responsables = new HashSet<flujo_responsables>();
        }
    
        public int id_paso { get; set; }
        public int id_actividad { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> duracion { get; set; }
        public Nullable<int> posicion { get; set; }
        public Nullable<int> tipo_dura { get; set; }
        public Nullable<int> tipo { get; set; }
    
        public virtual flujo_actividad flujo_actividad { get; set; }
        public virtual ICollection<flujo_paso_estado> flujo_paso_estado { get; set; }
        public virtual ICollection<flujo_seguimiento_paso> flujo_seguimiento_paso { get; set; }
        public virtual ICollection<flujo_responsables> flujo_responsables { get; set; }
    }
}