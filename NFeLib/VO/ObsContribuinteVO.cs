
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
    public class ObsContribuinteVO : BaseVO
    {
        #region Campos
        private String xCampo = "";
        private String xTexto = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Identificação do campo
        /// Tamanho: 1-20
        /// </summary>
        public String Campo
        {
            get { return this.xCampo; }
            set { this.xCampo = value; }
        }

        /// <summary>
        /// Conteúdo do campo
        /// Tamanho: 1-60
        /// </summary>
        public String Texto
        {
            get { return this.xTexto; }
            set { this.xTexto = value; }
        }

        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(ObsContribuinteXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return ObsContribuinteXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return ObsContribuinteXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
