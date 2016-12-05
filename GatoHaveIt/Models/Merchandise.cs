namespace GatoHaveIt.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Merchandise")]
    public partial class Merchandise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Merchandise()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public int ItemNumber { get; set; }

        public decimal Price { get; set; }

        [Required]
        [StringLength(300)]
        public string Descrption { get; set; }

        [Required]
        [StringLength(500)]
        public string ImageURL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
