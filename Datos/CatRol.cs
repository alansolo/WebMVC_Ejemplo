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
    
    public partial class CatRol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatRol()
        {
            this.Login = new HashSet<Login>();
            this.RolPantalla = new HashSet<RolPantalla>();
        }
    
        public int idRol { get; set; }
        public string rol { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fechaInsert { get; set; }
        public string usuarioInsert { get; set; }
        public Nullable<System.DateTime> fechaUpdate { get; set; }
        public string usuarioUpdate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Login> Login { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolPantalla> RolPantalla { get; set; }
    }
}
