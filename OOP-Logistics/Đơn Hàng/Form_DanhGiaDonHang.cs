using OOP_Logistics.Khách_Hàng;

namespace OOP_Logistics
{
    public partial class Form_DanhGiaDonHang : Form
    {
        private DonHang DonDuocDanhGia;
        private int DiemDanhGia;
        public Form_DanhGiaDonHang(DonHang dh)
        {
            InitializeComponent();
            DonDuocDanhGia = dh;
        }

        private void UnfillAllStars()
        {
            ptbStar1.Image = ptbStar2.Image = ptbStar3.Image = ptbStar4.Image = ptbStar5.Image = Properties.Resources.icons8_star_100_unfilled;
        }

        private void FillAllStars()
        {
            ptbStar1.Image = ptbStar2.Image = ptbStar3.Image = ptbStar4.Image = ptbStar5.Image = Properties.Resources.icons8_star_100_filled;
        }

        private void Form_DanhGiaDonHang_Load(object sender, EventArgs e)
        {
            UnfillAllStars();
            DiemDanhGia = 0;
        }

        private void ptbStar1_Click(object sender, EventArgs e)
        {
            UnfillAllStars();
            ptbStar1.Image = Properties.Resources.icons8_star_100_filled;
            DiemDanhGia = 1;
        }

        private void ptbStar2_Click(object sender, EventArgs e)
        {
            UnfillAllStars();
            ptbStar1.Image = ptbStar2.Image = Properties.Resources.icons8_star_100_filled;
            DiemDanhGia = 2;
        }

        private void ptbStar3_Click(object sender, EventArgs e)
        {
            FillAllStars();
            ptbStar5.Image = ptbStar4.Image = Properties.Resources.icons8_star_100_unfilled;
            DiemDanhGia = 3;
        }

        private void ptbStar4_Click(object sender, EventArgs e)
        {
            FillAllStars();
            ptbStar5.Image = Properties.Resources.icons8_star_100_unfilled;
            DiemDanhGia = 4;
        }

        private void ptbStar5_Click(object sender, EventArgs e)
        {
            FillAllStars();
            DiemDanhGia = 5;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            DonDuocDanhGia.ChoDanhGia(DiemDanhGia);
            MessageBox.Show($"Bạn đã cho {DiemDanhGia} sao.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
