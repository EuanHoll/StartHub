namespace StartHub
{
    partial class SelectPop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPop));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.programText = new System.Windows.Forms.Label();
            this.openProgramLocation = new System.Windows.Forms.Button();
            this.imageLocation = new System.Windows.Forms.Label();
            this.imgLocText = new System.Windows.Forms.Label();
            this.openImageLocation = new System.Windows.Forms.Button();
            this.addProgram = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 29);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Hub";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(13, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 18);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Program Location :";
            // 
            // programText
            // 
            this.programText.AutoSize = true;
            this.programText.Location = new System.Drawing.Point(43, 107);
            this.programText.Name = "programText";
            this.programText.Size = new System.Drawing.Size(0, 13);
            this.programText.TabIndex = 5;
            // 
            // openProgramLocation
            // 
            this.openProgramLocation.BackColor = System.Drawing.Color.Cyan;
            this.openProgramLocation.FlatAppearance.BorderSize = 0;
            this.openProgramLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProgramLocation.Location = new System.Drawing.Point(303, 102);
            this.openProgramLocation.Name = "openProgramLocation";
            this.openProgramLocation.Size = new System.Drawing.Size(31, 23);
            this.openProgramLocation.TabIndex = 6;
            this.openProgramLocation.Text = "...";
            this.openProgramLocation.UseVisualStyleBackColor = false;
            this.openProgramLocation.Click += new System.EventHandler(this.openProgramLocation_Click);
            // 
            // imageLocation
            // 
            this.imageLocation.AutoSize = true;
            this.imageLocation.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLocation.Location = new System.Drawing.Point(13, 150);
            this.imageLocation.Name = "imageLocation";
            this.imageLocation.Size = new System.Drawing.Size(126, 18);
            this.imageLocation.TabIndex = 7;
            this.imageLocation.Text = "Image Location :";
            // 
            // imgLocText
            // 
            this.imgLocText.AutoSize = true;
            this.imgLocText.Location = new System.Drawing.Point(46, 172);
            this.imgLocText.Name = "imgLocText";
            this.imgLocText.Size = new System.Drawing.Size(0, 13);
            this.imgLocText.TabIndex = 8;
            // 
            // openImageLocation
            // 
            this.openImageLocation.BackColor = System.Drawing.Color.Cyan;
            this.openImageLocation.FlatAppearance.BorderSize = 0;
            this.openImageLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openImageLocation.Location = new System.Drawing.Point(303, 167);
            this.openImageLocation.Name = "openImageLocation";
            this.openImageLocation.Size = new System.Drawing.Size(31, 23);
            this.openImageLocation.TabIndex = 9;
            this.openImageLocation.Text = "...";
            this.openImageLocation.UseVisualStyleBackColor = false;
            this.openImageLocation.Click += new System.EventHandler(this.openImageLocation_Click);
            // 
            // addProgram
            // 
            this.addProgram.BackColor = System.Drawing.Color.Cyan;
            this.addProgram.FlatAppearance.BorderSize = 0;
            this.addProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProgram.Location = new System.Drawing.Point(117, 227);
            this.addProgram.Name = "addProgram";
            this.addProgram.Size = new System.Drawing.Size(101, 23);
            this.addProgram.TabIndex = 10;
            this.addProgram.Text = "Add Program";
            this.addProgram.UseVisualStyleBackColor = false;
            this.addProgram.Click += new System.EventHandler(this.addProgram_Click);
            // 
            // SelectPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(346, 262);
            this.Controls.Add(this.addProgram);
            this.Controls.Add(this.openImageLocation);
            this.Controls.Add(this.imgLocText);
            this.Controls.Add(this.imageLocation);
            this.Controls.Add(this.openProgramLocation);
            this.Controls.Add(this.programText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectPop";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label programText;
        private System.Windows.Forms.Button openProgramLocation;
        private System.Windows.Forms.Label imageLocation;
        private System.Windows.Forms.Label imgLocText;
        private System.Windows.Forms.Button openImageLocation;
        private System.Windows.Forms.Button addProgram;
    }
}

