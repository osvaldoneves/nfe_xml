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
    public class TotalVO  : BaseVO
    {
        #region Campos
        private ICMSTotalVO ICMSTot = null;
        private ISSQNTotalVO ISSNQTot = null;
        private RetencaoTributoVO retTrib = null;
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Grupo Totais referentes ao ICMS 
        /// </summary>
        public ICMSTotalVO ICMSTotal
        {
            get { return this.ICMSTot; }
            set { this.ICMSTot = value; }
        }

        /// <summary>
        /// Grupo Totais referentes ao ISSQN
        /// </summary>
        public ISSQNTotalVO ISSNQTotal
        {
            get { return this.ISSNQTot; }
            set { this.ISSNQTot = value; }
        }

        /// <summary>
        /// Grupo Retenções de Tributos 
        /// </summary>
        public RetencaoTributoVO RetencaoTributo
        {
            get { return this.retTrib; }
            set { this.retTrib = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(TotalXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return TotalXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return TotalXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
