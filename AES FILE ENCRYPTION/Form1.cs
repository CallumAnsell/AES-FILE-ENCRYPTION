using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AES_FILE_ENCRYPTION
{
    public partial class Form1 : Form
    {
        public string inputDataFile, outputPath;
        public Form1()
        {
            InitializeComponent();
            this.Width = 700;
        }

        private void btnOpnFileDiag_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog inputFileDialog = new OpenFileDialog();
                inputFileDialog.Title = "Please select an Input File";
                inputFileDialog.ShowDialog();
                inputDataFile = inputFileDialog.FileName;
                txtDirectory.Text = inputDataFile;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDirectory.Text == string.Empty)
                {
                    MessageBox.Show("Please select an Input file");
                }
                else if (txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a password to encrypt your file with.");
                }
                else
                {
                    try
                    {
                        picLoading.Visible = true;
                        WrkerEncryption.RunWorkerAsync();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtDirectory.Text == string.Empty)
                {
                    MessageBox.Show("Please select an Input file");
                }
                else if (txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a password to decrypt your file with.");
                }
                else
                {
                    picLoading.Visible = true;
                    WrkerDecryption.RunWorkerAsync();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {
            inputDataFile = txtDirectory.Text;

        }

        private void chkPassChar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassChar.Checked == false)
            {
                txtPassword.PasswordChar = ('\0');
                chkPassChar.Text = "Hide password";
            }
            else
            {
                txtPassword.PasswordChar = Convert.ToChar("*");
                chkPassChar.Text = "Show password";
            }
        }

        private void WrkerEncryption_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                outputPath = inputDataFile + "ENCRYPTED";

                Crypto.EncryptFile(inputDataFile, outputPath, txtPassword.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void WrkerEncryption_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                picLoading.Visible = false;
                checkStateEncryption();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void checkStateEncryption()
        {

            if (File.Exists(inputDataFile + "ENCRYPTED"))
            {
                MessageBox.Show("The file has been encrypted successfully.");
                txtDirectory.Clear();
            }
            else
            {

            }
        }
        private void checkStateDecryption()
        {
            if (File.Exists(inputDataFile + "DECRYPTED"))
            {
                MessageBox.Show("The file has been decrypted successfully.");
                txtDirectory.Clear();
            }
            else
            {

            }
        }

        private void WrkerDecryption_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                outputPath = inputDataFile + "DECRYPTED";
                Crypto.DecryptFile(inputDataFile, outputPath, txtPassword.Text);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void WrkerDecryption_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                picLoading.Visible = false;
                checkStateDecryption();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
