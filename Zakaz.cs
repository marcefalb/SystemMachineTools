namespace System_Machine_Tools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zakaz
    {
        [Key]
        public int Id_zakaz { get; set; }

        public int Id_machine { get; set; }

        [Required]
        [StringLength(50)]
        public string Vid_remont { get; set; }

        public int Id_brigada { get; set; }

        public DateTime Date_start { get; set; }

        public DateTime Date_plan { get; set; }

        public DateTime Date_fact { get; set; }

        [Required]
        [StringLength(1)]
        public string Status_zakaza { get; set; }

        public virtual Brigade Brigade { get; set; }

        public virtual Machine Machine { get; set; }

        public virtual Vid_Remont Vid_Remont1 { get; set; }
    }
}
