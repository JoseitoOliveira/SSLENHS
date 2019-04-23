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
    public partial class home:Form {
        public home(Usuario user) {
            InitializeComponent();
            lblUser.Text=user.login;
            lblPermissao.Text=user.permissao;
        }
        public home() {
            InitializeComponent();
            lblUser.Visible=false;
            lblPermissao.Visible=false;
            lblLogout.Visible=false;
            imgLogout.Visible=false;

        }

        private void btnUsers_Click(object sender, EventArgs e) {
            GerenciarUsuarios gerenciarUsuarios = new GerenciarUsuarios();
            gerenciarUsuarios.Show();
        }
    }
}
