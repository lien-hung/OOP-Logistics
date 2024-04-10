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
        public static void NormalButtonColor(Button? btn)
        {
            if (btn is not null)
            {
                btn.BackColor = baseColor;
            }
        }
    }
}
