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
    public class CartaoVO  : BaseVO
    {
        #region Campos
        private String CNPJ = "";
        private String tBand = "";
        private String cAut = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// CNPJ da Credenciadora de cartão de crédito e/ou débito
        /// Tamanho: 14
        /// </summary>
        public String CNPJCredenciadora
        {
            get { return this.CNPJ; }
            set { this.CNPJ = value; }
        }

        /// <summary>
        /// Bandeira da operadora de cartão de crédito e/ou débito
        /// 01=Visa 
        /// 02=Mastercard
        /// 03=American Express 
        /// 04=Sorocred 
        /// 99=Outros 
        /// </summary>
        public String BandeiraOperadora
        {
            get { return this.tBand; }
            set { this.tBand = value; }
        }

        /// <summary>
        /// Número de autorização da operação cartão de crédito e/ou débito
        /// Tamanho 1-20
        /// </summary>
        public String NumeroAutorizacaoOperacao
        {
            get { return this.cAut; }
            set { this.cAut = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(CartaoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return CartaoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return CartaoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
