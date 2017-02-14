using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PER_Work
{
    public partial class info : Form
    {
        public string server_in = "Server= ;Database= ;Trusted_Connection=Yes"; 

        public info()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text != "" && txtmail.Text != "") {
            MessageBox.Show("Salvo com sucesso", "Welcome");
            /*
            using (SqlConnection conexao = new SqlConnection(server_in))
            {
                using (SqlCommand comando = new SqlCommand("insert into TBJogadores(nome,sobrenome,email) OUTPUT.ID values("+ txtnome.Text +"," + txtsobrenome.Text +"," + txtmail.Text +")", conexao)) {
                    conexao.Open();
                    int id_jogador = (int)comando.ExecuteScalar();
                }*/
                this.Close();
                }




        }

        private void txtnome_Enter(object sender, EventArgs e)
        {
            txtnome.Text = "";
        }

        private void txtsobrenome_Enter(object sender, EventArgs e)
        {
            txtsobrenome.Text = "";
        }

        private void txtmail_Enter(object sender, EventArgs e)
        {
            txtmail.Text = "";
        }
    }
}
