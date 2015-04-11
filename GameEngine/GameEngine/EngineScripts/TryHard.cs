using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.EngineScripts;
using System.Windows.Forms;

namespace GameEngine.EngineScripts
{
    public static class TryHard
    {

        public static void This(Action x, string Message = "Some kind of error has occured")
        {
            try
            {
                x();
                //MessageBox.Show(text: "all fine!");
            
            }
            catch(Exception e)
            {
                MessageBox.Show(text: Message + Environment.NewLine + Environment.NewLine + e);
            }
            finally
            { }
        }

    }
}
