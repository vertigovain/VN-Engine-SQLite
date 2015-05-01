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
 

    public static class GraphicEngine 
    {

        public static Bitmap BorderImage =  new Bitmap(@"G:\Temp\images\engine\border.png");
        public static Bitmap BackgroundImage  = new Bitmap(@"G:\Temp\images\engine\border.png");
        public static Color BackgroundColor = System.Drawing.Color.Black;
        public static bool UseDominantColor;
        public static int screenWidth=1920;
        public static int screenHeight = 1080;
        public static decimal xRatio = screenWidth / (decimal)1920;
        public static decimal yRatio = screenHeight / (decimal)1080;
        /**-------------------MEMBERS-------------**/
        //private Graphics DrawHandle;








        /**-----------------METHODS---------------**/


        public static Bitmap BGimg(string Path)
        {
            GraphicEngine.BackgroundImage = new Bitmap(Path);
            return BackgroundImage;
        }



        public static void DrawCharacter
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

        public static void DrawBackground
            (
             System.Windows.Forms.PaintEventArgs pe
            )

        {
            //pe.Graphics.Clear(Color.Transparent);

            Graphics g = pe.Graphics;
           
            decimal xHeight = BackgroundImage.Height;
            decimal Ratio = screenHeight / xHeight;
            decimal xWidth = BackgroundImage.Width * Ratio;
            int xPos = (screenWidth - (int)xWidth)/2;
            Rectangle r = new Rectangle(xPos, 0, (int)xWidth, screenHeight);
            g.DrawImage(BackgroundImage, xPos, 0, (int)xWidth, screenHeight);
            //draw rectangles at left and right matching the image colors
            //Color Color = bmp.GetPixel(0, 0);
            SolidBrush brush = new SolidBrush(BackgroundColor);
            g.FillRectangle(brush, 0, 0, xPos, screenHeight);
            //brush.Color = Color;
            g.FillRectangle(brush, xPos+(int)xWidth, 0, xPos, screenHeight);


            //g.DrawImage(BorderImage, xPos - 15, 0, BorderImage.Width, BorderImage.Height);
            //g.DrawImage(BorderImage, xPos + (int)xWidth - 15, 0, BorderImage.Width, BorderImage.Height);
            //brush.Dispose();
            //bmp.Dispose();



        }

        public static void DrawTextarea
           (object sender,
            //Graphics pe,
            System.Windows.Forms.PaintEventArgs pe,
            //Image Path, difine like "@"G:\Temp\00.png"
            Bitmap bmp
           )
      {

            Graphics g = pe.Graphics;
            decimal xHeight = bmp.Height * yRatio;
            //MessageBox.Show(text: xHeight.ToString() + "screenHeight: " + screenHeight.ToString() + "  / screen ratio: " +yRatio.ToString());
            decimal xWidth = bmp.Width * xRatio;
            decimal yPos = screenHeight - xHeight;
            g.DrawImage(bmp, 0, (int)yPos, (int)xWidth, (int)xHeight);
            //g.DrawImage(bmp, 0,450 , 1280, 266);
        }


        public static void SetBackground()
        {
            GraphicEngine.BackgroundImage.Dispose();
            GraphicEngine.BackgroundImage = GraphicEngine.BGimg(ScriptEngine.Path);
            if (UseDominantColor == true)
            { GraphicEngine.BackgroundColor = GameWindow.getDominantColor(GraphicEngine.BackgroundImage); }
            else
            { GraphicEngine.BackgroundColor = System.Drawing.Color.Black; }
        }

        public static void GetResolution()
        {

            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            GraphicEngine.screenWidth = resolution.Width;
            GraphicEngine.screenHeight = resolution.Height;
            xRatio = screenWidth / (decimal)1920;
            yRatio = screenHeight / (decimal)1080;

    }

        public static int X(int x)
        {
            
            int x1  = (int)(xRatio * (decimal)x);
            return x1;
        }

        public static int Y(int x)
        {
            int x1 = (int)(yRatio * (decimal)x);
            return x1;
        }


    }






}
