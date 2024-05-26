
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
    public class FaturaVO  : BaseVO
    {
        #region Campos
        private String nFat = "";
        private String vOrig = "";
        private String vDesc = "";
        private String vLiq = "";
        #endregion Campos


        #region Propriedades

        /// <summary>
        /// Número da Fatura
        /// Tamanho: 1-60
        /// </summary>
        public String NumeroFatura
        {
            get { return this.nFat; }
            set { this.nFat = value; }
        }

        /// <summary>
        /// Valor Original da Fatura 
        /// Formato: 13v2
        /// </summary>
        public String ValorOriginalFatura 
        {
            get { return this.vOrig; }
            set { this.vOrig = value; }
        }

        /// <summary>
        /// Valor do desconto 
        /// Formato 13v2
        /// </summary>
        public String ValorDesconto
        {
            get { return this.vDesc; }
            set { this.vDesc = value; }
        }

        /// <summary>
        /// Valor Líquido da Fatura
        /// Formato: 13v2
        /// </summary>
        public String ValorLiquidoFatura
        {
            get { return this.vLiq; }
            set { this.vLiq = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(FaturaXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return FaturaXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return FaturaXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
