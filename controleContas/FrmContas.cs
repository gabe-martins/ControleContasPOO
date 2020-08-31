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
            clientes.Add(new Cliente("Pedro", "12345"));
            clientes.Add(new Cliente("Kenia", "12346"));

            lstContas.Items.Clear();
            lstContas.ForEach(delegate (Cliente cli)
            {
                cmbTiTular.Items.Add(cli.Nome);
            }
            );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
    }
}
