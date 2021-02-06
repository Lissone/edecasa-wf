using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Edecasa
{
    public partial class TodosPedidos : Form
    {
        public TodosPedidos()
        {
            InitializeComponent();
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        // FUNÇÃO PARA FAZER FORM SE MEXER
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void TodosPedidos_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TODOSPEDIDOS ORDER BY ID DESC";
            objDBAccess.readDatathroughAdapter(query, dtUsers);
            DataGridViewTodospedidos.DataSource = dtUsers;
            objDBAccess.closeConn();
        }

        private void TodosPedidos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void DataGridViewTodospedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            if (DataGridViewTodospedidos.SelectedRows.Count > 0)
            {
                id = DataGridViewTodospedidos.CurrentRow.Cells["ID"].Value.ToString();
                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja excluir este registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    string query = "DELETE FROM TODOSPEDIDOS WHERE ID='" + id + "'";
                    SqlCommand deleteCommand = new SqlCommand(query);
                    int row = objDBAccess.executeQuery(deleteCommand);
                    if (row == 1)
                    {
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

        private void tbbusca_TextChanged(object sender, EventArgs e)
        {
            if (cbfiltrar.Text == "ID")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TODOSPEDIDOS WHERE ID LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewTodospedidos.DataSource = dt;
            }
            else if (cbfiltrar.Text == "NOME")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TODOSPEDIDOS WHERE NOME LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewTodospedidos.DataSource = dt;
            }
            else if (cbfiltrar.Text == "PAGAMENTO")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TODOSPEDIDOS WHERE PAGAMENTO LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewTodospedidos.DataSource = dt;
            }
            else if (cbfiltrar.Text == "DATA")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TODOSPEDIDOS WHERE DATA LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewTodospedidos.DataSource = dt;
            }
            else if (cbfiltrar.Text == "TELEFONE")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TODOSPEDIDOS WHERE TELEFONE LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewTodospedidos.DataSource = dt;
            }
            else if (cbfiltrar.Text == "RUA")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TODOSPEDIDOS WHERE RUA LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewTodospedidos.DataSource = dt;
            }
            else if (cbfiltrar.Text == "BAIRRO")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TODOSPEDIDOS WHERE BAIRRO LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewTodospedidos.DataSource = dt;
            }
            else if (cbfiltrar.Text == "NUMERO")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TODOSPEDIDOS WHERE NUMERO LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewTodospedidos.DataSource = dt;
            }
            else if (cbfiltrar.Text == "VALOR")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TODOSPEDIDOS WHERE VALOR LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewTodospedidos.DataSource = dt;
            }
        }
    }
}
