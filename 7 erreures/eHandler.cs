using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_erreures
{
    class eHandler
    {

        public static void btnClickHandler(object sender, EventArgs e)
        {
            Console.WriteLine(((Button)sender).Name + " was clicked");

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.bmp";


            switch (((Button)sender).Name)
            {
                case "load1":
                    ofd.ShowDialog();
                    if (ofd.FileName != "")
                    {

                        Form1.image1.Image = Image.FromFile(ofd.FileName);

                    }
                    break;

                case "load2":
                    ofd.ShowDialog();
                    if (ofd.FileName != "")
                    {

                        Form1.image2.Image = Image.FromFile(ofd.FileName);

                    }
                    break;

                case "start":
                    Form1.setImages(CompareImage.Run(Form1.image1.Image, Form1.image2.Image));
                    break;

            }
        }

    }
}
