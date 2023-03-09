using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AESEncryptor
{
    public partial class FileDecryptorForm : Form
    {
        public FileDecryptorForm()
        {
            InitializeComponent();
            ModeCB.DataSource = Enum.GetValues(typeof(EncryptionModes));
        }

        private void SelectFileBT_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var fileContent = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        ETextTB.Text = fileContent;

                    }
                }
            }
        }

        private void CBCEncryptBT_Click(object sender, EventArgs e)
        {
            try
            {
                EncryptionAlght encrypter = new EncryptionAlght();
                if ((EncryptionModes)ModeCB.SelectedItem == EncryptionModes.CBC)
                {
                    PlainTextTB.Text = encrypter.D_CBC(ETextTB.Text, KeyTB.Text, IVTB.Text);
                }
                else if ((EncryptionModes)ModeCB.SelectedItem == EncryptionModes.CFB)
                {
                    PlainTextTB.Text = encrypter.D_CFB(ETextTB.Text, KeyTB.Text, IVTB.Text);
                }
                else if ((EncryptionModes)ModeCB.SelectedItem == EncryptionModes.ECB)
                {
                    PlainTextTB.Text = encrypter.D_ECB(ETextTB.Text, KeyTB.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
