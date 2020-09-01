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
    public partial class FrmContas : Form
    {
        List<Conta> contas = new List<Conta>();
        List<Cliente> clientes = new List<Cliente>();

        public FrmContas()
        {
            InitializeComponent();

            this.AddClient("Pedro", 1992, "123456789");

            lstContas.Items.Clear();
            lstContas.Items.Add("Nome\tCPF\tTitular");

            clientes.ForEach(delegate (Cliente cli)
            {
                cmbTitular.Items.Add(cli.Nome);
            }
           );
        }

        public void AddClient(string nome, int ano, string cpf)
        {
            clientes.Add(new Cliente(nome, ano, cpf));
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormNovo frm = new FormNovo();
            frm.ShowDialog(this);
            frm.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (sair.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void lstContas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstContas.Items.Add(accountNumber.Text + "\t" + balance.Text + "\t" + cmbTitular.SelectedItem.ToString());
        }

        private void balance_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstContas.Items.Clear();
        }
    }
}
