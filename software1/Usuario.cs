using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software1
{
    public class Usuario
    {
        public string login { set; get; }
        public string permissao { set; get; }

        public Usuario() {
            login=null;
            permissao=null;
        }

    }
}
