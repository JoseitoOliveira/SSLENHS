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
    public partial class grafico:UserControl {
        public Size tamanho;

        public grafico() {
            InitializeComponent();
            tamanho=Size;
        }

  


        protected override CreateParams CreateParams {
            get {
                var cp = base.CreateParams;
                cp.Style|=0x840000;  // Turn on WS_BORDER + WS_THICKFRAME
                return cp;
            }
        }

        private void btnMax_Click(object sender, EventArgs e) {
            PlotTelaCheia plotMaximizado = new PlotTelaCheia();
            plotMaximizado.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            
        }
    }
}
