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
    public class COFINSSTVO  : BaseVO
    {
        #region Campos
        private String qBCProd = "";
        private String vAliqProd = "";
        private String vCOFINS = "";
        private String vBC = "";
        private String pCOFINS = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Quantidade Vendida
        /// Informar se o cálculo do PIS for em valor. 
        /// Formato 12v0-4
        /// </summary>
        public String QuantidadeVendida
        {
            get { return this.qBCProd; }
            set { this.qBCProd = value; }
        }

        /// <summary>
        /// Alíquota do PIS (em reais)
        /// Informar se o cálculo do COFINS for em valor
        /// Formato 11v0-4 
        /// </summary>
        public String ValorAliquotaProduto
        {
            get { return this.vAliqProd; }
            set { this.vAliqProd = value; }
        }

        /// <summary>
        /// Valor do PIS
        /// 13v2
        /// </summary>
        public String ValorCOFINS
        {
            get { return this.vCOFINS; }
            set { this.vCOFINS = value; }
        }

        /// <summary>
        /// Valor da BC do IPI
        /// Informar se o cálculo do PIS em percentual
        /// Formato 13v2
        /// </summary>
        public String ValorBC
        {
            get { return this.vBC; }
            set { this.vBC = value; }
        }

        /// <summary>
        /// Alíquota do PIS (em percentual)
        /// Informar os campos Q07 e Q08 se o cálculo do PIS em percentual
        /// Formato 3v2-4
        /// </summary>
        public String AliquotaCOFINS
        {
            get { return this.pCOFINS; }
            set { this.pCOFINS = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(COFINSSTXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return COFINSSTXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return COFINSSTXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
