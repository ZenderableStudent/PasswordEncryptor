
namespace PasswordEncryptor
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

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordToEncrypt = new System.Windows.Forms.TextBox();
            this.encryptedPassword = new System.Windows.Forms.TextBox();
            this.decryptedPassword = new System.Windows.Forms.TextBox();
            this.encryptPasswordButton = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.encryptedLabel = new System.Windows.Forms.Label();
            this.decryptedLabel = new System.Windows.Forms.Label();
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.privateKeyLabel = new System.Windows.Forms.Label();
            this.publicKeyTestBox = new System.Windows.Forms.TextBox();
            this.privateKeyTestBox = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.publicKeySave = new System.Windows.Forms.Button();
            this.privateKeySave = new System.Windows.Forms.Button();
            this.passwordSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(230, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(267, 15);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "PasswordEncryptor - assymetric encryption (RSA)";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(230, 41);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(118, 15);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Write your password:";
            // 
            // passwordToEncrypt
            // 
            this.passwordToEncrypt.Location = new System.Drawing.Point(233, 60);
            this.passwordToEncrypt.Name = "passwordToEncrypt";
            this.passwordToEncrypt.PasswordChar = '*';
            this.passwordToEncrypt.Size = new System.Drawing.Size(230, 23);
            this.passwordToEncrypt.TabIndex = 11;
            // 
            // encryptedPassword
            // 
            this.encryptedPassword.Location = new System.Drawing.Point(233, 102);
            this.encryptedPassword.Name = "encryptedPassword";
            this.encryptedPassword.Size = new System.Drawing.Size(230, 23);
            this.encryptedPassword.TabIndex = 12;
            // 
            // decryptedPassword
            // 
            this.decryptedPassword.Location = new System.Drawing.Point(233, 144);
            this.decryptedPassword.Name = "decryptedPassword";
            this.decryptedPassword.Size = new System.Drawing.Size(230, 23);
            this.decryptedPassword.TabIndex = 13;
            // 
            // encryptPasswordButton
            // 
            this.encryptPasswordButton.Location = new System.Drawing.Point(233, 262);
            this.encryptPasswordButton.Name = "encryptPasswordButton";
            this.encryptPasswordButton.Size = new System.Drawing.Size(230, 32);
            this.encryptPasswordButton.TabIndex = 14;
            this.encryptPasswordButton.Text = "Encrypt your password";
            this.encryptPasswordButton.UseVisualStyleBackColor = true;
            this.encryptPasswordButton.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(510, 370);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(164, 29);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.close_button_Click);
            // 
            // encryptedLabel
            // 
            this.encryptedLabel.AutoSize = true;
            this.encryptedLabel.Location = new System.Drawing.Point(230, 83);
            this.encryptedLabel.Name = "encryptedLabel";
            this.encryptedLabel.Size = new System.Drawing.Size(63, 15);
            this.encryptedLabel.TabIndex = 16;
            this.encryptedLabel.Text = "Encrypted:";
            // 
            // decryptedLabel
            // 
            this.decryptedLabel.AutoSize = true;
            this.decryptedLabel.Location = new System.Drawing.Point(232, 126);
            this.decryptedLabel.Name = "decryptedLabel";
            this.decryptedLabel.Size = new System.Drawing.Size(64, 15);
            this.decryptedLabel.TabIndex = 17;
            this.decryptedLabel.Text = "Decrypted:";
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Location = new System.Drawing.Point(232, 168);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(65, 15);
            this.publicKeyLabel.TabIndex = 18;
            this.publicKeyLabel.Text = "Public Key:";
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Location = new System.Drawing.Point(230, 215);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(68, 15);
            this.privateKeyLabel.TabIndex = 19;
            this.privateKeyLabel.Text = "Private Key:";
            // 
            // publicKeyTestBox
            // 
            this.publicKeyTestBox.Location = new System.Drawing.Point(233, 187);
            this.publicKeyTestBox.Name = "publicKeyTestBox";
            this.publicKeyTestBox.Size = new System.Drawing.Size(230, 23);
            this.publicKeyTestBox.TabIndex = 20;
            // 
            // privateKeyTestBox
            // 
            this.privateKeyTestBox.Location = new System.Drawing.Point(233, 233);
            this.privateKeyTestBox.Name = "privateKeyTestBox";
            this.privateKeyTestBox.Size = new System.Drawing.Size(230, 23);
            this.privateKeyTestBox.TabIndex = 21;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(510, 334);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(164, 29);
            this.buttonClear.TabIndex = 24;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // publicKeySave
            // 
            this.publicKeySave.Location = new System.Drawing.Point(233, 300);
            this.publicKeySave.Name = "publicKeySave";
            this.publicKeySave.Size = new System.Drawing.Size(230, 27);
            this.publicKeySave.TabIndex = 25;
            this.publicKeySave.Text = "Save public key to file";
            this.publicKeySave.UseVisualStyleBackColor = true;
            this.publicKeySave.Click += new System.EventHandler(this.publicKeySave_Click);
            // 
            // privateKeySave
            // 
            this.privateKeySave.Location = new System.Drawing.Point(233, 334);
            this.privateKeySave.Name = "privateKeySave";
            this.privateKeySave.Size = new System.Drawing.Size(230, 29);
            this.privateKeySave.TabIndex = 26;
            this.privateKeySave.Text = "Save private key to file";
            this.privateKeySave.UseVisualStyleBackColor = true;
            this.privateKeySave.Click += new System.EventHandler(this.privateKeySave_Click);
            // 
            // passwordSave
            // 
            this.passwordSave.Location = new System.Drawing.Point(233, 370);
            this.passwordSave.Name = "passwordSave";
            this.passwordSave.Size = new System.Drawing.Size(230, 29);
            this.passwordSave.TabIndex = 27;
            this.passwordSave.Text = "Save encrypted password to file";
            this.passwordSave.UseVisualStyleBackColor = true;
            this.passwordSave.Click += new System.EventHandler(this.passwordSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.passwordSave);
            this.Controls.Add(this.privateKeySave);
            this.Controls.Add(this.publicKeySave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.privateKeyTestBox);
            this.Controls.Add(this.publicKeyTestBox);
            this.Controls.Add(this.privateKeyLabel);
            this.Controls.Add(this.publicKeyLabel);
            this.Controls.Add(this.decryptedLabel);
            this.Controls.Add(this.encryptedLabel);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.encryptPasswordButton);
            this.Controls.Add(this.decryptedPassword);
            this.Controls.Add(this.encryptedPassword);
            this.Controls.Add(this.passwordToEncrypt);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Password encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordToEncrypt;
        private System.Windows.Forms.TextBox encryptedPassword;
        private System.Windows.Forms.TextBox decryptedPassword;
        private System.Windows.Forms.Button encryptPasswordButton;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label encryptedLabel;
        private System.Windows.Forms.Label decryptedLabel;
        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.Label privateKeyLabel;
        private System.Windows.Forms.TextBox publicKeyTestBox;
        private System.Windows.Forms.TextBox privateKeyTestBox;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button publicKeySave;
        private System.Windows.Forms.Button privateKeySave;
        private System.Windows.Forms.Button passwordSave;
    }
}
