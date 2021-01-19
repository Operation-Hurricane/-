using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Model
{
    public class OrderDetails
    {
        public int ODId { get; set; }
        public string ShippingMethod { get; set; }
        public string Carrier { get; set; }
        public string Bilslading { get; set; }
        public string Consignee { get; set; }
        public string ShippingAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string PaymentMethod { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal Freight { get; set; }
        public string InvoiceType { get; set; }
        public string CancellationReason { get; set; }
        public DateTime CancellationTime { get; set; }
        public decimal RefundAmount { get; set; }
        public string RefundWay { get; set; }
        public int AddSite_Side { get; set; }
    }
}
