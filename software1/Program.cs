using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software1 {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Usuario user;
            Login login = new Login();
            login.ShowDialog();
            user=login.user;
            if(user.login!=null && login.UsarOffiline==false) {
                Application.Run(new home(user));
            }
            if(login.UsarOffiline==true) {
                Application.Run(new home());
            }
            
            
        }
    }
}
