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
    public class ProcessoReferenciadoVO  : BaseVO
    {
        #region Campos
        private String nProc = "";
        private String indProc = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Identificador do processo ou ato concessório
        /// Tamanho: 1-60
        /// </summary>
        public String IdentificadorProcesso
        {
            get { return this.nProc; }
            set { this.nProc = value; }
        }

        /// <summary>
        /// Indicador da origem do processo
        /// 0=SEFAZ; 
        /// 1=Justiça Federal; 
        /// 2=Justiça Estadual; 
        /// 3=Secex/RFB; 
        /// 9=Outros
        /// </summary>
        public String IndicadorOrigemProcesso
        {
            get { return this.indProc; }
            set { this.indProc = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(ProcessoReferenciadoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return ProcessoReferenciadoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return ProcessoReferenciadoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
