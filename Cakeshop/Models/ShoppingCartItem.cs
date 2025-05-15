using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cakeshop.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }

        public int CakeId {  get; set; }
        [ForeignKey("CakeId")]
        public virtual Cake? Cake { get; set; }

        
        [Display(Name = "數量")]
        [Range(1,100, ErrorMessage = "價格必須介於1和100之間")]
        public int Quantity { get; set; }

        public string? UserId {  get; set; }
        [ForeignKey("UserId")]

        public virtual ApplicationUser? User { get; set; }
    }
}
