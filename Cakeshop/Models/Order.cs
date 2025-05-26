using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cakeshop.Models
{  public enum OrderStatus
   {
            [Display(Name ="處理中")]
            Panding,
            [Display(Name = "以確認")]
            Confirmed,
            [Display(Name = "已出貨")]
            Shipped,
            [Display(Name = "已完成")]
            Completed,
            [Display(Name = "已取消")]
            Cancelled
    }
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string? UserId { get; set; }=string.Empty;
        [ForeignKey("UserId")]

        public virtual ApplicationUser? User { get; set; }

        [Required]
        [Display(Name ="訂購日期")]

        public DateTime OrderDate { get; set; }

        [Required]
        [Display(Name = "訂單總額")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "收貨地址")]
        public string ShoppingAddress { get; set; }= string.Empty;
        [Required]
        [StringLength(50)]
        [Display(Name = "取件人姓名")]
        public string RecipientName { get; set; } = string.Empty;
        [Required]
        [StringLength(20)]
        [Display(Name = "連絡電話")]
        public string RecipientPhone { get; set; } = string.Empty;

        [Required]
        [Display(Name = "訂單狀態")]
        public OrderStatus Status { get; set; }=OrderStatus.Panding;

        public virtual ICollection<OrderDetial> OrderDetials { get; set; } = new List<OrderDetial>();

    }
}
