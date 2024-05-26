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
    public class ExportacaoIndiretaVO  : BaseVO
    {
        #region Campos
        private String nRE = "";
        private String chNFe = "";
        private String qExport = "";
        #endregion Campos


        #region Propriedades
        public String NumeroRegistroExportacao
        {
            get { return this.nRE; }
            set { this.nRE = value; }
        }

        public String ChaveAcessoNFExportacao
        {
            get { return this.chNFe; }
            set { this.chNFe = value; }
        }

        public String QuantidadeExportada
        {
            get { return this.qExport; }
            set { this.qExport = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(AutorizacaoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return AutorizacaoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return AutorizacaoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
