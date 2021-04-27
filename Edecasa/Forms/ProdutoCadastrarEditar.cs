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
using Edecasa.Models;
using Edecasa.Controllers;

namespace Edecasa
{
    public partial class ProdutoCadastrarEditar : Form
    {
        //Fazer form de mexer
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private static string categoria; //categoria do produto
        public ProdutoCadastrarEditar(string category)
        {
            InitializeComponent();

            btnatualizar.Visible = false;
            tbid.Visible = false;
            txtid.Visible = false;

            categoria = category;
        }
        public ProdutoCadastrarEditar(Produto produto)
        {
            InitializeComponent();

            tbid.Enabled = false;
            btncadastrar.Visible = false;

            tbid.Text = produto.Id.ToString();
            tbdescricao.Text = produto.Descricao;
            tbvlpequeno.Text = produto.VlPequeno.ToString();
            tbvlgrande.Text = produto.VlGrande.ToString();
            categoria = produto.Categoria;
        }

        private void ProdutoCadastrarEditar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnfechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;

            string descricao = tbdescricao.Text;
            double vlPequeno = Convert.ToDouble(tbvlpequeno.Text);
            double vlGrande = Convert.ToDouble(tbvlgrande.Text);

            var produtoController = new ProdutoController();
            var produto = new Produto { 
                Id = 0, 
                Descricao = descricao, 
                VlPequeno = vlPequeno, 
                VlGrande = vlGrande,
                Categoria = categoria
            };
            var ret = produtoController.create(produto);

            if (ret != null)
            {
                MessageBox.Show("Registro salvo com sucesso!", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshDataGrid();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;

            int id = Convert.ToInt32(tbid.Text);
            string descricao = tbdescricao.Text;
            double vlPequeno = Convert.ToDouble(tbvlpequeno.Text);
            double vlGrande = Convert.ToDouble(tbvlgrande.Text);

            var produtoController = new ProdutoController();
            var produto = new Produto
            {
                Id = id,
                Descricao = descricao,
                VlPequeno = vlPequeno,
                VlGrande = vlGrande,
                Categoria = categoria
            };
            var ret = produtoController.update(produto);

            if (ret)
            {
                MessageBox.Show("Registro atualizado com sucesso!", "Edição de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshDataGrid();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro! Tente novamente.", "Edição de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool validation()
        {
            if (tbdescricao.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ensira a descrição do produto", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbvlpequeno.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o valor do produto pequeno", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbvlgrande.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o valor do produto grande", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void refreshDataGrid()
        {
            if (categoria == "Pizza")
                UC_Pizzas.refresh = true;
            else if (categoria == "Bebida")
                UC_Bebidas.refresh = true;
            else if (categoria == "Outro")
                UC_Outros.refresh = true;
        }

        private void tbvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (tbvlgrande.Text.Contains(","))
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
