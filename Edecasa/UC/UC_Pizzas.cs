using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Edecasa
{
    public partial class UC_Pizzas : UserControl
    {
        public UC_Pizzas()
        {
            InitializeComponent();
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        //variaveis para edição
        public static string idpizza, nomepizza, brotopizza, grandepizza, refresh, edicao="0", tamanho;//tamanho = 1 BROTO
        public static string idpizzametade, nomepizzametade, valorpizzametade,validacao, quantidade;//se edicao = 0 n é para editar

        private void timer1_Tick(object sender, EventArgs e)
        {
            //PARA ATUALIZAR DATAGRID
            if (refresh == "1")
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PIZZAS ORDER BY ID ASC", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewPizzas.DataSource = dt;
                refresh = "0";
            }
        }

        //variavel
        string meia ="0";//saber se vai ser meia pizza
        string nomemetade1, valormetade1;//pegar valor da primeira metade da pizza
        string nomemetade2, valormetade2;
        private void tbbusca_TextChanged(object sender, EventArgs e)
        {
            if (cbfiltrar.Text == "ID")
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PIZZAS WHERE ID LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewPizzas.DataSource = dt;
            }
            else if (cbfiltrar.Text == "NOME")
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PIZZAS WHERE NOME LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewPizzas.DataSource = dt;
            }
        }

        private void DataGridViewPizzas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewPizzas.SelectedRows.Count > 0)
            {
                if (chbmeia.Checked)
                {
                    chbbroto.Enabled = false;
                    chbmeia.Enabled = false;
                    if (meia == "0")
                    {
                        //Se a pizza for meia
                        if (chbbroto.Checked)
                        {
                            //Primeira metade da pizza - BROTO
                            idpizzametade = DataGridViewPizzas.CurrentRow.Cells["ID"].Value.ToString();
                            nomemetade1 = DataGridViewPizzas.CurrentRow.Cells["NOME"].Value.ToString();
                            valormetade1 = DataGridViewPizzas.CurrentRow.Cells["BROTO"].Value.ToString();
                            MessageBox.Show("Selecione a outra metade da pizza", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tamanho = "1";
                            meia = "1";
                        }
                        else
                        {
                            //Primeira metade da pizza - GRANDE
                            idpizzametade = DataGridViewPizzas.CurrentRow.Cells["ID"].Value.ToString();
                            nomemetade1 = DataGridViewPizzas.CurrentRow.Cells["NOME"].Value.ToString();
                            valormetade1 = DataGridViewPizzas.CurrentRow.Cells["GRANDE"].Value.ToString();
                            MessageBox.Show("Selecione a outra metade da pizza", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tamanho = "0";
                            meia = "1";
                        }
                    }  
                    else
                    {
                        if(tamanho == "1")
                        {
                            //Segunda metade da pizza - BROTO
                            nomemetade2 = DataGridViewPizzas.CurrentRow.Cells["NOME"].Value.ToString();
                            valormetade2 = DataGridViewPizzas.CurrentRow.Cells["BROTO"].Value.ToString();
                            meia = "0";
                        }
                        else
                        {
                            //Segunda metade da pizza - GRANDE
                            nomemetade2 = DataGridViewPizzas.CurrentRow.Cells["NOME"].Value.ToString();
                            valormetade2 = DataGridViewPizzas.CurrentRow.Cells["GRANDE"].Value.ToString();
                            meia = "0";
                        }
                        Home.valoritem = (Convert.ToDouble(valormetade1) + Convert.ToDouble(valormetade2)) / 2;
                        nomepizzametade = String.Format("({0}-{1})", nomemetade1, nomemetade2);
                        quantidade = "1";
                        tamanho = "0";

                        SqlCommand InsertCommand = new SqlCommand("INSERT INTO PEDIDO(ID,NOME,QUANTIDADE,VALOR) VALUES(@id, @nome, @quantidade, @valor)");
                        InsertCommand.Parameters.AddWithValue("@id", idpizzametade);
                        InsertCommand.Parameters.AddWithValue("@nome", nomepizzametade);
                        InsertCommand.Parameters.AddWithValue("@quantidade", quantidade);
                        InsertCommand.Parameters.AddWithValue("@valor", Home.valoritem);
                        int row = objDBAccess.executeQuery(InsertCommand);
                        if (row == 1)
                        {
                            //PARA FAZER DESCRICAO DA COMPRA
                            Home.idpedido[Convert.ToInt32(idpizza)] = idpizzametade;
                            Home.nomepedido[Convert.ToInt32(idpizza)] = nomepizzametade + "-";
                            Home.registrar = "1";
                            Home.refresh = "1";//atualizar sacola
                            chbbroto.Enabled = true;
                            chbmeia.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    //Se a pizza nao for meia
                    idpizza = DataGridViewPizzas.CurrentRow.Cells["ID"].Value.ToString();
                    nomepizza = DataGridViewPizzas.CurrentRow.Cells["NOME"].Value.ToString();
                    brotopizza = DataGridViewPizzas.CurrentRow.Cells["BROTO"].Value.ToString();
                    grandepizza = DataGridViewPizzas.CurrentRow.Cells["GRANDE"].Value.ToString();

                    if (chbbroto.Checked)
                    {
                        tamanho = "1";//1 = broto
                    }
                    else
                    {    
                        tamanho = "0";//0 = grande
                    }
                    //PARA FAZER DESCRICAO DA COMPRA
                    Home.idpedido[Convert.ToInt32(idpizza)] = idpizza;
                    Home.nomepedido[Convert.ToInt32(idpizza)] = nomepizza + "-";
                    Home.pizza = "1";//para o form quantidade identificar que é pizza
                    Quantidade abrirform = new Quantidade();
                    abrirform.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha", "Cadastro de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            PizzaCadastrarEditar abrirform = new PizzaCadastrarEditar();
            abrirform.ShowDialog();
        }

        private void UC_Pizzas_Load(object sender, EventArgs e)
        { 
            string query = "SELECT * FROM PIZZAS ORDER BY ID ASC";
            objDBAccess.readDatathroughAdapter(query, dtUsers);
            DataGridViewPizzas.DataSource = dtUsers;
            objDBAccess.closeConn();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string id;
            if (DataGridViewPizzas.SelectedRows.Count > 0)
            {
                id = DataGridViewPizzas.CurrentRow.Cells["ID"].Value.ToString();
                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja excluir este registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    string query = "DELETE FROM PIZZAS WHERE ID='" + id + "'";
                    SqlCommand deleteCommand = new SqlCommand(query);
                    int row = objDBAccess.executeQuery(deleteCommand);
                    if (row == 1)
                    {
                        refresh = "1";
                        MessageBox.Show("Registro excluido com sucesso!", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (DataGridViewPizzas.SelectedRows.Count > 0)
            {
                idpizza = DataGridViewPizzas.CurrentRow.Cells["ID"].Value.ToString();
                nomepizza = DataGridViewPizzas.CurrentRow.Cells["NOME"].Value.ToString();
                brotopizza = DataGridViewPizzas.CurrentRow.Cells["BROTO"].Value.ToString();
                grandepizza = DataGridViewPizzas.CurrentRow.Cells["GRANDE"].Value.ToString();

                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja editar essa linha?", "Editar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    edicao = "1";
                    PizzaCadastrarEditar abrirform = new PizzaCadastrarEditar();
                    abrirform.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha", "Editar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
