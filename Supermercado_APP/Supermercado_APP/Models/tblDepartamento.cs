//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supermercado_APP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDepartamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDepartamento()
        {
            this.tblCiudades = new HashSet<tblCiudade>();
        }
    
        public int Dep_Codigo { get; set; }
        public string Dep_Descripcion { get; set; }
        public Nullable<bool> Dep_Activo { get; set; }
        public Nullable<int> Dep_UsuarioCrea { get; set; }
        public Nullable<System.DateTime> Dep_FechaCrea { get; set; }
        public Nullable<int> Dep_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Dep_FechaModifica { get; set; }
    
        public virtual tblUsuario tblUsuario { get; set; }
        public virtual tblUsuario tblUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCiudade> tblCiudades { get; set; }
    }
}
