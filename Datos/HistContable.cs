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
    
    public partial class HistContable
    {
        public long idHistContable { get; set; }
        public int idEmpresa { get; set; }
        public int idEmpresaInfFiscal { get; set; }
        public string cusId { get; set; }
        public int idClub { get; set; }
        public int idPlan { get; set; }
        public int idFormato { get; set; }
        public int idNivel { get; set; }
        public int idTipoPago { get; set; }
        public string periodo { get; set; }
        public decimal ivaRetencion { get; set; }
        public decimal importeCIAsinIva { get; set; }
        public decimal ivaCIA { get; set; }
        public decimal importeCIA { get; set; }
        public decimal retencionSinIva { get; set; }
        public decimal importeRetencion { get; set; }
        public decimal importeEmpSinIva { get; set; }
        public decimal ivaEmpleado { get; set; }
        public decimal importeEmpleado { get; set; }
        public decimal importeTotal { get; set; }
        public System.DateTime fechaInsert { get; set; }
        public string usuarioInsert { get; set; }
        public Nullable<System.DateTime> fechaUpdate { get; set; }
        public string usuarioUpdate { get; set; }
    }
}
