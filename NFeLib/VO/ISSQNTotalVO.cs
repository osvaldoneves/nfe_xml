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
    public class ISSQNTotalVO  : BaseVO
    {
        #region Campos
        private String vServ = "";
        private String vBC = "";
        private String vISS = "";
        private String vPIS = "";
        private String vCOFINS = "";
        private String dCompet = "";
        private String vDeducao = "";
        private String vOutro = "";
        private String vDescIncond = "";
        private String vDescCond = "";
        private String vISSRet = "";
        private String cRegTrib = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Valor total dos Serviços sob não-incidência ou não tributados pelo ICMS
        /// Formato: 13v2
        /// </summary>
        public String ValorTotalServicos
        {
            get { return this.vServ; }
            set { this.vServ = value; }
        }

        /// <summary>
        /// Valor total Base de Cálculo do ISS
        /// Formato: 13v2
        /// </summary>
        public String ValorTotalBaseCalculoISS
        {
            get { return this.vBC; }
            set { this.vBC = value; }
        }

        /// <summary>
        /// Valor total do ISS
        /// Formato: 13v2
        /// </summary>
        public String ValorTotalISS
        {
            get { return this.vISS; }
            set { this.vISS = value; }
        }

        /// <summary>
        /// Valor total do PIS sobre serviços 
        /// Formato: 13v2
        /// </summary>
        public String ValorTotalPIS
        {
            get { return this.vPIS; }
            set { this.vPIS = value; }
        }

        /// <summary>
        /// Valor total da COFINS sobre serviços.
        /// Formato: 13v2 
        /// </summary>
        public String ValorTotalCOFINS
        {
            get { return this.vCOFINS; }
            set { this.vCOFINS = value; }
        }

        /// <summary>
        /// Data da prestação do serviço
        /// Formato: “AAAA-MM-DD”
        /// </summary>
        public String DataPrestacaoServico
        {
            get { return this.dCompet; }
            set { this.dCompet = value; }
        }


        /// <summary>
        /// Valor total dedução para redução da Base de Cálculo.
        /// Formato: 13v2
        /// </summary>
        public String ValorTotalDeducaoReducaoBaseCalculo
        {
            get { return this.vDeducao; }
            set { this.vDeducao = value; }
        }

        /// <summary>
        /// Valor total outras retenções. Valor declaratório 
        /// Foramto: 13v2
        /// </summary>
        public String ValorTotalOutrasRetencoes
        {
            get { return this.vOutro; }
            set { this.vOutro = value; }
        }

        /// <summary>
        /// Valor total desconto incondicionado
        /// Formato: 13v2
        /// </summary>
        public String ValorTotalDescontoIncondicionado
        {
            get { return this.vDescIncond; }
            set { this.vDescIncond = value; }
        }

        /// <summary>
        /// Valor total desconto condicionado
        /// Foramto: 13v2
        /// </summary>
        public String ValorTotalDescontoCondicionado
        {
            get { return this.vDescCond; }
            set { this.vDescCond = value; }
        }

        /// <summary>
        /// Valor total retenção ISS
        /// Foramto: 13v2
        /// </summary>
        public String ValorTotalRetencaoISS
        {
            get { return this.vISSRet; }
            set { this.vISSRet = value; }
        }

        /// <summary>
        /// Código do Regime Especial de Tributação.
        /// 1=Microempresa Municipal; 
        /// 2=Estimativa; 
        /// 3=Sociedade de Profissionais; 
        /// 4=Cooperativa; 
        /// 5=Microempresário Individual (MEI); 
        /// 6=Microempresário e Empresa de Pequeno Porte (ME/EPP) 
        /// </summary>
        public String CodigoRegimeEspecialTributacao
        {
            get { return this.cRegTrib; }
            set { this.cRegTrib = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(ISSQNTotalXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return ISSQNTotalXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return ISSQNTotalXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
