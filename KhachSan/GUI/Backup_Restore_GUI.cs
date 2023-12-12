using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan.GUI
{
    public partial class Backup_Restore_GUI : Form
    {
        public Backup_Restore_GUI()
        {
            InitializeComponent();
        }




         
        private void btn_saoluu_Click_1(object sender, EventArgs e)
        {
            
            string mongodumpPath = @"C:\Program Files\MongoDB\Server\7.0\bin\mongodump.exe";
             
            string backupFolderPath = string.Empty;

            
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    backupFolderPath = folderBrowserDialog.SelectedPath;
                }
                else
                {
                    
                    return;
                }
            }
            List<string> collectionNames = new List<string>
            {
                "ViTriTuyenDung",
                "NhanVienPhongVan"
            };

            try
            {
                
                string backupDirectory = Path.Combine(backupFolderPath, DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                Directory.CreateDirectory(backupDirectory);
                foreach (string collectionName in collectionNames)
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = mongodumpPath;
                    startInfo.Arguments = $"--db TuyenDung --collection {collectionName} --out \"{backupDirectory}\"";

                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.CreateNoWindow = true;

                    using (Process process = Process.Start(startInfo))
                    {
                        process.WaitForExit();

                        if (process.ExitCode == 0)
                        {
                            MessageBox.Show($"Sao lưu collection {collectionName} thành công.");
                        }
                        else
                        {
                            MessageBox.Show($"Sao lưu collection {collectionName} thất bại.");
                        }
                    }
                }

                MessageBox.Show("Hoàn thành sao lưu các collection.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình sao lưu: " + ex.Message);
            }
        }



        private void btn_phuc_hoi_Click_1(object sender, EventArgs e)
        {
            
            string mongorestorePath = @"C:\Program Files\MongoDB\Server\7.0\bin\mongorestore.exe";

           
            string backupFolderPath = string.Empty;

         
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Tệp sao lưu MongoDB (*.bson)|*.bson|Tất cả các tệp (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    backupFolderPath = Path.GetDirectoryName(openFileDialog.FileName);
                }
                else
                { 
                    return;
                }
            }

            try
            {
                
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = mongorestorePath;
                startInfo.Arguments = $"--db TuyenDung --drop \"{backupFolderPath}\"";

                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;

                using (Process process = Process.Start(startInfo))
                {
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        MessageBox.Show("Phục hồi dữ liệu thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Phục hồi dữ liệu thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình phục hồi dữ liệu: " + ex.Message);
            }
        }
    }
}
