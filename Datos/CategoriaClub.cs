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
    
    public partial class CategoriaClub
    {
        public int idClub { get; set; }
        public int idFormato { get; set; }
        public int idNivelClub { get; set; }
        public System.DateTime fechaInsert { get; set; }
        public string usuarioInsert { get; set; }
        public Nullable<System.DateTime> fechaUpdate { get; set; }
        public string usuarioUpdate { get; set; }
    
        public virtual CatClub CatClub { get; set; }
        public virtual CatFormato CatFormato { get; set; }
        public virtual CatNivel CatNivel { get; set; }
    }
}
