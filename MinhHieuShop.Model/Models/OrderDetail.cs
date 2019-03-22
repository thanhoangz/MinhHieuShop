﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhHieuShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { get; set; }
        [Key]
        public int ProductID { get; set; }
        public int Quantitty { get; set; }



        // Khóa ngoại
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

    }
}
