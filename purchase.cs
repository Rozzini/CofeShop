using System;
using System.Collections.Generic;
using System.Text;

namespace CofeShop.Models
{
    class purchase
    {
        public int PurchaseId { get; set; }
        
        public string Person { get; set; }
        
        public double PurchaseSumm { get; set; }
        
        public int GoodId { get; set; }
        
        public DateTime Date { get; set; }
    }
}
