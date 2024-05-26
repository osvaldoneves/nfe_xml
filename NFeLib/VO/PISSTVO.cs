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
    public class PISSTVO  : BaseVO
    {
        #region Campos
        private String qBCProd = "";
        private String vAliqProd = "";
        private String vPIS = "";
        private String vBC = "";
        private String pPIS = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Quantidade Vendida
        /// Informar se o cálculo do PIS for em valor. 
        /// tag: qBCProd.
        /// Formato 12v0-4
        /// </summary>
        public String QuantidadeVendida
        {
            get { return this.qBCProd; }
            set { this.qBCProd = value; }
        }

        /// <summary>
        /// Alíquota do PIS (em reais).
        /// Informar se o cálculo do PIS for em valor.
        /// tag: vAliqProd
        /// Formato 11v0-4 
        /// </summary>
        public String ValorAliquotaPIS
        {
            get { return this.vAliqProd; }
            set { this.vAliqProd = value; }
        }

        /// <summary>
        /// Valor do PIS.
        /// tag: vPIS.
        /// Formato: 13v2.
        /// </summary>
        public String ValorPIS
        {
            get { return this.vPIS; }
            set { this.vPIS = value; }
        }

        /// <summary>
        /// Valor da BC do PIS.
        /// Informar se o cálculo do PIS em percentual.
        /// tag: vBC.
        /// Formato: 13v2.
        /// </summary>
        public String ValorBCPIS
        {
            get { return this.vBC; }
            set { this.vBC = value; }
        }

        /// <summary>
        /// Alíquota do PIS (em percentual).
        /// Informar os campos Q07 e Q08 se o cálculo do PIS em percentual.
        /// tag: pPIS.
        /// Formato 3v2-4
        /// </summary>
        public String AliquotaPIS
        {
            get { return this.pPIS; }
            set { this.pPIS = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(PISSTXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return PISSTXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return PISSTXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
