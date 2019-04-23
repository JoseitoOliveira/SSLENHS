using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software1 {
    public partial class ConfigurarBanco:Form {

        Conexao conn = new Conexao();

        public ConfigurarBanco() {
            InitializeComponent();
            loadData();
        }

        void loadData() {
            txtServerIP.Text=conn.serverIP.ToString();
            txtUser.Text=conn.username;
            txtPass.Text=conn.password;
        }

        private void btnAplicar_Click(object sender, EventArgs e) {
            conn.update(txtServerIP.Text,txtUser.Text,txtPass.Text);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
