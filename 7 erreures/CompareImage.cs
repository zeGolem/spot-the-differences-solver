using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_erreures
{
    class CompareImage
    {

        public static Image[] Run(Image img1, Image img2)
        {
            if (img1.Width != img2.Width)
                if (img2.Height != img1.Height)
                    return null;

            int width = img1.Width;
            int height = img1.Height;
            Bitmap bmp1 = new Bitmap(img1); Bitmap bmp2 = new Bitmap(img2);

            Bitmap newImage1 = new Bitmap(width, height); Bitmap newImage2 = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (IsColorCloseEnough(bmp1.GetPixel(x,y), bmp2.GetPixel(x,y),20))
                    {
                        newImage1.SetPixel(x, y, Color.Red);
                        newImage2.SetPixel(x, y, Color.Red);
                    }
                    else
                    {
                        newImage1.SetPixel(x, y, bmp1.GetPixel(x, y));
                        newImage2.SetPixel(x, y, bmp2.GetPixel(x, y));
                    }
                }
            }

            Image[] result = { newImage1, newImage2 };

            return result;
        }

        public static bool IsColorCloseEnough(Color color1, Color color2, int threshold)
        {

            if (GetDifference(color1.R, color2.R) < threshold && GetDifference(color1.G, color2.G) < threshold && GetDifference(color1.B, color2.B) < threshold)
                return true;

            return false;
        }

        public static int GetDifference(int n1, int n2)
        {
            if (n1 > n2)
                return n1 - n2;
            else
                return n2 - n1;
        }

    }

    
}
