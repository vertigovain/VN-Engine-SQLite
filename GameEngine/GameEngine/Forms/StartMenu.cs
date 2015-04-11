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
using GameEngine.EngineScripts;

namespace GameEngine
{
    
    public partial class Form1MainMenu : Form
    {
       
        public Form1MainMenu()
        {
            InitializeComponent();
        }

        public static void FillScenarioList(ListBox x)
        {
            SQLiteDataReader r = SQLEngine.ThrowQuery("SELECT Name FROM Scenarios");
            string line = String.Empty;
            while (r.Read())
            {
                line = r["Name"].ToString();
                x.Items.Add(line);

            } 
            r.Close();
            SQLiteConnection.ClearAllPools();

        }

        public static void ScenarioSelected(ListBox x, Label y)
        {
            
            String r = SQLEngine.GetValue("SELECT Description FROM Scenarios WHERE Name ='" + x.Text + "'");
            y.Text = r;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TryHard.This(() => FillScenarioList(listBox1), "Failed to fill Scenario List");

     

        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var GameWindow = new Constructor();
            GameWindow.Closed += (s, args) => this.Close();
            GameWindow.Show();
 
            
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
            TryHard.This(() => ScenarioSelected(listBox1, label3), "Failed to update Scenario Text at Label3");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
