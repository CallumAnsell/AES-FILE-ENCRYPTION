namespace AES_FILE_ENCRYPTION
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnOpnFileDiag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkPassChar = new System.Windows.Forms.CheckBox();
            this.WrkerEncryption = new System.ComponentModel.BackgroundWorker();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.WrkerDecryption = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDirectory
            // 
            this.txtDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectory.Location = new System.Drawing.Point(577, 38);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(773, 57);
            this.txtDirectory.TabIndex = 0;
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
            // 
            // btnOpnFileDiag
            // 
            this.btnOpnFileDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpnFileDiag.Location = new System.Drawing.Point(1413, 33);
            this.btnOpnFileDiag.Name = "btnOpnFileDiag";
            this.btnOpnFileDiag.Size = new System.Drawing.Size(339, 82);
            this.btnOpnFileDiag.TabIndex = 1;
            this.btnOpnFileDiag.Text = "Choose file";
            this.btnOpnFileDiag.UseVisualStyleBackColor = true;
            this.btnOpnFileDiag.Click += new System.EventHandler(this.btnOpnFileDiag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose an input file.";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(299, 259);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(477, 106);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "ENCRYPT";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(1008, 259);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(477, 106);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "DECRYPT";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter a password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(577, 125);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(773, 57);
            this.txtPassword.TabIndex = 5;
            // 
            // chkPassChar
            // 
            this.chkPassChar.AutoSize = true;
            this.chkPassChar.Checked = true;
            this.chkPassChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPassChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPassChar.Location = new System.Drawing.Point(1387, 135);
            this.chkPassChar.Name = "chkPassChar";
            this.chkPassChar.Size = new System.Drawing.Size(382, 56);
            this.chkPassChar.TabIndex = 7;
            this.chkPassChar.Text = "Show password";
            this.chkPassChar.UseVisualStyleBackColor = true;
            this.chkPassChar.CheckedChanged += new System.EventHandler(this.chkPassChar_CheckedChanged);
            // 
            // WrkerEncryption
            // 
            this.WrkerEncryption.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WrkerEncryption_DoWork);
            this.WrkerEncryption.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WrkerEncryption_RunWorkerCompleted);
            // 
            // picLoading
            // 
            this.picLoading.Image = ((System.Drawing.Image)(resources.GetObject("picLoading.Image")));
            this.picLoading.Location = new System.Drawing.Point(1580, 259);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(206, 157);
            this.picLoading.TabIndex = 8;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // WrkerDecryption
            // 
            this.WrkerDecryption.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WrkerDecryption_DoWork);
            this.WrkerDecryption.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WrkerDecryption_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 454);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.chkPassChar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpnFileDiag);
            this.Controls.Add(this.txtDirectory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AES FILE ENCRYPTION";
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnOpnFileDiag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkPassChar;
        private System.ComponentModel.BackgroundWorker WrkerEncryption;
        private System.Windows.Forms.PictureBox picLoading;
        private System.ComponentModel.BackgroundWorker WrkerDecryption;
    }
}

