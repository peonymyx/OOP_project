using PMTHITN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTHITN.GiangVien.Quanly
{
    public partial class frmbangdiem : Form
    {
        Form _parent;
        string _maDT;
        public frmbangdiem(Form parent, string maDT)
        {
            InitializeComponent();
            _maDT = maDT;
            _parent = parent;
            HienThiDiem();
        }

        private void HienThiDiem()
        {
            if (_maDT != null) 
            {
                List<DeThi> dsDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
                foreach(DeThi dethi in dsDeThi)
                {
                    if(dethi.MaDT == _maDT)
                    {
                        dgv_bangdiem.DataSource = dethi.DanhSachKetQua;
                    }
                }
            }
        }
        private void lbl_backnd_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }
    }
}
