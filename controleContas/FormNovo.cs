using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleContas
{

    public partial class FormNovo : Form
    {

        List<Cliente> clientes = new List<Cliente>();

        private FrmContas frmContas;
        public FormNovo()
        {
            InitializeComponent();
        }
              
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                frmContas = new FrmContas();
                frmContas.AddClient(nomeNovo.Text, Int32.Parse(anoNascimentoNovo.Text), cpfNovo.Text);
                frmContas.cmbTitular.Refresh();

                this.Close();
                //   clientes.Add(new Cliente(nomeNovo.Text, Int32.Parse(anoNascimentoNovo.Text), cpfNovo.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha os campos corretamente");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNovo_Load(object sender, EventArgs e)
        {
           
        }

        private void anoNascimentoNovo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpfNovo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
