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
    public class FormaPagamentoVO  : BaseVO
    {
        #region Campos
        private String tPag = "";
        private String vPag = "";
        private CartaoVO card = null;
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Tipo de pagamento
        /// 01=Dinheiro 
        /// 02=Cheque 
        /// 03=Cartão de Crédito 
        /// 04=Cartão de Débito 
        /// 05=Crédito Loja 
        /// 10=Vale Alimentação 
        /// 11=Vale Refeição 
        /// 12=Vale Presente 
        /// 13=Vale Combustível 
        /// 99=Outros 
        /// </summary>
        public String TipoPagamento
        {
            get { return this.tPag; }
            set { this.tPag = value; }
        }

        /// <summary>
        /// Valor do Pagamento 
        /// Formato: 13v2
        /// </summary>
        public String ValorPagamento
        {
            get { return this.vPag; }
            set { this.vPag = value; }
        }

        /// <summary>
        /// Grupo de Cartões 
        /// </summary>
        public CartaoVO Cartao
        {
            get { return this.card; }
            set { this.card = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(FormaPagamentoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return FormaPagamentoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return FormaPagamentoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
