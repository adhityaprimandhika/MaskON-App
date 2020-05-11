namespace MaskON_DB_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Nama { get; set; }

        [Required]
        [StringLength(30)]
        public string NIK { get; set; }

        [Required]
        [StringLength(30)]
        public string NoTelp { get; set; }

        [Required]
        [StringLength(100)]
        public string Lokasi { get; set; }

        [Required]
        [StringLength(50)]
        public string Gender { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipe { get; set; }
    }
}
