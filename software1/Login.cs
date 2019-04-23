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
    public partial class Login:Form {

        public Usuario user = new Usuario();
        public bool UsarOffiline = false;

        public Login() {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if(txtUser.Text == "admin" && txtPass.Text =="0000") {
                user.login=txtUser.Text;
                user.permissao="permissão";
                this.Close();
            }
            else {
                MessageBox.Show("Usuário ou senha incorretos");
                txtPass.Text="";
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            UsarOffiline=true;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            ConfigurarBanco configurarBanco = new ConfigurarBanco();
            configurarBanco.ShowDialog();
        }
    }
}
