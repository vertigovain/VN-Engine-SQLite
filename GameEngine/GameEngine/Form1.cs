using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEngine
{
    
    public partial class Form1MainMenu : Form
    {
        string TestVar = "Hello World!";
        public Form1MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=D:\\C# Project\\GameEngine\\Database\\GameEngine.db; Version=3;");
            conn.Open();


            SQLiteCommand cmd = conn.CreateCommand();
            string sql_command = "SELECT Name FROM Scenarios";
            cmd.CommandText = sql_command;
            SQLiteDataReader r = cmd.ExecuteReader();
            string line = String.Empty;
            while (r.Read())
            {
                line = r["Name"].ToString();
                listBox1.Items.Add(line);

            }
            r.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var GameWindow = new Form3();
            GameWindow.Closed += (s, args) => this.Close();
            GameWindow.Show();
            //this.Close();  //use only if another form is added at Program.cs
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var GameWindow = new GameWindow();
            GameWindow.Closed += (s, args) => this.Close();
            GameWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=D:\\C# Project\\GameEngine\\Database\\GameEngine.db; Version=3;");
            conn.Open();
        

            SQLiteCommand cmd = conn.CreateCommand();
            string sql_command = "SELECT Description FROM Scenarios WHERE Name ='"+listBox1.Text +"'";
            cmd.CommandText = sql_command;
            object Result;
            try
            {
                Result = cmd.ExecuteScalar();
                label3.Text = Result.ToString();
            }
            catch (SQLiteException ex)
            {
                label3.Text = ex.Message;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
