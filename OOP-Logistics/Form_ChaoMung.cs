using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Logistics
{
    public partial class Form_ChaoMung : Form
    {
        public Form_ChaoMung()
        {
            InitializeComponent();
        }

        private void Form_ChaoMung_Load(object sender, EventArgs e)
        {

        }

        private void btnKhachHang_MouseEnter(object sender, EventArgs e)
        {
            Util.DarkenButtonColor(sender as Button);
        }

        private void btnNhanVien_MouseEnter(object sender, EventArgs e)
        {
            Util.DarkenButtonColor(sender as Button);
        }

        private void btnQuanTriVien_MouseEnter(object sender, EventArgs e)
        {
            Util.DarkenButtonColor(sender as Button);
        }

        private void btnKhachHang_MouseLeave(object sender, EventArgs e)
        {
            Util.NormalButtonColor(sender as Button);
        }

        private void btnNhanVien_MouseLeave(object sender, EventArgs e)
        {
            Util.NormalButtonColor(sender as Button);
        }

        private void btnQuanTriVien_MouseLeave(object sender, EventArgs e)
        {
            Util.NormalButtonColor(sender as Button);
        }
    }
}
