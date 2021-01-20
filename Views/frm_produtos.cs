using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace SS_Almoxarifado.Views
{
    public partial class frm_produtos : Form
    {
        public frm_produtos()
        {
            InitializeComponent();
        }

        private void PictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void Frm_produtos_Load(object sender, EventArgs e)
        {           

            lbl_qtdProdutos.Text = lvw_listaProdutos.Items.Count.ToString() + " produtos cadastrados!";
        }

        private void Btn_novoProduto_Click(object sender, EventArgs e)
        {
            frm_cadProdutos cadP = new frm_cadProdutos();
            cadP.Visible = true;
        }

        private void Btn_buscarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.jpg;*.png;";
            ofd.Title = "Arquivos de Imagens";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String urlArquivo = ofd.FileName;
                String nome = ofd.SafeFileName;

                this.Text = nome;
                img_imagemProduto.SizeMode = PictureBoxSizeMode.CenterImage;
                img_imagemProduto.SizeMode = PictureBoxSizeMode.StretchImage;
                img_imagemProduto.Load(urlArquivo);
            }


        }
    }
}
