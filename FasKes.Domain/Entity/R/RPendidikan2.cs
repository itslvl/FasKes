using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FasKes.Domain.Entity.R
{
    public class RPendidikan2
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //FK
        public int KodePendidikan1 { get; set; }
        public virtual RPendidikan1 RPendidikan1 { get; set; }

        //PK
        public ICollection<RPendidikan3> LstRPendidikan3 { get; set; }
    }
}