using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using GameEngine.EngineScripts;


namespace GameEngine
{
    public static class ScriptEngine
    {
        public static int ScriptPosition = 1;
        public static int ScriptLength = int.Parse(SQLEngine.GetValue("SELECT Count(*) FROm ScnScript"));
        public static int ActionType;
        public static string Path;


        public static void GameInit()
        {
            ActionType = int.Parse(SQLEngine.GetValue("SELECT CmdID FROm ScnScript WHERE ID =" + ScriptPosition.ToString()));
            switch (ActionType)
            {
                case 1:
                    TryHard.This(() => SQLEngine.ImagePath());
                    GraphicEngine.SetBackground();
                    break;
                case 2:
                    break;
                case 3:
                    break;

            }

        }


        public static void Next()
        {
            ++ScriptPosition;
            if (ScriptPosition <= ScriptLength)
            {


                ActionType = int.Parse(SQLEngine.GetValue("SELECT CmdID FROm ScnScript WHERE ID =" + ScriptPosition.ToString()));
                switch (ActionType)
                {
                    case 1:
                        TryHard.This(() => SQLEngine.ImagePath());
                        GraphicEngine.SetBackground();
                        //MessageBox.Show(text: ScriptPosition.ToString());
                        break;
                    case 2:
                        break;
                    case 3:
                        break;

                }
            }

            else
            {
                MessageBox.Show(text: "End of Script.");
            }

            }
           

        }
    }

