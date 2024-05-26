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
    public class CombustivelVO  : BaseVO
    {
        #region Campos
        private String cProdANP = "";
        private String pMixGN = "";
        private String codif = "";
        private String qTemp = "";
        private String UFCons = "";

        private CideVO cide = null;
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Código de produto da ANP
        /// Utilizar a codificação de produtos do Sistema de Informações de Movimentação de Produtos - SIMP (http://www.anp.gov.br/simp/). (NT 2012/003)
        /// </summary>
        public String CodigoProdutoANP
        {
            get { return this.cProdANP; }
            set { this.cProdANP = value; }
        }

        /// <summary>
        /// Percentual de Gás Natural para o produto GLP (cProdANP=210203001)
        /// Caso não haja mistura o campo de percentual não deve ser informado
        /// Formato 3v4 
        /// </summary>
        public String PercentualGasNaturalGLP
        {
            get { return this.pMixGN; }
            set { this.pMixGN = value; }
        }

        /// <summary>
        /// Código de autorização / registro do CODIF
        /// Informar apenas quando a UF utilizar o CODIF (Sistema de Controle do Diferimento do Imposto nas Operações com AEAC - Álcool Etílico Anidro Combustível)
        /// Tamanho 1-21
        /// </summary>
        public String CODIF
        {
            get { return this.codif; }
            set { this.codif = value; }
        }

        /// <summary>
        /// Quantidade de combustível faturada à temperatura ambiente.
        /// Informar quando a quantidade faturada informada no campo "prod/qCom" (id:I10) tiver sido ajustada para uma temperatura diferente da ambiente.
        /// Formato 12v4
        /// </summary>
        public String QuantidadeTemperaturaAmbiente
        {
            get { return this.qTemp; }
            set { this.qTemp = value; }
        }

        /// <summary>
        /// Sigla da UF de consumo
        /// Informar a UF de consumo. Informar "EX" para Exterior.
        /// </summary>
        public String UFConsumo
        {
            get { return this.UFCons; }
            set { this.UFCons = value; }
        }

        /// <summary>
        /// Informações da CIDE
        /// </summary>
        public CideVO CIDE
        {
            get { return this.cide; }
            set { this.cide = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(CombustivelXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return CombustivelXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return CombustivelXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
