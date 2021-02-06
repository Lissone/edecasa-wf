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
    public partial class UC_Outros : UserControl
    {
        public UC_Outros()
        {
            InitializeComponent();
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public static string iditem, nomeitem, valoritem,validacao,refresh,edicao = "0";

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (DataGridViewOutros.SelectedRows.Count > 0)
            {
                iditem = DataGridViewOutros.CurrentRow.Cells["ID"].Value.ToString();
                nomeitem = DataGridViewOutros.CurrentRow.Cells["NOME"].Value.ToString();
                valoritem = DataGridViewOutros.CurrentRow.Cells["VALOR"].Value.ToString();

                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja editar essa linha?", "Editar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    edicao = "1";
                    OutroCadastrarEditar abrirform = new OutroCadastrarEditar();
                    abrirform.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha", "Editar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbbusca_TextChanged(object sender, EventArgs e)
        {
            if (cbfiltrar.Text == "ID")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM OUTROS WHERE ID LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewOutros.DataSource = dt;
            }
            else if (cbfiltrar.Text == "NOME")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM OUTROS WHERE NOME LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewOutros.DataSource = dt;
            }
        }

        private void DataGridViewOutros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewOutros.SelectedRows.Count > 0)
            {
                iditem = DataGridViewOutros.CurrentRow.Cells["ID"].Value.ToString();
                nomeitem = DataGridViewOutros.CurrentRow.Cells["NOME"].Value.ToString();
                valoritem = DataGridViewOutros.CurrentRow.Cells["VALOR"].Value.ToString();

                //PARA FAZER DESCRICAO DA COMPRA
                Home.idpedido[Convert.ToInt32(iditem)] = iditem;
                Home.nomepedido[Convert.ToInt32(iditem)] = nomeitem + "-";
                Home.outro = "1";//para o form quantidade identificar que é outro item
                Quantidade abrirform = new Quantidade();
                abrirform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha", "Cadastro de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //PARA ATUALIZAR DATAGRID
            if (refresh == "1")
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM OUTROS ORDER BY ID ASC", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewOutros.DataSource = dt;
                refresh = "0";
            }
        }
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string id;
            if (DataGridViewOutros.SelectedRows.Count > 0)
            {
                id = DataGridViewOutros.CurrentRow.Cells["ID"].Value.ToString();
                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja excluir este registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    string query = "DELETE FROM OUTROS WHERE ID='" + id + "'";
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

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            OutroCadastrarEditar abrirform = new OutroCadastrarEditar();
            abrirform.ShowDialog();
        }

        private void UC_Outros_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM OUTROS ORDER BY ID ASC";
            objDBAccess.readDatathroughAdapter(query, dtUsers);
            DataGridViewOutros.DataSource = dtUsers;
            objDBAccess.closeConn();
        }
    }
}
