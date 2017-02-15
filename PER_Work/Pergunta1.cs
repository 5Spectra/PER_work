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
    public partial class Pergunta1 : Form
    {
        public int id_save;
        public Pergunta1(int id_jogador)
        {
            InitializeComponent();
            id_save = id_jogador;
            RB1.Text = "Azul";
            RB2.Text = "Vermelho";
            RB3.Text = "Verde";
            RB4.Text = "Outros";
            nivel.Text = "Fácil";         
        }

        private void Conf_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0556321W10-1\\SQLEXPRESS;Database=PER_work;Trusted_Connection=Yes"))
            {
                using (SqlCommand comando = new SqlCommand("insert into TBPerguntas(pergunta,r_correta,nivel,pontos,id_jogador) values(@Per,@R,@N,@P,@ID)", conexao))
                {
                    comando.Parameters.AddWithValue("Per", Perg.Text);
                    comando.Parameters.AddWithValue("R", "todas");
                    comando.Parameters.AddWithValue("N", nivel.Text);
                    comando.Parameters.AddWithValue("ID", id_save);
                    comando.Parameters.AddWithValue("P", 5);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                    this.Close();
                }
            }
        }
    }
}
