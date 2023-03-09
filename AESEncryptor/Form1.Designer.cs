namespace AESEncryptor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBCTextTB = new System.Windows.Forms.TextBox();
            this.CBCKeyTB = new System.Windows.Forms.TextBox();
            this.CBCIVTB = new System.Windows.Forms.TextBox();
            this.CBCEncryptedTB = new System.Windows.Forms.TextBox();
            this.CFBEncryptedTB = new System.Windows.Forms.TextBox();
            this.CFBIVTB = new System.Windows.Forms.TextBox();
            this.CFBKeyTB = new System.Windows.Forms.TextBox();
            this.CFBTextTB = new System.Windows.Forms.TextBox();
            this.ECBEncryptedTB = new System.Windows.Forms.TextBox();
            this.ECBKeyTB = new System.Windows.Forms.TextBox();
            this.ECBTextTB = new System.Windows.Forms.TextBox();
            this.FileButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EncryptedLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DecryptionButton = new System.Windows.Forms.Button();
            this.ECBEncryptBT = new System.Windows.Forms.Button();
            this.CFBEncryptBT = new System.Windows.Forms.Button();
            this.CBCEncryptBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CBC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(625, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "ECB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(347, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "CFB";
            // 
            // CBCTextTB
            // 
            this.CBCTextTB.Location = new System.Drawing.Point(12, 164);
            this.CBCTextTB.Name = "CBCTextTB";
            this.CBCTextTB.Size = new System.Drawing.Size(216, 23);
            this.CBCTextTB.TabIndex = 3;
            // 
            // CBCKeyTB
            // 
            this.CBCKeyTB.Location = new System.Drawing.Point(12, 234);
            this.CBCKeyTB.Name = "CBCKeyTB";
            this.CBCKeyTB.Size = new System.Drawing.Size(216, 23);
            this.CBCKeyTB.TabIndex = 4;
            // 
            // CBCIVTB
            // 
            this.CBCIVTB.Location = new System.Drawing.Point(12, 301);
            this.CBCIVTB.Name = "CBCIVTB";
            this.CBCIVTB.Size = new System.Drawing.Size(216, 23);
            this.CBCIVTB.TabIndex = 5;
            // 
            // CBCEncryptedTB
            // 
            this.CBCEncryptedTB.Location = new System.Drawing.Point(12, 444);
            this.CBCEncryptedTB.Name = "CBCEncryptedTB";
            this.CBCEncryptedTB.Size = new System.Drawing.Size(216, 23);
            this.CBCEncryptedTB.TabIndex = 6;
            // 
            // CFBEncryptedTB
            // 
            this.CFBEncryptedTB.Location = new System.Drawing.Point(286, 444);
            this.CFBEncryptedTB.Name = "CFBEncryptedTB";
            this.CFBEncryptedTB.Size = new System.Drawing.Size(216, 23);
            this.CFBEncryptedTB.TabIndex = 10;
            // 
            // CFBIVTB
            // 
            this.CFBIVTB.Location = new System.Drawing.Point(286, 301);
            this.CFBIVTB.Name = "CFBIVTB";
            this.CFBIVTB.Size = new System.Drawing.Size(216, 23);
            this.CFBIVTB.TabIndex = 9;
            // 
            // CFBKeyTB
            // 
            this.CFBKeyTB.Location = new System.Drawing.Point(286, 234);
            this.CFBKeyTB.Name = "CFBKeyTB";
            this.CFBKeyTB.Size = new System.Drawing.Size(216, 23);
            this.CFBKeyTB.TabIndex = 8;
            // 
            // CFBTextTB
            // 
            this.CFBTextTB.Location = new System.Drawing.Point(286, 164);
            this.CFBTextTB.Name = "CFBTextTB";
            this.CFBTextTB.Size = new System.Drawing.Size(216, 23);
            this.CFBTextTB.TabIndex = 7;
            // 
            // ECBEncryptedTB
            // 
            this.ECBEncryptedTB.Location = new System.Drawing.Point(558, 444);
            this.ECBEncryptedTB.Name = "ECBEncryptedTB";
            this.ECBEncryptedTB.Size = new System.Drawing.Size(216, 23);
            this.ECBEncryptedTB.TabIndex = 13;
            // 
            // ECBKeyTB
            // 
            this.ECBKeyTB.Location = new System.Drawing.Point(558, 234);
            this.ECBKeyTB.Name = "ECBKeyTB";
            this.ECBKeyTB.Size = new System.Drawing.Size(216, 23);
            this.ECBKeyTB.TabIndex = 12;
            // 
            // ECBTextTB
            // 
            this.ECBTextTB.Location = new System.Drawing.Point(558, 164);
            this.ECBTextTB.Name = "ECBTextTB";
            this.ECBTextTB.Size = new System.Drawing.Size(216, 23);
            this.ECBTextTB.TabIndex = 11;
            // 
            // FileButton
            // 
            this.FileButton.Location = new System.Drawing.Point(100, 12);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(75, 23);
            this.FileButton.TabIndex = 14;
            this.FileButton.Text = "Select file";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Plain text";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(12, 216);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(26, 15);
            this.KeyLabel.TabIndex = 16;
            this.KeyLabel.Text = "Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Init. vector";
            // 
            // EncryptedLabel
            // 
            this.EncryptedLabel.AutoSize = true;
            this.EncryptedLabel.Location = new System.Drawing.Point(12, 426);
            this.EncryptedLabel.Name = "EncryptedLabel";
            this.EncryptedLabel.Size = new System.Drawing.Size(83, 15);
            this.EncryptedLabel.TabIndex = 18;
            this.EncryptedLabel.Text = "Encrypted text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Encrypted text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Init. vector";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Plain text";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(558, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Encrypted text";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(558, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Key";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(558, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Plain text";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(286, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 37);
            this.label11.TabIndex = 27;
            this.label11.Text = "Encryption form";
            // 
            // DecryptionButton
            // 
            this.DecryptionButton.Location = new System.Drawing.Point(12, 11);
            this.DecryptionButton.Name = "DecryptionButton";
            this.DecryptionButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptionButton.TabIndex = 28;
            this.DecryptionButton.Text = "Decryption";
            this.DecryptionButton.UseVisualStyleBackColor = true;
            this.DecryptionButton.Click += new System.EventHandler(this.DecryptionButton_Click);
            // 
            // ECBEncryptBT
            // 
            this.ECBEncryptBT.Location = new System.Drawing.Point(558, 473);
            this.ECBEncryptBT.Name = "ECBEncryptBT";
            this.ECBEncryptBT.Size = new System.Drawing.Size(216, 23);
            this.ECBEncryptBT.TabIndex = 59;
            this.ECBEncryptBT.Text = "Encrypt";
            this.ECBEncryptBT.UseVisualStyleBackColor = true;
            this.ECBEncryptBT.Click += new System.EventHandler(this.ECBEncryptBT_Click);
            // 
            // CFBEncryptBT
            // 
            this.CFBEncryptBT.Location = new System.Drawing.Point(286, 473);
            this.CFBEncryptBT.Name = "CFBEncryptBT";
            this.CFBEncryptBT.Size = new System.Drawing.Size(216, 23);
            this.CFBEncryptBT.TabIndex = 58;
            this.CFBEncryptBT.Text = "Encrypt";
            this.CFBEncryptBT.UseVisualStyleBackColor = true;
            this.CFBEncryptBT.Click += new System.EventHandler(this.CFBEncryptBT_Click);
            // 
            // CBCEncryptBT
            // 
            this.CBCEncryptBT.Location = new System.Drawing.Point(12, 473);
            this.CBCEncryptBT.Name = "CBCEncryptBT";
            this.CBCEncryptBT.Size = new System.Drawing.Size(216, 23);
            this.CBCEncryptBT.TabIndex = 57;
            this.CBCEncryptBT.Text = "Encrypt";
            this.CBCEncryptBT.UseVisualStyleBackColor = true;
            this.CBCEncryptBT.Click += new System.EventHandler(this.CBCEncryptBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.ECBEncryptBT);
            this.Controls.Add(this.CFBEncryptBT);
            this.Controls.Add(this.CBCEncryptBT);
            this.Controls.Add(this.DecryptionButton);
            this.Controls.Add(this.label11);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.ECBEncryptedTB);
            this.Controls.Add(this.ECBKeyTB);
            this.Controls.Add(this.ECBTextTB);
            this.Controls.Add(this.CFBEncryptedTB);
            this.Controls.Add(this.CFBIVTB);
            this.Controls.Add(this.CFBKeyTB);
            this.Controls.Add(this.CFBTextTB);
            this.Controls.Add(this.CBCEncryptedTB);
            this.Controls.Add(this.CBCIVTB);
            this.Controls.Add(this.CBCKeyTB);
            this.Controls.Add(this.CBCTextTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox CBCTextTB;
        private TextBox CBCKeyTB;
        private TextBox CBCIVTB;
        private TextBox CBCEncryptedTB;
        private TextBox CFBEncryptedTB;
        private TextBox CFBIVTB;
        private TextBox CFBKeyTB;
        private TextBox CFBTextTB;
        private TextBox ECBEncryptedTB;
        private TextBox ECBKeyTB;
        private TextBox ECBTextTB;
        private Button FileButton;
        private Label label4;
        private Label KeyLabel;
        private Label label5;
        private Label EncryptedLabel;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label11;
        private Button DecryptionButton;
        private Button ECBEncryptBT;
        private Button CFBEncryptBT;
        private Button CBCEncryptBT;
    }
}