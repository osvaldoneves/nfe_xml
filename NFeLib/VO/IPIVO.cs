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
    public class IPIVO  : BaseVO
    {
        #region Campos
        private String clEnq = "";
        private String CNPJProd = "";
        private String cSelo = "";
        private String qSelo = "";
        private String cEnq = "";

        private IPITributadoVO ipiTrib = null;
        private IPINaoTributadoVO ipiNT = null;
        #endregion Campos


        #region Propriedades


        /// <summary>
        /// Classe de enquadramento do IPI para Cigarros e Bebidas 
        /// Preenchimento conforme Atos Normativos editados pela Receita Federal(Observação 2)
        /// </summary>
        public String ClasseEnquadramentoIPI
        {
            get { return this.clEnq; }
            set { this.clEnq = value; }
        }

        /// <summary>
        /// CNPJ do produtor da mercadoria, quando diferente do emitente. Somente para os casos de exportação direta ou indireta.
        /// Informar os zeros não significativos
        /// </summary>
        public String CNPJProdutor
        {
            get { return this.CNPJProd; }
            set { this.CNPJProd = value; }
        }

        /// <summary>
        /// Código do selo de controle IPI
        /// Preenchimento conforme Atos Normativos editados pela Receita Federal (Observação 3) 
        /// </summary>
        public String CodigoSelo
        {
            get { return this.cSelo; }
            set { this.cSelo = value; }
        }

        /// <summary>
        /// Quantidade de selo de controle.
        /// </summary>
        public String QuantidadeSelo
        {
            get { return this.qSelo; }
            set { this.qSelo = value; }
        }

        /// <summary>
        /// Código de Enquadramento Legal do IPI
        /// Tabela a ser criada pela RFB, informar 999 enquanto a tabela não for criada 
        /// </summary>
        public String CodigoEnquadramento
        {
            get { return this.cEnq; }
            set { this.cEnq = value; }
        }


        /// <summary>
        /// Grupo do CST 00, 49, 50 e 99
        /// </summary>
        public IPITributadoVO IPITributado
        {
            get { return this.ipiTrib; }
            set { this.ipiTrib = value; }
        }

        /// <summary>
        /// Grupo CST 01, 02, 03, 04, 51, 52, 53, 54 e 55
        /// </summary>
        public IPINaoTributadoVO IPINaoTributado
        {
            get { return this.ipiNT; }
            set { this.ipiNT = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(IPIXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return IPIXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return IPIXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
