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
        public static string pizza = "0", pizzametade = "0", bebida = "0", outro = "0";//para o form quantidade saber o item / =0 n tem registro
        public static string registrar, datagora,refresh, pedido, limpar_array; //registrar adicionar valor na label de valor da home / refresh = dar um refresh na sacola
        public static double valoritem, total; //calcular sacola de todos os items
        public static string[] idpedido = new string[200];
        public static string[] nomepedido = new string[200];
        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
            //if (DataGridViewItens.Rows.Count.ToString() == "0")
            //{
            //    this.Close();
            //}
            //else
            //{
            //    string query = "DELETE FROM PEDIDO";
            //    SqlCommand deleteCommand = new SqlCommand(query);
            //    int row = objDBAccess.executeQuery(deleteCommand);
            //    if (row == 1)
            //    {
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
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
                    refresh = "1";
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
            panelsidehome.Visible = false;
            //getAll
            //cliente
            //var clienteController = new ClienteController();
            //var clientes = clienteController.getAll();

            //foreach (Cliente data in clientes)
            //{
            //    Console.WriteLine(data.Id);
            //    Console.WriteLine(data.Pedidos);
            //}

            //pedidos
            //var pedidoController = new PedidoController();
            //var pedidos = pedidoController.getAll();

            //item
            //var itemController = new ItemController();
            //var itens = itemController.getAll();
            //foreach (Item data in itens)
            //{
            //    Console.WriteLine(data.Id);
            //    Console.WriteLine(data.PedidoId);
            //    Console.WriteLine(data.Pedido.Valor);
            //    Console.WriteLine(data.ProdutoId);
            //    Console.WriteLine(data.Produto.Descricao);
            //}

            //create
            ////produto
            //var produtoController = new ProdutoController();
            //var produto = new Produto { Id = 0, Descricao = "CocaCola", VlPequeno = 5, VlGrande = 12 };
            //var ret = produtoController.create(produto);
            //Console.WriteLine(ret);

            ////cliente
            //var clienteController = new ClienteController();
            //var cliente = new Cliente { Id = 0, Rua = "Guaraciaba", Bairro = "Jardim Barbosa", Numero = "62", Telefone = "984119505" };
            //var ret1 = clienteController.create(cliente);
            //Console.WriteLine(ret1);


            ////pedido
            //var pedidoController = new PedidoController();
            //DateTime myDateTime = DateTime.Now;
            //var pedido = new Pedido { Id = 0, TpPagamento = "Cartao", Valor = 78, Taxa = 5, Data = myDateTime, ClienteId = 1 };
            //var ret2 = pedidoController.create(pedido);
            //Console.WriteLine(ret2);

            //item
            //var itemController = new ItemController();
            //var item = new Item { Id = 0, Quantidade = 2, ProdutoId = 1, PedidoId = 1 };
            //var ret3 = itemController.create(item);
            //Console.WriteLine(ret3);

            //update
            //var clienteController = new ClienteController();
            //var newCliente = new Cliente { Id = 2, Bairro = "Antonomeu", Rua = "Maria joaquina", Numero = "day you cool", Telefone = "9878745" };
            //var ret = clienteController.update(newCliente);
            //Console.WriteLine(ret);

            //item
            //var itemC = new ItemController();
            //var newItem = new Item { Id = 4, Quantidade = 2, ProdutoId = 1, PedidoId = 1, Tamanho = "Grande" };
            //var ret = itemC.update(newItem);
            //Console.WriteLine(ret);

            //delete
            //var clienteController = new ClienteController();
            //var ret = clienteController.delete(1);
            //Console.WriteLine(ret);


            //SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=BDEdecasa; User ID=leonardodias;Password= 080108; Integrated Security=True;");
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PEDIDO ORDER BY ID ASC", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //DataGridViewPedido.DataSource = dt;

            //Datagridview
            DataGridViewItens.ColumnCount = 4;
            DataGridViewItens.Columns[0].Name = "Quantidade";
            DataGridViewItens.Columns[1].Name = "Produto";
            DataGridViewItens.Columns[2].Name = "Valor";
            DataGridViewItens.Columns[3].Name = "Categoria";

            var itemController = new ItemController();
            var itens = itemController.getAll();

            var rows = new List<string[]>();
            foreach (Item item in itens)
            {
                string valor;

                if (item.Tamanho == "Grande")
                    valor = item.Produto.VlGrande.ToString();
                else
                    valor = item.Produto.VlPequeno.ToString();

                string[] row = new string[]
                {
                    item.Quantidade.ToString(),
                    item.Produto.Descricao,
                    valor,
                    item.Produto.Categoria
                };
                rows.Add(row);
            }

            foreach (string[] row in rows)
            {
                DataGridViewItens.Rows.Add(row);
            }

            //datagrid para outros produtos
            //var itemController = new ItemController();
            //var itens = itemController.getAll();

            //var data = from item in itens //where
            //           orderby item.Quantidade
            //           select new
            //           {
            //               Quantidade = item.Quantidade.ToString(),
            //               Produto = item.Produto.Descricao,
            //               Valor = item.Produto.VlGrande.ToString(),
            //               Categoria = item.Produto.Categoria
            //           };
            //DataGridViewItens.DataSource = data.ToList();
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
            UC_Outros uch = new UC_Outros();
            AdicionarControlesParaPainel(uch);
        }

        private void btnpizzas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnpizzas);
            panelsidehome.Visible = true;
            UC_Pizzas uch = new UC_Pizzas();
            AdicionarControlesParaPainel(uch);
        }

        private void btnbebidas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnbebidas);
            panelsidehome.Visible = true;
            UC_Bebidas uch = new UC_Bebidas();
            AdicionarControlesParaPainel(uch);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data.Text = "Data: " + DateTime.Now.ToShortDateString();
            hora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            //registro de pizza
            if (registrar == "1")
            {
                total = total + valoritem;
                txtvalor.Text = total.ToString();
                registrar = "0";
            }     
            //para atualizar sacola
            //if (refresh == "1")
            //{
            //    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BDEdecasa;Integrated Security=True;");
            //    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PEDIDO ORDER BY ID ASC", con);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    DataGridViewPedido.DataSource = dt;
            //    refresh = "0";
            //}
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
                    refresh = "1";
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
            if(txtvalor.Text == "0")
            {
                MessageBox.Show("Por favor, selecione items na lista!", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
