namespace ParserGUI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MapImage = new System.Windows.Forms.PictureBox();
            this.TileImage = new System.Windows.Forms.PictureBox();
            this.TileTypeList = new System.Windows.Forms.ComboBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveMapToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem.Text = "&Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // saveMapToolStripMenuItem
            // 
            this.saveMapToolStripMenuItem.Name = "saveMapToolStripMenuItem";
            this.saveMapToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveMapToolStripMenuItem.Text = "&Save Map";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MapImage
            // 
            this.MapImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MapImage.Location = new System.Drawing.Point(12, 27);
            this.MapImage.Name = "MapImage";
            this.MapImage.Size = new System.Drawing.Size(512, 512);
            this.MapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MapImage.TabIndex = 1;
            this.MapImage.TabStop = false;
            // 
            // TileImage
            // 
            this.TileImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TileImage.Location = new System.Drawing.Point(546, 27);
            this.TileImage.Name = "TileImage";
            this.TileImage.Size = new System.Drawing.Size(128, 128);
            this.TileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TileImage.TabIndex = 2;
            this.TileImage.TabStop = false;
            // 
            // TileTypeList
            // 
            this.TileTypeList.FormattingEnabled = true;
            this.TileTypeList.Location = new System.Drawing.Point(546, 162);
            this.TileTypeList.Name = "TileTypeList";
            this.TileTypeList.Size = new System.Drawing.Size(128, 21);
            this.TileTypeList.TabIndex = 3;
            // 
            // SetButton
            // 
            this.SetButton.Enabled = false;
            this.SetButton.Location = new System.Drawing.Point(547, 186);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(126, 25);
            this.SetButton.TabIndex = 4;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // OutputText
            // 
            this.OutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputText.Location = new System.Drawing.Point(547, 240);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputText.Size = new System.Drawing.Size(127, 157);
            this.OutputText.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 563);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.TileTypeList);
            this.Controls.Add(this.TileImage);
            this.Controls.Add(this.MapImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Map Parser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMapToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox MapImage;
        private System.Windows.Forms.PictureBox TileImage;
        private System.Windows.Forms.ComboBox TileTypeList;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

