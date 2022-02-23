﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SupermercadoDBEntities : DbContext
    {
        public SupermercadoDBEntities()
            : base("name=SupermercadoDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblUsuario> tblUsuarios { get; set; }
        public virtual DbSet<tblCategoria> tblCategorias { get; set; }
        public virtual DbSet<tblCompra> tblCompras { get; set; }
        public virtual DbSet<tblProducto> tblProductos { get; set; }
        public virtual DbSet<tblventadetalle> tblventadetalles { get; set; }
        public virtual DbSet<tblVentaEncabezado> tblVentaEncabezadoes { get; set; }
        public virtual DbSet<tblCargo> tblCargos { get; set; }
        public virtual DbSet<tblCargosPersona> tblCargosPersonas { get; set; }
        public virtual DbSet<tblCiudade> tblCiudades { get; set; }
        public virtual DbSet<tblDepartamento> tblDepartamentos { get; set; }
        public virtual DbSet<tblDireccione> tblDirecciones { get; set; }
        public virtual DbSet<tblPersona> tblPersonas { get; set; }
        public virtual DbSet<tblProveedore> tblProveedores { get; set; }
        public virtual DbSet<VW_Usuario> VW_Usuario { get; set; }
        public virtual DbSet<VW_Categorias> VW_Categorias { get; set; }
    
        public virtual ObjectResult<UDP_Inicio_Sesion_Result> UDP_Inicio_Sesion(string usu_UsuarioNombre, string usu_Contrasena)
        {
            var usu_UsuarioNombreParameter = usu_UsuarioNombre != null ?
                new ObjectParameter("Usu_UsuarioNombre", usu_UsuarioNombre) :
                new ObjectParameter("Usu_UsuarioNombre", typeof(string));
    
            var usu_ContrasenaParameter = usu_Contrasena != null ?
                new ObjectParameter("Usu_Contrasena", usu_Contrasena) :
                new ObjectParameter("Usu_Contrasena", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Inicio_Sesion_Result>("UDP_Inicio_Sesion", usu_UsuarioNombreParameter, usu_ContrasenaParameter);
        }
    
        public virtual int UDP_Proveedores_DELETE(Nullable<int> pro_Id, Nullable<int> pro_UsuarioModifica)
        {
            var pro_IdParameter = pro_Id.HasValue ?
                new ObjectParameter("Pro_Id", pro_Id) :
                new ObjectParameter("Pro_Id", typeof(int));
    
            var pro_UsuarioModificaParameter = pro_UsuarioModifica.HasValue ?
                new ObjectParameter("Pro_UsuarioModifica", pro_UsuarioModifica) :
                new ObjectParameter("Pro_UsuarioModifica", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UDP_Proveedores_DELETE", pro_IdParameter, pro_UsuarioModificaParameter);
        }
    
        public virtual int UDP_Proveedores_INSERT(string pro_Empresa, string pro_RepNombreS, string pro_RepPriApellido, string pro_RepSegApellido, Nullable<int> dir_Id, string pro_TelFijo, string pro_TelMovil, string pro_Email, string pro_PaginaWeb, Nullable<int> pro_UsuarioCrea)
        {
            var pro_EmpresaParameter = pro_Empresa != null ?
                new ObjectParameter("Pro_Empresa", pro_Empresa) :
                new ObjectParameter("Pro_Empresa", typeof(string));
    
            var pro_RepNombreSParameter = pro_RepNombreS != null ?
                new ObjectParameter("Pro_RepNombreS", pro_RepNombreS) :
                new ObjectParameter("Pro_RepNombreS", typeof(string));
    
            var pro_RepPriApellidoParameter = pro_RepPriApellido != null ?
                new ObjectParameter("Pro_RepPriApellido", pro_RepPriApellido) :
                new ObjectParameter("Pro_RepPriApellido", typeof(string));
    
            var pro_RepSegApellidoParameter = pro_RepSegApellido != null ?
                new ObjectParameter("Pro_RepSegApellido", pro_RepSegApellido) :
                new ObjectParameter("Pro_RepSegApellido", typeof(string));
    
            var dir_IdParameter = dir_Id.HasValue ?
                new ObjectParameter("Dir_Id", dir_Id) :
                new ObjectParameter("Dir_Id", typeof(int));
    
            var pro_TelFijoParameter = pro_TelFijo != null ?
                new ObjectParameter("Pro_TelFijo", pro_TelFijo) :
                new ObjectParameter("Pro_TelFijo", typeof(string));
    
            var pro_TelMovilParameter = pro_TelMovil != null ?
                new ObjectParameter("Pro_TelMovil", pro_TelMovil) :
                new ObjectParameter("Pro_TelMovil", typeof(string));
    
            var pro_EmailParameter = pro_Email != null ?
                new ObjectParameter("Pro_Email", pro_Email) :
                new ObjectParameter("Pro_Email", typeof(string));
    
            var pro_PaginaWebParameter = pro_PaginaWeb != null ?
                new ObjectParameter("Pro_PaginaWeb", pro_PaginaWeb) :
                new ObjectParameter("Pro_PaginaWeb", typeof(string));
    
            var pro_UsuarioCreaParameter = pro_UsuarioCrea.HasValue ?
                new ObjectParameter("Pro_UsuarioCrea", pro_UsuarioCrea) :
                new ObjectParameter("Pro_UsuarioCrea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UDP_Proveedores_INSERT", pro_EmpresaParameter, pro_RepNombreSParameter, pro_RepPriApellidoParameter, pro_RepSegApellidoParameter, dir_IdParameter, pro_TelFijoParameter, pro_TelMovilParameter, pro_EmailParameter, pro_PaginaWebParameter, pro_UsuarioCreaParameter);
        }
    
        public virtual int UDP_Proveedores_UPDATE(Nullable<int> pro_Id, string pro_Empresa, string pro_RepNombreS, string pro_RepPriApellido, string pro_RepSegApellido, Nullable<int> dir_Id, string pro_TelFijo, string pro_TelMovil, string pro_Email, string pro_PaginaWeb, Nullable<int> pro_UsuarioModifica)
        {
            var pro_IdParameter = pro_Id.HasValue ?
                new ObjectParameter("Pro_Id", pro_Id) :
                new ObjectParameter("Pro_Id", typeof(int));
    
            var pro_EmpresaParameter = pro_Empresa != null ?
                new ObjectParameter("Pro_Empresa", pro_Empresa) :
                new ObjectParameter("Pro_Empresa", typeof(string));
    
            var pro_RepNombreSParameter = pro_RepNombreS != null ?
                new ObjectParameter("Pro_RepNombreS", pro_RepNombreS) :
                new ObjectParameter("Pro_RepNombreS", typeof(string));
    
            var pro_RepPriApellidoParameter = pro_RepPriApellido != null ?
                new ObjectParameter("Pro_RepPriApellido", pro_RepPriApellido) :
                new ObjectParameter("Pro_RepPriApellido", typeof(string));
    
            var pro_RepSegApellidoParameter = pro_RepSegApellido != null ?
                new ObjectParameter("Pro_RepSegApellido", pro_RepSegApellido) :
                new ObjectParameter("Pro_RepSegApellido", typeof(string));
    
            var dir_IdParameter = dir_Id.HasValue ?
                new ObjectParameter("Dir_Id", dir_Id) :
                new ObjectParameter("Dir_Id", typeof(int));
    
            var pro_TelFijoParameter = pro_TelFijo != null ?
                new ObjectParameter("Pro_TelFijo", pro_TelFijo) :
                new ObjectParameter("Pro_TelFijo", typeof(string));
    
            var pro_TelMovilParameter = pro_TelMovil != null ?
                new ObjectParameter("Pro_TelMovil", pro_TelMovil) :
                new ObjectParameter("Pro_TelMovil", typeof(string));
    
            var pro_EmailParameter = pro_Email != null ?
                new ObjectParameter("Pro_Email", pro_Email) :
                new ObjectParameter("Pro_Email", typeof(string));
    
            var pro_PaginaWebParameter = pro_PaginaWeb != null ?
                new ObjectParameter("Pro_PaginaWeb", pro_PaginaWeb) :
                new ObjectParameter("Pro_PaginaWeb", typeof(string));
    
            var pro_UsuarioModificaParameter = pro_UsuarioModifica.HasValue ?
                new ObjectParameter("Pro_UsuarioModifica", pro_UsuarioModifica) :
                new ObjectParameter("Pro_UsuarioModifica", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UDP_Proveedores_UPDATE", pro_IdParameter, pro_EmpresaParameter, pro_RepNombreSParameter, pro_RepPriApellidoParameter, pro_RepSegApellidoParameter, dir_IdParameter, pro_TelFijoParameter, pro_TelMovilParameter, pro_EmailParameter, pro_PaginaWebParameter, pro_UsuarioModificaParameter);
        }
    
        public virtual int UDP_tblPersonas_Delete(Nullable<int> per_Id, Nullable<int> per_UsuarioModifica)
        {
            var per_IdParameter = per_Id.HasValue ?
                new ObjectParameter("Per_Id", per_Id) :
                new ObjectParameter("Per_Id", typeof(int));
    
            var per_UsuarioModificaParameter = per_UsuarioModifica.HasValue ?
                new ObjectParameter("Per_UsuarioModifica", per_UsuarioModifica) :
                new ObjectParameter("Per_UsuarioModifica", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UDP_tblPersonas_Delete", per_IdParameter, per_UsuarioModificaParameter);
        }
    
        public virtual int UDP_tblPersonas_Insert(string per_Identidad, string per_Rtn, string per_Nombres, string per_PrimerApellido, string per_SegundoApellido, string per_Sexo, Nullable<int> dir_Id, string per_Telefono, string per_Correo, Nullable<int> per_UsuarioCrea)
        {
            var per_IdentidadParameter = per_Identidad != null ?
                new ObjectParameter("Per_Identidad", per_Identidad) :
                new ObjectParameter("Per_Identidad", typeof(string));
    
            var per_RtnParameter = per_Rtn != null ?
                new ObjectParameter("Per_Rtn", per_Rtn) :
                new ObjectParameter("Per_Rtn", typeof(string));
    
            var per_NombresParameter = per_Nombres != null ?
                new ObjectParameter("Per_Nombres", per_Nombres) :
                new ObjectParameter("Per_Nombres", typeof(string));
    
            var per_PrimerApellidoParameter = per_PrimerApellido != null ?
                new ObjectParameter("Per_PrimerApellido", per_PrimerApellido) :
                new ObjectParameter("Per_PrimerApellido", typeof(string));
    
            var per_SegundoApellidoParameter = per_SegundoApellido != null ?
                new ObjectParameter("Per_SegundoApellido", per_SegundoApellido) :
                new ObjectParameter("Per_SegundoApellido", typeof(string));
    
            var per_SexoParameter = per_Sexo != null ?
                new ObjectParameter("Per_Sexo", per_Sexo) :
                new ObjectParameter("Per_Sexo", typeof(string));
    
            var dir_IdParameter = dir_Id.HasValue ?
                new ObjectParameter("Dir_Id", dir_Id) :
                new ObjectParameter("Dir_Id", typeof(int));
    
            var per_TelefonoParameter = per_Telefono != null ?
                new ObjectParameter("Per_Telefono", per_Telefono) :
                new ObjectParameter("Per_Telefono", typeof(string));
    
            var per_CorreoParameter = per_Correo != null ?
                new ObjectParameter("Per_Correo", per_Correo) :
                new ObjectParameter("Per_Correo", typeof(string));
    
            var per_UsuarioCreaParameter = per_UsuarioCrea.HasValue ?
                new ObjectParameter("Per_UsuarioCrea", per_UsuarioCrea) :
                new ObjectParameter("Per_UsuarioCrea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UDP_tblPersonas_Insert", per_IdentidadParameter, per_RtnParameter, per_NombresParameter, per_PrimerApellidoParameter, per_SegundoApellidoParameter, per_SexoParameter, dir_IdParameter, per_TelefonoParameter, per_CorreoParameter, per_UsuarioCreaParameter);
        }
    
        public virtual int UDP_tblPersonas_Update(Nullable<int> per_Id, string per_Identidad, string per_Rtn, string per_Nombres, string per_PrimerApellido, string per_SegundoApellido, string per_Sexo, Nullable<int> dir_Id, string per_Telefono, string per_Correo, Nullable<int> per_UsuarioModifica)
        {
            var per_IdParameter = per_Id.HasValue ?
                new ObjectParameter("Per_Id", per_Id) :
                new ObjectParameter("Per_Id", typeof(int));
    
            var per_IdentidadParameter = per_Identidad != null ?
                new ObjectParameter("Per_Identidad", per_Identidad) :
                new ObjectParameter("Per_Identidad", typeof(string));
    
            var per_RtnParameter = per_Rtn != null ?
                new ObjectParameter("Per_Rtn", per_Rtn) :
                new ObjectParameter("Per_Rtn", typeof(string));
    
            var per_NombresParameter = per_Nombres != null ?
                new ObjectParameter("Per_Nombres", per_Nombres) :
                new ObjectParameter("Per_Nombres", typeof(string));
    
            var per_PrimerApellidoParameter = per_PrimerApellido != null ?
                new ObjectParameter("Per_PrimerApellido", per_PrimerApellido) :
                new ObjectParameter("Per_PrimerApellido", typeof(string));
    
            var per_SegundoApellidoParameter = per_SegundoApellido != null ?
                new ObjectParameter("Per_SegundoApellido", per_SegundoApellido) :
                new ObjectParameter("Per_SegundoApellido", typeof(string));
    
            var per_SexoParameter = per_Sexo != null ?
                new ObjectParameter("Per_Sexo", per_Sexo) :
                new ObjectParameter("Per_Sexo", typeof(string));
    
            var dir_IdParameter = dir_Id.HasValue ?
                new ObjectParameter("Dir_Id", dir_Id) :
                new ObjectParameter("Dir_Id", typeof(int));
    
            var per_TelefonoParameter = per_Telefono != null ?
                new ObjectParameter("Per_Telefono", per_Telefono) :
                new ObjectParameter("Per_Telefono", typeof(string));
    
            var per_CorreoParameter = per_Correo != null ?
                new ObjectParameter("Per_Correo", per_Correo) :
                new ObjectParameter("Per_Correo", typeof(string));
    
            var per_UsuarioModificaParameter = per_UsuarioModifica.HasValue ?
                new ObjectParameter("Per_UsuarioModifica", per_UsuarioModifica) :
                new ObjectParameter("Per_UsuarioModifica", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UDP_tblPersonas_Update", per_IdParameter, per_IdentidadParameter, per_RtnParameter, per_NombresParameter, per_PrimerApellidoParameter, per_SegundoApellidoParameter, per_SexoParameter, dir_IdParameter, per_TelefonoParameter, per_CorreoParameter, per_UsuarioModificaParameter);
        }
    
        public virtual int UDP_Venta_INSERT(Nullable<int> ventEnc_NumFactura, Nullable<System.DateTime> ventEnc_Fecha, Nullable<decimal> ventEnc_Total, Nullable<int> ven_UsuarioCrea, Nullable<int> prd_Id, Nullable<decimal> ventDet_Precio, Nullable<int> ventDet_Cantidad, Nullable<decimal> ventDet_Descuento, string ventDet_Impuesto, Nullable<int> cont)
        {
            var ventEnc_NumFacturaParameter = ventEnc_NumFactura.HasValue ?
                new ObjectParameter("VentEnc_NumFactura", ventEnc_NumFactura) :
                new ObjectParameter("VentEnc_NumFactura", typeof(int));
    
            var ventEnc_FechaParameter = ventEnc_Fecha.HasValue ?
                new ObjectParameter("VentEnc_Fecha", ventEnc_Fecha) :
                new ObjectParameter("VentEnc_Fecha", typeof(System.DateTime));
    
            var ventEnc_TotalParameter = ventEnc_Total.HasValue ?
                new ObjectParameter("VentEnc_Total", ventEnc_Total) :
                new ObjectParameter("VentEnc_Total", typeof(decimal));
    
            var ven_UsuarioCreaParameter = ven_UsuarioCrea.HasValue ?
                new ObjectParameter("Ven_UsuarioCrea", ven_UsuarioCrea) :
                new ObjectParameter("Ven_UsuarioCrea", typeof(int));
    
            var prd_IdParameter = prd_Id.HasValue ?
                new ObjectParameter("Prd_Id", prd_Id) :
                new ObjectParameter("Prd_Id", typeof(int));
    
            var ventDet_PrecioParameter = ventDet_Precio.HasValue ?
                new ObjectParameter("VentDet_Precio", ventDet_Precio) :
                new ObjectParameter("VentDet_Precio", typeof(decimal));
    
            var ventDet_CantidadParameter = ventDet_Cantidad.HasValue ?
                new ObjectParameter("VentDet_Cantidad", ventDet_Cantidad) :
                new ObjectParameter("VentDet_Cantidad", typeof(int));
    
            var ventDet_DescuentoParameter = ventDet_Descuento.HasValue ?
                new ObjectParameter("VentDet_Descuento", ventDet_Descuento) :
                new ObjectParameter("VentDet_Descuento", typeof(decimal));
    
            var ventDet_ImpuestoParameter = ventDet_Impuesto != null ?
                new ObjectParameter("VentDet_Impuesto", ventDet_Impuesto) :
                new ObjectParameter("VentDet_Impuesto", typeof(string));
    
            var contParameter = cont.HasValue ?
                new ObjectParameter("cont", cont) :
                new ObjectParameter("cont", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UDP_Venta_INSERT", ventEnc_NumFacturaParameter, ventEnc_FechaParameter, ventEnc_TotalParameter, ven_UsuarioCreaParameter, prd_IdParameter, ventDet_PrecioParameter, ventDet_CantidadParameter, ventDet_DescuentoParameter, ventDet_ImpuestoParameter, contParameter);
        }
    
        public virtual int UDP_Usuario_INSERT(string usu_UsuarioNombre, string usu_Contrasena, Nullable<bool> usu_EsAdmin, Nullable<int> usu_UsuarioCrea)
        {
            var usu_UsuarioNombreParameter = usu_UsuarioNombre != null ?
                new ObjectParameter("Usu_UsuarioNombre", usu_UsuarioNombre) :
                new ObjectParameter("Usu_UsuarioNombre", typeof(string));
    
            var usu_ContrasenaParameter = usu_Contrasena != null ?
                new ObjectParameter("Usu_Contrasena", usu_Contrasena) :
                new ObjectParameter("Usu_Contrasena", typeof(string));
    
            var usu_EsAdminParameter = usu_EsAdmin.HasValue ?
                new ObjectParameter("Usu_EsAdmin", usu_EsAdmin) :
                new ObjectParameter("Usu_EsAdmin", typeof(bool));
    
            var usu_UsuarioCreaParameter = usu_UsuarioCrea.HasValue ?
                new ObjectParameter("Usu_UsuarioCrea", usu_UsuarioCrea) :
                new ObjectParameter("Usu_UsuarioCrea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UDP_Usuario_INSERT", usu_UsuarioNombreParameter, usu_ContrasenaParameter, usu_EsAdminParameter, usu_UsuarioCreaParameter);
        }
    
        public virtual int UDP_Usuario_UPDATE(Nullable<int> usu_Id, string usu_UsuarioNombre, string usu_Contrasena, Nullable<bool> usu_EsAdmin, Nullable<int> usu_UsuarioModifica)
        {
            var usu_IdParameter = usu_Id.HasValue ?
                new ObjectParameter("Usu_Id", usu_Id) :
                new ObjectParameter("Usu_Id", typeof(int));
    
            var usu_UsuarioNombreParameter = usu_UsuarioNombre != null ?
                new ObjectParameter("Usu_UsuarioNombre", usu_UsuarioNombre) :
                new ObjectParameter("Usu_UsuarioNombre", typeof(string));
    
            var usu_ContrasenaParameter = usu_Contrasena != null ?
                new ObjectParameter("Usu_Contrasena", usu_Contrasena) :
                new ObjectParameter("Usu_Contrasena", typeof(string));
    
            var usu_EsAdminParameter = usu_EsAdmin.HasValue ?
                new ObjectParameter("Usu_EsAdmin", usu_EsAdmin) :
                new ObjectParameter("Usu_EsAdmin", typeof(bool));
    
            var usu_UsuarioModificaParameter = usu_UsuarioModifica.HasValue ?
                new ObjectParameter("Usu_UsuarioModifica", usu_UsuarioModifica) :
                new ObjectParameter("Usu_UsuarioModifica", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UDP_Usuario_UPDATE", usu_IdParameter, usu_UsuarioNombreParameter, usu_ContrasenaParameter, usu_EsAdminParameter, usu_UsuarioModificaParameter);
        }
    
        public virtual int UDP_Usuario_DELETE(Nullable<int> usu_Id, Nullable<int> usu_UsuarioModifica)
        {
            var usu_IdParameter = usu_Id.HasValue ?
                new ObjectParameter("Usu_Id", usu_Id) :
                new ObjectParameter("Usu_Id", typeof(int));
    
            var usu_UsuarioModificaParameter = usu_UsuarioModifica.HasValue ?
                new ObjectParameter("Usu_UsuarioModifica", usu_UsuarioModifica) :
                new ObjectParameter("Usu_UsuarioModifica", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UDP_Usuario_DELETE", usu_IdParameter, usu_UsuarioModificaParameter);
        }
    
        public virtual int UDP_Categoria_DELETE(Nullable<int> cat_Id, Nullable<int> cat_UsuarioModifica)
        {
            var cat_IdParameter = cat_Id.HasValue ?
                new ObjectParameter("Cat_Id", cat_Id) :
                new ObjectParameter("Cat_Id", typeof(int));
    
            var cat_UsuarioModificaParameter = cat_UsuarioModifica.HasValue ?
                new ObjectParameter("Cat_UsuarioModifica", cat_UsuarioModifica) :
                new ObjectParameter("Cat_UsuarioModifica", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UDP_Categoria_DELETE", cat_IdParameter, cat_UsuarioModificaParameter);
        }
    
        public virtual int UDP_Categoria_INSERT(string cat_Descripcion, Nullable<int> cat_UsuarioCrea)
        {
            var cat_DescripcionParameter = cat_Descripcion != null ?
                new ObjectParameter("Cat_Descripcion", cat_Descripcion) :
                new ObjectParameter("Cat_Descripcion", typeof(string));
    
            var cat_UsuarioCreaParameter = cat_UsuarioCrea.HasValue ?
                new ObjectParameter("Cat_UsuarioCrea", cat_UsuarioCrea) :
                new ObjectParameter("Cat_UsuarioCrea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UDP_Categoria_INSERT", cat_DescripcionParameter, cat_UsuarioCreaParameter);
        }
    
        public virtual int UDP_Categoria_UPDATE(Nullable<int> cat_Id, string cat_Descripcion, Nullable<int> cat_UsuarioModifica)
        {
            var cat_IdParameter = cat_Id.HasValue ?
                new ObjectParameter("Cat_Id", cat_Id) :
                new ObjectParameter("Cat_Id", typeof(int));
    
            var cat_DescripcionParameter = cat_Descripcion != null ?
                new ObjectParameter("Cat_Descripcion", cat_Descripcion) :
                new ObjectParameter("Cat_Descripcion", typeof(string));
    
            var cat_UsuarioModificaParameter = cat_UsuarioModifica.HasValue ?
                new ObjectParameter("Cat_UsuarioModifica", cat_UsuarioModifica) :
                new ObjectParameter("Cat_UsuarioModifica", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UDP_Categoria_UPDATE", cat_IdParameter, cat_DescripcionParameter, cat_UsuarioModificaParameter);
        }
    }
}
