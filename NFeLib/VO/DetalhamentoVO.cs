using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.Base;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public class DetalhamentoVO  : BaseVO
    {
        #region Campos
        private String nItem = "";
        private String infAdProd = null;

        private ProdutoVO prod = null;
        private ImpostoVO imposto = null;
        private ImpostoDevolvidoVO impostoDevol = null;
        #endregion Campos

        #region Propriedades
        /// <summary>
        /// Informações Adicionais do Produto
        /// Norma referenciada, informações complementares, etc.
        /// </summary>
        public String InformacoesAdicionaisProduto
        {
            get { return this.infAdProd; }
            set { this.infAdProd = value; }
        }

        public String NumeroItem
        {
            get { return this.nItem; }
            set { this.nItem = value; }
        }

        public ProdutoVO Produto
        {
            get { return this.prod; }
            set { this.prod = value; }
        }

        public ImpostoVO Imposto
        {
            get { return this.imposto; }
            set { this.imposto = value; }
        }

        public ImpostoDevolvidoVO ImpostoDevolvido
        {
            get { return this.impostoDevol; }
            set { this.impostoDevol = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(AutorizacaoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return AutorizacaoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return AutorizacaoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
