using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            // Aula Teste de Login

            //Jonas Valereo Técnico em Informática

            //Declarando as variais 

            string usuario, senha;

            usuario = textUsuario.Text;
            senha = textSenha.Text;


            //Declarando tomada de decisão IF / decisão, se o Usuario e senha for iguais será chamado form2

            if (usuario == "teste" && senha == "teste")
          
               
            {

                //Declarando o codigo objeto novo 

                Form2 novo = new Form2();

                //Declarando, chamar o metodo show do form2
                novo.Show();

                //Declarando, fecha o form1
                this.Visible = false;





            }
        }
    }
}
