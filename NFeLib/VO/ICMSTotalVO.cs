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
    public class ICMSTotalVO  : BaseVO
    {
        #region Campos
        private String vBC = "";
        private String vICMS = "";
        private String vICMSDeson = "";
        private String vBCST = "";
        private String vST = "";
        private String vProd = "";
        private String vFrete = "";
        private String vSeg = "";
        private String vDesc = "";
        private String vII = "";
        private String vIPI = "";
        private String vPIS = "";
        private String vCOFINS = "";
        private String vOutro = "";
        private String vNF = "";
        private String vTotTrib = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Base de Cálculo do ICMS
        /// Foramto 13v2
        /// </summary>
        public String ValorBaseCalculoICMS
        {
            get { return this.vBC; }
            set { this.vBC = value; }
        }

        /// <summary>
        /// Valor Total do ICMS 
        /// Formato: 13v2
        /// </summary>
        public String ValorTotalICMS
        {
            get { return this.vICMS; }
            set { this.vICMS = value; }
        }

        /// <summary>
        /// Valor Total do ICMS desonerado 
        /// Formato: 13v2
        /// </summary>
        public String ValorTotalICMSDesonerado
        {
            get { return this.vICMSDeson; }
            set { this.vICMSDeson = value; }
        }

        /// <summary>
        /// Base de Cálculo do ICMS ST
        /// Formato: 13v2
        /// </summary>
        public String BaseCalculoICMSST
        {
            get { return this.vBCST; }
            set { this.vBCST = value; }
        }

        /// <summary>
        /// Valor Total do ICMS ST 
        /// Formato: 13v2
        /// </summary>
        public String ValorTotalICMSST
        {
            get { return this.vST; }
            set { this.vST = value; }
        }

        /// <summary>
        /// Valor Total dos produtos e serviços 
        /// Formato: 13v2
        /// </summary>
        public String ValorTotalProdutosServicos
        {
            get { return this.vProd; }
            set { this.vProd = value; }
        }

        /// <summary>
        /// Valor Total do Frete 
        /// Formato: 13v2
        /// </summary>
        public String ValorTotalFrete
        {
            get { return this.vFrete; }
            set { this.vFrete = value; }
        }

        /// <summary>
        /// Valor Total do Seguro
        /// Foramto: 13v2
        /// </summary>
        public String ValorTotalSeguro
        {
            get { return this.vSeg; }
            set { this.vSeg = value; }
        }

        /// <summary>
        /// Valor Total do Desconto
        /// Foramto: 13v2
        /// </summary>
        public String ValorTotalDesconto
        {
            get { return this.vDesc; }
            set { this.vDesc = value; }
        }

        /// <summary>
        /// Valor Total do II
        /// Foramto: 13v2
        /// </summary>
        public String ValorTotalImpostoImportacao
        {
            get { return this.vII; }
            set { this.vII = value; }
        }

        /// <summary>
        /// Valor Total do IPI 
        /// Foramto: 13v2
        /// </summary>
        public String ValorTotalIPI
        {
            get { return this.vIPI; }
            set { this.vIPI = value; }
        }

        /// <summary>
        /// Valor do PIS 
        /// Foramto: 13v2
        /// </summary>
        public String ValorTotalPIS
        {
            get { return this.vPIS; }
            set { this.vPIS = value; }
        }

        /// <summary>
        /// Valor da COFINS
        /// Foramto: 13v2
        /// </summary>
        public String ValorTotalCOFINS
        {
            get { return this.vCOFINS; }
            set { this.vCOFINS = value; }
        }

        /// <summary>
        /// Outras Despesas acessórias 
        /// Formato: 13v2
        /// </summary>
        public String OutrasDespesas
        {
            get { return this.vOutro; }
            set { this.vOutro = value; }
        }

        /// <summary>
        /// Valor Total da NF-e
        /// Vide validação para este campo na regra de validação W16-xx
        /// Foramto: 13v2
        /// </summary>
        public String ValorTotalNF
        {
            get { return this.vNF; }
            set { this.vNF = value; }
        }

        /// <summary>
        /// Valor aproximado total de tributos federais, estaduais e municipais.
        /// Formato: 13v2
        /// </summary>
        public String ValorTotalTributos
        {
            get { return this.vTotTrib; }
            set { this.vTotTrib = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(ICMSTotalXML.grupo.CamposNo.Keys);            
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return ICMSTotalXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return ICMSTotalXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
