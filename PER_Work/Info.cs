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

        public info()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text != "" && txtmail.Text != "")
            {
                MessageBox.Show("Salvo com sucesso", "Welcome");

                using (SqlConnection conexao = new SqlConnection("Server=AME0556321W10-1\\SQLEXPRESS;Database=PER_work;Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into TBJogadores(nome,sobrenome,email) OUTPUT INSERTED.ID_JOGADOR values(@Nome,@Sobre,@Email)", conexao))
                    {
                        comando.Parameters.AddWithValue("Nome", txtnome.Text);
                        comando.Parameters.AddWithValue("Sobre", txtsobrenome.Text);
                        comando.Parameters.AddWithValue("Email", txtmail.Text);
                        conexao.Open();
                        int id_jogador = (int)comando.ExecuteScalar();
                        MessageBox.Show("Hard = 15\nMedio = 10\nFacil = 5", "Valor das dificuldades");
                        this.Hide();

                        Pergunta1 P1 = new Pergunta1(id_jogador); Pergunta2 P2 = new Pergunta2(id_jogador); Pergunta3 P3 = new Pergunta3(id_jogador);
                        Pergunta4 P4 = new Pergunta4(id_jogador); Pergunta5 P5 = new Pergunta5(id_jogador);

                        P1.ShowDialog(); P2.ShowDialog(); P3.ShowDialog(); P4.ShowDialog(); P5.ShowDialog();


                        comando.CommandText = "Select SUM(pontos) from TBPerguntas where id_jogador = @FINAL";
                        comando.Parameters.AddWithValue("FINAL", id_jogador);

                        SqlDataReader acertos = comando.ExecuteReader();
                        acertos.Read();
                        int pontos = acertos.GetInt32(0);
                        FinalTel Fim = new FinalTel(id_jogador,pontos);
                        Fim.ShowDialog();
                        acertos.Close();
                        this.Close();
                    }
                }
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
