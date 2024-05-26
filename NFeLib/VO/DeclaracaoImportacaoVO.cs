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
    public class DeclaracaoImportacaoVO  : BaseVO
    {
        #region Campos
        private String nDI = "";
        private String dDI = "";
        private String xLocDesemb = "";
        private String UFDesemb = "";
        private String dDesemb = "";
        private String tpViaTransp = "";
        private String vAFRMM = "";
        private String tpIntermedio = "";
        private String cnpj = "";
        private String ufTerceiro = "";
        private String cExportador = "";

        private List<AdicaoVO> adicoes = null;
        #endregion Campos


        #region Propriedades
        public String NumeroDocumentoImportacao
        {
            get { return this.nDI; }
            set { this.nDI = value; }
        }

        public String DataRegistroDocumento
        {
            get { return this.dDI; }
            set { this.dDI = value; }
        }

        public String LocalDesembaraco
        {
            get { return this.xLocDesemb; }
            set { this.xLocDesemb = value; }
        }

        public String UFDesembaraco
        {
            get { return this.UFDesemb; }
            set { this.UFDesemb = value; }
        }

        public String DataDesembaraco
        {
            get { return this.dDesemb; }
            set { this.dDesemb = value; }
        }

        public String TipoViaTransporte
        {
            get { return this.tpViaTransp; }
            set { this.tpViaTransp = value; }
        }

        public String ValorAFRMM
        {
            get { return this.vAFRMM; }
            set { this.vAFRMM = value; }
        }

        public String TipoIntermedioImportacao
        {
            get { return this.tpIntermedio; }
            set { this.tpIntermedio = value; }
        }

        public String CNPJ
        {
            get { return this.cnpj; }
            set { this.cnpj = value; }
        }

        public String UFTerceiro
        {
            get { return this.ufTerceiro; }
            set { this.ufTerceiro = value; }
        }

        public String CodigoExportador
        {
            get { return this.cExportador; }
            set { this.cExportador = value; }
        }

        public List<AdicaoVO> Adicoes
        {
            get { return this.adicoes; }
            set { this.adicoes = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(DeclaracaoImportacaoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return DeclaracaoImportacaoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return DeclaracaoImportacaoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
