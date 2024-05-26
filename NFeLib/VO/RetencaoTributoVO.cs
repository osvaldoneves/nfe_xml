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
    /// <summary>
    /// Grupo Retenções de Tributos
    /// Exemplos de atos normativos que definem obrigatoriedade da retenção de contribuições: 
    /// a) IRPJ/CSLL/PIS/COFINS - Fonte - Recebimentos de Órgão Público Federal, Lei nº 9.430, de 27 de dezembro de 1996, art. 64, Lei nº 10.833/2003, art. 34, como normas infralegais, temos como exemplo: IN SRF 480/2004 e IN 539, de 25/04/05. 
    /// b) Retenção do Imposto de Renda pelas Fontes Pagadoras, REMUNERAÇÃO DE SERVIÇOS PROFISSIONAIS PRESTADOS POR PESSOA JURÍDICA, Lei nº 7.450/85, art. 52
    /// c) IRPJ, CSLL, COFINS e PIS - Serviços Prestados por Pessoas Jurídicas - Retenção na Fonte, Lei nº 10.833 de 29.12.2003, art. 30, 31, 32, 35 e 36 
    /// </summary>
    public class RetencaoTributoVO  : BaseVO
    {
        #region Campos
        private String vRetPIS = "";
        private String vRetCOFINS = "";
        private String vRetCSLL = "";
        private String vBCIRRF = "";
        private String vIRRF = "";
        private String vBCRetPrev = "";
        private String vRetPrev = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Valor Retido de PIS
        /// Formato: 13v2
        /// </summary>
        public String ValorRetidoPIS
        {
            get { return this.vRetPIS; }
            set { this.vRetPIS = value; }
        }

        /// <summary>
        /// Valor Retido de COFINS
        /// Formato: 13v2
        /// </summary>
        public String ValorRetidoCOFINS
        {
            get { return this.vRetCOFINS; }
            set { this.vRetCOFINS = value; }
        }

        /// <summary>
        /// Valor Retido de CSLL.
        /// Formato: 13v2
        /// </summary>
        public String ValorRetidoCSLL
        {
            get { return this.vRetCSLL; }
            set { this.vRetCSLL = value; }
        }

        /// <summary>
        /// Base de Cálculo do IRRF.
        /// Formato: 13v2
        /// </summary>
        public String BaseCalculoIRRF
        {
            get { return this.vBCIRRF; }
            set { this.vBCIRRF = value; }
        }

        /// <summary>
        /// Valor Retido do IRRF.
        /// Formato: 13v2
        /// </summary>
        public String ValorRetidoIRRF
        {
            get { return this.vIRRF; }
            set { this.vIRRF = value; }
        }

        /// <summary>
        /// Base de Cálculo da Retenção da Previdência Social
        /// </summary>
        public String BaseCalculoRetencaoPrevidencia
        {
            get { return this.vBCRetPrev; }
            set { this.vBCRetPrev = value; }
        }

        /// <summary>
        /// Valor da Retenção da Previdência Social
        /// Formato: 13v2
        /// </summary>
        public String ValorRetencaoPrevidenciaSocial
        {
            get { return this.vRetPrev; }
            set { this.vRetPrev = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(RetencaoTributoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return RetencaoTributoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return RetencaoTributoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
