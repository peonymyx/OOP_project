using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PMTHITN.Models
{
    [Serializable]
    class Khoa : ISerializable
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MaKhoa", MaKhoa);
            info.AddValue("TenKhoa", TenKhoa);
        }
        public Khoa() { }

        public Khoa(SerializationInfo info, StreamingContext context)
        {
            MaKhoa = info.GetString("MaKhoa");
            TenKhoa = info.GetString("TenKhoa");
        }

    }
}
