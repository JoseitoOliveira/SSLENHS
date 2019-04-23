using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace software1 {
    class Conexao {

        public IPAddress serverIP;
        public int port;
        public string username;
        public string password;

        public Conexao() {
            if(!File.Exists("AcessDB.cfg")) {
                StreamWriter escritor = File.CreateText("AcessDB.cfg");
                escritor.WriteLine("ServerIP:192.168.0.200");
                escritor.WriteLine("Porta:6006");
                escritor.WriteLine("Usuario:Admin");
                escritor.WriteLine("Password:0000");
                escritor.Close();
            }
            inicializeDados();
        }

        public void inicializeDados() {
            StreamReader leitor = File.OpenText("AcessDB.cfg");
            serverIP=IPAddress.Parse(leitor.ReadLine().Split(':')[1]);
            port=int.Parse(leitor.ReadLine().Split(':')[1]);
            username=leitor.ReadLine().Split(':')[1];
            password=leitor.ReadLine().Split(':')[1];
            leitor.Close();
        }


        public void update(string serverIP, int port, string username, string password) {
            this.serverIP=IPAddress.Parse(serverIP);
            this.port=port;
            this.username=username;
            this.password=password;
            StreamWriter escritor = new StreamWriter("AcessDB.cfg");
            escritor.WriteLine("ServerIP:"+serverIP);
            escritor.WriteLine("Porta:"+port.ToString());
            escritor.WriteLine("Usuario:"+username);
            escritor.WriteLine("Password:"+password);
            escritor.Close();
        }


        public void update(string serverIP, string username, string password) {
            this.serverIP=IPAddress.Parse(serverIP);
            this.username=username;
            this.password=password;
            StreamWriter escritor = File.CreateText("AcessDB.cfg");
            escritor.WriteLine("ServerIP:"+serverIP);
            escritor.WriteLine("Porta:"+port.ToString());
            escritor.WriteLine("Usuario:"+username);
            escritor.WriteLine("Password:"+password);
            escritor.Close();
        }


    }
}
