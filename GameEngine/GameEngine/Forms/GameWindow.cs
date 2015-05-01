using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameEngine.EngineScripts;

namespace GameEngine
{
    public partial class GameWindow : Form
    {
        //GraphicEngine PaintChar = new GraphicEngine();
       
        //Bitmap BorderImage = new Bitmap(@"G:\Temp\images\engine\border.png");
        Bitmap TextareaImage = new Bitmap(@"G:\Temp\images\engine\transparent.png");
        Color BackgroundColor { get; set; }
        bool TextAreaVisible;

        //public void LoadBackground(string ImagePath)
        //{
        //    BackgroundImage = new Bitmap(ImagePath);
        //    decimal xHeight = BackgroundImage.Height;
        //    decimal Ratio = 1080 / xHeight;
        //    decimal xWidth = BackgroundImage.Width * Ratio;
        //    if (xWidth < 1920)
        //    {
        //        BackgroundColor = getDominantColor(BackgroundImage);
        //    }
        //    else
        //    { BackgroundColor = Color.Black; }
        //}
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
            //<--Maximize window
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.WindowState = FormWindowState.Maximized;
            GraphicEngine.GetResolution(); //sets resolution for rendering
                                           //-->

            this.panelOptions.AllowDrop = true;
            foreach (Control c in this.panelOptions.Controls)
            {
                c.MouseDown += new MouseEventHandler(c_MouseDown);
            }
            this.panelOptions.DragOver += new DragEventHandler(panelOptions_DragOver);
            this.panelOptions.DragDrop += new DragEventHandler(panelOptions_DragDrop);

            //<--Resize/Move components according to resolution
            button1.Location = new Point(GraphicEngine.X(button1.Location.X), GraphicEngine.Y(button1.Location.Y));
            button1.Size = new Size(GraphicEngine.X(button1.Size.Width), GraphicEngine.Y(button1.Size.Height));

            //-->

            //<--sets hidable Text are to visible state by default
            this.TextAreaVisible = true;
            //-->

            // this.LoadBackground(@"G:\Temp\Images\13.jpg");


            ScriptEngine.GameInit();
           int Value = int.Parse(SQLEngine.GetValue("Select Value from GameOptions where ID=1"));
           if (Value == 1)
            { checkBoxOptions_toggleDominantColor.Checked = true; GraphicEngine.UseDominantColor = true; }
           else
            { checkBoxOptions_toggleDominantColor.Checked = false; GraphicEngine.UseDominantColor = false; }
            

           
            
         
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
            GraphicEngine.DrawBackground(e);
            //GraphicEngine.DrawCharacter(this, 0, 0, 1.3m, 1.3m, e, @"G:\Temp\1.png", 1); //use 0 as width/heigth for default values , last value is Alpha (1 - non transparent, 0.25f etc trans)
            if (TextAreaVisible == true)
            {
                GraphicEngine.DrawTextarea(this, e, TextareaImage);
            }

            
            //MessageBox.Show(text: GraphicEngine.BackgroundImage.Width.ToString());
        }



        private void GameWindow_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //{
            //    ScriptEngine.Next();
            //    this.Invalidate();
            //}

        }

   

        private void GameWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {

                if (TextAreaVisible == true)
                {
                    TextAreaVisible = false;
                    this.Invalidate();
                }
                else
                {
                    TextAreaVisible = true;
                    this.Invalidate();
                }
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ScriptEngine.Next();
                this.Invalidate();

            }
        }

        private void checkBoxOptions_toggleDominantColor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOptions_toggleDominantColor.Checked)
            {
                SQLEngine.Update("Update GameOptions Set value = 1 where id = 1");
                GraphicEngine.UseDominantColor = true;
            }
            else
            {
                SQLEngine.Update("Update GameOptions Set value = 0 where id = 1");
                GraphicEngine.UseDominantColor = false;
            }
        }

        private void button3_Options_Click(object sender, EventArgs e) { panelOptions.Visible = !panelOptions.Visible; }
        private void button3_Click(object sender, EventArgs e) { panelOptions.Visible = false; }


        void c_MouseDown(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            c.DoDragDrop(c, DragDropEffects.Move);
        }

        void panelOptions_DragDrop(object sender, DragEventArgs e)
        {
            Control c = e.Data.GetData(e.Data.GetFormats()[0]) as Control;
            if (c != null)
            {
                c.Location = this.panelOptions.PointToClient(new Point(e.X, e.Y));
                this.panelOptions.Controls.Add(c);
            }
        }

        void panelOptions_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
