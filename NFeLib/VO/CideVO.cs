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
    public class CideVO  : BaseVO
    {
        #region Campos
        private String qBCProd = "";
        private String vAliqProd = "";
        private String vCIDE = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        ///  BC da CIDE em quantidade
        ///  Formato 12v0-4
        /// </summary>
        public String BaseCalculoCIDE
        {
            get { return this.qBCProd; }
            set { this.qBCProd = value; }
        }

        /// <summary>
        /// Valor da alíquota da CIDE
        /// Formato 11v4
        /// </summary>
        public String ValorAlicotaCIDE
        {
            get { return this.vAliqProd; }
            set { this.vAliqProd = value; }
        }

        /// <summary>
        /// Valor da CIDE
        /// Formato 13v2
        /// </summary>
        public String ValorCIDE
        {
            get { return this.vCIDE; }
            set { this.vCIDE = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(CideXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return CideXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return CideXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
