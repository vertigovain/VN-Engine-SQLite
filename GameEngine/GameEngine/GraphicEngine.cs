using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameEngine
{
 
    public class GraphicEngine 
    {
        

        /**-------------------MEMBERS-------------**/
        //private Graphics DrawHandle;








        /**-----------------METHODS---------------**/


        

       

        public void DrawCharacter
            (object sender,
            //position
            int x1,
            int y1,
            //dimensions
            decimal Width,
            decimal Height,
             //Graphics pe,
             System.Windows.Forms.PaintEventArgs pe,
             //Image Path, difine like "@"G:\Temp\1.png"
             string ImagePath,
            //transparency
            float Alpha
            )

        {
            //pe.Graphics.Clear(Color.Transparent);
           
            Graphics g = pe.Graphics;
            Bitmap bmp = new Bitmap(ImagePath);
            int xWidth;
            int xHeight;
            if (Width == 0) { xWidth = bmp.Width; } else { xWidth = (int)(bmp.Width * Width); }
            if (Height == 0) { xHeight = bmp.Height; } else { xHeight = (int)(bmp.Height *Height); }
            if (x1 == 0) { x1 = 860 - (xWidth / 2); }
            if (y1 == 0) { y1 = 1080 - xHeight; }


            Rectangle r = new Rectangle(x1, y1, xWidth, xHeight);

            ColorMatrix colorMatrix = new ColorMatrix();
            ImageAttributes ia = new ImageAttributes();
            colorMatrix.Matrix33 = Alpha;
            ia.SetColorMatrix(colorMatrix);

            g.DrawImage(bmp, r, 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, ia);
            //g.Dispose();
            bmp.Dispose();   
                
        }

        public void DrawBackground
            (object sender,
             //Graphics pe,
             System.Windows.Forms.PaintEventArgs pe,
             //Image Path, difine like "@"G:\Temp\00.png"
             Bitmap bmp,
             Color BackgroundColor,
             Bitmap BorderImage
            )

        {
            //pe.Graphics.Clear(Color.Transparent);

            Graphics g = pe.Graphics;
           
            decimal xHeight = bmp.Height;
            decimal Ratio = 1080 / xHeight;
            decimal xWidth = bmp.Width * Ratio;
            int xPos = (1920 - (int)xWidth)/2;
            Rectangle r = new Rectangle(xPos, 0, (int)xWidth, 1080);
            g.DrawImage(bmp, xPos, 0, (int)xWidth, 1080);
            //draw rectangles at left and right matching the image colors
            //Color Color = bmp.GetPixel(0, 0);
            SolidBrush brush = new SolidBrush(BackgroundColor);
            g.FillRectangle(brush, 0, 0, xPos, 1080);
            //brush.Color = Color;
            g.FillRectangle(brush, xPos+(int)xWidth, 0, xPos, 1080);


            //g.DrawImage(BorderImage, xPos - 15, 0, BorderImage.Width, BorderImage.Height);
            //g.DrawImage(BorderImage, xPos + (int)xWidth - 15, 0, BorderImage.Width, BorderImage.Height);
            //brush.Dispose();
            //bmp.Dispose();



        }

        public void DrawTextarea
           (object sender,
            //Graphics pe,
            System.Windows.Forms.PaintEventArgs pe,
            //Image Path, difine like "@"G:\Temp\00.png"
            Bitmap bmp
           )
      {

            Graphics g = pe.Graphics;
            g.DrawImage(bmp, 0, 700, bmp.Width, bmp.Height);
        }


    }





}
