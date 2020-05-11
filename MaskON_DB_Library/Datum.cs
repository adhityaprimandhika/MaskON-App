namespace MaskON_DB_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Data")]
    public partial class Datum
    {
        public int Id { get; set; }

        public int N95 { get; set; }

        public int Surgery { get; set; }

        [Required]
        [StringLength(100)]
        public string Lokasi { get; set; }
    }
}
