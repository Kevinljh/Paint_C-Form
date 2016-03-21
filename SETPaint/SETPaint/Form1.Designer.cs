namespace SETPaint
{
    partial class myForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myForm));
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.lineBtn = new System.Windows.Forms.ToolStripButton();
            this.toolBarSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.shapeBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.ellipseBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.rectBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sizeBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.sizeDownDropItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeDownDropItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeDownDropItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeDownDropItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeDownDropItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lineColorBtn = new System.Windows.Forms.ToolStripButton();
            this.toolBarSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.fillColorBtn = new System.Windows.Forms.ToolStripButton();
            this.toolBarSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.eraseBtn = new System.Windows.Forms.ToolStripButton();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.mousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileDropDownMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.aboutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.helpDrowDownMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.toolBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineBtn,
            this.toolBarSeparator2,
            this.shapeBtn,
            this.toolBarSeparator1,
            this.sizeBtn,
            this.toolBarSeparator3,
            this.lineColorBtn,
            this.toolBarSeparator5,
            this.fillColorBtn,
            this.toolBarSeparator4,
            this.eraseBtn});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(882, 25);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "toolStrip1";
            // 
            // lineBtn
            // 
            this.lineBtn.BackColor = System.Drawing.SystemColors.Control;
            this.lineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(33, 22);
            this.lineBtn.Text = "Line";
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // toolBarSeparator2
            // 
            this.toolBarSeparator2.Name = "toolBarSeparator2";
            this.toolBarSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // shapeBtn
            // 
            this.shapeBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipseBtn,
            this.rectBtn});
            this.shapeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shapeBtn.Name = "shapeBtn";
            this.shapeBtn.Size = new System.Drawing.Size(52, 22);
            this.shapeBtn.Text = "Shape";
            this.shapeBtn.ToolTipText = "Shape";
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(126, 22);
            this.ellipseBtn.Text = "Ellipse";
            this.ellipseBtn.Click += new System.EventHandler(this.ellipseToolStripMenuItem1_Click);
            // 
            // rectBtn
            // 
            this.rectBtn.Name = "rectBtn";
            this.rectBtn.Size = new System.Drawing.Size(126, 22);
            this.rectBtn.Text = "Rectangle";
            this.rectBtn.Click += new System.EventHandler(this.rectangleToolStripMenuItem1_Click);
            // 
            // toolBarSeparator1
            // 
            this.toolBarSeparator1.Name = "toolBarSeparator1";
            this.toolBarSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // sizeBtn
            // 
            this.sizeBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeDownDropItem1,
            this.sizeDownDropItem2,
            this.sizeDownDropItem3,
            this.sizeDownDropItem4,
            this.sizeDownDropItem5});
            this.sizeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sizeBtn.Name = "sizeBtn";
            this.sizeBtn.Size = new System.Drawing.Size(40, 22);
            this.sizeBtn.Text = "Size";
            this.sizeBtn.ToolTipText = "Size";
            this.sizeBtn.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.sizeBtn_DropDownItemClicked_1);
            // 
            // sizeDownDropItem1
            // 
            this.sizeDownDropItem1.Name = "sizeDownDropItem1";
            this.sizeDownDropItem1.Size = new System.Drawing.Size(86, 22);
            this.sizeDownDropItem1.Text = "3";
            // 
            // sizeDownDropItem2
            // 
            this.sizeDownDropItem2.Name = "sizeDownDropItem2";
            this.sizeDownDropItem2.Size = new System.Drawing.Size(86, 22);
            this.sizeDownDropItem2.Text = "6";
            // 
            // sizeDownDropItem3
            // 
            this.sizeDownDropItem3.Name = "sizeDownDropItem3";
            this.sizeDownDropItem3.Size = new System.Drawing.Size(86, 22);
            this.sizeDownDropItem3.Text = "9";
            // 
            // sizeDownDropItem4
            // 
            this.sizeDownDropItem4.Name = "sizeDownDropItem4";
            this.sizeDownDropItem4.Size = new System.Drawing.Size(86, 22);
            this.sizeDownDropItem4.Text = "12";
            // 
            // sizeDownDropItem5
            // 
            this.sizeDownDropItem5.Name = "sizeDownDropItem5";
            this.sizeDownDropItem5.Size = new System.Drawing.Size(86, 22);
            this.sizeDownDropItem5.Text = "15";
            // 
            // toolBarSeparator3
            // 
            this.toolBarSeparator3.Name = "toolBarSeparator3";
            this.toolBarSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lineColorBtn
            // 
            this.lineColorBtn.BackColor = System.Drawing.SystemColors.Control;
            this.lineColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lineColorBtn.Enabled = false;
            this.lineColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("lineColorBtn.Image")));
            this.lineColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineColorBtn.Name = "lineColorBtn";
            this.lineColorBtn.Size = new System.Drawing.Size(65, 22);
            this.lineColorBtn.Text = "Line Color";
            this.lineColorBtn.Click += new System.EventHandler(this.lineColorBtn_Click);
            // 
            // toolBarSeparator5
            // 
            this.toolBarSeparator5.Name = "toolBarSeparator5";
            this.toolBarSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // fillColorBtn
            // 
            this.fillColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillColorBtn.Enabled = false;
            this.fillColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("fillColorBtn.Image")));
            this.fillColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillColorBtn.Name = "fillColorBtn";
            this.fillColorBtn.Size = new System.Drawing.Size(58, 22);
            this.fillColorBtn.Text = "Fill Color";
            this.fillColorBtn.ToolTipText = "Fill Colour";
            this.fillColorBtn.Click += new System.EventHandler(this.fillColorBtn_Click);
            // 
            // toolBarSeparator4
            // 
            this.toolBarSeparator4.Name = "toolBarSeparator4";
            this.toolBarSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // eraseBtn
            // 
            this.eraseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.eraseBtn.Image = ((System.Drawing.Image)(resources.GetObject("eraseBtn.Image")));
            this.eraseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(38, 22);
            this.eraseBtn.Text = "Erase";
            this.eraseBtn.Click += new System.EventHandler(this.eraseBtn_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mousePosition});
            this.statusBar.Location = new System.Drawing.Point(0, 617);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(882, 22);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusStrip1";
            // 
            // mousePosition
            // 
            this.mousePosition.Name = "mousePosition";
            this.mousePosition.Size = new System.Drawing.Size(0, 17);
            this.mousePosition.Visible = false;
            // 
            // fileDropDownMenu
            // 
            this.fileDropDownMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBtn,
            this.saveBtn,
            this.exitBtn});
            this.fileDropDownMenu.Name = "fileDropDownMenu";
            this.fileDropDownMenu.Size = new System.Drawing.Size(40, 20);
            this.fileDropDownMenu.Text = "FILE";
            // 
            // openBtn
            // 
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(105, 22);
            this.openBtn.Text = "OPEN";
            this.openBtn.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 22);
            this.saveBtn.Text = "SAVE";
            this.saveBtn.Click += new System.EventHandler(this.sAVEToolStripMenuItem_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(105, 22);
            this.exitBtn.Text = "EXIT";
            this.exitBtn.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDropDownMenu,
            this.aboutBtn});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(882, 24);
            this.menuBar.TabIndex = 2;
            this.menuBar.Text = "menuStrip1";
            // 
            // aboutBtn
            // 
            this.aboutBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpDrowDownMenu});
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(47, 20);
            this.aboutBtn.Text = "HELP";
            // 
            // helpDrowDownMenu
            // 
            this.helpDrowDownMenu.Name = "helpDrowDownMenu";
            this.helpDrowDownMenu.Size = new System.Drawing.Size(152, 22);
            this.helpDrowDownMenu.Text = "ABOUT";
            this.helpDrowDownMenu.Click += new System.EventHandler(this.aBOUTToolStripMenuItem1_Click);
            // 
            // myPictureBox
            // 
            this.myPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myPictureBox.BackColor = System.Drawing.Color.White;
            this.myPictureBox.Location = new System.Drawing.Point(0, 52);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(882, 562);
            this.myPictureBox.TabIndex = 0;
            this.myPictureBox.TabStop = false;
            this.myPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myPictureBox_MouseDown);
            this.myPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myPictureBox_MouseMove);
            this.myPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myPictureBox_MouseUp);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 639);
            this.Controls.Add(this.myPictureBox);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuBar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "myForm";
            this.Text = "SETPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripButton lineBtn;
        private System.Windows.Forms.ToolStripDropDownButton shapeBtn;
        private System.Windows.Forms.ToolStripMenuItem ellipseBtn;
        private System.Windows.Forms.ToolStripMenuItem rectBtn;
        private System.Windows.Forms.ToolStripDropDownButton sizeBtn;
        private System.Windows.Forms.ToolStripMenuItem fileDropDownMenu;
        private System.Windows.Forms.ToolStripMenuItem openBtn;
        private System.Windows.Forms.ToolStripMenuItem saveBtn;
        private System.Windows.Forms.ToolStripMenuItem exitBtn;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem aboutBtn;
        private System.Windows.Forms.ToolStripMenuItem helpDrowDownMenu;
        private System.Windows.Forms.ToolStripMenuItem sizeDownDropItem1;
        private System.Windows.Forms.ToolStripMenuItem sizeDownDropItem2;
        private System.Windows.Forms.ToolStripMenuItem sizeDownDropItem3;
        private System.Windows.Forms.ToolStripMenuItem sizeDownDropItem4;
        private System.Windows.Forms.ToolStripMenuItem sizeDownDropItem5;
        private System.Windows.Forms.ToolStripSeparator toolBarSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolBarSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolBarSeparator3;
        private System.Windows.Forms.ToolStripButton lineColorBtn;
        private System.Windows.Forms.ToolStripSeparator toolBarSeparator4;
        private System.Windows.Forms.ToolStripButton fillColorBtn;
        private System.Windows.Forms.ToolStripStatusLabel mousePosition;
        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.ToolStripSeparator toolBarSeparator5;
        private System.Windows.Forms.ToolStripButton eraseBtn;
    }
}

