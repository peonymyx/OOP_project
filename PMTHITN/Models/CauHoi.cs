using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PMTHITN.Models
{
    [Serializable]
    public class CauHoi : ISerializable
    {
        public string MaCH { get; set; }
        public string NoiDung { get; set; }
        public string DapAn { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MaCH", MaCH);
            info.AddValue("NoiDung", NoiDung);
            info.AddValue("DapAn", DapAn);
        }
        public CauHoi() { }

        public CauHoi(SerializationInfo info, StreamingContext context)
        {
            MaCH = info.GetString("MaCH");
            NoiDung = info.GetString("NoiDung");
            DapAn = info.GetString("DapAn");
        }

        public CauHoi(string maCH, string noiDung, string dapAn)
        {
            MaCH = maCH;
            NoiDung = noiDung;
            DapAn = dapAn;
        }
    }
}
