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
using Edecasa.Classes;

namespace Edecasa
{
    public partial class BebidaCadastrarEditar : Form
    {
        public BebidaCadastrarEditar()
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
        private void btnfechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            UC_Bebidas.edicao = "0";
        }

        private void BebidaCadastrarEditar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BebidaCadastrarEditar_Load(object sender, EventArgs e)
        {
            if(UC_Bebidas.edicao == "1")
            {
                btncadastrar.Enabled = false;
                tbid.Enabled = false;
                tbid.Text = UC_Bebidas.idbebida;
                tbnome.Text = UC_Bebidas.nomebebida;
                tbtamanho.Text = UC_Bebidas.tamanhobebida;
                tbvalor.Text = UC_Bebidas.tamanhobebida;
            }
            else
            {
                btnatualizar.Enabled = false;
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            UC_Bebidas.idbebida = tbid.Text;
            UC_Bebidas.nomebebida = tbnome.Text;
            UC_Bebidas.tamanhobebida = tbtamanho.Text;
            UC_Bebidas.valorbebida = tbvalor.Text;

            validation.BebidaCadastrarEditarValidation();

            if(UC_Bebidas.validacao == "1")
            {
                SqlCommand InsertCommand = new SqlCommand("INSERT INTO BEBIDAS(ID,NOME,TAMANHO,VALOR) VALUES(@id, @nome, @tamanho, @valor)");
                InsertCommand.Parameters.AddWithValue("@id", UC_Bebidas.idbebida);
                InsertCommand.Parameters.AddWithValue("@nome", UC_Bebidas.nomebebida);
                InsertCommand.Parameters.AddWithValue("@tamanho", UC_Bebidas.tamanhobebida);
                InsertCommand.Parameters.AddWithValue("@valor", UC_Bebidas.valorbebida);

                int row = objDBAccess.executeQuery(InsertCommand);
                if (row == 1)
                {
                    UC_Bebidas.refresh = "1";
                    MessageBox.Show("Registro salvo com sucesso!", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.OpenForms["BebidaCadastrarEditar"].Close();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }  
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            UC_Bebidas.idbebida = tbid.Text;
            UC_Bebidas.nomebebida = tbnome.Text;
            UC_Bebidas.tamanhobebida = tbtamanho.Text;
            UC_Bebidas.valorbebida = tbvalor.Text;

            validation.BebidaCadastrarEditarValidation();

            if(UC_Bebidas.validacao == "1")
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja atualizar esse registro?", "Edição de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    string query = "UPDATE BEBIDAS SET NOME='" + UC_Bebidas.nomebebida + "', TAMANHO='" + UC_Bebidas.tamanhobebida + "', VALOR='" + UC_Bebidas.valorbebida + "' WHERE ID='" + UC_Bebidas.idbebida + "'";
                    SqlCommand updateCommand = new SqlCommand(query);
                    int row = objDBAccess.executeQuery(updateCommand);
                    if (row == 1)
                    {
                        UC_Bebidas.refresh = "1";
                        UC_Bebidas.edicao = "0";
                        MessageBox.Show("Registro atualizado com sucesso!", "Edição de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.OpenForms["BebidaCadastrarEditar"].Close();
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
