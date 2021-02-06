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
    public partial class PizzaCadastrarEditar : Form
    {
        public PizzaCadastrarEditar()
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
        private void PizzaCadastrarEditar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PizzaCadastrarEditar_Load(object sender, EventArgs e)
        {
            if(UC_Pizzas.edicao == "1")
            {
                btncadastrar.Enabled = false;
                tbid.Enabled = false;
                tbid.Text = UC_Pizzas.idpizza;
                tbnomepizza.Text = UC_Pizzas.nomepizza;
                tbvalorbroto.Text = UC_Pizzas.brotopizza;
                tbvalorgrande.Text = UC_Pizzas.grandepizza;
            }
            else
            {
                btnatualizar.Enabled = false;
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            UC_Pizzas.idpizza = tbid.Text;
            UC_Pizzas.nomepizza = tbnomepizza.Text;
            UC_Pizzas.brotopizza = tbvalorbroto.Text;
            UC_Pizzas.grandepizza = tbvalorgrande.Text;

            validation.PizzaCadastrarEditarValidation();

            if(UC_Pizzas.validacao == "1")
            {
                SqlCommand InsertCommand = new SqlCommand("INSERT INTO PIZZAS(ID,NOME,BROTO,GRANDE) VALUES(@id, @nome, @broto, @grande)");
                InsertCommand.Parameters.AddWithValue("@id", UC_Pizzas.idpizza);
                InsertCommand.Parameters.AddWithValue("@nome", UC_Pizzas.nomepizza);
                InsertCommand.Parameters.AddWithValue("@broto", UC_Pizzas.brotopizza);
                InsertCommand.Parameters.AddWithValue("@grande", UC_Pizzas.grandepizza);

                int row = objDBAccess.executeQuery(InsertCommand);
                if (row == 1)
                {
                    UC_Pizzas.refresh = "1"; 
                    MessageBox.Show("Registro salvo com sucesso!", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.OpenForms["PizzaCadastrarEditar"].Close();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            UC_Pizzas.idpizza = tbid.Text;
            UC_Pizzas.nomepizza = tbnomepizza.Text;
            UC_Pizzas.brotopizza = tbvalorbroto.Text;
            UC_Pizzas.grandepizza = tbvalorgrande.Text;


            if(UC_Pizzas.validacao == "1")
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja atualizar esse registro?", "Edição de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    string query = "UPDATE PIZZAS SET NOME='" + UC_Pizzas.nomepizza + "', BROTO='" + UC_Pizzas.brotopizza + "', GRANDE='" + UC_Pizzas.grandepizza + "' WHERE ID='" + UC_Pizzas.idpizza + "'";
                    SqlCommand updateCommand = new SqlCommand(query);


                    int row = objDBAccess.executeQuery(updateCommand);
                    if (row == 1)
                    {
                        UC_Pizzas.refresh = "1";
                        UC_Pizzas.edicao = "0";
                        MessageBox.Show("Registro atualizado com sucesso!", "Edição de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.OpenForms["PizzaCadastrarEditar"].Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro! Tente novamente.", "Edição de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            UC_Pizzas.edicao = "0";
            Application.OpenForms["PizzaCadastrarEditar"].Close();
        }

        private void tbvalorbroto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (tbvalorbroto.Text.Contains(","))
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

        private void tbvalorgrande_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (tbvalorgrande.Text.Contains(","))
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
