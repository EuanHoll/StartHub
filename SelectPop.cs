using StartHub.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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
            this.nameTextBox.Text = name;
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

                if (imgLoc == "")
                {
                    openFileDialog1.InitialDirectory = "c:\\";
                }
                else
                {
                    openFileDialog1.InitialDirectory = imgLoc;
                }

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
                if (exeLoc == "")
                {
                    openFileDialog1.InitialDirectory = "c:\\";
                }
                else
                {
                    openFileDialog1.InitialDirectory = exeLoc;
                }

                openFileDialog1.Filter = "exe Files (*.exe)|*.exe|jar Files (*.jar)|*.jar|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 0;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    exeLoc = openFileDialog1.FileName;
                    programText.Text = exeLoc;
                    imgLoc = openFileDialog1.FileName;
                    imgLocText.Text = imgLoc;

                    if(nameTextBox.Text == "")
                    {
                        string exe = exeLoc.Split('\\')[exeLoc.Split('\\').Length - 1];
                        exe = Regex.Replace(exe, ".exe", "");
                        exe = Regex.Replace(exe, ".jar", "");
                        exe = Regex.Replace(exe, ".bat", "");
                        exe = UtilMethods.FirstLetterToUpperCaseOrConvertNullToEmptyString(exe);
                        nameTextBox.Text = exe;
                    }

                    FileEnum fileEnum = UtilMethods.hasHighQualityIcon(UtilMethods.getFileName(exeLoc));
                    if (fileEnum != FileEnum.None)
                    {

                        DialogResult dialogResult = MessageBox.Show("Do you want to display a high quality icon for " + 
                            UtilMethods.getNameFromFileEnum(fileEnum) + 
                            " or not?", "High Quality Icon", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            imgLoc = "resources:" + UtilMethods.getImageNameFromFileEnum(fileEnum);
                            imgLocText.Text = imgLoc;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }

                    }

                }

            }
        }

        private void addProgram_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
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

            UtilMethods.addToFile(nameTextBox.Text, exeLoc, imgLoc);
            this.Close();
        }

    }
}
