using System;
using System.Windows.Forms;
using System.IO;

namespace ImageCryptography
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            DeleteExistingFiles();
        }

        private static void DeleteExistingFiles()
        {
            if (File.Exists("key.txt"))
            {
                File.Delete("key.txt");
                Console.WriteLine("Existing file deleted: key.txt");
            }
            if (File.Exists("receive.txt"))
            {
                File.Delete("receive.txt");
                Console.WriteLine("Existing file deleted: receive.txt");
            }
            if (File.Exists("enc.txt"))
            {
                File.Delete("enc.txt");
                Console.WriteLine("Existing file deleted: enc.txt");
            }
        }
    }
}
