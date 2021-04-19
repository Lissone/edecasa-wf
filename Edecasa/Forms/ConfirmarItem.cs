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
    public partial class ConfirmarItem : Form
    {
        //Fazer form de mexer
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private static Item item;
        public ConfirmarItem(Item data)
        {
            InitializeComponent();

            item = data;
        }

        private void Quantidade_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if(cbtamanho.Text.Equals(""))
            {
                MessageBox.Show("Selecione o tamanho do item", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            item.Tamanho = cbtamanho.Text;
            item.Quantidade = Convert.ToInt32(numquantidade.Value);

            var itemController = new ItemController();
            var ret = itemController.create(item);

            if(ret)
            {
                MessageBox.Show("Registro salvo com sucesso!", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Home.refresh = true; //Atualizar grid da home
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
