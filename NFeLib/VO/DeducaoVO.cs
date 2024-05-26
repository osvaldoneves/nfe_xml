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
    public class DeducaoVO  : BaseVO
    {
        #region Campos
        private String xDed = "";
        private String vDed = "";
        private String vFor = "";
        private String vTotDed = "";
        private String vLiqFor = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Descrição da Dedução
        /// Tamanho: 1-60
        /// </summary>
        public String DescricaoDeducao
        {
            get { return this.xDed; }
            set { this.xDed = value; }
        }

        /// <summary>
        /// Valor da Dedução
        /// Formato: 13v2
        /// </summary>
        public String ValorDeducao
        {
            get { return this.vDed; }
            set { this.vDed = value; }
        }

        /// <summary>
        /// Valor dos Fornecimentos
        /// Formato: 13v2
        /// </summary>
        public String ValorFornecimentos
        {
            get { return this.vFor; }
            set { this.vFor = value; }
        }

        /// <summary>
        /// Valor Total da Dedução
        /// Formato: 13v2
        /// </summary>
        public String ValorTotalDeducao
        {
            get { return this.vTotDed; }
            set { this.vTotDed = value; }
        }

        /// <summary>
        /// Valor Líquido dos Fornecimentos
        /// Formato: 13v2
        /// </summary>
        public String ValorLiquidoFornecimentos
        {
            get { return this.vLiqFor; }
            set { this.vLiqFor = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(DeducaoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return DeducaoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return DeducaoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
