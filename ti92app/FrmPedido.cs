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
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = Cliente.Listar();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember= "Id";

            cmbUsuario.DataSource = Usuario.Listar();
            cmbUsuario.DisplayMember = "Nome";
            cmbUsuario.ValueMember = "Id";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(Cliente.ObterPorId((int)cmbCliente.SelectedValue), Usuario.ObterPorId((int)cmbUsuario.SelectedValue));
            pedido.Inserir();
            lblStatus.Text = pedido.Status.ToString()+" - "+pedido.Hashcode;
            txtId.Text = pedido.Id.ToString();
            btnInserir.Enabled = false;
            grbProduto.Enabled = true;
            txtIdProd.Focus();
        }

        private void txtIdProd_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                Produto produto = Produto.ObterPorId(int.Parse(txtId.Text));
                if (produto.Id > 0)
                {
                    txtDescricao.Text = produto.Descricao;
                    txtUnidade.Text = produto.Unidade;
                    txtPreco.Text = produto.Preco.ToString();
                }
                else
                {
                    txtDescricao.Text = "***** Produto não cadastrado! *****";
                }
            }
            else
            {
                txtDescricao.Clear();
                txtUnidade.Clear();
                txtPreco.Clear();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            grbDados.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ItemPedido item = new ItemPedido(int.Parse(txtId.Text),Produto.ObterPorId(int.Parse(txtIdProd.Text)),double.Parse(txtQuantidade.Text),double.Parse(txtDesconto.Text));
            item.Adicionar();
            AtualizaDataGrid(int.Parse(txtId.Text));
        }
        public void AtualizaDataGrid(int id)
        {
            dgvItens.Rows.Clear();
            List<ItemPedido> items = ItemPedido.Listar(id);
            double total = 0;
            int linha =0;
            foreach (var item in items)
            {
                dgvItens.Rows.Add();
                dgvItens.Rows[linha].Cells[0].Value = linha + 1;
                dgvItens.Rows[linha].Cells[1].Value = item.Produto.Id.ToString();
                dgvItens.Rows[linha].Cells[2].Value = item.Produto.Descricao.ToString();
                dgvItens.Rows[linha].Cells[3].Value = item.Produto.Unidade.ToString();
                dgvItens.Rows[linha].Cells[4].Value = item.Preco.ToString("##0.00");
                dgvItens.Rows[linha].Cells[5].Value = item.Quantidade.ToString("##0.000");
                dgvItens.Rows[linha].Cells[6].Value = item.Desconto.ToString("##0.00");
                double totalIten = (item.Preco * item.Quantidade) - item.Desconto;
                dgvItens.Rows[linha].Cells[7].Value = totalIten.ToString("##0.00");
                linha++;
                total += totalIten;
            }
            txtTotal.Text = total.ToString("##0.00");
        }
    }
}
