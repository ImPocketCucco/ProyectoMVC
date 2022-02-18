//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supermercado_APP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProducto
    {
        public tblProducto()
        {
            this.tblCompras = new HashSet<tblCompra>();
            this.tblventadetalles = new HashSet<tblventadetalle>();
        }
    
        public int Prd_Id { get; set; }
        public string Prd_Codigo { get; set; }
        public string Prd_Descripcion { get; set; }
        public Nullable<int> Cat_Id { get; set; }
        public Nullable<int> Pro_Id { get; set; }
        public Nullable<int> Prd_Stock { get; set; }
        public Nullable<decimal> Prd_PrecioCompra { get; set; }
        public Nullable<decimal> Prd_PrecioVenta { get; set; }
        public byte[] Prd_Imagen { get; set; }
        public bool Prd_Estado { get; set; }
        public int Prd_UsuarioCrea { get; set; }
        public System.DateTime Prd_FechaCrea { get; set; }
        public Nullable<int> Prd_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Prd_FechaModifica { get; set; }
    
        public virtual tblUsuario tblUsuario { get; set; }
        public virtual tblUsuario tblUsuario1 { get; set; }
        public virtual tblCategoria tblCategoria { get; set; }
        public virtual ICollection<tblCompra> tblCompras { get; set; }
        public virtual tblProveedore tblProveedore { get; set; }
        public virtual ICollection<tblventadetalle> tblventadetalles { get; set; }
    }
}
