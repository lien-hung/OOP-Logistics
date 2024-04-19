namespace OOP_Logistics
{
    public class Util
    {
        private static Color baseColor = Color.FromArgb(0, 0, 0, 0);
        public static void DarkenButtonColor(Button? btn)
        {
            if (btn is not null)
            {
                baseColor = btn.BackColor;
                btn.BackColor = Color.FromArgb(50, baseColor);
            }
        }
        public static void NormalizeButtonColor(Button? btn)
        {
            if (btn is not null)
            {
                btn.BackColor = baseColor;
            }
        }
        public static bool ExistsEmptyTextbox(Form frm)
        {
            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(ctrl.Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool ExistsEmptyTextbox(GroupBox grp)
        {
            foreach (Control ctrl in grp.Controls)
            {
                if (ctrl is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(ctrl.Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
