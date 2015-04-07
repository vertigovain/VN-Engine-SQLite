using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEngine
{
    public partial class GameWindow : Form
    {
        GraphicEngine PaintChar = new GraphicEngine();
        Bitmap BackgroundImage { get; set; }
        Bitmap BorderImage = new Bitmap(@"G:\Temp\images\engine\border.png");
        Bitmap TextareaImage = new Bitmap(@"G:\Temp\images\engine\transparent.png");
        Color BackgroundColor { get; set; }
        bool TextAreaVisible;

        public void LoadBackground(string ImagePath)
        {
            BackgroundImage = new Bitmap(ImagePath);
            decimal xHeight = BackgroundImage.Height;
            decimal Ratio = 1080 / xHeight;
            decimal xWidth = BackgroundImage.Width * Ratio;
            if (xWidth < 1920)
            {
                BackgroundColor = getDominantColor(BackgroundImage);
            }
            else
            { BackgroundColor = Color.Black; }
        }
        public GameWindow()
        {
            InitializeComponent();
   
        }

        public static Color getDominantColor(Bitmap bmp)
        {
            //Used for tally
            int r = 0;
            int g = 0;
            int b = 0;

            int total = 0;

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color clr = bmp.GetPixel(x, y);

                    r += clr.R;
                    g += clr.G;
                    b += clr.B;

                    total++;
                }
            }

            //Calculate average
            r /= total;
            g /= total;
            b /= total;

            return Color.FromArgb(r, g, b);
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.WindowState = FormWindowState.Maximized;
            this.LoadBackground(@"G:\Temp\Images\13.jpg");
            this.TextAreaVisible = true;



            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GameWindow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Transparent); 
            PaintChar.DrawBackground(this, e, BackgroundImage, BackgroundColor, BorderImage);
            PaintChar.DrawCharacter(this, 0, 0, 1.3m, 1.3m, e, @"G:\Temp\1.png", 1); //use 0 as width/heigth for default values , last value is Alpha (1 - non transparent, 0.25f etc trans)
            if (TextAreaVisible == true)
            {
                PaintChar.DrawTextarea(this, e, TextareaImage);
            }
        }



        private void GameWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {

                if (TextAreaVisible == true)
                { TextAreaVisible = false;
                  this.Invalidate();
                }
                else
                { TextAreaVisible = true;
                  this.Invalidate();
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = ("Git Test");
        }
    }
}
