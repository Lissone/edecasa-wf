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

namespace Edecasa.Forms
{
    public partial class Ajustes : Form
    {
        public Ajustes()
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

        public void AtualizarCombobox()
        {
            //INSERIR FORMAS DE PAGAMENTO NA COMBOBOX
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ("Data Source=.;Initial Catalog=BDEdecasa;Integrated Security=True");
            cn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.CommandText = "SELECT DESCRICAO FROM FORMA_PAGAMENTO ORDER BY DESCRICAO ASC";
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbpagamento.DisplayMember = "DESCRICAO";
            cbpagamento.DataSource = dt;
        }
        public void AtualizarTextbox()
        {
            //PASSA PAGAMENTO MOTOQUEIRO PARA TEXTBOX
            string query = "SELECT * FROM MOTOQUEIRO";
            objDBAccess.readDatathroughAdapter(query, dtUsers);
            if (dtUsers.Rows.Count != 0)
            {
                tbmotoqueiro.Text = dtUsers.Rows[0]["VALOR"].ToString();
                if (tbmotoqueiro.Text.Equals(""))
                {
                    btncadastrarmotoqueiro.Enabled = true;
                    btnatualizarmotoqueiro.Enabled = false;
                }
                else
                {
                    btncadastrarmotoqueiro.Enabled = false;
                    btnatualizarmotoqueiro.Enabled = true;
                }
            }   
        }
        private void Ajustes_Load(object sender, EventArgs e)
        {
            //AtualizarCombobox();
            //AtualizarTextbox();
            //btnexcluir.Visible = true;
            //tbpagamento.Visible = false;
            //lblcancelar.Visible = false;
            
        }
        private void btncadastrarpagamento_Click(object sender, EventArgs e)
        {
            if(tbpagamento.Visible == false)
            {
                btnexcluir.Visible = false;
                tbpagamento.Visible = true;
                lblcancelar.Visible = true;
            }
            else
            {
                string pagamento = tbpagamento.Text;

                if (pagamento.Equals(""))
                {
                    MessageBox.Show("Por favor, ensira o nome do tipo de pagamento", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlCommand InsertCommand = new SqlCommand("INSERT INTO FORMA_PAGAMENTO(DESCRICAO) VALUES(@descricao)");
                    InsertCommand.Parameters.AddWithValue("@descricao", pagamento);

                    int row = objDBAccess.executeQuery(InsertCommand);
                    if (row == 1)
                    {
                        btnexcluir.Visible = true;
                        tbpagamento.Visible = false;
                        lblcancelar.Visible = false;
                        tbpagamento.Text = string.Empty;
                        AtualizarCombobox();
                        MessageBox.Show("Registro salvo com sucesso!", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Ajustes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string descricao = cbpagamento.Text;
            DialogResult dialog = MessageBox.Show("Você tem certeza que deseja excluir este registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string query = "DELETE FROM FORMA_PAGAMENTO WHERE DESCRICAO='" + descricao + "'";
                SqlCommand deleteCommand = new SqlCommand(query);
                int row = objDBAccess.executeQuery(deleteCommand);
                if (row == 1)
                {
                    AtualizarCombobox();
                    MessageBox.Show("Registro excluido com sucesso!", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void lblcancelar_Click(object sender, EventArgs e)
        {
            btnexcluir.Visible = true;
            tbpagamento.Visible = false;
            lblcancelar.Visible = false;
            tbpagamento.Text = string.Empty;
        }

        private void btncadastrarmotoqueiro_Click(object sender, EventArgs e)
        {
            string pagamento = tbmotoqueiro.Text;

            if (pagamento.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o valor", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand InsertCommand = new SqlCommand("INSERT INTO MOTOQUEIRO(ID,VALOR) VALUES(@id, @valor)");
                InsertCommand.Parameters.AddWithValue("@id", "1");
                InsertCommand.Parameters.AddWithValue("@valor", pagamento);

                int row = objDBAccess.executeQuery(InsertCommand);
                if (row == 1)
                {
                    btncadastrarmotoqueiro.Enabled = false;
                    btnatualizarmotoqueiro.Enabled = true;
                    MessageBox.Show("Registro salvo com sucesso!", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnatualizarmotoqueiro_Click(object sender, EventArgs e)
        {
            string valor = tbmotoqueiro.Text;

            DialogResult dialog = MessageBox.Show("Você tem certeza que deseja atualizar esse registro?", "Edição de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string query = "UPDATE MOTOQUEIRO SET VALOR='" + valor + "' WHERE ID= 1";
                SqlCommand updateCommand = new SqlCommand(query);
                int row = objDBAccess.executeQuery(updateCommand);
                if (row == 1)
                {  
                    MessageBox.Show("Registro atualizado com sucesso!", "Edição de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Edição de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tbmotoqueiro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (tbmotoqueiro.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
