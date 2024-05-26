using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.Base;
using OLNG.Bibliotecas.NFeLib.XML;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public class DestinatarioVO : BaseVO
    {
        #region Campos
        #region dest
        private String cpf = "";           // CPF do destinatário (11)
        private String cnpj = "";          // CNPJ do destinatário (14)
        private String idEstrangeiro = ""; // Identificação do destinatário no caso de comprador estrangeiro (5-20)
        private String xNome = "";         // Nome ou Rasão Social do destinatário (60)
        private String indIEDest = "9";    // Indicador da IE do Destinatário  (1)
        private String IE = "";            // Inscrição Estadual do Destinatário (2-14)
        private String ISUF = "";          // Inscrição na SUFRAMA (8-9)
        private String IM = "";            // Inscrição Municial do Tomador de Serviço (1-15)
        private String email = "";         // e-mail destinatário (1-60)

        private EnderecoVO enderDest = null;
        #endregion dest
        #endregion Campos


        #region Propriedades
        public String CPF
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }

        public String CNPJ
        {
            get { return this.cnpj; }
            set { this.cnpj = value; }
        }

        public String IdEstrangeiro
        {
            get { return this.idEstrangeiro; }
            set { this.idEstrangeiro = value; }
        }

        public String Nome
        {
            get { return this.xNome; }
            set { this.xNome = value; }
        }

        public String IndIEDestinatario
        {
            get { return this.indIEDest; }
            set { this.indIEDest = value; }
        }

        public String InscricaoEstadual
        {
            get { return this.IE; }
            set { this.IE = value; }
        }

        public String InscricaoSUFRAMA
        {
            get { return this.ISUF; }
            set { this.ISUF = value; }
        }

        public String InscricaoMunicipal
        {
            get { return this.IM; }
            set { this.IM = value; }
        }

        public String eMail
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public EnderecoVO EnderecoDestinatario
        {
            get { return this.enderDest; }
            set { this.enderDest = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(DestinatarioXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return DestinatarioXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return DestinatarioXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
