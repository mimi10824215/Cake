using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cakeshop.Models
{
    public class Cake
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="蛋糕名稱為必填")]
        [StringLength(100)]
        [Display(Name ="蛋糕名稱")]
        public string Name { get; set; } =string.Empty;
        
        [Display(Name = "描述")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "價格為必填")]
        [Display(Name = "價格")]
        [Range(0.01,10000.00,ErrorMessage ="價格必須介於0.01和10000之間")]
        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; }

        [Display(Name = "圖片路徑")]
        public string? ImageUrl { get; set; }

    }
}
