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
    public class ImpostoVO  : BaseVO
    {
        #region Campos
        private String vTotTrib = "";
        private ICMSVO icms = null;
        private IPIVO ipi = null;
        private ImpostoImportacaoVO ii = null;
        private PISVO pis = null;
        private PISSTVO pisst = null;
        private COFINSVO cofins = null;
        private COFINSSTVO cofinsst = null;
        private ISSQNVO issqn = null;
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Valor aproximado total de tributos federais, estaduais e municipais.
        /// Formato 13v2
        /// </summary>
        public String ValorTotalTributos
        {
            get { return this.vTotTrib; }
            set { this.vTotTrib = value; }
        }

        /// <summary>
        /// Informações do ICMS da Operação própria e ST
        /// </summary>
        public ICMSVO ICMS
        {
            get { return this.icms; }
            set { this.icms = value; }
        }

        /// <summary>
        /// Imposto sobre Produtos Industrializados
        /// Informar apenas quando o item for sujeito ao IPI 
        /// </summary>
        public IPIVO IPI
        {
            get { return this.ipi; }
            set { this.ipi = value; }
        }

        /// <summary>
        ///  Imposto de Importação 
        ///  Informar apenas quando o item for sujeito ao II
        /// </summary>
        public ImpostoImportacaoVO ImpostoImportacao
        {
            get { return this.ii; }
            set { this.ii = value; }
        }

        /// <summary>
        /// Grupo PIS
        /// </summary>
        public PISVO PIS
        {
            get { return this.pis; }
            set { this.pis = value; }
        }

        /// <summary>
        /// PISST
        /// </summary>
        public PISSTVO PISST
        {
            get { return this.pisst; }
            set { this.pisst = value; }
        }

        /// <summary>
        /// Grupo COFINS
        /// </summary>
        public COFINSVO COFINS
        {
            get { return this.cofins; }
            set { this.cofins = value; }
        }

        /// <summary>
        /// Grupo COFINSST
        /// </summary>
        public COFINSSTVO COFINSST
        {
            get { return this.cofinsst; }
            set { this.cofinsst = value; }
        }

        /// <summary>
        /// Grupo ISSQN
        /// </summary>
        public ISSQNVO ISSQN
        {
            get { return this.issqn; }
            set { this.issqn = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(ImpostoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return ImpostoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return ImpostoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
