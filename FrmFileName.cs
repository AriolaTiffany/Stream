using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace CreateTxtFile
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;

        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            string name = txtFileName.Text.Trim();

            if (name.Length == 0 || name.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("Please enter a valid file name.", "frmFileName",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFileName.Focus();
                return;
            }

            SetFileName = name + ".txt";

            this.Close();
        }

    }
}
