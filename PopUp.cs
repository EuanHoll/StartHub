using StartHub.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartHub
{
    public partial class PopUp : Form
    {
        public PopUp()
        {
            InitializeComponent();
        }

        private int lineCount = -1;
        private int fileInt = 0;
        private List<ProgramContainer> list = new List<ProgramContainer>();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void OnPaint(PaintEventArgs e)
        {
            if (lineCount != UtilMethods.getLineCount() || fileInt != UtilMethods.getFileInt())
            {
                list = UtilMethods.getProgramList();

                upDateList();

                lineCount = UtilMethods.getLineCount();
                fileInt = UtilMethods.getFileInt();
            }

            base.OnPaint(e);
        }

        public override void Refresh()
        {
            if (lineCount != UtilMethods.getLineCount() || fileInt != UtilMethods.getFileInt())
            {
                list = UtilMethods.getProgramList();

                upDateList();

                lineCount = UtilMethods.getLineCount();
                fileInt = UtilMethods.getFileInt();
            }

            base.Refresh();
        }


        private void upDateList()
        {
            startHubList.Items.Clear();

            foreach(ProgramContainer pro in list)
            {
                startHubList.Items.Add(pro.name + " : " + pro.programId);
            }


            startHubList.Hide();
            startHubList.Show();
        }

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
            this.Close();
        }

        private void addProgram_Click(object sender, EventArgs e)
        {
            SelectPop selectPop = new SelectPop();
            selectPop.Show();
        }

        private void removeProgram_Click(object sender, EventArgs e)
        {
            ProgramContainer pro = UtilMethods.stringToPC((string)startHubList.SelectedItem, list);

            if(pro == null)
            {
                return;
            }

            startHubList.Items.Remove(startHubList.SelectedItem);
            UtilMethods.removeLine(pro.name, pro.fileLoc, pro.imgLoc);
        }

        private void PopUp_MouseMove(object sender, MouseEventArgs e)
        {
            Refresh();
        }

        private void startHubList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.startHubList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                ProgramContainer sltPro = UtilMethods.stringToPC(startHubList.Items[index].ToString(), list);
                SelectPop selectPop = new SelectPop(sltPro.name, sltPro.fileLoc, sltPro.imgLoc);
                selectPop.Show();
            }
        }
    }
}
