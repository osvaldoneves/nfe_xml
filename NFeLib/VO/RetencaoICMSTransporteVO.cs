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
    public class RetencaoICMSTransporteVO : BaseVO
    {
        #region Campos
        private String vServ = "";
        private String vBCRet = "";
        private String pICMSRet = "";
        private String vICMSRet = "";
        private String cfop = "";
        private String cMunFG = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Valor do Serviço
        /// Formato 13v2
        /// </summary>
        public String ValorServico
        {
            get { return this.vServ; }
            set { this.vServ = value; }
        }

        /// <summary>
        /// BC da Retenção do ICMS 
        /// Formato: 13v2
        /// </summary>
        public String ValorBCRetencaoICMS
        {
            get { return this.vBCRet; }
            set { this.vBCRet = value; }
        }

        /// <summary>
        /// Alíquota da Retenção
        /// Formato: 3v2-4
        /// </summary>
        public String AliquotaRetencao
        {
            get { return this.pICMSRet; }
            set { this.pICMSRet = value; }
        }

        /// <summary>
        /// Valor do ICMS Retido 
        /// Formato: 13v2
        /// </summary>
        public String ValorICMSRetido
        {
            get { return this.vICMSRet; }
            set { this.vICMSRet = value; }
        }

        /// <summary>
        /// CFOP de Serviço de Transporte (Anexo XIII.03). 
        /// </summary>
        public String CFOP
        {
            get { return this.cfop; }
            set { this.cfop = value; }
        }

        /// <summary>
        /// Código do município de ocorrência do fato gerador do ICMS do transporte.
        /// Utilizar a Tabela do IBGE(Anexo IX - Tabela de UF, Município e País)
        /// Tamanho: 7
        /// </summary>
        public String CodigoMunicipio
        {
            get { return this.cMunFG; }
            set { this.cMunFG = value; }
        }

        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(RetencaoICMSTransporteXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return RetencaoICMSTransporteXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return RetencaoICMSTransporteXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
