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
    public partial class SelectPop : Form
    {
        private ProgramContainer pro;

        public SelectPop()
        {
            InitializeComponent();
        }

        public SelectPop(string name, string fileLoc, string imgLoc)
        {
            InitializeComponent();
            pro = new ProgramContainer(name, fileLoc, imgLoc);
            this.textBox1.Text = name;
            this.imgLocText.Text = imgLoc;
            this.imgLoc = imgLoc;
            this.exeLoc = fileLoc;
            this.programText.Text = fileLoc;
        }

        private string exeLoc = "";
        private string imgLoc = "";

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
            this.Close();
        }

        private void openImageLocation_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.gif;|exe Files|*.exe";
                openFileDialog1.FilterIndex = 0;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = openFileDialog1.FileName;
                    imgLocText.Text = imgLoc;
                }

            }
        }

        private void openProgramLocation_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "exe Files (*.exe)|*.exe|jar Files (*.jar)|*.jar|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 0;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    exeLoc = openFileDialog1.FileName;
                    programText.Text = exeLoc;
                    imgLoc = openFileDialog1.FileName;
                    imgLocText.Text = imgLoc;
                }

            }
        }

        private void addProgram_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a name" + Environment.NewLine + "To cancel please select the x");
                return;
            }
            else if (exeLoc == "")
            {
                MessageBox.Show("Please enter a program file" + Environment.NewLine + "To cancel please select the x");
                return;
            }
            else if (imgLoc == "")
            {
                MessageBox.Show("Please enter an image file" + Environment.NewLine + "To cancel please select the x");
                return;
            }

            if(pro != null)
            {
                UtilMethods.removeLine(pro.name, pro.fileLoc, pro.imgLoc);
            }

            UtilMethods.addToFile(textBox1.Text, exeLoc, imgLoc);
            this.Close();
        }
    }
}
