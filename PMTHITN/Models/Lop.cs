using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PMTHITN.Models
{
    [Serializable]
    class Lop : ISerializable
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaGV { get; set; }
        public List<string> DanhSachSinhVien { get; set; }
        public List<string> DanhSachDeThi { get; set; }

        public Lop() {
            DanhSachSinhVien = new List<string>();
            DanhSachDeThi = new List<string>();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MaLop", MaLop);
            info.AddValue("TenLop", TenLop);
            info.AddValue("MaGV", MaGV);
            info.AddValue("DanhSachSinhVien", JsonConvert.SerializeObject(DanhSachSinhVien));
            info.AddValue("DanhSachDeThi", JsonConvert.SerializeObject(DanhSachDeThi));
        }

        public Lop(SerializationInfo info, StreamingContext context)
        {
            MaLop = info.GetString("MaLop");
            TenLop = info.GetString("TenLop");
            MaGV = info.GetString("MaGV");
            DanhSachSinhVien = JsonConvert.DeserializeObject<List<string>>(info.GetString("DanhSachSinhVien"));
            DanhSachDeThi = JsonConvert.DeserializeObject<List<string>>(info.GetString("DanhSachDeThi"));
        }

        public void ThemDeThi(string deThi)
        {
            DanhSachDeThi.Add(deThi);
        }
        /*public List<DeThi> getDanhSachDeThi(string MaLop)
        {
            return DanhSachDeThi;
        }*/
    }
}
