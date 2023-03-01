using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ti92class;


namespace ti92app
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNome.Text, txtCpf.Text, txtEmail.Text);
            cliente.Inserir();
            txtId.Text = cliente.Id.ToString();
        }


        private void FrmCliente_Load(object sender, EventArgs e)
        {
            var lista = Cliente.Listar();
            int linha = 0;
            foreach (var item in lista)
            {
                dtgCliente.Rows.Add();
                dtgCliente.Rows[linha].Cells[0].Value = item.Id;
                dtgCliente.Rows[linha].Cells[1].Value = item.Nome;
                dtgCliente.Rows[linha].Cells[2].Value = item.Cpf;
                dtgCliente.Rows[linha].Cells[3].Value = item.Telefones;
                dtgCliente.Rows[linha].Cells[4].Value = item.Enderecos;
                dtgCliente.Rows[linha].Cells[5].Value = item.Email;
                dtgCliente.Rows[linha].Cells[6].Value = item.Data;
                dtgCliente.Rows[linha].Cells[7].Value = item.Ativo;
                linha++;
            }
        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCpf.Text = dtgCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dtgCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDataCli.Text = dtgCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
            chkAtivoCli.Checked = (bool)dtgCliente.Rows[e.RowIndex].Cells[5].Value;
        }

        private void dtgTelefone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumero.Text = dtgTelefone.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbTipoTelefone.Text = dtgTelefone.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dtgEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCep.Text = dtgEndereco.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLogradouro.Text = dtgEndereco.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNumero.Text = dtgEndereco.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtComplemento.Text = dtgEndereco.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtBairro.Text = dtgEndereco.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCidade.Text = dtgEndereco.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEstado.Text = dtgEndereco.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtUf.Text = dtgEndereco.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmbTipoEndereco.Text = dtgEndereco.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(int.Parse(txtId.Text), txtNome.Text, txtCpf.Text, txtEmail.Text, DateTime.Parse(txtDataCli.Text), chkAtivoCli.Checked, Telefone.ListarPorCliente(int.Parse(txtId.Text)), Endereco.ListarPorCliente(int.Parse(txtId.Text)));
            cliente.Atualizar();
            MessageBox.Show("Cliente Atualizado com sucesso!");
            FrmCliente_Load(sender, e);
        }

        private void btnAcrescentar_Click(object sender, EventArgs e)
        {

        }

        private void pnlTelefone_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}