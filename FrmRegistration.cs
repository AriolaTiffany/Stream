using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System;
using System.IO;
using System.Windows.Forms;

namespace CreateTxtFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string middleInitial = txtMI.Text.Trim();

            long studentNo;
            if (!long.TryParse(txtStudentNo.Text.Trim(), out studentNo))
            {
                MessageBox.Show("Student No. must contain digits only.", "FrmRegistration",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentNo.Focus();
                return;
            }

            if (lastName.Length == 0 || firstName.Length == 0 || 
                cboProgram.SelectedIndex < 0 || cboGender.SelectedIndex < 0)
            {
                MessageBox.Show("Please complete all required fields.", "FrmRegistration",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int age;
            if (!int.TryParse(txtAge.Text.Trim(), out age))
            {
                MessageBox.Show("Age must be a number.", "FrmRegistration",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }

            long contactNo;
            if (!long.TryParse(txtContactNo.Text.Trim(), out contactNo))
            {
                MessageBox.Show("Contact No. must contain digits only.", "FrmRegistration",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactNo.Focus();
                return;
            }

            if (middleInitial.Length > 0 && !middleInitial.EndsWith("."))
            {
                middleInitial += ".";
            }

            string fullName = lastName + ", " + firstName;
            if (middleInitial.Length > 0)
            {
                fullName += ", " + middleInitial;
            }

            string[] lines =
            {
                "Student No.: " + studentNo,
                "Full Name:   " + fullName,
                "Program:     " + cboProgram.Text,
                "Gender:      " + cboGender.Text,
                "Age:         " + age,
                "Birthday:    " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                "Contact No.: " + contactNo
            };

            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string filePath = Path.Combine(docPath, studentNo + ".txt");

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                    Console.WriteLine(line);
                }
            }

            MessageBox.Show("Registration saved:\n" + filePath, "FrmRegistration",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
             {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
             };


            for (int i = 0; i < 6; i++)
            {
                cboProgram.Items.Add(ListOfProgram[i].ToString());
            }

            string[] ListOfGender = new string[]
            {
                   "Female",
                    "Male"
            };

            for (int i = 0; i < 2; i++)
            {
                cboGender.Items.Add(ListOfGender[i].ToString());
            }
        }
    }
}
