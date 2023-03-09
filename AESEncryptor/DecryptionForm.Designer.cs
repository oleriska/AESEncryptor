namespace AESEncryptor
{
    partial class DecryptionForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EncryptedLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.label228 = new System.Windows.Forms.Label();
            this.ECBTextTB = new System.Windows.Forms.TextBox();
            this.ECBKeyTB = new System.Windows.Forms.TextBox();
            this.ECBEncTB = new System.Windows.Forms.TextBox();
            this.CFBTextTB = new System.Windows.Forms.TextBox();
            this.CFBIVTB = new System.Windows.Forms.TextBox();
            this.CFBKeyTB = new System.Windows.Forms.TextBox();
            this.CFBEncTB = new System.Windows.Forms.TextBox();
            this.CBCTextTB = new System.Windows.Forms.TextBox();
            this.CBCIVTB = new System.Windows.Forms.TextBox();
            this.CBCKeyTB = new System.Windows.Forms.TextBox();
            this.CBCEncTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBCEncryptBT = new System.Windows.Forms.Button();
            this.CFBEncryptBT = new System.Windows.Forms.Button();
            this.ECBEncryptBT = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.EncryptionFormBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(566, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 53;
            this.label10.Text = "Plain text";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(566, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 15);
            this.label12.TabIndex = 52;
            this.label12.Text = "Key";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(566, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 15);
            this.label13.TabIndex = 51;
            this.label13.Text = "Encrypted text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "Plain text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 49;
            this.label7.Text = "Init. vector";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "Encrypted text";
            // 
            // EncryptedLabel
            // 
            this.EncryptedLabel.AutoSize = true;
            this.EncryptedLabel.Location = new System.Drawing.Point(20, 351);
            this.EncryptedLabel.Name = "EncryptedLabel";
            this.EncryptedLabel.Size = new System.Drawing.Size(56, 15);
            this.EncryptedLabel.TabIndex = 46;
            this.EncryptedLabel.Text = "Plain text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Init. vector";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(20, 214);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(26, 15);
            this.KeyLabel.TabIndex = 44;
            this.KeyLabel.Text = "Key";
            // 
            // label228
            // 
            this.label228.AutoSize = true;
            this.label228.Location = new System.Drawing.Point(20, 144);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(83, 15);
            this.label228.TabIndex = 43;
            this.label228.Text = "Encrypted text";
            // 
            // ECBTextTB
            // 
            this.ECBTextTB.Location = new System.Drawing.Point(566, 369);
            this.ECBTextTB.Name = "ECBTextTB";
            this.ECBTextTB.Size = new System.Drawing.Size(216, 23);
            this.ECBTextTB.TabIndex = 42;
            // 
            // ECBKeyTB
            // 
            this.ECBKeyTB.Location = new System.Drawing.Point(566, 232);
            this.ECBKeyTB.Name = "ECBKeyTB";
            this.ECBKeyTB.Size = new System.Drawing.Size(216, 23);
            this.ECBKeyTB.TabIndex = 41;
            // 
            // ECBEncTB
            // 
            this.ECBEncTB.Location = new System.Drawing.Point(566, 162);
            this.ECBEncTB.Name = "ECBEncTB";
            this.ECBEncTB.Size = new System.Drawing.Size(216, 23);
            this.ECBEncTB.TabIndex = 40;
            // 
            // CFBTextTB
            // 
            this.CFBTextTB.Location = new System.Drawing.Point(294, 369);
            this.CFBTextTB.Name = "CFBTextTB";
            this.CFBTextTB.Size = new System.Drawing.Size(216, 23);
            this.CFBTextTB.TabIndex = 39;
            // 
            // CFBIVTB
            // 
            this.CFBIVTB.Location = new System.Drawing.Point(294, 299);
            this.CFBIVTB.Name = "CFBIVTB";
            this.CFBIVTB.Size = new System.Drawing.Size(216, 23);
            this.CFBIVTB.TabIndex = 38;
            // 
            // CFBKeyTB
            // 
            this.CFBKeyTB.Location = new System.Drawing.Point(294, 232);
            this.CFBKeyTB.Name = "CFBKeyTB";
            this.CFBKeyTB.Size = new System.Drawing.Size(216, 23);
            this.CFBKeyTB.TabIndex = 37;
            // 
            // CFBEncTB
            // 
            this.CFBEncTB.Location = new System.Drawing.Point(294, 162);
            this.CFBEncTB.Name = "CFBEncTB";
            this.CFBEncTB.Size = new System.Drawing.Size(216, 23);
            this.CFBEncTB.TabIndex = 36;
            // 
            // CBCTextTB
            // 
            this.CBCTextTB.Location = new System.Drawing.Point(20, 369);
            this.CBCTextTB.Name = "CBCTextTB";
            this.CBCTextTB.Size = new System.Drawing.Size(216, 23);
            this.CBCTextTB.TabIndex = 35;
            // 
            // CBCIVTB
            // 
            this.CBCIVTB.Location = new System.Drawing.Point(20, 299);
            this.CBCIVTB.Name = "CBCIVTB";
            this.CBCIVTB.Size = new System.Drawing.Size(216, 23);
            this.CBCIVTB.TabIndex = 34;
            // 
            // CBCKeyTB
            // 
            this.CBCKeyTB.Location = new System.Drawing.Point(20, 232);
            this.CBCKeyTB.Name = "CBCKeyTB";
            this.CBCKeyTB.Size = new System.Drawing.Size(216, 23);
            this.CBCKeyTB.TabIndex = 33;
            // 
            // CBCEncTB
            // 
            this.CBCEncTB.Location = new System.Drawing.Point(20, 162);
            this.CBCEncTB.Name = "CBCEncTB";
            this.CBCEncTB.Size = new System.Drawing.Size(216, 23);
            this.CBCEncTB.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(355, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 54);
            this.label3.TabIndex = 31;
            this.label3.Text = "CFB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(633, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 54);
            this.label2.TabIndex = 30;
            this.label2.Text = "ECB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 54);
            this.label1.TabIndex = 29;
            this.label1.Text = "CBC";
            // 
            // CBCEncryptBT
            // 
            this.CBCEncryptBT.Location = new System.Drawing.Point(20, 398);
            this.CBCEncryptBT.Name = "CBCEncryptBT";
            this.CBCEncryptBT.Size = new System.Drawing.Size(216, 23);
            this.CBCEncryptBT.TabIndex = 54;
            this.CBCEncryptBT.Text = "Encrypt";
            this.CBCEncryptBT.UseVisualStyleBackColor = true;
            this.CBCEncryptBT.Click += new System.EventHandler(this.CBCEncryptBT_Click);
            // 
            // CFBEncryptBT
            // 
            this.CFBEncryptBT.Location = new System.Drawing.Point(294, 398);
            this.CFBEncryptBT.Name = "CFBEncryptBT";
            this.CFBEncryptBT.Size = new System.Drawing.Size(216, 23);
            this.CFBEncryptBT.TabIndex = 55;
            this.CFBEncryptBT.Text = "Encrypt";
            this.CFBEncryptBT.UseVisualStyleBackColor = true;
            this.CFBEncryptBT.Click += new System.EventHandler(this.CFBEncryptBT_Click);
            // 
            // ECBEncryptBT
            // 
            this.ECBEncryptBT.Location = new System.Drawing.Point(566, 398);
            this.ECBEncryptBT.Name = "ECBEncryptBT";
            this.ECBEncryptBT.Size = new System.Drawing.Size(216, 23);
            this.ECBEncryptBT.TabIndex = 56;
            this.ECBEncryptBT.Text = "Encrypt";
            this.ECBEncryptBT.UseVisualStyleBackColor = true;
            this.ECBEncryptBT.Click += new System.EventHandler(this.ECBEncryptBT_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(294, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 37);
            this.label11.TabIndex = 57;
            this.label11.Text = "Decryption form";
            // 
            // EncryptionFormBT
            // 
            this.EncryptionFormBT.Location = new System.Drawing.Point(12, 12);
            this.EncryptionFormBT.Name = "EncryptionFormBT";
            this.EncryptionFormBT.Size = new System.Drawing.Size(75, 23);
            this.EncryptionFormBT.TabIndex = 58;
            this.EncryptionFormBT.Text = "Encryption";
            this.EncryptionFormBT.UseVisualStyleBackColor = true;
            this.EncryptionFormBT.Click += new System.EventHandler(this.EncryptionFormBT_Click);
            // 
            // DecryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.EncryptionFormBT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ECBEncryptBT);
            this.Controls.Add(this.CFBEncryptBT);
            this.Controls.Add(this.CBCEncryptBT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EncryptedLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.label228);
            this.Controls.Add(this.ECBTextTB);
            this.Controls.Add(this.ECBKeyTB);
            this.Controls.Add(this.ECBEncTB);
            this.Controls.Add(this.CFBTextTB);
            this.Controls.Add(this.CFBIVTB);
            this.Controls.Add(this.CFBKeyTB);
            this.Controls.Add(this.CFBEncTB);
            this.Controls.Add(this.CBCTextTB);
            this.Controls.Add(this.CBCIVTB);
            this.Controls.Add(this.CBCKeyTB);
            this.Controls.Add(this.CBCEncTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DecryptionForm";
            this.Text = "DecryptionForm";
            this.Load += new System.EventHandler(this.DecryptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private Label label12;
        private Label label13;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label EncryptedLabel;
        private Label label5;
        private Label KeyLabel;
        private Label label228;
        private TextBox ECBTextTB;
        private TextBox ECBKeyTB;
        private TextBox ECBEncTB;
        private TextBox CFBTextTB;
        private TextBox CFBIVTB;
        private TextBox CFBKeyTB;
        private TextBox CFBEncTB;
        private TextBox CBCTextTB;
        private TextBox CBCIVTB;
        private TextBox CBCKeyTB;
        private TextBox CBCEncTB;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button CBCEncryptBT;
        private Button CFBEncryptBT;
        private Button ECBEncryptBT;
        private Label label11;
        private Button EncryptionFormBT;
    }
}