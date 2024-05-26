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
    public class ProdutoVO  : BaseVO
    {
        #region Campos
        private String cProd = "";
        private String cEAN = "";
        private String xProd = "";
        private String ncm = "";
        private List<String> nve = null;
        private String extipi = "";
        private String cfop = "";
        private String uCom = "";
        private String qCom = "";
        private String vUnCom = "";
        private String vProd = "";
        private String cEANTrib = "";
        private String uTrib = "";
        private String qTrib = "";
        private String vUnTrib = "";
        private String vFrete = "";
        private String vSeg = "";
        private String vDesc = "";
        private String vOutro = "";
        private String indTot = "";

        private List<DeclaracaoImportacaoVO> dis = null;
        private List<ExportacaoVO> detExports = null;

        #endregion Campos


        #region Propriedades
        
        public String CodigoProduto
        {
            get { return this.cProd; }
            set { this.cProd = value; }
        }


        public String CodigoEAN
        {
            get { return this.cEAN; }
            set { this.cEAN = value; }
        }


        public String DescricaoProduto
        {
            get { return this.xProd; }
            set { this.xProd = value; }
        }
        public String NCM
        {
            get { return this.ncm; }
            set { this.ncm = value; }
        }

        public List<String> NVE
        {
            get { return this.nve; }
            set { this.nve = value; }
        }

        public String EXTIPI
        {
            get { return this.extipi; }
            set { this.extipi = value; }
        }

        public String CFOP
        {
            get { return this.cfop; }
            set { this.cfop = value; }
        }

        public String UnidadeComercial
        {
            get { return this.uCom; }
            set { this.uCom = value; }
        }

        public String QuantidadeComercial
        {
            get { return this.qCom; }
            set { this.qCom = value; }
        }

        public String ValorUnitarioComercializacao
        {
            get { return this.vUnCom; }
            set { this.vUnCom = value; }
        }

        public String ValorTotalBruto
        {
            get { return this.vProd; }
            set { this.vProd = value; }
        }

        public String CodigoEANTributavel
        {
            get { return this.cEANTrib; }
            set { this.cEANTrib = value; }
        }

        public String UnidadeTributavel
        {
            get { return this.uTrib; }
            set { this.uTrib = value; }
        }

        public String QuantidadeTributavel
        {
            get { return this.qTrib; }
            set { this.qTrib = value; }
        }

        public String ValorUnitarioTributacao
        {
            get { return this.vUnTrib; }
            set { this.vUnTrib = value; }
        }

        public String ValorFrete
        {
            get { return this.vFrete; }
            set { this.vFrete = value; }
        }

        public String ValorSeguro
        {
            get { return this.vSeg; }
            set { this.vSeg = value; }
        }

        public String ValorDesconto
        {
            get { return this.vDesc; }
            set { this.vDesc = value; }
        }

        /// <summary>
        /// Outras despesas acessórias.
        /// tag: vOutro 
        /// </summary>
        public String OutrasDespesas
        {
            get { return this.vOutro; }
            set { this.vOutro = value; }
        }

        /// <summary>
        /// Indica se valor do Item (vProd) entra no valor total da NF-e (vProd).
        /// 0=Valor do item(vProd) não compõe o valor total da NF-e; 
        /// 1=Valor do item(vProd) compõe o valor total da NF-e(vProd)
        /// tag: indTot
        /// </summary>
        public String IndicadorValorTotal 
        {
            get { return this.indTot; }
            set { this.indTot = value; }
        }

        public List<DeclaracaoImportacaoVO> DeclaracaoImportacao
        {
            get { return this.dis; }
            set { this.dis = value; }
        }

        public List<ExportacaoVO> Exportacao
        {
            get { return this.detExports; }
            set { this.detExports = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(ProdutoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return ProdutoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return ProdutoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
