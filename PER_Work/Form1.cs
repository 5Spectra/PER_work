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
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string difi = Convert.ToString(dificuldade.Text);
            if (difi == "Médio")
            MessageBox.Show(difi);

            //Info I1 = new Info(id_jogador);
            //Pergunta1 P2 = new Pergunta1(id_jogador); Pergunta2 P2 = new Pergunta2(id_jogador);
            //Pergunta3 P3 = new Pergunta3(id_jogador); Pergunta4 P4 = new Pergunta4(id_jogador);

           //I1.ShowDialog(); P1.ShowDialog(); P2.ShowDialog(); P3.ShowDialog(); P4.ShowDialog();
        }
    }
}
