using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_erreures
{
    public partial class Form1 : Form
    {
        public static PictureBox image1 = new PictureBox();
        public static PictureBox image2 = new PictureBox();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            image1.Location = new Point(12, 12);
            image1.Size = new Size(250, 250);
            image1.SizeMode = PictureBoxSizeMode.Zoom;

            image2.Location = new Point(275, 12);
            image2.Size = new Size(250, 250);
            image2.SizeMode = PictureBoxSizeMode.Zoom;


            Button btnLoad1 = new Button();
            btnLoad1.Location = new Point(12, 272);
            btnLoad1.Size = new Size(250, 25);
            btnLoad1.Name = "load1";
            btnLoad1.Text = "Parcourir...";

            Button btnLoad2 = new Button();
            btnLoad2.Location = new Point(275, 272);
            btnLoad2.Size = new Size(250, 25);
            btnLoad2.Name = "load2";
            btnLoad2.Text = "Parcourir...";

            Button btnStart = new Button();
            btnStart.Location = new Point(12, 305);
            btnStart.Size = new Size(513, 25);
            btnStart.Name = "start";
            btnStart.Text = "Démarer";

            this.Size = new Size(550, 375);
            this.Controls.Add(image1);
            this.Controls.Add(image2);
            this.Controls.Add(btnLoad1);
            this.Controls.Add(btnLoad2);
            this.Controls.Add(btnStart);

            btnLoad1.Click += new EventHandler(eHandler.btnClickHandler);
            btnLoad2.Click += new EventHandler(eHandler.btnClickHandler);
            btnStart.Click += new EventHandler(eHandler.btnClickHandler);
        }

        public static void setImages(Image[] imgs)
        {
            if(imgs != null)
            {
                image1.Image = imgs[0];
                image2.Image = imgs[1];
            }else
                MessageBox.Show("Please use 2 images of the same size");
        }
        
    }
}
