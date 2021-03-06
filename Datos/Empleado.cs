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
    
    public partial class Empleado
    {
        public int idEmpresa { get; set; }
        public int idEmpresaInfFiscal { get; set; }
        public long idEmpleado { get; set; }
        public long idEmpleadoPadre { get; set; }
        public string cusId { get; set; }
        public string numEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public string rfc { get; set; }
        public string curp { get; set; }
        public string genero { get; set; }
        public string email { get; set; }
        public string calle { get; set; }
        public int numExterior { get; set; }
        public Nullable<int> numInterior { get; set; }
        public string colonia { get; set; }
        public string municipioDelegacion { get; set; }
        public string estado { get; set; }
        public int cp { get; set; }
        public string telefono { get; set; }
        public string telefono2 { get; set; }
        public int idPlan { get; set; }
        public int idClub { get; set; }
        public int idTipoPago { get; set; }
        public bool estatus { get; set; }
        public System.DateTime fechaInsert { get; set; }
        public string usuarioInsert { get; set; }
        public Nullable<System.DateTime> fechaUpdate { get; set; }
        public string usuarioUpdate { get; set; }
    
        public virtual CatTipoPago CatTipoPago { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
