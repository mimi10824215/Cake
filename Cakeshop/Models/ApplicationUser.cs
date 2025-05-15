using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Cakeshop.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Required(ErrorMessage = "姓名為必填")]
        [StringLength(50)]
        [Display(Name = "姓名")]
        public string Name { get; set; } =string.Empty;

        [Required(ErrorMessage = "地址為必填")]
        [StringLength(200)]
        [Display(Name = "地址")]
        public string Address { get; set; }=string.Empty;

        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<ShoppingCartItem>? ShoppingCartItems { get; set; }
    }
}
