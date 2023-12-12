
using KhachSan.DTO;
using KhachSan.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhachSan.DAO;
using MongoDB.Driver;

namespace KhachSan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //IAsyncCursor<ViTriTuyenDung> ts = (IAsyncCursor<ViTriTuyenDung>)Access.Test("ViTriTuyenDung");
            //ts.MoveNextAsync();
            //foreach (ViTriTuyenDung t in ts.Current)
            //{
            //    MessageBox.Show(t.ToString());
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DangNhap_GUI());
        }
    }
}
