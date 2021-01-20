using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_Almoxarifado.ModelBean
{
    class Produto
    {
        private Int32 id;
        private String codigo;
        private DateTime dataCadastro;
        private String nome;
        private String descricao;
        private String fabricante;
        private String unidade;
        private Int32 estoqueMinimo;
        private String setor;
        private String categoria;
        private String subCategoria;
        private Boolean perecivel;
        private String tipoArmazenagem;
        private String observacao;
        private String imagem;
        private String qrCode;
        private Int32 estoqueTotal;
        private Int32 estoqueDisponivel;
        private Int32 estoqueBloqueado;
        private String textoQrCode;
        private Double valorUnitario;
        private Boolean emEstoque;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public string Unidade { get => unidade; set => unidade = value; }
        public int EstoqueMinimo { get => estoqueMinimo; set => estoqueMinimo = value; }
        public string Setor { get => setor; set => setor = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string SubCategoria { get => subCategoria; set => subCategoria = value; }
        public bool Perecivel { get => perecivel; set => perecivel = value; }
        public string TipoArmazenagem { get => tipoArmazenagem; set => tipoArmazenagem = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string Imagem { get => imagem; set => imagem = value; }
        public string QrCode { get => qrCode; set => qrCode = value; }
        public int EstoqueTotal { get => estoqueTotal; set => estoqueTotal = value; }
        public int EstoqueDisponivel { get => estoqueDisponivel; set => estoqueDisponivel = value; }
        public int EstoqueBloqueado { get => estoqueBloqueado; set => estoqueBloqueado = value; }
        public string TextoQrCode { get => textoQrCode; set => textoQrCode = value; }
        public double ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
        public bool EmEstoque { get => emEstoque; set => emEstoque = value; }
    }
}
