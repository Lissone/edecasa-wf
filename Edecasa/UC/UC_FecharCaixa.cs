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
    public partial class UC_FecharCaixa : UserControl
    {
        public UC_FecharCaixa()
        {
            InitializeComponent();
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        //variaveisglobais
        public static string valortotal, valortaxa, motoqueirofixo;
        double totalvalor,totaltaxa,salarioentregador;
        string cadastrar = "0";
        private void btntodospedidos_Click(object sender, EventArgs e)
        {
            TodosPedidos abrirform = new TodosPedidos();
            abrirform.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //cadastrar do banco de dados
            string linhas = DataGridViewFecharcaixa.Rows.Count.ToString();
            string data = DateTime.Now.ToShortDateString();
            if (linhas == "0")
            {
                if(cadastrar == "1")
                {
                    //Quando zerar o datagrid, cria registro na tabela VALORTOTAL
                    salarioentregador = Convert.ToDouble(motoqueirofixo);
                    salarioentregador = salarioentregador + totaltaxa;
                    valortotal = totalvalor.ToString();

                    SqlCommand InsertCommand = new SqlCommand("INSERT INTO VALORTOTAL(DATA,LUCRO,ENTREGADOR) VALUES(@data, @lucro, @entregador)");
                    InsertCommand.Parameters.AddWithValue("@data", data);
                    InsertCommand.Parameters.AddWithValue("@lucro", valortotal);
                    InsertCommand.Parameters.AddWithValue("@entregador", salarioentregador);
                    int row1 = objDBAccess.executeQuery(InsertCommand);
                    if (row1 == 1)
                    {
                        cadastrar = "0";
                        MessageBox.Show($"Valor lucrado: {valortotal} \nPagamento entregador: {salarioentregador}", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnvalorestotais_Click(object sender, EventArgs e)
        {
            ValorTotal abrirform = new ValorTotal();
            abrirform.ShowDialog();
        }

        private void tbbusca_TextChanged(object sender, EventArgs e)
        {
            if (cbfiltrar.Text == "ID")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FECHARCAIXA WHERE ID LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewFecharcaixa.DataSource = dt;
            }
            else if (cbfiltrar.Text == "NOME")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FECHARCAIXA WHERE NOME LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewFecharcaixa.DataSource = dt;
            }
            else if (cbfiltrar.Text == "PAGAMENTO")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FECHARCAIXA WHERE PAGAMENTO LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewFecharcaixa.DataSource = dt;
            }
            else if (cbfiltrar.Text == "DATA")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FECHARCAIXA WHERE DATA LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewFecharcaixa.DataSource = dt;
            }
            else if (cbfiltrar.Text == "TELEFONE")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FECHARCAIXA WHERE TELEFONE LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewFecharcaixa.DataSource = dt;
            }
            else if (cbfiltrar.Text == "RUA")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FECHARCAIXA WHERE RUA LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewFecharcaixa.DataSource = dt;
            }
            else if (cbfiltrar.Text == "BAIRRO")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FECHARCAIXA WHERE BAIRRO LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewFecharcaixa.DataSource = dt;
            }
            else if (cbfiltrar.Text == "NUMERO")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FECHARCAIXA WHERE NUMERO LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewFecharcaixa.DataSource = dt;
            }
            else if (cbfiltrar.Text == "VALOR")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FECHARCAIXA WHERE VALOR LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewFecharcaixa.DataSource = dt;
            }
        }

        private void UC_FecharCaixa_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM FECHARCAIXA";
            objDBAccess.readDatathroughAdapter(query, dtUsers);
            DataGridViewFecharcaixa.DataSource = dtUsers;
            objDBAccess.closeConn();
        }

        private void DataGridViewFecharcaixa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string data, hora, nome, telefone, valor, rua, bairro, numero, pagamento, taxa, descricao;

            if (DataGridViewFecharcaixa.SelectedRows.Count > 0)
            {
                //adicionar registro na tabela TODOSPEDIDOS
                data = DataGridViewFecharcaixa.CurrentRow.Cells["DATA"].Value.ToString();
                hora = DataGridViewFecharcaixa.CurrentRow.Cells["HORA"].Value.ToString();
                nome = DataGridViewFecharcaixa.CurrentRow.Cells["NOME"].Value.ToString();
                telefone = DataGridViewFecharcaixa.CurrentRow.Cells["TELEFONE"].Value.ToString();
                valor = DataGridViewFecharcaixa.CurrentRow.Cells["VALOR"].Value.ToString();
                rua = DataGridViewFecharcaixa.CurrentRow.Cells["RUA"].Value.ToString();
                bairro = DataGridViewFecharcaixa.CurrentRow.Cells["BAIRRO"].Value.ToString();
                numero = DataGridViewFecharcaixa.CurrentRow.Cells["NUMERO"].Value.ToString();
                pagamento = DataGridViewFecharcaixa.CurrentRow.Cells["PAGAMENTO"].Value.ToString();
                taxa = DataGridViewFecharcaixa.CurrentRow.Cells["TAXA"].Value.ToString();
                descricao = DataGridViewFecharcaixa.CurrentRow.Cells["DESCRICAO"].Value.ToString();

                SqlCommand InsertCommand = new SqlCommand("INSERT INTO TODOSPEDIDOS(DATA,HORA,NOME,TELEFONE,VALOR,PAGAMENTO,RUA,BAIRRO,NUMERO,TAXA,DESCRICAO) VALUES(@data, @hora, @nome, @telefone, @valor, @pagamento, @rua, @bairro, @numero, @taxa, @descricao)");
                InsertCommand.Parameters.AddWithValue("@data", data);
                InsertCommand.Parameters.AddWithValue("@nome", nome);
                InsertCommand.Parameters.AddWithValue("@hora", hora);
                InsertCommand.Parameters.AddWithValue("@telefone", telefone);
                InsertCommand.Parameters.AddWithValue("@rua", rua);
                InsertCommand.Parameters.AddWithValue("@bairro", bairro);
                InsertCommand.Parameters.AddWithValue("@numero", numero);
                InsertCommand.Parameters.AddWithValue("@pagamento", pagamento);
                InsertCommand.Parameters.AddWithValue("@valor", valor);
                InsertCommand.Parameters.AddWithValue("@taxa", taxa);
                InsertCommand.Parameters.AddWithValue("@descricao", descricao);

                int row = objDBAccess.executeQuery(InsertCommand);
                if (row == 1)
                {
                    totalvalor = totalvalor + Convert.ToDouble(valor);
                    totaltaxa = totaltaxa + Convert.ToDouble(taxa);

                    string query = "DELETE FROM FECHARCAIXA WHERE DATA='" + data + "' AND HORA='" + hora + "'";
                    SqlCommand deleteCommand = new SqlCommand(query);
                    int row2 = objDBAccess.executeQuery(deleteCommand);
                    if (row2 == 1)
                    {
                        cadastrar = "1";
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha", "Cadastro de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //para atualizar o datagrid
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BDEdecasa;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FECHARCAIXA", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGridViewFecharcaixa.DataSource = dt;
        }
    }
}
