using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Model
{
    public class Flash_saleInfo
    {
        public int Fs_Id { get; set; }
        public string Fs_Name { get; set; }
        public string Fs_Remark { get; set; }
        public string Fs_Pic { get; set; }
        public decimal Fs_Price { get; set; }
        public string Fs_KuCun { get; set; }
        public DateTime Fs_StartTime { get; set; }
        public DateTime Fs_EndTime { get; set; }
    }
}
