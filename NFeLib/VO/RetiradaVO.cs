using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.Base;


namespace OLNG.Bibliotecas.NFeLib.VO
{
    public class RetiradaVO : BaseVO
    {
        #region Campos
        private String cnpj = "";   //CNPJ do emitente
        private String cpf = "";    //CPF do emitente
        private String xLgr = "";
        private String nro = "";
        private String xCpl = "";
        private String xBairro = "";
        private String cMun = "";
        private String xMun = "";
        private String uf = "";
        #endregion Campos

        #region Propriedades
        public String CNPJ
        {
            get { return this.cnpj; }
            set { this.cnpj = value; }
        }

        public String CPF
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }

        public String Logradouro
        {
            get { return this.xLgr; }
            set { this.xLgr = value; }
        }

        public String Numero
        {
            get { return this.nro; }
            set { this.nro = value; }
        }

        public String Complemento
        {
            get { return this.xCpl; }
            set { this.xCpl = value; }
        }

        public String Bairro
        {
            get { return this.xBairro; }
            set { this.xBairro = value; }
        }

        public String CodigoMunicipio
        {
            get { return this.cMun; }
            set { this.cMun = value; }
        }

        public String NomeMunicipio
        {
            get { return this.xMun; }
            set { this.xMun = value; }
        }

        public String UF
        {
            get { return this.uf; }
            set { this.uf = value; }
        }
        #endregion Propriedades

        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(RetiradaXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return RetiradaXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return RetiradaXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
