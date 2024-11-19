using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FasKes.Domain.Entity.R
{
    public class RPendidikan3
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string UrutReporting { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //FK
        public int KodePendidikan2 { get; set; }
        public virtual RPendidikan2 RPendidikan2 { get; set; }

        //PK
    }
}