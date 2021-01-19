using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Model
{
    public class ShowSPInfo
    {
        public int SPId { get; set; }
        public string SPName { get; set; }
        public string SPImg { get; set; }
        public string SPRemark { get; set; }
        public decimal SPPrice { get; set; }
        public string SPKuCun { get; set; }
        public int TypeInfo_Id { get; set; }
        public int BrandInfo_Id { get; set; }
        public int TextureInfo_Id { get; set; }

    }
}
