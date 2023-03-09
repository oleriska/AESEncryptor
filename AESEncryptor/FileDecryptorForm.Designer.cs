namespace AESEncryptor
{
    partial class FileDecryptorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectFileBT = new System.Windows.Forms.Button();
            this.CBCEncryptBT = new System.Windows.Forms.Button();
            this.EncryptedLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.label228 = new System.Windows.Forms.Label();
            this.PlainTextTB = new System.Windows.Forms.TextBox();
            this.IVTB = new System.Windows.Forms.TextBox();
            this.KeyTB = new System.Windows.Forms.TextBox();
            this.ETextTB = new System.Windows.Forms.TextBox();
            this.ModeCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectFileBT
            // 
            this.SelectFileBT.Location = new System.Drawing.Point(12, 12);
            this.SelectFileBT.Name = "SelectFileBT";
            this.SelectFileBT.Size = new System.Drawing.Size(216, 23);
            this.SelectFileBT.TabIndex = 0;
            this.SelectFileBT.Text = "Select file..";
            this.SelectFileBT.UseVisualStyleBackColor = true;
            this.SelectFileBT.Click += new System.EventHandler(this.SelectFileBT_Click);
            // 
            // CBCEncryptBT
            // 
            this.CBCEncryptBT.Location = new System.Drawing.Point(12, 377);
            this.CBCEncryptBT.Name = "CBCEncryptBT";
            this.CBCEncryptBT.Size = new System.Drawing.Size(216, 23);
            this.CBCEncryptBT.TabIndex = 64;
            this.CBCEncryptBT.Text = "Encrypt";
            this.CBCEncryptBT.UseVisualStyleBackColor = true;
            this.CBCEncryptBT.Click += new System.EventHandler(this.CBCEncryptBT_Click);
            // 
            // EncryptedLabel
            // 
            this.EncryptedLabel.AutoSize = true;
            this.EncryptedLabel.Location = new System.Drawing.Point(12, 330);
            this.EncryptedLabel.Name = "EncryptedLabel";
            this.EncryptedLabel.Size = new System.Drawing.Size(56, 15);
            this.EncryptedLabel.TabIndex = 63;
            this.EncryptedLabel.Text = "Plain text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "Init. vector";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(12, 120);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(26, 15);
            this.KeyLabel.TabIndex = 61;
            this.KeyLabel.Text = "Key";
            // 
            // label228
            // 
            this.label228.AutoSize = true;
            this.label228.Location = new System.Drawing.Point(12, 50);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(83, 15);
            this.label228.TabIndex = 60;
            this.label228.Text = "Encrypted text";
            // 
            // PlainTextTB
            // 
            this.PlainTextTB.Location = new System.Drawing.Point(12, 348);
            this.PlainTextTB.Name = "PlainTextTB";
            this.PlainTextTB.Size = new System.Drawing.Size(216, 23);
            this.PlainTextTB.TabIndex = 59;
            // 
            // IVTB
            // 
            this.IVTB.Location = new System.Drawing.Point(12, 205);
            this.IVTB.Name = "IVTB";
            this.IVTB.Size = new System.Drawing.Size(216, 23);
            this.IVTB.TabIndex = 58;
            // 
            // KeyTB
            // 
            this.KeyTB.Location = new System.Drawing.Point(12, 138);
            this.KeyTB.Name = "KeyTB";
            this.KeyTB.Size = new System.Drawing.Size(216, 23);
            this.KeyTB.TabIndex = 57;
            // 
            // ETextTB
            // 
            this.ETextTB.Location = new System.Drawing.Point(12, 68);
            this.ETextTB.Name = "ETextTB";
            this.ETextTB.Size = new System.Drawing.Size(216, 23);
            this.ETextTB.TabIndex = 56;
            // 
            // ModeCB
            // 
            this.ModeCB.FormattingEnabled = true;
            this.ModeCB.Location = new System.Drawing.Point(12, 272);
            this.ModeCB.Name = "ModeCB";
            this.ModeCB.Size = new System.Drawing.Size(216, 23);
            this.ModeCB.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 66;
            this.label1.Text = "Mode";
            // 
            // FileDecryptorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModeCB);
            this.Controls.Add(this.CBCEncryptBT);
            this.Controls.Add(this.EncryptedLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.label228);
            this.Controls.Add(this.PlainTextTB);
            this.Controls.Add(this.IVTB);
            this.Controls.Add(this.KeyTB);
            this.Controls.Add(this.ETextTB);
            this.Controls.Add(this.SelectFileBT);
            this.Name = "FileDecryptorForm";
            this.Text = "FileDecryptorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SelectFileBT;
        private Button CBCEncryptBT;
        private Label EncryptedLabel;
        private Label label5;
        private Label KeyLabel;
        private Label label228;
        private TextBox PlainTextTB;
        private TextBox IVTB;
        private TextBox KeyTB;
        private TextBox ETextTB;
        private ComboBox ModeCB;
        private Label label1;
    }
}