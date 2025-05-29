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

            var cakes = new Cake[] {
 
            new Cake { Name = "經典牛肉漢堡", Description = "多汁牛肉搭配新鮮蔬菜與特製醬料", Price = 120.00m, ImageUrl = "/images/Beef Burger.jpg" },
            new Cake { Name = "起司牛肉堡", Description = "經典漢堡搭配濃郁起司", Price = 120.00m, ImageUrl = "/images/Cheeseburger.png" },
            new Cake { Name = "培根起司牛肉堡", Description = "培根、起司與牛肉的完美結合", Price = 130.00m, ImageUrl = "/images/Bacon Cheeseburger.jpg" },
            new Cake { Name = "雙層牛肉堡", Description = "雙層牛肉滿足你的飢餓感", Price = 120.00m, ImageUrl = "/images/Double Cheeseburger.jpg" },
            new Cake { Name = "香辣雞肉三明治", Description = "香辣雞肉搭配爽口生菜", Price = 110.00m, ImageUrl = "/images/Spicy Chicken Sandwich.jpg" },
            new Cake { Name = "烤雞三明治", Description = "健康烤雞與新鮮麵包的完美搭配", Price = 110.00m, ImageUrl = "/images/Grilled chicken Sandwich.jpg" },
            new Cake { Name = "俱樂部三明治", Description = "層層堆疊的經典三明治", Price = 110.00m, ImageUrl = "/images/Club Sandwich.jpg" },
            new Cake { Name = "費城牛肉起司三明治", Description = "香煎牛肉配上濃郁起司", Price = 110.00m, ImageUrl = "/images/Philly Cheesesteak Sandwich.jpg" },
            new Cake { Name = "熱狗", Description = "經典熱狗配上香軟麵包", Price = 50.00m, ImageUrl = "/images/hot dog.jpg" },
            new Cake { Name = "起司熱狗", Description = "濃郁起司加持的熱狗", Price = 50.00m, ImageUrl = "/images/cheese hot dog.jpg" },
            new Cake { Name = "辣椒熱狗", Description = "加入辣椒醬的經典熱狗", Price = 50.00m, ImageUrl = "/images/Chili Dog.jpg" },
            new Cake { Name = "美式BBQ烤肋排", Description = "經典美式風味BBQ醬肋排", Price = 150.00m, ImageUrl = "/images/American BBQ Ribs.jpg" },
            new Cake { Name = "炸雞", Description = "外酥內嫩的美味炸雞", Price = 50.00m, ImageUrl = "/images/Fried Chicken.jpg" },
            new Cake { Name = "雞塊", Description = "酥脆多汁的雞塊", Price = 50.00m, ImageUrl = "/images/Nuggets.png" },
            new Cake { Name = "炸魚薯條", Description = "經典英式魚排搭配薯條", Price = 50.00m, ImageUrl = "/images/fish_chips.png" },
            new Cake { Name = "美式鬆餅 (藍莓)", Description = "藍莓風味鬆餅，甜蜜滿分", Price = 50.00m, ImageUrl = "/images/American Pancakes (Blueberry).jpg" },
            new Cake { Name = "美式鬆餅 (草莓)", Description = "草莓果醬與鮮奶油搭配鬆餅", Price = 50.00m, ImageUrl = "/images/American Pancakes (Strawberry).jpg" },
            new Cake { Name = "法式吐司", Description = "金黃酥香，甜而不膩", Price = 50.00m, ImageUrl = "/images/French Toast.jpg" },
            new Cake { Name = "冰美式咖啡", Description = "清爽無糖美式冰咖啡", Price = 50.00m, ImageUrl = "/images/American Coffee.jpg" },
            new Cake { Name = "義式肉醬麵", Description = "濃郁番茄牛肉醬拌義大利麵", Price = 150.00m, ImageUrl = "/images/Spaghetti Bolognese.jpg" },
            new Cake { Name = "奶油培根義大利麵", Description = "香濃奶油醬配上脆口培根", Price = 150.00m, ImageUrl = "/images/Spaghetti Carbonara.jpg" },
            new Cake { Name = "青醬義大利麵", Description = "新鮮羅勒青醬拌麵", Price = 150.00m, ImageUrl = "/images/Pesto Spaghetti.jpg" },
            new Cake { Name = "白醬義大利麵 (雞肉)", Description = "香滑白醬配嫩雞肉", Price = 150.00m, ImageUrl = "/images/Fettuccine Alfredo (Chicken).jpg" },
            new Cake { Name = "海鮮義大利麵", Description = "海味十足的義大利麵", Price = 150.00m, ImageUrl = "/images/Seafood Spaghetti.jpg" },
            new Cake { Name = "瑪格麗特披薩", Description = "經典番茄與起司披薩", Price = 220.00m, ImageUrl = "/images/Margherita Pizza.jpg" },
            new Cake { Name = "義大利臘腸披薩", Description = "辛香臘腸與濃起司組合", Price = 220.00m, ImageUrl = "/images/Pepperoni Pizza.jpg" },
            new Cake { Name = "夏威夷披薩", Description = "鳳梨與火腿的熱帶風味", Price = 220.00m, ImageUrl = "/images/Hawaiian Pizza.jpg" },
            new Cake { Name = "總匯披薩", Description = "多種配料一次滿足", Price = 220.00m, ImageUrl = "/images/Supreme Pizza.jpg" },
            new Cake { Name = "素食披薩", Description = "滿滿蔬菜的健康選擇", Price = 220.00m, ImageUrl = "/images/Vegetarian Pizza.jpg" },
            new Cake { Name = "義式餃子 (瑞可達起司菠菜)", Description = "內餡濃郁起司與菠菜", Price = 100.00m, ImageUrl = "/images/Ravioli (Ricotta and Spinach).jpg" },
            new Cake { Name = "義式餃子 (牛肉)", Description = "香嫩牛肉餡餃", Price = 100.00m, ImageUrl = "/images/Ravioli (Beef).jpg" },
            new Cake { Name = "義式燉飯 (蘑菇)", Description = "滑順米飯佐香菇風味", Price = 100.00m, ImageUrl = "/images/Mushroom Risotto.jpg" },
            new Cake { Name = "海鮮燉飯", Description = "多種海鮮燉煮入味", Price = 100.00m, ImageUrl = "/images/Seafood Risotto.jpg" },
            new Cake { Name = "卡布里沙拉", Description = "番茄、起司與羅勒的經典組合", Price = 100.00m, ImageUrl = "/images/Caprese Salad.jpg" },
            new Cake { Name = "提拉米蘇", Description = "香甜滑順的經典甜點", Price = 50.00m, ImageUrl = "/images/Tiramisu.jpg" },
            new Cake { Name = "義式奶酪", Description = "口感細緻的奶酪甜點", Price = 50.00m, ImageUrl = "/images/Panna Cotta.jpg" },
            new Cake { Name = "義式冰淇淋 (Gelato)", Description = "濃郁香甜的義式冰淇淋", Price = 50.00m, ImageUrl = "/images/Italian Ice Cream (Gelato).jpg" },
            new Cake { Name = "美式起司薯條", Description = "熱騰騰起司融化於薯條上", Price = 50.00m, ImageUrl = "/images/American Cheese Fries.jpg" },
            new Cake { Name = "蒜香麵包", Description = "酥脆濃郁的蒜味麵包", Price = 50.00m, ImageUrl = "/images/Garlic Bread.jpg" },
            new Cake { Name = "洋蔥圈", Description = "外酥內嫩的經典點心", Price = 50.00m, ImageUrl = "/images/onion_rings.png" },
            new Cake { Name = "凱薩沙拉", Description = "經典凱薩醬配生菜與麵包丁", Price = 50.00m, ImageUrl = "/images/Caesar Salad.jpg" },
            new Cake { Name = "義式蔬菜湯", Description = "溫暖的蔬菜清湯", Price = 50.00m, ImageUrl = "/images/Minestrone Soup.jpg" },
            new Cake { Name = "番茄濃湯", Description = "濃郁酸甜番茄湯", Price = 50.00m, ImageUrl = "/images/Tomato Soup.jpg" },
            new Cake { Name = "玉米濃湯", Description = "香甜濃郁的玉米湯", Price = 50.00m, ImageUrl = "/images/SOUP.jpg" },
            new Cake { Name = "可口可樂", Description = "經典氣泡飲品", Price = 30.00m, ImageUrl = "/images/Coca Cola.png" },
            new Cake { Name = "冰紅茶", Description = "清涼爽口的紅茶飲品", Price = 30.00m, ImageUrl = "/images/Iced Black Tea.jpg" },
            new Cake { Name = "拿鐵咖啡", Description = "奶香濃郁的義式拿鐵", Price = 40.00m, ImageUrl = "/images/Latte.jpg" },
            new Cake { Name = "卡布奇諾", Description = "綿密奶泡與濃縮咖啡完美融合", Price = 50.00m, ImageUrl = "/images/Cappuccino.jpg" },
            new Cake { Name = "經典巧克力蛋糕", Description = "濃郁滑順的黑巧克力甘納許", Price = 150.00m, ImageUrl = "/images/Food1.jpg" },
            new Cake { Name = "草莓奶油蛋糕", Description = "清爽草莓搭配香濃奶油，口感清新", Price = 120.00m, ImageUrl = "/images/Food2.jpg" },
            new Cake { Name = "抹茶紅豆蛋糕", Description = "日式抹茶融合綿密紅豆，甘甜不膩", Price = 160.00m, ImageUrl = "/images/Food4.png" },
            new Cake { Name = "香草生乳蛋糕", Description = "入口即化的香草生乳，綿密順口", Price = 100.00m, ImageUrl = "/images/Food5.jpg" }
 };

            foreach (Cake c in cakes)
            {
                context.Cakes.Add(c);
            }
            context.SaveChanges();

        }
    }
}
