using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using StartHub.Utils;

namespace StartHub.Controls
{
    public partial class ProgramControl : UserControl
    {
        string programLoc;
        int programID;

        public ProgramControl(string programName, string programLoc, string imageLocation, int programID)
        {
            InitializeComponent();
            name.Text = programName;

            if (!imageLocation.StartsWith("resources:"))
            {
                if (!imageLocation.EndsWith(".exe"))
                {
                    pictureBox1.ImageLocation = imageLocation;
                }
                else
                {
                    pictureBox1.Image = resizeImage(Icon.ExtractAssociatedIcon(imageLocation).ToBitmap(), new Size(pictureBox1.Width, pictureBox1.Height));
                }
            }
            else
            {
                pictureBox1.Image = UtilMethods.getBitMapFromResource(imageLocation);
            }


            this.programLoc = programLoc;
            this.programID = programID;

        }

        private static Image resizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        private void ProgramControl_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(programLoc);
        }
    }
}
