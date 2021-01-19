using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Model
{
    public class SP_XQ
    {
        public int XQ_Id { get; set; }
        public int SPId { get; set; }
        public string XQ_Remark { get; set; }
        public string XQ_Colour { get; set; }
        public int Sizes_Id { get; set; }
        public int Sp_Count { get; set; }
        public string Materials { get; set; }
        public string Capacity { get; set; }
        public string Surface { get; set; }
        public string Norm { get; set; }
    }
}
