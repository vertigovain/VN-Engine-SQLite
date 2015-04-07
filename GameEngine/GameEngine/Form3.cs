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
using WMPLib;


namespace GameEngine
{
    
    public partial class Form3 : Form
    {
        public int xxx;
        GraphicEngine PaintChar = new GraphicEngine();
        public Form3()
        {
            InitializeComponent();
           

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            





        }



 


        public void button1_Click(object sender, EventArgs e)
        {

            xxx = xxx + 100;
            this.Invalidate();
        }

        public void Form3_Paint(object sender, PaintEventArgs e)
        {
            
            
            e.Graphics.Clear(Color.Transparent);
            PaintChar.DrawCharacter(this, 0, 0, 0, 0, e, @"G:\Temp\radiation.jpg", 0.5f);
            PaintChar.DrawCharacter(this, 0, 0, 0, 0, e, @"G:\Temp\1.png", 1); //use 0 as width/heigth for default values , last value is Alpha (1 - non transparent, 0.25f etc trans)
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
