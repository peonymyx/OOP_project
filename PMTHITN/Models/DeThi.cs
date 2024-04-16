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
    public class DeThi : ISerializable
    {
        public string MaDT { get; set; }
        public string TenMH { get; set; }

        public string ThoiGianLamBai { get; set; }
        public int SoLuongCauHoi { get; set; }
        public int ThoiGianThi  { get; set; }
        public List<string> DanhSachCauHoi { get; set; }
        public List<KetQua> DanhSachKetQua { get; set; }
        public DeThi()
        {
            DanhSachKetQua = new List<KetQua>();
            DanhSachCauHoi = new List<string>();
        }

        public DeThi(string maDeThi, string tenMonHoc, int soCau, int thoiGianThi, string thoiGianLamBai)
        {
            MaDT = maDeThi;
            TenMH = tenMonHoc;
            SoLuongCauHoi = soCau;
            ThoiGianThi = thoiGianThi;
            ThoiGianLamBai = thoiGianLamBai;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MaDT", MaDT);
            info.AddValue("TenMH", TenMH);
            info.AddValue("ThoiGianLamBai", ThoiGianLamBai);
            info.AddValue("SoLuongCauHoi", SoLuongCauHoi);
            info.AddValue("ThoiGianThi", ThoiGianThi);
            info.AddValue("DanhSachCauHoi", JsonConvert.SerializeObject(DanhSachCauHoi));
            info.AddValue("DanhSachKetQua", JsonConvert.SerializeObject(DanhSachKetQua));
        }

        public DeThi(SerializationInfo info, StreamingContext context)
        {
            MaDT = info.GetString("MaDT");
            TenMH = info.GetString("TenMH");
            ThoiGianLamBai = info.GetString("ThoiGianLamBai");
            SoLuongCauHoi = info.GetInt32("SoLuongCauHoi");
            ThoiGianThi = info.GetInt32("ThoiGianThi");
            DanhSachCauHoi = JsonConvert.DeserializeObject<List<string>>(info.GetString("DanhSachCauHoi"));
            DanhSachKetQua = (List<KetQua>)info.GetValue("DanhSachKetQua", typeof(List<KetQua>));
        }


    }
}
