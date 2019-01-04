using StartHub.Controls;
using StartHub.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartHub
{
    public partial class MainScreen : Form
    {
        private int lineCount = -1;
        private int fileInt = 0;
        private List<ProgramContainer> list = new List<ProgramContainer>();
        private List<ProgramControl> pcList = new List<ProgramControl>();

        public MainScreen()
        {
            InitializeComponent();
            ShowImages();
        }

        private void ShowImages()
        {
            if (lineCount != UtilMethods.getLineCount() || fileInt != UtilMethods.getFileInt())
            {
                list = UtilMethods.getProgramList();

                upDateList();

                lineCount = UtilMethods.getLineCount();
                fileInt = UtilMethods.getFileInt();
            }
        }

        private void deleteAll()
        {
            foreach(ProgramControl pc in pcList)
            {
                pc.Dispose();
            }
            pcList.Clear();
        }

        private void upDateList()
        {
            deleteAll();

            foreach(ProgramContainer pro in list)
            {
                ProgramControl pc = new ProgramControl(pro.name, pro.fileLoc, pro.imgLoc, pro.programId);
                pcList.Add(pc);
                pc.Parent = flowLayoutPanel1;
            }
        }

        private void managePrograms_Click(object sender, EventArgs e)
        {
            PopUp popUp = new PopUp();
            popUp.Show();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            ShowImages();
        }
    }
}
