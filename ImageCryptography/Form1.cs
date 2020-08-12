using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace ImageCryptography
{

    public partial class Form1 : Form
    {
        static int RSA_P = 0;
        static int RSA_Q = 0; 
        static int RSA_E = 0;
        static int d = 0;
        static int n = 0;
        static string loadImage = "";
        static string loadcipher = "";


        public Form1()
        {
            InitializeComponent();
        }

        public string GetIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Disable_all();
            groupBox6.Hide();
            storeEnc_btn.Enabled = false;
            encryptImage_btn.Enabled = false;
            send_btn.Enabled = false;
            saveImage_txt.Enabled = false;
            selectEncImage_btn.Enabled = false;
        }

        // Function to encrypt the image
        public string Encrypt(string imageToEncrypt)
        {
            MessageBox.Show("RSA_E = " + RSA_E + "\nn = " + n);
            string hex = imageToEncrypt;
            char[] ar = hex.ToCharArray();
            String c = "";
            progressBar1.Maximum = ar.Length;
             for (int i = 0; i < ar.Length; i++)
             {
                Application.DoEvents();
                progressBar1.Value = i;
                if (c == "")
                   c = c + ImageCrypto.RSAalgorithm.BigMod(ar[i], RSA_E, n);
                else
                   c = c + "-" + ImageCrypto.RSAalgorithm.BigMod(ar[i], RSA_E, n);
             }
             return c;
        }

        // Function to decrypt the image
        public string Decrypt(String  imageToDecrypt)
        {
                char[] ar = imageToDecrypt.ToCharArray();
                int i = 0, j = 0;
                string c = "", dc = "";
                progressBar2.Maximum = ar.Length;
                try
                {
                    for (; i < ar.Length; i++)
                    {
                        Application.DoEvents();
                        c = "";
                        progressBar2.Value = i;
                        for (j = i; ar[j] != '-'; j++)
                            c = c + ar[j];
                        i = j;

                        int xx = Convert.ToInt32(c);
                        dc = dc + ((char)ImageCrypto.RSAalgorithm.BigMod(xx, d, n)).ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            return dc;
        }

        // Send public Key button Click event
        private void SendPublicKey(object sender, EventArgs e)
        {
            string ip = GetIP();
            selectEncImage_btn.Enabled = true;

            if (sendPublicKey_btn.Text== "Send Public Key")
            {
                if (primeNumber1_txt.Text == "" || primeNumber2_txt.Text == "" || numberE_txt.Text == "")
                {
                    MessageBox.Show("Enter Valid Details For RSA", "ERROR");
                }

                else
                {
                    if (ImageCrypto.library.IsPrime(Convert.ToInt16(primeNumber1_txt.Text)))
                    {
                        RSA_P = Convert.ToInt16(primeNumber1_txt.Text);
                    }
                    else
                    {
                        primeNumber1_txt.Text = "";
                        MessageBox.Show("Enter Prime Number");
                        return;
                    }
                    if (ImageCrypto.library.IsPrime(Convert.ToInt16(primeNumber2_txt.Text)))
                    {
                        RSA_Q = Convert.ToInt16(primeNumber2_txt.Text);
                    }
                    else
                    {
                        primeNumber2_txt.Text = "";
                        MessageBox.Show("Enter Prime Number");
                        return;
                    }

                    RSA_E = Convert.ToInt16(numberE_txt.Text);

                    //  Calculating Private Key
                    n = ImageCrypto.RSAalgorithm.n_value(RSA_P, RSA_Q);
                    int phi = ImageCrypto.RSAalgorithm.cal_phi(RSA_P, RSA_Q);
                    d = ImageCrypto.RSAalgorithm.cal_privateKey(phi, RSA_E, n);
                    MessageBox.Show("Please Connect to the server IP : " + ip + "\nPublic Key = (" + RSA_E + " ," + n + ")\nPrivate Key = (" + d + "," + n + ")", "Alert");

                    primeNumber1_txt.Enabled = false;
                    primeNumber2_txt.Enabled = false;
                    numberE_txt.Enabled = false;
                    storeEnc_btn.Enabled = true;
                    saveImage_btn.Enabled = true;
                    saveImage_txt.Enabled = true;
                    sendPublicKey_btn.Text = "Receive";


                    // Sending Public key
                    try
                    {
                        string cmdText = "python sendTest.py " + ip + " " + RSA_E + " " + n;

                        Console.WriteLine(cmdText);

                        Process process = new Process();
                        process.StartInfo.FileName = "cmd.exe";
                        process.StartInfo.CreateNoWindow = true;
                        process.StartInfo.RedirectStandardInput = true;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.StartInfo.UseShellExecute = false;
                        process.Start();
                        process.StandardInput.WriteLine(cmdText);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        Console.WriteLine(process.StandardOutput.ReadToEnd());
                        process.WaitForExit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error while sending public key!");
                    }

                }
            }
            else
            {
                // Receiving Public Key
                try
                {
                    MessageBox.Show("Server IP = " + ip.ToString());
                    string cmdText = "python server.py " + ip;
                    Console.WriteLine(cmdText);

                    Process process = new Process();
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.Start();
                    process.StandardInput.WriteLine(cmdText);
                    process.StandardInput.Flush();
                    process.StandardInput.Close();
                    process.WaitForExit();
                    Console.WriteLine(process.StandardOutput.ReadToEnd());
                    MessageBox.Show("Encrypted file received and stored as receive.txt","Alert");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error while receiving public key!");
                }
            }

        }

        // Encrypt image button
        private void EncryptImage(object sender, EventArgs e)
        {
            try
            {
                selectImage_btn.Enabled = false;
                Disable_all();
                String en = Encrypt(loadImage);
                File.WriteAllText("enc.txt", en);
                MessageBox.Show("Encryption Done");
                selectImage_btn.Enabled = true;
                send_btn.Enabled = true;
                Enable_all();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error while encrypting image");
            }
        }

        // Decrypt Image button Click event
        private void DecryptImage(object sender, EventArgs e)
        {
            Disable_all();
            try
            {
                String de = Decrypt(loadcipher);
                pictureBox1.Image = ImageCrypto.library.ConvertByteToImage(ImageCrypto.library.DecodeHex(de));
                FileInfo fi = new FileInfo(saveImage_txt.Text);

                label9.Text = "File Name: " + fi.Name;
                label10.Text = "Image Resolution: " + pictureBox1.Image.PhysicalDimension.Height + " X " + pictureBox1.Image.PhysicalDimension.Width;


                pictureBox1.Image.Save(saveImage_txt.Text, System.Drawing.Imaging.ImageFormat.Jpeg);
                double imageMB = (fi.Length / 1024f) / 1024f;
                label11.Text = "Image Size: " + imageMB.ToString(".##") + "MB";
                MessageBox.Show("Image decrypted and Saved");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        // Load Image button event
        private void LoadImage(object sender, EventArgs e)
        {
            loadImage =  BitConverter.ToString(ImageCrypto.library.ConvertImageToByte(pictureBox1.Image));
            MessageBox.Show("Image Load Successfully");
            groupBox4.Enabled = true;
            storeEnc_btn.Enabled = true;
            encryptImage_btn.Enabled = true;

        }

        private void StoreEnc(object sender, EventArgs e)
        {
            SaveFileDialog save1 = new SaveFileDialog();
            save1.Filter = "TEXT|*.txt";
            if (save1.ShowDialog() == DialogResult.OK)
            {
                storeEnc_txt.Text = save1.FileName;
                encryptImage_btn.Enabled = true;
            }
            else
            {
                storeEnc_txt.Text = "";
                encryptImage_btn.Enabled = false;
            }
        }

        private void SelectImage(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Filter = "JPG|*.JPG";
            if (open1.ShowDialog() == DialogResult.OK)
            {
                selectImage_txt.Text = open1.FileName;
                pictureBox1.Image = Image.FromFile(selectImage_txt.Text);
                loadImage_btn.Enabled = true;
                FileInfo fi = new FileInfo(selectImage_txt.Text);

                label9.Text = "File Name: " + fi.Name;
                label10.Text = "Image Resolution: " + pictureBox1.Image.PhysicalDimension.Height + " X " + pictureBox1.Image.PhysicalDimension.Width;

                double imageMB = ((fi.Length / 1024f) / 1024f);                

                label11.Text = "Image Size: " + imageMB.ToString(".##") + "MB";
            }
            else
            {
                selectImage_txt.Text = "";
                label9.Text = "File Name: ";
                label10.Text = "Image Resolution: ";
                label11.Text = "Image Size: ";

                pictureBox1.Image = Properties.Resources.blank;
                loadImage_btn.Enabled = false;
                
            }
        }

        private void Disable_all()
        {            
            loadImage_btn.Enabled = false;
            loadEncImage_btn.Enabled = false;
            saveImage_btn.Enabled = false;
            decryptImage_btn.Enabled = false;
        }

        private void Enable_all()
        {
            selectImage_btn.Enabled = true;
            loadImage_btn.Enabled = true;
            groupBox4.Enabled = true;
            storeEnc_btn.Enabled = true;
            encryptImage_btn.Enabled = true;
            send_btn.Enabled = true;
        }

        private void SelectEncImage(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Filter = "TEXT|*.txt";
            if (open1.ShowDialog() == DialogResult.OK)
            {
                selectEncImage_txt.Text = open1.FileName;
                selectImage_txt.Text = open1.FileName;
                loadEncImage_btn.Enabled = true;
            }
            else
            {
                selectEncImage_txt.Text = "";
                loadEncImage_btn.Enabled = false;
            }
        }

        private void LoadEncimage(object sender, EventArgs e)
        {   
            loadcipher = File.ReadAllText(selectImage_txt.Text);
            MessageBox.Show("Load Cipher Successfully");
            groupBox5.Enabled = true;
            groupBox4.Enabled = true;
            saveImage_btn.Enabled = true;

        }

        private void SaveImage(object sender, EventArgs e)
        {
            SaveFileDialog save1 = new SaveFileDialog();
            save1.Filter = "JPG|*.JPG";
            if (save1.ShowDialog() == DialogResult.OK)
            {
                saveImage_txt.Text = save1.FileName;
                decryptImage_btn.Enabled = true;
            }
            else
            {
                saveImage_txt.Text = "";
                decryptImage_btn.Enabled = false;
            }
        }

        // Send Encrypted image button event
        private void Send(object sender, EventArgs e)
        {
            try
            {
                string ip = getPublicIP_txt.Text;
                string fn = System.IO.Path.GetFullPath(storeEnc_txt.Text);

                //call client.py
                string cmdText = "python client.py " + ip + " enc.txt";
                MessageBox.Show(fn, "Sending file name");

                Console.WriteLine(cmdText);

                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
                process.StandardInput.WriteLine(cmdText);
                process.StandardInput.Flush();
                process.StandardInput.Close();
                Console.WriteLine(process.StandardOutput.ReadToEnd());
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Get Public Key event
        private void GetPublicKey(object sender, EventArgs e)
        {
            try
            {
                string ip = getPublicIP_txt.Text;
                string cmdText = "python recTest.py " +  ip ;
                label12.Text = "Recceiver's IP = " + ip ;

                Console.WriteLine(cmdText);

                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
                process.StandardInput.WriteLine(cmdText);
                process.StandardInput.Flush();
                process.StandardInput.Close();
                Console.WriteLine(process.StandardOutput.ReadToEnd());
                process.WaitForExit();

                //Read Public Key
                string Keys = File.ReadAllText("Key.txt");
                MessageBox.Show(Keys, "Keys");
                string[] PubKeys = Keys.Split('+');
                Int32.TryParse(PubKeys[0], out RSA_E);
                Int32.TryParse(PubKeys[1], out n);
                lbl_pubKey.Text = ("("+RSA_E+","+ n + ")");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetPublicIP(object sender, MouseEventArgs e)
        {
            getPublicIP_txt.Text = "";
        }

        private void CreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox6.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreditDone(object sender, EventArgs e)
        {
            groupBox6.Hide();
        }
    }
}
