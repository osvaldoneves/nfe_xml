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
    public class ComercioExteriorVO  : BaseVO
    {
        #region Campos
        private String ufSaidaPais = "";
        private String xLocExporta = "";
        private String xLocDespacho = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Sigla da UF de Embarque ou de transposição de fronteira.
        /// Não aceita o valor "EX"
        /// </summary>
        public String UFSaidaPais
        {
            get { return this.ufSaidaPais; }
            set { this.ufSaidaPais = value; }
        }

        /// <summary>
        /// Descrição do Local de Embarque ou de transposição de fronteira
        /// Tamanho: 1-60
        /// </summary>
        public String LocalExportacao
        {
            get { return this.xLocExporta; }
            set { this.xLocExporta = value; }
        }

        /// <summary>
        /// Descrição do local de despacho
        /// Tamanho: 1-60
        /// </summary>
        public String LocalDespacho
        {
            get { return this.xLocDespacho; }
            set { this.xLocDespacho = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(ComercioExteriorXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return ComercioExteriorXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return ComercioExteriorXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
