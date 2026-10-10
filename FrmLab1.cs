using System;
using System.IO;
using System.Windows.Forms;

namespace CreateTxtFile
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            FrmFileName.SetFileName = null;

            FrmFileName fileNameForm = new FrmFileName();
            fileNameForm.ShowDialog();

            if (string.IsNullOrEmpty(FrmFileName.SetFileName))
            {
                MessageBox.Show("No file name was entered. The file was not created.",
                    "FrmLab1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string getInput = txtInput.Text;

            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
                FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }

            MessageBox.Show("File created:\n" + Path.Combine(docPath, FrmFileName.SetFileName),
                "FrmLab1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
