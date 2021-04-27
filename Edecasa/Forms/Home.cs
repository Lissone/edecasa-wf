using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Edecasa.Properties;
using Edecasa.Forms;
using Edecasa.Models;
using Edecasa.Controllers;

namespace Edecasa
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        //variaveis globais
        public static bool refresh;
        public static int pedidoId = 0;
        public static string pizza = "0", pizzametade = "0", bebida = "0", outro = "0";//para o form quantidade saber o item / =0 n tem registro
        public static string registrar, datagora, pedido, limpar_array; //registrar adicionar valor na label de valor da home / refresh = dar um refresh na sacola
        public static double valoritem, total; //calcular sacola de todos os items
        public static string[] idpedido = new string[200];
        public static string[] nomepedido = new string[200];
        private void btnfechar_Click(object sender, EventArgs e)
        {
            //if(pedidoId == 0)
            //{
            //    MessageBox.Show("É necessário fechar o pedido para sair.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            this.Close();
        }
        private void moveSidePanel(Control btn)
        {
            panelsidehome.Top = btn.Top;
            panelsidehome.Height = btn.Height;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            UC_Home uch = new UC_Home();
            AdicionarControlesParaPainel(uch);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            if(DataGridViewItens.Rows.Count.ToString() == "0")//SE SACOLA ESTIVER VAZIA
            {
                MessageBox.Show("Sacola de pedidos vazia!", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "DELETE FROM PEDIDO";
                SqlCommand deleteCommand = new SqlCommand(query);
                int row = objDBAccess.executeQuery(deleteCommand);
                if (row != 0)
                {
                    limpar_array = "1";
                    txtvalor.Text = "0";
                    total = 0;
                    refresh = true;
                    MessageBox.Show("Sacola de pedidos limpa!", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            panelsidehome.Visible = false;

            CadastrarPedido abrirform = new CadastrarPedido();
            abrirform.ShowDialog();
        }

        private void btnajustes_Click(object sender, EventArgs e)
        {
            Ajustes abrirform = new Ajustes();
            abrirform.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DataGridViewItens.ColumnCount = 4;
            DataGridViewItens.Columns[0].Name = "Quant.";
            DataGridViewItens.Columns[1].Name = "Produto";
            DataGridViewItens.Columns[2].Name = "Tamanho";
            DataGridViewItens.Columns[3].Name = "Valor";

            refreshDataGrid();

            panelsidehome.Visible = false;
        }

        private void refreshDataGrid()
        {
            DataGridViewItens.Rows.Clear();

            var itemController = new ItemController();
            var itens = itemController.getByPedidoId(pedidoId);

            var rows = new List<string[]>();
            foreach (Item item in itens)
            {
                string valor;

                if (item.Tamanho == "Grande")
                    valor = (item.Quantidade * item.Produto.VlGrande).ToString();
                else
                    valor = (item.Quantidade * item.Produto.VlPequeno).ToString();

                string[] row = new string[]
                {
                    item.Quantidade.ToString(),
                    item.Produto.Descricao,
                    item.Tamanho,
                    valor
                };
                rows.Add(row);
            }

            foreach (string[] row in rows)
            {
                DataGridViewItens.Rows.Add(row);
            }

            DataGridViewItens.Sort(DataGridViewItens.Columns[1], ListSortDirection.Ascending);
        }

        public void AdicionarControlesParaPainel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelprincipal.Controls.Clear();
            panelprincipal.Controls.Add(c);
        }

        private void btnoutros_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnoutros);
            panelsidehome.Visible = true;
            UC_Outros uch = new UC_Outros(pedidoId);
            AdicionarControlesParaPainel(uch);
        }

        private void btnpizzas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnpizzas);
            panelsidehome.Visible = true;
            UC_Pizzas uch = new UC_Pizzas(pedidoId);
            AdicionarControlesParaPainel(uch);
        }

        private void btnbebidas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnbebidas);
            panelsidehome.Visible = true;
            UC_Bebidas uch = new UC_Bebidas(pedidoId);
            AdicionarControlesParaPainel(uch);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data.Text = "Data: " + DateTime.Now.ToShortDateString();
            hora.Text = "Hora: " + DateTime.Now.ToLongTimeString();

            //registro de pizza
            //if (registrar == "1")
            //{
            //    total = total + valoritem;
            //    txtvalor.Text = total.ToString();
            //    registrar = "0";
            //}

            if(refresh) //atualizar sacola
            {
                refreshDataGrid();
                refresh = false;
            }

            if (pedidoId == 0)
            {
                btnpedido.Enabled = true;
                txtsacola.Visible = false;
                btncancelarpedido.Visible = false;
                DataGridViewItens.Visible = false;
                btnfinalizar.Visible = false;
                btnlimpar.Visible = false;
                txttotal.Visible = false;
                txtrs.Visible = false;
                txtvalor.Visible = false;
            }
            else
            {
                btnpedido.Enabled = false;
                txtsacola.Visible = true;
                btncancelarpedido.Visible = true;
                DataGridViewItens.Visible = true;
                btnfinalizar.Visible = true;
                btnlimpar.Visible = true;
                txttotal.Visible = true;
                txtrs.Visible = true;
                txtvalor.Visible = true;
            }
        }

        private void DataGridViewPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DELETAR ITEM SACOLA
            string id, nome,valor,quantidade;
            if (DataGridViewItens.SelectedRows.Count > 0)
            {
                id = DataGridViewItens.CurrentRow.Cells["ID"].Value.ToString();
                nome = DataGridViewItens.CurrentRow.Cells["NOME"].Value.ToString();
                valor = DataGridViewItens.CurrentRow.Cells["VALOR"].Value.ToString();
                quantidade = DataGridViewItens.CurrentRow.Cells["QUANTIDADE"].Value.ToString();

                string query = "DELETE FROM PEDIDO WHERE NOME='" + nome + "'";
                SqlCommand deleteCommand = new SqlCommand(query);
                int row = objDBAccess.executeQuery(deleteCommand);
                if (row == 1)
                {
                    //APAGAR REGISTRO DA DESCRICAO DA COMPRA
                    idpedido[Convert.ToInt32(id)] = "";
                    nomepedido[Convert.ToInt32(id)] = "";
                    //RESETAR VALOR
                    total = total - (Convert.ToDouble(valor) * Convert.ToDouble(quantidade));
                    txtvalor.Text = total.ToString();
                    refresh = true;
                    //RESETAR ARRAY CASO A SACOLA FIQUE VAZIA
                    if(DataGridViewItens.Rows.Count.ToString() == "0")
                    {
                        for (int i = 0; i <= 199; i++)
                        {
                            idpedido[i] = "";
                            nomepedido[i] = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            //COLOCAR NOME DOS PEDIDOS NA DESCRICAO
            //for(int i=0; i <= 199;i++)
            //{
            //    tbpedido.Text = tbpedido.Text + nomepedido[i];
            //}
            //pedido = tbpedido.Text;
            //total = Convert.ToDouble(txtvalor.Text);
            //CadastrarPedido abrirform = new CadastrarPedido();
            //abrirform.ShowDialog();
         
        }
    }
}
