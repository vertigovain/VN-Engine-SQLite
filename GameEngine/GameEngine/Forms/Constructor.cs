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
using System.Data.SQLite;
using GameEngine.EngineScripts;


namespace GameEngine
{
    
    public partial class Constructor : Form
    {
       
        public Constructor()
        {
            InitializeComponent();
           

        }

        static void FillScenarioListBox(ListBox x)
        {
            SQLiteDataReader r = SQLEngine.ThrowQuery("SELECT scr.ID, ScnCommands.Description, img.path FROM ScnScript scr left outer join ResImages img on scr.cmdAction = img.id left outer join ScnCommands on scr.cmdID = ScnCommands.ID");
            string line = String.Empty;
            while (r.Read())
            {
                line = r["ID"].ToString() + " " + r["Description"].ToString() + " " + r["Path"].ToString();
                x.Items.Add(line);

            }
            r.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Fill ListBox1;
            TryHard.This(() => FillScenarioListBox(listBox1), "Failed to fill Scenario List.");
            






        }



 


        
    }
}
