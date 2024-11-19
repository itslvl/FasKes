using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FasKes.Domain.Entity.R
{
    public class RPendidikan1
    {
         [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //PK
        public ICollection<RPendidikan2> LstRPendidikan2 { get; set; }
    }
}