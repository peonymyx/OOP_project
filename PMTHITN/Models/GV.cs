using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PMTHITN.Models
{
    [Serializable]
    class GV : User, ISerializable
    {
        public Khoa Khoa { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Ma", Ma);
            info.AddValue("Ten", Ten);
            info.AddValue("Email", Email);
            info.AddValue("MatKhau", MatKhau);
            info.AddValue("Khoa", Khoa);
        }
        public GV() { }

        public GV(SerializationInfo info, StreamingContext context)
        {
            Ma = info.GetString("Ma");
            Ten = info.GetString("Ten");
            Email = info.GetString("Email");
            MatKhau = info.GetString("MatKhau");
            Khoa = new Khoa
            {
                MaKhoa = info.GetString("MaKhoa"),
                TenKhoa = info.GetString("TenKhoa")
            };
        }
      
    }
}
