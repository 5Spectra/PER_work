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
    public partial class Pergunta3 : Form
    {
        public int id_save;
        public Pergunta3(int id_jogador)
        {
            InitializeComponent();
            id_save = id_jogador;
            nivel.Text = "Médio";
            RB1.Text = "Inglês";
            RB2.Text = "Espanhol";
            RB3.Text = "Portugues";
            RB4.Text = "Branca";
        }

        private void Conf_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0556321W10-1\\SQLEXPRESS;Database=PER_work;Trusted_Connection=Yes"))
            {
                using (SqlCommand comando = new SqlCommand("insert into TBPerguntas(pergunta,r_correta,nivel,pontos,id_jogador) values(@Per,@R,@N,@P,@ID)", conexao))
                {
                    comando.Parameters.AddWithValue("Per", Perg.Text);
                    comando.Parameters.AddWithValue("R", RB4.Text);
                    comando.Parameters.AddWithValue("N", nivel.Text);
                    comando.Parameters.AddWithValue("ID", id_save);
                    if (RB4.Checked == true)
                        comando.Parameters.AddWithValue("P", 10);
                    else
                        comando.Parameters.AddWithValue("P", 0);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                    this.Close();
                }
            }
        }
    }
}
