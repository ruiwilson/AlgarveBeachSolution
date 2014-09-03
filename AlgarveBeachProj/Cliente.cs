using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgarveBeach
{
   public class Cliente
    {
    //Campos da tabela clientes T_~ 
        private string mUsername;
        private string mPassword;
        private string mNome;
        private string mEmail;
        

        //Método Construtor vazio permite construir um objecto carro sem propriedades iniciais
        public Cliente()
        {
        }

        public Cliente(string Username, string Password, string Nome, string Email)
        {
            this.Username = Username;
            this.Password = Password;
            this.Nome = Nome;
            this.Email = Email;
            
        }

        //Método responsável por carregar os dados de um cliente existente na base de dados
        public void CarregarCliente(string IDcliente)
        {
            string[] campos = { "Username", "Password", "Nomecliente", "Emailcliente" };
            AcessoBD aBD = new AcessoBD("ANDROID-PC", "ALGARCOM", "sa", "1234");
            string[] valores = aBD.LerTabela("Clientes", campos, "IDcliente", IDcliente);
            this.Username = valores[0];
            this.Password = valores[1];
            this.Nome = valores[2];
            this.Email = valores[3];     
        }

        //Método responsável por actualizar um cliente existente na base de dados
        public void ActualizarCliente(string IDcliente)
        {
            string[] campos = { "Username", "Password", "Nomecliente", "Emailcliente" };
            string[] valores = { this.Username, this.Password, this.Nome, this.Email };
            AcessoBD aBD = new AcessoBD("ANDROID-PC", "ALGARCOM", "sa", "1234");
            aBD.ActualizaTabela("Clientes", campos, valores, "IDcliente", IDcliente);
        }

        //Método responsável por inserir um novo cliente na base de dados
        public void InserirCliente()
        {
            string[] campos = { "Username", "Password", "Nomecliente", "Emailcliente" };
            string[] valores = { this.Username, this.Password, this.Nome, this.Email }; 
            AcessoBD aBD = new AcessoBD("ANDROID-PC", "ALGARCOM", "sa", "1234");
            aBD.InserirRegisto("Clientes", campos, valores);
        }

        //Método responsável pela caracterização do carro mostrando as suas propriedades básicas
        public string Caracteriza()
        {
            return "Este cliente chama-se " + this.Nome;
        }


        //Método responsável por apagar Clientes
        public void ApagarCliente(string IDcliente)
        {
            AcessoBD aBD = new AcessoBD("ANDROID-PC", "ALGARCOM", "sa", "1234");
            aBD.ApagarRegisto("Clientes", "IDcliente", IDcliente);
        }



        //::::::::::::::::::::::Propriedades::::::::::::::::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        public string Username
        {
            get { return mUsername; }
            set { mUsername = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public string Nome
        {
            get { return mNome; }
            set { mNome = value; }
        }

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }
        
    }
}
