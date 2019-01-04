namespace StartHub
{
    partial class PopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUp));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addProgram = new System.Windows.Forms.Button();
            this.removeProgram = new System.Windows.Forms.Button();
            this.startHubList = new System.Windows.Forms.ListBox();
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
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // addProgram
            // 
            this.addProgram.BackColor = System.Drawing.Color.Cyan;
            this.addProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addProgram.FlatAppearance.BorderSize = 0;
            this.addProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProgram.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProgram.Location = new System.Drawing.Point(16, 305);
            this.addProgram.Name = "addProgram";
            this.addProgram.Size = new System.Drawing.Size(114, 27);
            this.addProgram.TabIndex = 3;
            this.addProgram.Text = "Add Program";
            this.addProgram.UseVisualStyleBackColor = false;
            this.addProgram.Click += new System.EventHandler(this.addProgram_Click);
            // 
            // removeProgram
            // 
            this.removeProgram.BackColor = System.Drawing.Color.Cyan;
            this.removeProgram.FlatAppearance.BorderSize = 0;
            this.removeProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeProgram.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProgram.Location = new System.Drawing.Point(190, 305);
            this.removeProgram.Name = "removeProgram";
            this.removeProgram.Size = new System.Drawing.Size(144, 27);
            this.removeProgram.TabIndex = 4;
            this.removeProgram.Text = "Remove Program";
            this.removeProgram.UseVisualStyleBackColor = false;
            this.removeProgram.Click += new System.EventHandler(this.removeProgram_Click);
            // 
            // startHubList
            // 
            this.startHubList.BackColor = System.Drawing.Color.DarkTurquoise;
            this.startHubList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startHubList.FormattingEnabled = true;
            this.startHubList.Location = new System.Drawing.Point(10, 34);
            this.startHubList.Name = "startHubList";
            this.startHubList.Size = new System.Drawing.Size(324, 260);
            this.startHubList.TabIndex = 5;
            this.startHubList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.startHubList_MouseDoubleClick);
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(346, 336);
            this.Controls.Add(this.startHubList);
            this.Controls.Add(this.removeProgram);
            this.Controls.Add(this.addProgram);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopUp";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PopUp_MouseMove);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProgram;
        private System.Windows.Forms.Button removeProgram;
        private System.Windows.Forms.ListBox startHubList;
    }
}

