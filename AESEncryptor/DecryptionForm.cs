using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESEncryptor
{
    public partial class DecryptionForm : Form
    {
        EncryptionAlght encrypter;
        public DecryptionForm()
        {
            InitializeComponent();
            encrypter = new EncryptionAlght();
        }

        private void DecryptionForm_Load(object sender, EventArgs e)
        {

        }

        private void EncryptionFormBT_Click(object sender, EventArgs e)
        {
          Close();
        }

        private void CBCEncryptBT_Click(object sender, EventArgs e)
        {
            try
            {
                CBCTextTB.Text = encrypter.D_CBC(CBCEncTB.Text, CBCKeyTB.Text, CBCIVTB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CFBEncryptBT_Click(object sender, EventArgs e)
        {
            try
            {
                CFBTextTB.Text = encrypter.D_CFB(CFBEncTB.Text, CFBKeyTB.Text, CFBIVTB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ECBEncryptBT_Click(object sender, EventArgs e)
        {
            try
            {
                ECBTextTB.Text = encrypter.D_ECB(ECBEncTB.Text, ECBKeyTB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
