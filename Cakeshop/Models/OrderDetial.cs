using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cakeshop.Models
{
    public class OrderDetial
    {
        public int Id { get; set; }

       
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]

        public virtual Order? Order { get; set; }
        public int CakeId { get; set; }

        public virtual Cake? Cake { get; set; }

        [Required]
        [Display(Name = "數量")]
        [Range(1, 100)]
        public int Quantity { get; set; }


        [Required]
        [Display(Name ="單價(當時)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
