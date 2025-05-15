using Cakeshop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Cakeshop.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Cakes.Any())
            {
                return;
            }

            var cakes = new Cake[]
            {
                new Cake { Name = "經典巧克力蛋糕", Description = "濃郁滑順的黑巧克力甘納許", Price = 550.00m, ImageUrl = "/images/Food1.jpg" },
                new Cake { Name = "草莓奶油蛋糕", Description = "清爽草莓搭配香濃奶油，口感清新", Price = 520.00m, ImageUrl = "/images/Food2.jpg" },
                new Cake { Name = "藍莓乳酪蛋糕", Description = "濃郁乳酪中透出藍莓果香", Price = 530.00m, ImageUrl = "/images/Food3.jpg" },
                new Cake { Name = "抹茶紅豆蛋糕", Description = "日式抹茶融合綿密紅豆，甘甜不膩", Price = 560.00m, ImageUrl = "/images/Food4.png" },
                new Cake { Name = "香草生乳蛋糕", Description = "入口即化的香草生乳，綿密順口", Price = 500.00m, ImageUrl = "/images/Food5.jpg" }
            };

            foreach (Cake c in cakes)
            {
                context.Cakes.Add(c);
            }
            context.SaveChanges();

        }
    }
}
