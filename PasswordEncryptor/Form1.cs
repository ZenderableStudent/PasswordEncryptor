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
using System.Windows;
using System.Security.Cryptography;

namespace PasswordEncryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxZaszyfrowany_TextChanged(object sender, EventArgs e)
        {

        }

        string publicKeySaveText = "";
        string privateKeySaveText = "";
        string encryptedPasswordSaveText = "";

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            var cryptoServiceProvider = new RSACryptoServiceProvider(2048); //2048 - Długość klucza
            var privateKey = cryptoServiceProvider.ExportParameters(true); //Generowanie klucza prywatnego
            var publicKey = cryptoServiceProvider.ExportParameters(false); //Generowanie klucza publiczny

            string publicKeyString = AssymetricEncryption.GetKeyString(publicKey);
            string privateKeyString = AssymetricEncryption.GetKeyString(privateKey);


            publicKeyTestBox.Text = publicKeyString;
            privateKeyTestBox.Text = privateKeyString;

            publicKeySaveText = publicKeyString;
            privateKeySaveText = privateKeyString;

            string textToEncrypt = passwordToEncrypt.Text;
            string encryptedText = AssymetricEncryption.Encrypt(textToEncrypt, publicKeyString); //Szyfrowanie za pomocą klucza publicznego
            encryptedPassword.Text = encryptedText;
            encryptedPasswordSaveText = encryptedText;
            string decryptedText = AssymetricEncryption.Decrypt(encryptedText, privateKeyString); //Odszyfrowywanie za pomocą klucza prywatnego
            decryptedPassword.Text = decryptedText;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            passwordToEncrypt.Clear();
            encryptedPassword.Clear();
            decryptedPassword.Clear();
            publicKeyTestBox.Clear();
            privateKeyTestBox.Clear();
        }

        private void saveToFile(String text, String fileName)
        {
            // Set a variable to the Documents path.
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName)))
            {
                outputFile.WriteLine(text);
            }
        }

        private void publicKeySave_Click(object sender, EventArgs e)
        {
            saveToFile(publicKeySaveText, "publicKey.txt");
        }

        private void privateKeySave_Click(object sender, EventArgs e)
        {
            saveToFile(privateKeySaveText, "privateKey.txt");
        }

        private void passwordSave_Click(object sender, EventArgs e)
        {
            saveToFile(encryptedPasswordSaveText, "encryptedPassword.txt");
        }
    }
}
