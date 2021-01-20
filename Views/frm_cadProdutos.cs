using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SS_Almoxarifado.ModelDAO;

namespace SS_Almoxarifado.Views
{
    public partial class frm_cadProdutos : Form
    {
        public frm_cadProdutos()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            String id;
            String codigo;
            String nome;
            String descricao;
            String fabricante;
            String unidade;
            String estoqueMinimo;
            String localizacao;
            String setor;
            String categoria;
            String subCategoria;
            String tipoArmazenagem;
            String perecivel;
            String observacoes;
            String qrCode;

            id = txt_id.Text;
            codigo = txt_codigo.Text;
            nome = txt_nome.Text;
            descricao = txt_descricao.Text;
            fabricante = cmb_fabricante.Text;
            unidade = cmb_unidade.Text;
            estoqueMinimo = txt_estoqueMinimo.Text;
            localizacao = cmb_localizacao.Text;
            setor = cmb_setor.Text;
            categoria = cmb_categoria.Text;
            subCategoria = cmb_subCategoria.Text;
            tipoArmazenagem = cmb_tipoArmazenagem.Text;
            if (cbx_perecivel.Checked == true)
            {
                perecivel = "Produto Perecível";
            }
            else
            {
                perecivel = "Produto Não Perecível";
            }
            observacoes = txt_observacoes.Text;
            qrCode = "<Id: " + id + "> \n <Código: " + codigo + ">" + "\n" + nome + "\n" + descricao + "\n" + fabricante + "\n" + unidade + "\n" + estoqueMinimo + "\n" + localizacao + "\n" + setor + "\n" + categoria + "\n" + subCategoria + "\n" + tipoArmazenagem + "\n" + perecivel + "\n" + observacoes;



            QRCoder.QRCodeGenerator QRCode = new QRCoder.QRCodeGenerator();
            var myData = QRCode.CreateQrCode(qrCode, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(myData);
            img_qrCode.Image = code.GetGraphic(50);
        }

        private void Btn_excluirProduto_Click(object sender, EventArgs e)
        {
            ProdutoDAO pdao = new ProdutoDAO();
            pdao.criarProduto();
            MessageBox.Show("Conexão realizada com sucesso!");
        }
    }
}
