using Microsoft.VisualBasic.ApplicationServices;

namespace OOP_Logistics
{
    public class MyApplication : WindowsFormsApplicationBase
    {
        public MyApplication()
        {
            ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }
        protected override void OnCreateMainForm()
        {
            MainForm = new Form_ChaoMung();
        }
    }
}
