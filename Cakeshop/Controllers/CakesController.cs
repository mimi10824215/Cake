using Microsoft.AspNetCore.Mvc;
using Cakeshop.Models;
using Cakeshop.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace Cakeshop.Controllers
{
    public class CakesController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public CakesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var cakes = await _context.Cakes.ToListAsync();
            return View(cakes);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
               
            } 
            var cakes = await _context.Cakes.FirstOrDefaultAsync(m =>m.Id == id);
            if(cakes == null)
            {
                return NotFound();
            }

            ViewBag.Quantify = 1;
            return View(cakes);

        }
    }
}
