using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.Base;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public class EnderecoVO : BaseVO
    {
        #region Campos

        #region enderEmit
        private String xLgr = "";    // Logradouro (60)
        private String nro = "";     // Número (60)
        private String xCpl = "";    // Complemento (60)
        private String xBairro = ""; // Bairro (60)
        private String cMun = "";    // Código do Município (7)
        private String xMun = "";    // Nome do Município (60)
        private String uf = "";      // UF (2)
        private String cep = "";     // CEP (8)
        private String cPais = "";   // Código do Pais (4)
        private String xPais = "";   // Nome do Pais (60)]
        private String fone = "";    // Telefone DDD+Numero (4-14)
        #endregion enderEmit

        #endregion Campos


        #region Propriedades
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

        public String CEP
        {
            get { return this.cep; }
            set { this.cep = value; }
        }

        public String CodigoPais
        {
            get { return this.cPais; }
            set { this.cPais = value; }
        }

        public String NomePais
        {
            get { return this.xPais; }
            set { this.xPais = value; }
        }

        public String  Telefone
        {
            get { return this.fone; }
            set { this.fone = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(EnderecoEmitenteXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return EnderecoEmitenteXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return EnderecoEmitenteXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}