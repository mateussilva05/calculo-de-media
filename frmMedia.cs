using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void frmMedia_Load(object sender, EventArgs e)
        {

        }

        private void lblNota2_Click(object sender, EventArgs e)
        {

        }

        private void lblNota3_Click(object sender, EventArgs e)
        {

        }

        private void lblNota1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNota1.Text == "")
            {
                MessageBox.Show("Insira as notas do aluno nas caixas de textos respectivas para prosseguir", "opa",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double resultado, numero1, numero2, numero3, numerot;

                numero1 = double.Parse(txtNota1.Text);
                numero2 = double.Parse(txtNota2.Text);
                numero3 = double.Parse(txtNota3.Text);
                numerot = double.Parse(txtTrabalho.Text);

                resultado = (numero1 + numero2 + numero3 + numerot) / 4;
                txtResultado.Text += resultado;
                
                if (resultado >= 6)
                {
                    txtResultado.ForeColor = Color.Lime;
                    lblResultado.ForeColor = Color.Lime;
                    lblResultado.Text = "O aluno conseguiu alcançar a média " + resultado + " e foi aprovado!";
                }
                else
                {
                    txtResultado.ForeColor = Color.Maroon;
                    lblResultado.ForeColor = Color.Maroon;
                    lblResultado.Text = "O aluno conseguiu alcançar a média " + resultado + " e acabou reprovado...";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtTrabalho.Text = "";
            txtResultado.Text = "";
            lblResultado.Text = "";
        }
    }
}
