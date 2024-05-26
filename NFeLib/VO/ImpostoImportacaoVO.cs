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
    public class ImpostoImportacaoVO  : BaseVO
    {
        #region Campos
        private String vBC = "";
        private String vDespAdu = "";
        private String vII = "";
        private String vIOF = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Valor despesas aduaneiras
        /// Formato 13v2
        /// </summary>
        public String ValorBCImpostoImportacao
        {
            get { return this.vBC; }
            set { this.vBC = value; }
        }

        /// <summary>
        /// Valor despesas aduaneiras
        /// Formato 13v2
        /// </summary>
        public String ValorDespesasAduaneiras
        {
            get { return this.vDespAdu; }
            set { this.vDespAdu = value; }
        }

        /// <summary>
        /// Valor Imposto de Importação 
        /// Formato 13v2
        /// </summary>
        public String ValorImpostoImportacao
        {
            get { return this.vII; }
            set { this.vII = value; }
        }

        /// <summary>
        /// Valor Imposto sobre Operações Financeiras
        /// Formato 13v2
        /// </summary>
        public String ValorIOF
        {
            get { return this.vIOF; }
            set { this.vIOF = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(ImpostoImportacaoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return ImpostoImportacaoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return ImpostoImportacaoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
