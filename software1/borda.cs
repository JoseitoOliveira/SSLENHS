using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software1 {
    public partial class borda:UserControl {
        Form janela;
        Color backgroud =DefaultBackColor;
        public borda() {
            InitializeComponent();
        }
        public void setJanela(Form j) {
            janela=j;
        }


        public void setTtilulo(string text) {
            Titulo.Text=text;
        }

        // Esse é o form padrão, todos os outros deverão herdar deste
        //Variáveis responsáveis por mover a janela
        bool mov;
        int xIni;
        int yIni;


        private void borda_MouseDown(object sender, MouseEventArgs e) {
            mov=true;
            xIni=e.X;
            yIni=e.Y;

        }

        private void borda_MouseMove(object sender, MouseEventArgs e) {
            if(mov) {
                janela.SetDesktopLocation(MousePosition.X-xIni, MousePosition.Y-yIni);
            }
        }
        private void btnClose_Click(object sender, EventArgs e) {
            janela.Close();
        }

        private void btnMinimizer_Click(object sender, EventArgs e) {
            janela.WindowState=FormWindowState.Minimized;
        }
        private void borda_MouseUp(object sender, MouseEventArgs e) {
            mov=false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e) {
            btnClose.BackColor=Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e) {
            btnClose.BackColor=Color.Transparent;
        }
    }
}
