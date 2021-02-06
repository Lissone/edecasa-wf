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
    public partial class UC_Bebidas : UserControl
    {
        public UC_Bebidas()
        {
            InitializeComponent();
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public static string idbebida,nomebebida,tamanhobebida,valorbebida,validacao,edicao = "0",refresh;

        private void tbbusca_TextChanged(object sender, EventArgs e)
        {
            if (cbfiltrar.Text == "ID")
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM BEBIDAS WHERE ID LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewBebidas.DataSource = dt;
            }
            else if (cbfiltrar.Text == "NOME")
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM BEBIDAS WHERE NOME LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewBebidas.DataSource = dt;
            }
            else if (cbfiltrar.Text == "TAMANHO")
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM BEBIDAS WHERE TAMANHO LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewBebidas.DataSource = dt;
            }
        }

        private void DataGridViewBebidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewBebidas.SelectedRows.Count > 0)
            {
                idbebida = DataGridViewBebidas.CurrentRow.Cells["ID"].Value.ToString();
                nomebebida = DataGridViewBebidas.CurrentRow.Cells["NOME"].Value.ToString();
                tamanhobebida = DataGridViewBebidas.CurrentRow.Cells["TAMANHO"].Value.ToString();
                valorbebida = DataGridViewBebidas.CurrentRow.Cells["VALOR"].Value.ToString();

                //PARA FAZER DESCRICAO DA COMPRA
                Home.idpedido[Convert.ToInt32(idbebida)] = idbebida;
                Home.nomepedido[Convert.ToInt32(idbebida)] = nomebebida + "-";
                Home.bebida = "1";//para o form quantidade identificar que é bebida
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
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM BEBIDAS ORDER BY ID ASC", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewBebidas.DataSource = dt;
                refresh = "0";
            }
        }
        private void btncadastrar_Click(object sender, EventArgs e)
        {
            BebidaCadastrarEditar abrirform = new BebidaCadastrarEditar();
            abrirform.ShowDialog();
        }

        private void UC_Bebidas_Load(object sender, EventArgs e)
        {
            refresh = "1";
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string id;
            if (DataGridViewBebidas.SelectedRows.Count > 0)
            {
                id = DataGridViewBebidas.CurrentRow.Cells["ID"].Value.ToString();
                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja excluir este registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    string query = "DELETE FROM BEBIDAS WHERE ID='" + id + "'";
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
            if (DataGridViewBebidas.SelectedRows.Count > 0)
            {
                idbebida = DataGridViewBebidas.CurrentRow.Cells["ID"].Value.ToString();
                nomebebida = DataGridViewBebidas.CurrentRow.Cells["NOME"].Value.ToString();
                tamanhobebida = DataGridViewBebidas.CurrentRow.Cells["TAMANHO"].Value.ToString();
                valorbebida = DataGridViewBebidas.CurrentRow.Cells["VALOR"].Value.ToString();

                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja editar essa linha?", "Editar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    edicao = "1";
                    BebidaCadastrarEditar abrirform = new BebidaCadastrarEditar();
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
