using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edecasa.Controllers;
using Edecasa.Models;

namespace Edecasa
{
    public partial class UC_Bebidas : UserControl
    {
        public UC_Bebidas()
        {
            InitializeComponent();
        }

        private void UC_Bebidas_Load(object sender, EventArgs e)
        {
            refreshDataGrid();

            if (DataGridViewBebidas.SelectedRows.Count == 0)
            {
                btneditar.Visible = false;
                btnexcluir.Visible = false;
            } 
            else
            {
                btneditar.Visible = true;
                btnexcluir.Visible = true;
            }
        }

        private void refreshDataGrid()
        {
            var produtoController = new ProdutoController();
            var produtos = produtoController.getByCategoria("Bebida");

            var data = from produto in produtos
                       select new
                       {
                           Id = produto.Id,
                           Descricao = produto.Descricao,
                           Valor_Pequeno = produto.VlPequeno,
                           Valor_Grande = produto.VlGrande
                       };

            DataGridViewBebidas.DataSource = data.ToList();
        }
        private void tbbusca_TextChanged(object sender, EventArgs e)
        {
            if (tbbusca.Text == "")
            {
                refreshDataGrid();
                return;
            }

            if(cbfiltrar.Text == "Todos")
            {
                refreshDataGrid();
            }
            else if (cbfiltrar.Text == "Id")
            {
                var produtoController = new ProdutoController();
                var produtos = produtoController.getByCategoria("Bebida");

                var data = from produto in produtos
                           where produto.Id == Convert.ToInt32(tbbusca.Text)
                           select new
                           {
                               Id = produto.Id,
                               Descricao = produto.Descricao,
                               Valor_Pequeno = produto.VlPequeno,
                               Valor_Grande = produto.VlGrande
                           };

                DataGridViewBebidas.DataSource = data.ToList();
            }
            else if (cbfiltrar.Text == "Descrição")
            {
                var produtoController = new ProdutoController();
                var produtos = produtoController.getByCategoria("Bebida");

                var data = from produto in produtos
                           where produto.Descricao.Contains(tbbusca.Text)
                           select new
                           {
                               Id = produto.Id,
                               Descricao = produto.Descricao,
                               Valor_Pequeno = produto.VlPequeno,
                               Valor_Grande = produto.VlGrande
                           };

                DataGridViewBebidas.DataSource = data.ToList();
            }
            else if (cbfiltrar.Text == "Valor")
            {
                var produtoController = new ProdutoController();
                var produtos = produtoController.getByCategoria("Bebida");

                var data = from produto in produtos
                           where produto.VlGrande == Convert.ToDouble(tbbusca.Text) || produto.VlPequeno == Convert.ToDouble(tbbusca.Text)
                           select new
                           {
                               Id = produto.Id,
                               Descricao = produto.Descricao,
                               Valor_Pequeno = produto.VlPequeno,
                               Valor_Grande = produto.VlGrande
                           };

                DataGridViewBebidas.DataSource = data.ToList();
            }
        }

        private void DataGridViewBebidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int produtoId = Convert.ToInt32(DataGridViewBebidas.CurrentRow.Cells["Id"].Value);

            Quantidade quantidadeForm = new Quantidade(produtoId);
            quantidadeForm.ShowDialog();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            ProdutoCadastrarEditar produtoForm = new ProdutoCadastrarEditar("Bebida");
            produtoForm.ShowDialog();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (DataGridViewBebidas.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(DataGridViewBebidas.CurrentRow.Cells["Id"].Value);

                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja excluir este registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    var produtoController = new ProdutoController();
                    var ret = produtoController.delete(id);

                    if (ret)
                    {
                        MessageBox.Show("Registro excluido com sucesso!", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (DataGridViewBebidas.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(DataGridViewBebidas.CurrentRow.Cells["Id"].Value);
                string descricao = DataGridViewBebidas.CurrentRow.Cells["Descricao"].Value.ToString();
                double vlGrande = Convert.ToDouble(DataGridViewBebidas.CurrentRow.Cells["Valor_Grande"].Value);
                double vlPequeno = Convert.ToDouble(DataGridViewBebidas.CurrentRow.Cells["Valor_Pequeno"].Value);
                string categoria = "Bebida";

                Produto produto = new Produto { Id = id, Descricao = descricao, VlGrande = vlGrande, VlPequeno = vlPequeno, Categoria = categoria };

                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja editar essa linha?", "Editar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    ProdutoCadastrarEditar produtoForm = new ProdutoCadastrarEditar(produto);
                    produtoForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha", "Editar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbfiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbbusca.Text = "";
            refreshDataGrid();
        }
    }
}
