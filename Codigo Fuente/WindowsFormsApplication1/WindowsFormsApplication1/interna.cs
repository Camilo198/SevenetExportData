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
    
    public partial class interna
    {
        public interna()
        {
            this.interna_dependencias = new HashSet<interna_dependencias>();
            this.interna_indices = new HashSet<interna_indices>();
            this.seguimiento_tramite_interna = new HashSet<seguimiento_tramite_interna>();
        }
    
        public int id_interna { get; set; }
        public int temporada { get; set; }
        public int consecutivo { get; set; }
        public Nullable<System.DateTime> fgraba { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string origen { get; set; }
        public string id_documento { get; set; }
        public Nullable<int> estado_tramite { get; set; }
        public string resumen { get; set; }
        public string login { get; set; }
        public string usuario_grabo { get; set; }
        public Nullable<int> id_tramite { get; set; }
        public string cd { get; set; }
        public Nullable<int> sizea { get; set; }
        public Nullable<System.DateTime> fradica { get; set; }
        public string hradica { get; set; }
        public Nullable<int> id_flujo { get; set; }
        public Nullable<int> id_doc { get; set; }
        public Nullable<int> id_recibida { get; set; }
        public Nullable<int> id_serie { get; set; }
        public Nullable<int> id_dependencia { get; set; }
        public string n_folios { get; set; }
        public byte[] imagen { get; set; }
        public Nullable<int> id_sede { get; set; }
        public Nullable<int> id_mensajero { get; set; }
        public Nullable<int> id_sede_envia { get; set; }
        public Nullable<int> estado { get; set; }
        public string archivo { get; set; }
        public Nullable<int> imagenes { get; set; }
        public string responsable { get; set; }
        public Nullable<int> longitud { get; set; }
        public string ext { get; set; }
        public Nullable<int> id_dependencia_radicacion { get; set; }
        public Nullable<int> origen_int { get; set; }
        public string ruta_imagen { get; set; }
        public string encriptada { get; set; }
        public Nullable<int> consecutivo_borrador { get; set; }
        public Nullable<int> version_borrador { get; set; }
    
        public virtual temporadas temporadas { get; set; }
        public virtual ICollection<interna_dependencias> interna_dependencias { get; set; }
        public virtual ICollection<interna_indices> interna_indices { get; set; }
        public virtual ICollection<seguimiento_tramite_interna> seguimiento_tramite_interna { get; set; }
    }
}
