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
    class SV : ISerializable
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }

        public List<string> MaLop { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Ma", Ma);
            info.AddValue("Ten", Ten);
            info.AddValue("Email", Email);
            info.AddValue("MatKhau", MatKhau);
            info.AddValue("NganHangCauHoi", JsonConvert.SerializeObject(MaLop));
        }
        public SV() { }

        public SV(SerializationInfo info, StreamingContext context)
        {
            Ma = info.GetString("Ma");
            Ten = info.GetString("Ten");
            Email = info.GetString("Email");
            MatKhau = info.GetString("MatKhau");
            MaLop = JsonConvert.DeserializeObject<List<string>>(info.GetString("MaLop"));
        }
    }
}
