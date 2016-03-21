//FILE : SETPaint.cs
//PROJECT : PROG2120 - Assignment #3 (SETPaint)
//PROGRAMMER : Junhao Li
//FIRST VERSION : 2014-10-07
//DESCRIPTION :
//			This is simple drawing program like Microsoft Paint. It can draw lines, rectangles and ellipses
//          with chosen color and lines size. User can only open and save as png file.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace SETPaint
{
    //	Class		:	Form
    //	Description		:	Represents a window or dialog box that makes up an application's user interface
    public partial class myForm : Form
    {      
        //line and rectangle's start and end point, used to draw a object
        Point endLinePoint = new Point(0, 0);
        Point lineStartPiont = new Point(0, 0);
        Point rectStartPiont = new Point(0, 0);
        Point rectEndPiont = new Point(0, 0);
        //rect as rubber banding
        Rectangle currentRect; 
        //choose a object
        bool bDrawLine = false;
        bool bDrawRectangle = false;
        bool bDrawEllipse = false;
        //set default size as 5
        int currLineSize = 3;
        //set default color as black
        Color currLineColor = Color.Black;
        //set default fill color as while
        Color currFillColor;
        //bitmaps
        Bitmap myBitmap ;
        Bitmap tempBitmap;
        //used when the mouse is up
        Graphics realG;
        bool pbMouseLC = false;
  
        public myForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;   
        }

        // FUNCTION : lineBtn_Click
        // DESCRIPTION :
        //				Choose to draw a line when clicked
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful.
        private void lineBtn_Click(object sender, EventArgs e)
        {
            bDrawLine = true;
            bDrawRectangle = false;
            bDrawEllipse = false;
            lineColorBtn.Enabled = true;
            fillColorBtn.Enabled = false;
        }

        // FUNCTION : rectangleToolStripMenuItem1_Click
        // DESCRIPTION :
        //				Choose to draw a rectangle
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful.     
        private void rectangleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bDrawRectangle = true;
            bDrawLine = false;
            bDrawEllipse = false;
            fillColorBtn.Enabled = true;
            lineColorBtn.Enabled = true;
        }

        // FUNCTION : oPENToolStripMenuItem_Click
        // DESCRIPTION :
        //				Open a png file and show on the picture box
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful.
        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Png files (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            myBitmap = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                            //update the picture box
                            tempBitmap = (Bitmap)myBitmap.Clone();
                            Graphics g = Graphics.FromImage(tempBitmap);
                            myPictureBox.BackgroundImage = tempBitmap;
                            realG.DrawImage(myBitmap, new Point(0, 0));
                        }
                        this.Text = this.Text + " - " + openFileDialog1.SafeFileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                
            }
        }

        // FUNCTION : ellipseToolStripMenuItem1_Click
        // DESCRIPTION :
        //				Choose to draw a ellipse
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful.
        private void ellipseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bDrawEllipse = true;
            bDrawLine = false;
            bDrawRectangle = false;
            fillColorBtn.Enabled = true;
            lineColorBtn.Enabled = true;
        }

        // FUNCTION : lineColorBtn_Click
        // DESCRIPTION :
        //				Opens a dialog and gets line color
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful.
        private void lineColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog myDialog = new ColorDialog();

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                currLineColor = myDialog.Color;
            }
        }

        // FUNCTION : fillColorBtn_Click
        // DESCRIPTION :
        //				Gets the fill color
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful.
        private void fillColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog myDialog = new ColorDialog();

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                currFillColor = myDialog.Color;
            }
        }

        // FUNCTION : sizeBtn_DropDownItemClicked_1
        // DESCRIPTION :
        //				Get the line size from user
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful.
        private void sizeBtn_DropDownItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            //get the line size and convert to string for later use
            currLineSize = Convert.ToInt32(e.ClickedItem.ToString());
        }

        // FUNCTION : eXITToolStripMenuItem_Click
        // DESCRIPTION :
        //				Exit program btn
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful. 
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        // FUNCTION : sAVEToolStripMenuItem_Click
        // DESCRIPTION :
        //				Open and read a file, display one the picturebox
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful.
        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //only accept png file
            saveFileDialog1.Filter = "Png files (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = (System.IO.FileStream)saveFileDialog1.OpenFile()) != null)
                {
                    //load the img to bitmap
                    myBitmap.Save(myStream, System.Drawing.Imaging.ImageFormat.Png);
                    myStream.Close();
                }
            }
        }

        // FUNCTION : aBOUTToolStripMenuItem1_Click
        // DESCRIPTION :
        //				Pop-up a messagebox
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful. 
        private void aBOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paint Application\n©Kevin Corporation");
        }

        // FUNCTION : myPictureBox_MouseDown
        // DESCRIPTION :
        //				Get start point and enable the mouse position
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful. 
        private void myPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if((bDrawEllipse) || (bDrawLine) || (bDrawRectangle))
            {
                mousePosition.Visible = true;
            }
            lineStartPiont = e.Location;
            rectStartPiont = e.Location;
            pbMouseLC = true;
        }

        // FUNCTION : myPictureBox_MouseUp
        // DESCRIPTION :
        //				Refresh the picture box as the mouse up
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful.
        private void myPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mousePosition.Visible = false;
            pbMouseLC = false;

            tempBitmap = (Bitmap)myBitmap.Clone();
            Graphics g = Graphics.FromImage(tempBitmap);
            myPictureBox.BackgroundImage = tempBitmap;
            //used for fill color
            SolidBrush brush = new SolidBrush(currFillColor);

            if(bDrawLine)
            {
                //draw new line
                g.DrawLine(new Pen(currLineColor, currLineSize), lineStartPiont, endLinePoint);
            }
            if(bDrawRectangle)
            {
                g.DrawRectangle(new Pen(currLineColor, currLineSize), currentRect);
                g.FillRectangle(brush, currentRect);
            }
            if(bDrawEllipse)
            {
                g.DrawEllipse(new Pen(currLineColor, currLineSize), currentRect);
                g.FillEllipse(brush, currentRect);
            }
            //make change and store
            myBitmap = (Bitmap)tempBitmap.Clone();
            //display myBitmap
            realG.DrawImage(myBitmap, new Point(0, 0));
        }

        // FUNCTION : myPictureBox_MouseMove
        // DESCRIPTION :
        //				Draw dash path as rubber binding, and display the mouse position
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful.
        private void myPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (bDrawLine)
            {
                endLinePoint = e.Location;
                if (pbMouseLC == true)
                {
                    tempBitmap = (Bitmap)myBitmap.Clone();
                    Graphics g = Graphics.FromImage(tempBitmap);
                    Pen dashLinePen = new Pen(currLineColor, currLineSize);
                    dashLinePen.DashStyle = DashStyle.Dash;
                    myPictureBox.BackgroundImage = tempBitmap;
                    g.DrawLine(dashLinePen, lineStartPiont, endLinePoint);
                    g.Dispose();

                    string temp = e.X.ToString() + ", " + e.Y.ToString() + "px";
                    mousePosition.Text = temp;
                }
                
            }
            else 
            {
                rectEndPiont = e.Location;
                if (pbMouseLC == true)
                {
                    tempBitmap = (Bitmap)myBitmap.Clone();
                    Graphics g = Graphics.FromImage(tempBitmap);
                    Pen dashLinePen = new Pen(currLineColor, currLineSize);
                    dashLinePen.DashStyle = DashStyle.Dash;
                    myPictureBox.BackgroundImage = tempBitmap;

                    //modified the start and end point, so that it can draw from different direction
                    int realStartX = Math.Min(rectStartPiont.X, rectEndPiont.X);
                    int realStartY = Math.Min(rectStartPiont.Y, rectEndPiont.Y);
                    int realEndX = Math.Max(rectStartPiont.X, rectEndPiont.X);
                    int realEndY = Math.Max(rectStartPiont.Y, rectEndPiont.Y);

                    currentRect = new Rectangle(realStartX, realStartY, realEndX - realStartX, realEndY - realStartY);
                    if (bDrawRectangle)
                    {
                        g.DrawRectangle(dashLinePen, currentRect);
                    }
                    else if(bDrawEllipse)
                    {
                        g.DrawEllipse(dashLinePen, currentRect);
                    }
                    g.Dispose();

                    string temp = e.X.ToString() + ", " + e.Y.ToString() + "px";
                    mousePosition.Text = temp;
                }
            }
        }

        // FUNCTION : Form1_Load
        // DESCRIPTION :
        //				Intialize the bitmap as the form is loaded
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful.
        private void Form1_Load(object sender, EventArgs e)
        {
            myBitmap = new Bitmap(myPictureBox.Width, myPictureBox.Height);
            tempBitmap = new Bitmap(myPictureBox.Width, myPictureBox.Height);
            realG = this.myPictureBox.CreateGraphics();
            this.FormBorderStyle = (System.Windows.Forms.FormBorderStyle)1;
        }

        // FUNCTION : eraseBtn_Click
        // DESCRIPTION :
        //				Erase everything that's one the picture box
        // PARAMETERS :
        //				object sender :The sender is the control that the action is for (say OnClick, it's the button).
        //              EventArgs e: The EventArgs are arguments that the implementor of this event may find useful.
        private void eraseBtn_Click(object sender, EventArgs e)
        {
            
            if(DialogResult.OK == MessageBox.Show("Do you want to erase everything", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
            {
                Graphics g = Graphics.FromImage(myBitmap);
                myPictureBox.BackgroundImage = myBitmap;
                g.Clear(Color.White);
                g.Dispose();
            }
        }


    }
}
