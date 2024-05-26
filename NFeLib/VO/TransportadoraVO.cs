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
    public class TransportadoraVO  : BaseVO
    {
        #region Campos
        private String cpf = "";
        private String cnpj = "";
        private String xNome = "";
        private String IE = "";
        private String xEnder = "";
        private String xMun = "";
        private String uf = "";
        #endregion Campos


        #region Propriedades

        /// <summary>
        /// CPF do Transportador
        /// Preencher os zeros não significativos
        /// Tamanho: 11
        /// </summary>
        public String CPF
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }


        /// <summary>
        /// CNPJ do Transportador
        /// Preencher os zeros não significativos
        /// Tamanho: 14
        /// </summary>
        public String CNPJ
        {
            get { return this.cnpj; }
            set { this.cnpj = value; }
        }

        /// <summary>
        /// Razão Social ou nome 
        /// Tamanho: 2-60
        /// </summary>
        public String Nome
        {
            get { return this.xNome; }
            set { this.xNome = value; }
        }

        /// <summary>
        /// Inscrição Estadual do Transportador
        /// Informar: - Inscrição Estadual do transportador contribuinte do ICMS, sem caracteres de formatação (ponto, barra, hífen, etc.); 
        ///           - Literal “ISENTO” para transportador isento de inscrição no cadastro de contribuintes ICMS; 
        ///           - Não informar a tag para não contribuinte do ICMS, A UF deve ser informada se informado uma IE. (v2.0)
        /// Tamanho: 2-14
        /// </summary>
        public String InscricaoEstadual
        {
            get { return this.IE; }
            set { this.IE = value; }
        }

        /// <summary>
        /// Endereço Completo
        /// Tamanho: 1-60
        /// </summary>
        public String EnderecoCompleto
        {
            get { return this.xEnder; }
            set { this.xEnder = value; }
        }

        /// <summary>
        /// Nome do município
        /// Tamanho: 1-60
        /// </summary>
        public String NomeMunicipio
        {
            get { return this.xMun; }
            set { this.xMun = value; }
        }

        /// <summary>
        /// Sigla da UF 
        /// A UF deve ser informada se informado uma IE. (v2.0). Informar "EX" para Exterior.
        /// Tamanho: 2
        /// </summary>
        public String SiglaUF
        {
            get { return this.uf; }
            set { this.uf = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(TransportadoraXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return TransportadoraXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return TransportadoraXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
