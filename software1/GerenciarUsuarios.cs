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
    public partial class GerenciarUsuarios:Form {
        public GerenciarUsuarios() {
            InitializeComponent();
        }


        private void btnAddUser_Click(object sender, EventArgs e) {
            EditarUsuario addUser = new EditarUsuario();
            addUser.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
