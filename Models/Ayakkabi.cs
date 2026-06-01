using System.ComponentModel.DataAnnotations;

namespace NikeDb.Models
{
    public class Ayakkabi
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı zorunludur")]
        [StringLength(100)]
        public string Isim { get; set; }

        [Required(ErrorMessage = "Fiyat zorunludur")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Fiyat pozitif olmalıdır")]
        public decimal Fiyat { get; set; }

        [Required(ErrorMessage = "Kategori zorunludur")]
        [StringLength(50)]
        public string Kategori { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        [StringLength(500)]
        public string ResimUrl { get; set; }
    }
}
