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
    
    public partial class historial_respuesta_tramite
    {
        public int id_respuesta_tramite { get; set; }
        public int secuencia { get; set; }
        public Nullable<int> id_recibida { get; set; }
        public Nullable<int> id_despachada { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string respuesta_final { get; set; }
    }
}