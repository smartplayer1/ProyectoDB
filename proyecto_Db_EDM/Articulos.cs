//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyecto_Db_EDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Articulos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Articulos()
        {
            this.BodegaArticulo = new HashSet<BodegaArticulo>();
            this.FacturaLineas = new HashSet<FacturaLineas>();
        }
    
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Medida { get; set; }
        public int Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public int CategoriaId { get; set; }
        public int PresentacionId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BodegaArticulo> BodegaArticulo { get; set; }
        public virtual UnidadMedidad UnidadMedidad { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Presentacion Presentacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaLineas> FacturaLineas { get; set; }
    }
}