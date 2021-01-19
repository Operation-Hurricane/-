using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Model
{
    public class ShopCar
    {
        public int Shop_Id { get; set; }
        public string Shop_Name{ get; set; }
        public string Shop_Img { get; set; }
        public string Shop_Color { get; set; }
        public int Sizes_Id{ get; set; }
        public decimal Shop_Price{ get; set; }
        public int Shop_Sum{ get; set; }
        public string Shop_Dinheiro { get; set; }
    }
}
