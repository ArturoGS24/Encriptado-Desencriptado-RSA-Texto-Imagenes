using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace RSA_Encryption_Decryption
{
    public partial class Form1 : Form
    {

        public static string Message; //text to be encrypted
        public static List<byte[]> Encrypted_Texts_Array = new List<byte[]>(); //store encrypted texts
        private static RSAParameters publicKey;
        private static RSAParameters privateKey;
        string originalText=Message, imgLoc;
        public static string textoDesenciptado = "";

        public enum KeySizes
        {
            SIZE_512 = 512,
            SIZE_1024 = 1024,
            SIZE_2048 = 2048,
            SIZE_952 = 952,
            SIZE_1369 = 1369
        }
        public Form1()
        {
            InitializeComponent();
            File.WriteAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\encrypted.txt", String.Empty);

        }


        //Encrypt Button
        private void EncButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlainTextInput.Text))
            {
                MessageBox.Show("Debe ingresar algo en el campo mensaje");

            }
            else
            {
                Message = PlainTextInput.Text;
                StartEncrypto(Message);

                string fileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\encrypted.txt";

                using (StreamReader streamReader = File.OpenText(fileName))
                {
                    string text = streamReader.ReadToEnd();
                    Console.WriteLine(text);
                    CipherText.Text = text;
                }

                //imprimir llaves publica y privada
                txtCPublic.Text = KeyToString(publicKey);
                txtCPrivada.Text = KeyToString(privateKey);
            }

        }
        //Decrypt Button
        private void DecButton_Click(object sender, EventArgs e)
        {
            PlainTextOutput.Text = "";
            textoDesenciptado = "";
            StartDecrypto();
            PlainTextOutput.Text = textoDesenciptado;

        }
        //Method for Encryption
        static void StartEncrypto(string x)
        {

            //get text size
            int Text_Size = System.Text.ASCIIEncoding.ASCII.GetByteCount(x);
            Console.WriteLine("Text Size: " + Text_Size + " bytes");

            generateKeys();

            //encrypt message in chunks of 250 bytes then store result in file, separated by line breaks
            File.WriteAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\encrypted.txt", "");
            int Chunk_Size = 199;

            for (int i = 0; i < Math.Ceiling(Text_Size / (Chunk_Size * 1.0)); i++)
            {
                try
                {
                    byte[] Encrypted_Text = Encrypt(Encoding.UTF8.GetBytes(x.Substring(i * Chunk_Size, Chunk_Size)));

                    File.AppendAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\encrypted.txt", Convert.ToBase64String(Encrypted_Text) + "\n");

                    Encrypted_Texts_Array.Add(Encrypted_Text);
                }
                catch (System.Exception)
                {
                    byte[] Encrypted_Text = Encrypt(Encoding.UTF8.GetBytes(x.Substring(i * Chunk_Size)));

                    File.AppendAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\encrypted.txt", Convert.ToBase64String(Encrypted_Text) + "\n");

                    Encrypted_Texts_Array.Add(Encrypted_Text);
                }
            }

            Console.WriteLine("Encrypted data written to file\n");
        }

        //Method for Decryption
        static void StartDecrypto()
        {

            List<byte[]> Decrypted_Texts = new List<byte[]>();

            //read encrypted data from file line by line and decrypt it
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\encrypted.txt");

            while ((line = file.ReadLine()) != null)
            {
                byte[] from_file = Convert.FromBase64String(line);
                byte[] decrypted = Decrypt(from_file);

                Decrypted_Texts.Add(decrypted);
            }
            file.Close();

            foreach (var chunk in Decrypted_Texts)
            {
                textoDesenciptado += (Encoding.UTF8.GetString(chunk));
            }
        }

        static void generateKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false; //Don't store the keys in a key container
                publicKey = rsa.ExportParameters(false);
                privateKey = rsa.ExportParameters(true);

                //store the keys in file
                File.WriteAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\pubKey.xml", KeyToString(publicKey));
                File.WriteAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\priKey.xml", KeyToString(privateKey));

                Console.WriteLine("Keys writen to file\n");
            }
        }

        static byte[] Encrypt(byte[] input)
        {
            byte[] encrypted;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;

                //get public key from file
                rsa.ImportParameters(StringToKey(File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\pubKey.xml")));

                try
                {
                    encrypted = rsa.Encrypt(input, true);
                    return encrypted;
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e);
                    byte[] empty = { };
                    return empty;
                }

            }
        }


        static byte[] Decrypt(byte[] input)
        {
            byte[] decrypted;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;

                //get private key from file
                rsa.ImportParameters(StringToKey(File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\priKey.xml")));

                try
                {
                    decrypted = rsa.Decrypt(input, true);
                    return decrypted;
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e);
                    byte[] empty = { };
                    return empty;
                }

            }

        }

        //converting the public key into a string representation
        static string KeyToString(RSAParameters key)
        {
            //we need some buffer
            var sw = new System.IO.StringWriter();
            //we need a serializer
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            //serialize the key into the stream
            xs.Serialize(sw, key);
            //get the string from the stream

            return sw.ToString();
        }

        static RSAParameters StringToKey(string stringkey)
        {
            //get a stream from the string
            var sr = new System.IO.StringReader(stringkey);
            //we need a deserializer
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            //get the object back from the stream

            return (RSAParameters)xs.Deserialize(sr);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            txtStringImg.Text = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    imgLoc = imageLocation;
                    pbImage.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncImg_Click(object sender, EventArgs e)
        {
            pbImage.ImageLocation = "";
            Message = "";
            Encrypted_Texts_Array.Clear();
            textoDesenciptado = "";

            //pbImage.ImageLocation
            using (Image image = Image.FromFile(imgLoc))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);

                    Message = base64String;
                    StartEncrypto(Message);

                    string fileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\encrypted.txt";

                    using (StreamReader streamReader = File.OpenText(fileName))
                    {
                        string text = streamReader.ReadToEnd();
                        Console.WriteLine(text);
                        txtStringImg.Text = text;
                    }

                    //imprimir llaves publica y privada
                    txtCPublic.Text = KeyToString(publicKey);
                    txtCPrivada.Text = KeyToString(privateKey);

                }
            }
        }

        private void PlainTextInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlainTextOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //rbTexto
            PlainTextInput.Text = "";
            PlainTextOutput.Text = "";
            CipherText.Text = "";
            txtCPublic.Text = "";
            txtCPrivada.Text = "";
            btnEncImg.Enabled = false;
            btnSelectImage.Enabled = false;
            button1.Enabled = false;
            btnDesImg.Enabled = false;

            EncButton.Enabled = true;
            DecButton.Enabled = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //rbImage
            PlainTextInput.Text = "";
            PlainTextOutput.Text = "";
            CipherText.Text = "";
            txtCPublic.Text = "";
            txtCPrivada.Text = "";
            EncButton.Enabled = false;
            DecButton.Enabled = false;

            btnEncImg.Enabled = true;
            btnSelectImage.Enabled = true;
            button1.Enabled = true;
            btnDesImg.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textoDesenciptado = "";
            StartDecrypto();
            PlainTextOutput.Text = textoDesenciptado;
            txtStringImg.Text = "";
        }

        private void btnEncPass_Click(object sender, EventArgs e)
        {
            if (ContrasenaSegura(txtPassword.Text) == true)
            {

                Message = txtPassword.Text;
                StartEncrypto(Message);

                string fileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\encrypted.txt";

                using (StreamReader streamReader = File.OpenText(fileName))
                {
                    string text = streamReader.ReadToEnd();
                    Console.WriteLine(text);
                    CipherText.Text = text;
                }

                //imprimir llaves publica y privada
                txtCPublic.Text = KeyToString(publicKey);
                txtCPrivada.Text = KeyToString(privateKey);
            }
            else{ MessageBox.Show("La contraseña no es segura"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(PlainTextOutput.Text)));
            pbImg2.Image = img;
        }

        public Boolean ContrasenaSegura(String contraseñaSinVerificar)
        {
            //letras de la a a la z,  minusculas
            Regex letrasMin = new Regex(@"[a-z]");
            //letras de la A a la Z, mayusculas y minusculas
            Regex letrasMay = new Regex(@"[A-Z]");
            //digitos del 0 al 9
            Regex numeros = new Regex(@"[0-9]");
            //cualquier caracter del conjunto
            Regex caracEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");

            //Boolean cumpleCriterios = false;

            //si no contiene las letras min, regresa false
            if (!letrasMin.IsMatch(contraseñaSinVerificar))
            {
                return false;
            }
            //si no contiene las letras may, regresa false
            if (!letrasMay.IsMatch(contraseñaSinVerificar))
            {
                return false;
            }
            if (contraseñaSinVerificar.Length<8 && contraseñaSinVerificar.Length > 50)
            {
                return false;
            }
            //si no contiene los numeros, regresa false
            if (!numeros.IsMatch(contraseñaSinVerificar))
            {
                return false;
            }

            //si no contiene los caracteres especiales, regresa false
            if (!caracEsp.IsMatch(contraseñaSinVerificar))
            {
                return false;
            }

            //si cumple con todo, regresa true
            return true;
}
    }
            

            
}

