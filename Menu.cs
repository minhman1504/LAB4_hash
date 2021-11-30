using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace LAB4_hash
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            init();
        }

        private string lastInput = "";
        private string lastFormat = "";
        private string filePath = "";

        private void init()
        {
            cbFormat.SelectedIndex = 0;
        }

        public static byte[] hexStringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private byte[] loadFileToByteArray()
        {
            return File.ReadAllBytes(filePath);
        }

        private void calcHash(byte[] inputBytes) 
        {
            //MessageBox.Show("calcHash() running !"); //-> Test running

            //calc MD5
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                txtMD5.Text = sb.ToString();
            }
            //calc SHA1
            using (System.Security.Cryptography.SHA1 sha1 = System.Security.Cryptography.SHA1.Create())
            {
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                txtSHA1.Text = sb.ToString();
            }
            //calc SHA256
            using (System.Security.Cryptography.SHA256 sha2 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha2.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                txtSHA2.Text = sb.ToString();
            }
            //calc SHA384
            using (System.Security.Cryptography.SHA384 sha3 = System.Security.Cryptography.SHA384.Create())
            {
                byte[] hashBytes = sha3.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                txtSHA3.Text = sb.ToString();
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            cbFormat.SelectedIndex = 2;
            //openfiledialog
            //selectfile -> filePath
            OpenFileDialog openf = new OpenFileDialog()
            {
                Title = "SelectFile to Hash!"
            };

            if (openf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePath = openf.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
            txtInput.Text = "Load file: " + filePath + " to hash!";
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            if(txtInput.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Input Data Empty!", "Error");
                return;
            }


            if (cbFormat.Text == "Hex String") 
            {
                if(!Regex.IsMatch(txtInput.Text.Trim(), @"\A\b[0-9a-fA-F]+\b\Z"))
                {
                    MessageBox.Show("Hex String Input Error", "Error");
                    return;
                }
                if(txtInput.Text.Trim().Length % 2 == 1)
                {
                    txtInput.Text = "0" + txtInput.Text;
                }
            }

            panelOutput.Visible = true;

            panelMD5.Visible = cbMD5.Checked;
            panelSHA1.Visible = cbSHA1.Checked;
            panelSHA2.Visible = cbSHA2.Checked;
            panelSHA3.Visible = cbSHA3.Checked;

            if(txtInput.Text == lastInput && cbFormat.Text == lastFormat)
            {
                //calced
                return;
            }

            byte[] inputBytes = null;
            //validate input
            if (cbFormat.Text == "Normal String")
            {
                // implement
                // code
                inputBytes = System.Text.Encoding.UTF8.GetBytes(txtInput.Text.Trim());
            }
            else if( cbFormat.Text == "Hex String")
            {
                // implement
                // code
                inputBytes = hexStringToByteArray(txtInput.Text.Trim().ToUpper());
            }
            else //binary file
            {
                // implement
                // code
                inputBytes = loadFileToByteArray();
            }

            calcHash(inputBytes);

            lastInput = txtInput.Text;
            lastFormat = cbFormat.Text;
        }

        private void cbFormat_SelectedValueChanged(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }
    }
}
