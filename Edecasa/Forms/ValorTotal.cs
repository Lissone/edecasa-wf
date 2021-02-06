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
    public partial class ValorTotal : Form
    {
        public ValorTotal()
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

        private void ValorTotal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void ValorTotal_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM VALORTOTAL ORDER BY ID DESC";
            objDBAccess.readDatathroughAdapter(query, dtUsers);
            DataGridViewValortotal.DataSource = dtUsers;
            objDBAccess.closeConn();
        }

        private void DataGridViewValortotal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            if (DataGridViewValortotal.SelectedRows.Count > 0)
            {
                id = DataGridViewValortotal.CurrentRow.Cells["ID"].Value.ToString();
                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja excluir este registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    string query = "DELETE FROM VALORTOTAL WHERE ID='" + id + "'";
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
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VALORTOTAL WHERE ID LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewValortotal.DataSource = dt;
            }
            else if (cbfiltrar.Text == "DATA")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VALORTOTAL WHERE DATA LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewValortotal.DataSource = dt;
            }
            else if (cbfiltrar.Text == "LUCRO")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VALORTOTAL WHERE LUCRO LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewValortotal.DataSource = dt;
            }
            else if (cbfiltrar.Text == "ENTREGADOR")
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VALORTOTAL WHERE ENTREGADOR LIKE '" + tbbusca.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewValortotal.DataSource = dt;
            }
        }

    }
}
