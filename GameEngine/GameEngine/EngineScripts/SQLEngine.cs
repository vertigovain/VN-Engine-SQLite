using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GameEngine.EngineScripts
{
    public static class SQLEngine
    {
        public static SQLiteDataReader ThrowQuery(string Query)
        {
            string ConnString = (@"Data Source=") + Environment.CurrentDirectory + (@"\GameEngine.db; Version=3;");
            SQLiteConnection conn = new SQLiteConnection(ConnString);
            conn.Open();

            SQLiteCommand cmd = conn.CreateCommand();
            string sql_command = Query;
            cmd.CommandText = sql_command;
            SQLiteDataReader r = cmd.ExecuteReader();     
            cmd.Dispose();
            return r;
            


        }

        public static string GetValue(string Query)
        {
            string ConnString = (@"Data Source=") + Environment.CurrentDirectory + (@"\GameEngine.db; Version=3;");
            SQLiteConnection conn = new SQLiteConnection(ConnString);
            conn.Open();

            SQLiteCommand cmd = conn.CreateCommand();
            string sql_command = Query;
            cmd.CommandText = sql_command;


            object Result;
         
            Result = cmd.ExecuteScalar();
            cmd.Dispose();
            conn.Close();
            return Result.ToString();
            
          
            
     
     
            


        }

    }
}
