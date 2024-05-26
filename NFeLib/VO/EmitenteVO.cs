using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.Base;
using OLNG.Bibliotecas.NFeLib.XML;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public class EmitenteVO : BaseVO
    {
        #region Campos
        #region emit
        private String cnpj = "";   //CNPJ do emitente
        private String cpf = "";    //CPF do emitente
        private String xNome = "";  //Rasão Social ou Nome do emitente
        private String xFant = "";  //Nome Fantasia
        private String IE = "";     //Inscrição Estadual (0-14)
        private String IEST = "";   //Insrição Estadual do Substituto Tributário
        private String im = "";     //Inscrição Municipal
        private String cnae = "";   //CNAE fiscal
        private String CRT = "";   //Código de Regime Tributário (1-Simples Nacional ; 2- Simples Nacional - excesso de sublimite de receita bruta ; 3-Regime Nacional)
        #endregion emit

        private EnderecoVO enderEmit = null;
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

        public String Nome
        {
            get { return this.xNome; }
            set { this.xNome = value; }
        }

        public String NomeFantasia
        {
            get { return this.xFant; }
            set { this.xFant = value; } }

        public String InscricaoEstadual
        {
            get { return this.IE; }
            set { this.IE = value; } }

        public String InscricaoEstadualST
        {
            get { return this.IEST; }
            set { this.IEST = value; }
        }

        
        public String InscricaoMunicial
        {
            get { return this.im; }
            set { this.im = value; }
        }

        public String CNAE
        {
            get { return this.CNAE; }
            set { this.CNAE = value; }
        }
        
        public string CodRegimeTributario
        {
            get { return this.CRT; }
            set { this.CRT = value; }
        }

        public EnderecoVO EnderecoEmitente
        {
            get { return this.enderEmit; }
            set { this.enderEmit = value; }
        }
        #endregion Proriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(EmitenteXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return EmitenteXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return EmitenteXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
