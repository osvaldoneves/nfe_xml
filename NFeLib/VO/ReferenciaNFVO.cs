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
    public class ReferenciaNFVO : BaseVO
    {
        #region Campos
        private String cUF = "";
        private String AAMM = "";
        private String cnpj = "";
        private String mod = "";
        private String serie = "";
        private String nNF = "";
        #endregion Campos

        #region Propriedades

        public String CodigoUF
        {
            get { return this.CodigoUF; }
            set { this.CodigoUF = value; }
        }

        public String AnoMesEmissao
        {
            get { return this.AAMM; }
            set { this.AAMM = value; }
        }

        public String CNPJ
        {
            get { return this.cnpj; }
            set { this.cnpj = value; }
        }

        public String ModeloDocFiscal
        {
            get { return this.mod; }
            set { this.mod = value; }
        }

        public String Serie
        {
            get { return this.serie; }
            set { this.serie = value; }
        }

        public String NumeroDocumentoFiscal
        {
            get { return this.nNF; }
            set { this.nNF = value; }
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
