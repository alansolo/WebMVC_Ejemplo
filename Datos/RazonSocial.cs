//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class RazonSocial
    {
        public int idEmpresa { get; set; }
        public int idRazonSocial { get; set; }
        public string razonSocial1 { get; set; }
        public string rfc { get; set; }
        public string calle { get; set; }
        public string numeroExt { get; set; }
        public string numeroInt { get; set; }
        public string colonia { get; set; }
        public string municipioDelegacion { get; set; }
        public string estado { get; set; }
        public string cp { get; set; }
        public System.DateTime vigenciaInicio { get; set; }
        public System.DateTime vigenciaFinal { get; set; }
        public bool estatus { get; set; }
        public System.DateTime fechaInsert { get; set; }
        public string usuarioInsert { get; set; }
        public Nullable<System.DateTime> fechaUpdate { get; set; }
        public string usuarioupdate { get; set; }
    
        public virtual Empresa Empresa { get; set; }
    }
}
