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
            disable_all();
            groupBox6.Hide();
            button4.Enabled = false;
            button5.Enabled = false;
            button11.Enabled = false;
            txt_strDec.Enabled = false;
            button10.Enabled = false;
        }

        // Function to encrypt the image
        public string encrypt(string imageToEncrypt)
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
        public string decrypt(String  imageToDecrypt)
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
        private void button3_Click(object sender, EventArgs e)
        {
            string ip = GetIP();
            button10.Enabled = true;

            if (btn_sendKey.Text== "Send Public Key")
            {
                if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Enter Valid Details For RSA", "ERROR");
                }

                else
                {
                    if (ImageCrypto.library.IsPrime(Convert.ToInt16(textBox2.Text)))
                    {
                        RSA_P = Convert.ToInt16(textBox2.Text);
                    }
                    else
                    {
                        textBox2.Text = "";
                        MessageBox.Show("Enter Prime Number");
                        return;
                    }
                    if (ImageCrypto.library.IsPrime(Convert.ToInt16(textBox3.Text)))
                    {
                        RSA_Q = Convert.ToInt16(textBox3.Text);
                    }
                    else
                    {
                        textBox3.Text = "";
                        MessageBox.Show("Enter Prime Number");
                        return;
                    }

                    RSA_E = Convert.ToInt16(textBox4.Text);

                    //  Calculating Private Key
                    n = ImageCrypto.RSAalgorithm.n_value(RSA_P, RSA_Q);
                    int phi = ImageCrypto.RSAalgorithm.cal_phi(RSA_P, RSA_Q);
                    d = ImageCrypto.RSAalgorithm.cal_privateKey(phi, RSA_E, n);
                    MessageBox.Show("Please Connect to the server IP : " + ip + "\nPublic Key = (" + RSA_E + " ," + n + ")\nPrivate Key = (" + d + "," + n + ")", "Alert");

                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button4.Enabled = true;
                    button7.Enabled = true;
                    txt_strDec.Enabled = true;
                    btn_sendKey.Text = "Receive";


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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;
                disable_all();
                String en = encrypt(loadImage);
                File.WriteAllText(textBox5.Text, en);
                MessageBox.Show("Encryption Done");
                button1.Enabled = true;
                button11.Enabled = true;
                enable_all();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Decrypt Image button Click event
        private void button6_Click(object sender, EventArgs e)
        {
            disable_all();
            try
            {
                String de = decrypt(loadcipher);
                pictureBox1.Image = ImageCrypto.library.ConvertByteToImage(ImageCrypto.library.DecodeHex(de));
                FileInfo fi = new FileInfo(txt_strDec.Text);

                label9.Text = "File Name: " + fi.Name;
                label10.Text = "Image Resolution: " + pictureBox1.Image.PhysicalDimension.Height + " X " + pictureBox1.Image.PhysicalDimension.Width;


                pictureBox1.Image.Save(txt_strDec.Text, System.Drawing.Imaging.ImageFormat.Jpeg);
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
        private void button2_Click(object sender, EventArgs e)
        {
            loadImage =  BitConverter.ToString(ImageCrypto.library.ConvertImageToByte(pictureBox1.Image));
            MessageBox.Show("Image Load Successfully");
            groupBox4.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save1 = new SaveFileDialog();
            save1.Filter = "TEXT|*.txt";
            if (save1.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = save1.FileName;
                button5.Enabled = true;
            }
            else
            {
                textBox5.Text = "";
                button5.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Filter = "JPG|*.JPG";
            if (open1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open1.FileName;
                pictureBox1.Image = Image.FromFile(textBox1.Text);
                button2.Enabled = true;
                FileInfo fi = new FileInfo(textBox1.Text);

                label9.Text = "File Name: " + fi.Name;
                label10.Text = "Image Resolution: " + pictureBox1.Image.PhysicalDimension.Height + " X " + pictureBox1.Image.PhysicalDimension.Width;

                double imageMB = ((fi.Length / 1024f) / 1024f);                

                label11.Text = "Image Size: " + imageMB.ToString(".##") + "MB";
            }
            else
            {
                textBox1.Text = "";
                label9.Text = "File Name: ";
                label10.Text = "Image Resolution: ";
                label11.Text = "Image Size: ";

                pictureBox1.Image = Properties.Resources.blank;
                button2.Enabled = false;
                
            }
        }

        private void disable_all()
        {            
            button2.Enabled = false;
            btn_loadDec.Enabled = false;
            button7.Enabled = false;
            btn_decrypt.Enabled = false;
        }

        private void enable_all()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            groupBox4.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button11.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Filter = "TEXT|*.txt";
            if (open1.ShowDialog() == DialogResult.OK)
            {
                textBox7.Text = open1.FileName;
                textBox1.Text = open1.FileName;
                btn_loadDec.Enabled = true;
            }
            else
            {
                textBox7.Text = "";
                btn_loadDec.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {   
            loadcipher = File.ReadAllText(textBox1.Text);
            MessageBox.Show("Load Cipher Successfully");
            groupBox5.Enabled = true;
            groupBox4.Enabled = true;
            button7.Enabled = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog save1 = new SaveFileDialog();
            save1.Filter = "JPG|*.JPG";
            if (save1.ShowDialog() == DialogResult.OK)
            {
                txt_strDec.Text = save1.FileName;
                btn_decrypt.Enabled = true;
            }
            else
            {
                txt_strDec.Text = "";
                btn_decrypt.Enabled = false;
            }
        }

        // Send Encrypted image button event
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = textBox6.Text;
                string fn = System.IO.Path.GetFullPath(textBox5.Text);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Receive encrypted image button event
        private void button12_Click(object sender, EventArgs e)
        {
            string ip = GetIP();

            try {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occurred while Receiving encypted image");
            }

        }

        // Get Public Key event
        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ip = textBox6.Text;
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

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6.Text = "";
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox6.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            groupBox6.Hide();
        }
    }
}
