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
    
    public partial class item_imagen_guia_despachada
    {
        public int id_registro_estado_despacha { get; set; }
        public int item { get; set; }
        public Nullable<int> id_courier { get; set; }
        public string guia { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public string hora_registro { get; set; }
        public string observaciones { get; set; }
        public Nullable<int> longitud { get; set; }
        public string ext { get; set; }
        public string estado { get; set; }
    }
}