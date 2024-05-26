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
    public class ImpostoDevolvidoVO  : BaseVO
    {
        #region Campos
        private String pDevol = "";
        private IPIDevolvidoVO ipiDevol = null;
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Percentual da mercadoria devolvida.
        /// Formato: 3v2
        /// </summary>
        public String PercentualMercadoriaDevolvida
        {
            get { return this.pDevol; }
            set { this.pDevol = value; }
        }

        public IPIDevolvidoVO IPIDevolvido
        {
            get { return this.ipiDevol; }
            set { this.ipiDevol = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(ImpostoDevolvidoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return ImpostoDevolvidoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return ImpostoDevolvidoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
