using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SS_Almoxarifado.ModelBean;
using SS_Almoxarifado.Views;
using SS_Almoxarifado.Connection;
using System.Data.OleDb;

namespace SS_Almoxarifado.ModelDAO
{
    

    class ProdutoDAO
    {
                
        frm_cadProdutos cadP = new frm_cadProdutos();


        Int32 idFabricante;
        Int32 idUnidade;
        Int32 idLocalizacao;
        Int32 idSetor;
        Int32 idCategoria;
        Int32 idSubCategoria;
        Int32 idTipoArmazenagem;


        public void criarProduto()
        {
            string strCon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db_almoxarifado.accdb";
            OleDbConnection con = new OleDbConnection(strCon);

            OleDbCommand sql = new OleDbCommand("SELECT MAX(id) AS MAIOR FROM tb_produtos");

            con.Open();

            String id;

            id = "";

            con.Close();

     

        }

        public void salvarProduto()
        {
            
            String sql;

            selectIdFabricante();
            selectIdLocalizacao();
            selectIdUnidade();
            selectIdSetor();
            selectIdCategoria();
            selectIdSubCategoria();            
            selectIdTipoArmazenagem();




            //sql = "INSERT INTO tb_produtos( " + "\n";
            //+"id, " + "\n";
            //+ "dataCadastro, " + "\n";
            //codigo, nome, descricao, id_fabricante, id_unidade, estoqueMinimo, id_localizacao, " _
            //            & "id_setor, id_categoria, id_subCategoria, perecivel, id_tipoArmazenagem, observacao, imagem, qrCode) " _
            //            & "VALUES (" _
            //            & id & ", '" _
            //            & dataCadastro & "', '" _
            //            & codigo & "', '" _
            //            & nome & "', '" _
            //            & descricao & "', " _
            //            & idFabricante & ", " _
            //            & idUnidade & ", " _
            //            & estoqueMinimo & ", " _
            //            & idLocalizacao & ", " _
            //            & idSetor & ", " _
            //            & idCategoria & ", " _
            //            & idSubCategoria & ", " _
            //            & perecivel & ", " _
            //            & idTipoArmazenagem & ", '" _
            //            & observacao & "', '" _
            //            & imagem & "', '" _
            //            & qrCode & "');;
        }

        public void atualizarProduto()
        {
            String sql;


            sql = "UPDATE tb_produtos SET ... WHERE codigo = ";
        }

        public void excluirProduto()
        {
            String sql;


            sql = "DELETE FROM tb_produtos WHERE codigo = ...";

            
        }

        public void selectIdFabricante()
        {
            String fabricante;
            String sql;



            fabricante = "";

            sql = "SELECT id FROM tb_fabricantes WHERE fabricante = '" + fabricante + "'";

            
        }

        public void selectIdUnidade()
        {
            String unidade;
            String sql;



            unidade = "";

            sql = "SELECT id FROM tb_unidades WHERE unidade = '" + unidade + "'";


        }

        public void selectIdLocalizacao()
        {
            String localizacao;
            String sql;



            localizacao = "";

            sql = "SELECT id FROM tb_localizacao WHERE localizacao = '" + localizacao + "'";


        }

        public void selectIdSetor()
        {
            String setor;
            String sql;



            setor = "";

            sql = "SELECT id FROM tb_setores WHERE setor = '" + setor + "'";


        }

        public void selectIdCategoria()
        {
            String categoria;
            String sql;



            categoria = "";

            sql = "SELECT id FROM tb_categorias WHERE categoria = '" + categoria + "'";


        }

        public void selectIdSubCategoria()
        {
            String subCategoria;
            String sql;



            subCategoria = "";

            sql = "SELECT id FROM tb_subCategorias WHERE subCategoria = '" + subCategoria + "'";


        }

        public void selectIdTipoArmazenagem()
        {
            String tipoArmazenagem;
            String sql;



            tipoArmazenagem = "";

            sql = "SELECT id FROM tb_tipoArmazenagem WHERE tipoArmazenagem = '" + tipoArmazenagem + "'";


        }
    }
}
