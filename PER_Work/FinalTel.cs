using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PER_Work
{
    public partial class FinalTel : Form
    {
        public string pontos_salvos;
        public int id_salvo, pontos_s;

        public FinalTel(int id_jogador, int pontos)
        {
            InitializeComponent();
            pontos_salvos = Convert.ToString(pontos);
            Ponta.Text = pontos_salvos;
            pontos_s = pontos;
            if (pontos_s == 0) { txtfina.Text = "Desiste"; }
            else if (pontos_s <= 10 && pontos_s > 4) { txtfina.Text = "Continua tentando"; }
            else if (pontos_s <= 20 && pontos_s > 10) { txtfina.Text = "Tá quase"; }
            else if (pontos_s <= 40 && pontos_s > 20) { txtfina.Text = "Quase deu"; }
            else if (pontos_s >= 50) { txtfina.Text = "Parabéns"; }

        }

        private void Try_Click(object sender, EventArgs e)
        {
            //intro start = new intro();
            //start.ShowDialog();
            this.Close();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
