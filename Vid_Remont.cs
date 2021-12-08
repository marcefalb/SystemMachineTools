namespace System_Machine_Tools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vid_Remont
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vid_Remont()
        {
            Zakazs = new HashSet<Zakaz>();
        }

        [Key]
        [Column("Vid_remont")]
        [StringLength(50)]
        public string Vid_remont1 { get; set; }

        public decimal Machine_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zakaz> Zakazs { get; set; }
    }
}
