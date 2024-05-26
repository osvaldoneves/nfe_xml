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
    public class InfoAdicionalVO : BaseVO
    {
        #region Campos
        private String infAdFisco = "";
        private String infCpl = "";
        private List<ObsContribuinteVO> obsCont = null;
        private List<ObsFiscoVO> obsFisco = null;
        private List<ProcessoReferenciadoVO> procRef = null;
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Informações Adicionais de Interesse do Fisco 
        /// Tamanho: 1-2000
        /// </summary>
        public String InformacoesAdicionaisFisco 
        {
            get { return this.infAdFisco; }
            set { this.infAdFisco = value; }
        }

        /// <summary>
        /// Informações Complementares de interesse do Contribuinte
        /// Tamanho: 1-5000
        /// </summary>
        public String InformacoesComplementaresContribuinte 
        {
            get { return this.infCpl; }
            set { this.infCpl = value; }
        }

        /// <summary>
        /// Grupo Campo de uso livre do contribuinte
        /// Campo de uso livre do contribuinte, Informar o nome do campo no atributo xCampo e o conteúdo do campo no xTexto
        /// Ocorrência: 0-10
        /// </summary>
        public List<ObsContribuinteVO> ObsContribuinte
        {
            get { return this.obsCont; }
            set { this.obsCont = value; }
        }

        /// <summary>
        /// Grupo Campo de uso livre do Fisco
        /// Campo de uso livre do Fisco. Informar o nome do campo no atributo xCampo e o conteúdo do campo no xTexto
        /// Ocorrência: 1-10
        /// </summary>
        public List<ObsFiscoVO> ObsFisco
        {
            get { return this.obsFisco; }
            set { this.obsFisco = value; }
        }

        /// <summary>
        /// Grupo Processo referenciado
        /// Ocorrência: 1-100
        /// </summary>
        public List<ProcessoReferenciadoVO> ProcessoReferenciado
        {
            get { return this.procRef; }
            set { this.procRef = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(InfoAdicionalXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return InfoAdicionalXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return InfoAdicionalXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
