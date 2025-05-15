using Cakeshop.Data;
using Cakeshop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
namespace Cakeshop.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
       
       private readonly ApplicationDbContext _context;
       private readonly UserManager<ApplicationUser> _userManager;


        public OrdersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
                _context = context;
                _userManager = userManager;
        }
        private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "";
        public async Task<IActionResult>Checkout()
        {
            var userId =GetUserId();
            if (string.IsNullOrEmpty(userId)) return Challenge();
            var user = await _userManager.GetUserAsync(User); // Qƒƒ^ƒ£####
            if (user == null) return NotFound("");
            var cartItems = await _context.ShoppingCartItems
                            .Where(c => c.UserId ==userId)
                            .Include(c=>c.Cake)
                            .ToListAsync();
            if (!cartItems.Any())
            {
                TempData["ErrorMessage"] = "KNIVIZAN · ĦÆ • ";
                return RedirectToAction("Index", "ShoppingCart");
            }
            // 計算總金額
            decimal total = cartItems.Sum(item => (item.Cake?.Price ?? 0) * item.Quantity);
            // 建立一個 ViewModel 來傳遞預設的訂單資訊
            var checkoutViewModel = new CheckoutViewModel
            {
                RecipientName = user.Name,
                ShippingAddress = user.Address,
                RecipientPhone = user.PhoneNumber ?? "",
                CartItems = cartItems,
                TotalAmount = total
            };

            return View(checkoutViewModel);
        }


        public IActionResult Index()
        {
            return View();
        }

    }
    public class CheckoutViewModel
    {
        [Required(ErrorMessage = "收件人姓名為必填項")]
        [StringLength(50)]
        [Display(Name = "收件人姓名")]
        public string RecipientName { get; set; } = string.Empty;

        [Required(ErrorMessage = "收貨地址為必填項")]
        [StringLength(200)]
        [Display(Name = "收貨地址")]
        public string ShippingAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "聯絡電話為必填項")]
        [Phone(ErrorMessage = "請輸入有效的電話號碼")]
        [Display(Name = "聯絡電話")]
        public string RecipientPhone { get; set; } = string.Empty;

        // 顯示用，不需要 Post 回來
        public IEnumerable<ShoppingCartItem> CartItems { get; set; } = new List<ShoppingCartItem>();
        public decimal TotalAmount { get; set; }
    }
}

