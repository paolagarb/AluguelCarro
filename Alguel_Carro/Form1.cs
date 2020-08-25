using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alguel_Carro.Entities;

namespace Alguel_Carro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string modelo = txtModelo.Text;
            DateTime retirada = pickerRetirada.Value;
            DateTime devolucao = pickerDevolucao.Value;
            double valorH = double.Parse(txtValorHora.Text);
            double valorD = double.Parse(txtValorDia.Text);

            Carro carro = new Carro(modelo);
            Aluguel aluguel = new Aluguel(retirada, devolucao, carro);

        }
    }
}
