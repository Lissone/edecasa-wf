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
using System.Net.NetworkInformation;
using Edecasa.Classes;

namespace Edecasa
{
    public partial class OutroCadastrarEditar : Form
    {
        public OutroCadastrarEditar()
        {
            InitializeComponent();
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        Validation validation = new Validation();
        // FUNÇÃO PARA FAZER FORM SE MEXER
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void OutroCadastrarEditar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            UC_Outros.edicao = "0";
            this.Close();
        }

        private void OutroCadastrarEditar_Load(object sender, EventArgs e)
        {
            if (UC_Outros.edicao == "1")
            {
                btncadastrar.Enabled = false;
                tbid.Enabled = false;
                tbid.Text = UC_Outros.iditem;
                tbnome.Text = UC_Outros.nomeitem;
                tbvalor.Text = UC_Outros.valoritem;
            }
            else
            {
                btnatualizar.Enabled = false;
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            UC_Outros.iditem = tbid.Text;
            UC_Outros.nomeitem = tbnome.Text;
            UC_Outros.valoritem = tbvalor.Text;

            validation.OutroCadastrarEditarValidation();

            if(UC_Outros.validacao == "1")
            {
                SqlCommand InsertCommand = new SqlCommand("INSERT INTO OUTROS(ID,NOME,VALOR) VALUES(@id, @nome, @valor)");
                InsertCommand.Parameters.AddWithValue("@id", UC_Outros.iditem);
                InsertCommand.Parameters.AddWithValue("@nome", UC_Outros.nomeitem);
                InsertCommand.Parameters.AddWithValue("@valor", UC_Outros.valoritem);

                int row = objDBAccess.executeQuery(InsertCommand);
                if (row == 1)
                {
                    UC_Outros.refresh = "1";
                    MessageBox.Show("Registro salvo com sucesso!", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.OpenForms["OutroCadastrarEditar"].Close();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            UC_Outros.iditem = tbid.Text;
            UC_Outros.nomeitem = tbnome.Text;
            UC_Outros.valoritem = tbvalor.Text;

            validation.OutroCadastrarEditarValidation();

            if (UC_Outros.validacao == "1")
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja atualizar esse registro?", "Edição de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    string query = "UPDATE OUTROS SET NOME='" + UC_Outros.nomeitem + "', VALOR='" + UC_Outros.valoritem + "' WHERE ID='" + UC_Outros.iditem + "'";
                    SqlCommand updateCommand = new SqlCommand(query);

                    int row = objDBAccess.executeQuery(updateCommand);
                    if (row == 1)
                    {
                        UC_Outros.refresh = "1";
                        UC_Outros.edicao = "0";
                        MessageBox.Show("Registro atualizado com sucesso!", "Edição de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.OpenForms["OutroCadastrarEditar"].Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro! Tente novamente.", "Edição de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void tbvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (tbvalor.Text.Contains(","))
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
