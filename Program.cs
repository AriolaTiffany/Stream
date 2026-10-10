namespace CreateTxtFile
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLab1 frmLab1 = new FrmLab1();
            FrmRegistration frmRegistration = new FrmRegistration();

            frmLab1.StartPosition = FormStartPosition.Manual;
            frmRegistration.StartPosition = FormStartPosition.Manual;

            frmLab1.Location = new System.Drawing.Point(80, 150);
            frmRegistration.Location = new System.Drawing.Point(frmLab1.Right + 40, 150);

            frmRegistration.Show();
            Application.Run(frmLab1);
        }
    }
}