namespace AESEncryptor
{
    public partial class Form1 : Form
    {
        EncryptionAlght encrypter;
        public Form1()
        {
            InitializeComponent();
            encrypter = new EncryptionAlght();
        }

        private void DecryptionButton_Click(object sender, EventArgs e)
        {
            DecryptionForm formDe = new DecryptionForm();
            Hide();
            formDe.ShowDialog();
            Show();
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            FileDecryptorForm formDe = new FileDecryptorForm();
            Hide();
            formDe.ShowDialog();
            Show();
        }

        private void CBCEncryptBT_Click(object sender, EventArgs e)
        {
            try
            {
               CBCEncryptedTB.Text = encrypter.CBC(CBCTextTB.Text, CBCKeyTB.Text, CBCIVTB.Text);
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
                CFBEncryptedTB.Text = encrypter.CFB(CFBTextTB.Text, CFBKeyTB.Text, CFBIVTB.Text);
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
                ECBEncryptedTB.Text = encrypter.ECB(ECBTextTB.Text, ECBKeyTB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}