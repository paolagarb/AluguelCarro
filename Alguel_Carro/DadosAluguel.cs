using Alguel_Carro.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alguel_Carro
{
    public partial class DadosAluguel : Form
    {
        Aluguel aluguel1;
        public DadosAluguel()
        {
            InitializeComponent();
        }

        public DadosAluguel(Aluguel aluguel)
        {
            InitializeComponent();

             aluguel1 = aluguel;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 aluguel = new Form1();
            aluguel.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aluguel confirmado!", "Confirmado!");
            this.Visible = false;
            Form1 aluguel = new Form1();
            aluguel.Visible = true;
        }

        private void DadosAluguel_Load(object sender, EventArgs e)
        {
            lblValor.Text = aluguel1.Fatura.ToString();
            lblModelo.Text = aluguel1.Carro.Modelo;
            lblRetirada.Text = aluguel1.Retirada.ToString("dd/MM/yyyy HH:mm");
            lblDevolucao.Text = aluguel1.Devolução.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
