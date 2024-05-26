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
    public class IPITributadoVO  : BaseVO
    {
        #region Campos
        private String cst = "";
        private String vBC = "";
        private String pIPI = "";
        private String qUnid = "";
        private String vUnid = "";
        private String vIPI = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Código da situação tributária do IPI.
        /// 00=Entrada com recuperação de crédito 
        /// 49=Outras entradas 
        /// 50=Saída tributada 
        /// 99=Outras saídas 
        /// </summary>
        public String CST
        {
            get { return this.cst; }
            set { this.cst = value; }
        }


        /// <summary>
        /// Valor da BC do IPI 
        /// Informar se o cálculo do IPI for por alíquota
        /// </summary>
        public String ValorBCIPI
        {
            get { return this.vBC; }
            set { this.vBC = value; }
        }

        /// <summary>
        /// Alíquota do IPI 
        /// Informar se o cálculo do IPI for por alíquota
        /// </summary>
        public String AliquotaIPI
        {
            get { return this.pIPI; }
            set { this.pIPI = value; }
        }

        /// <summary>
        /// Quantidade total na unidade padrão para tributação (somente para os produtos tributados por unidade) 
        /// Informar se o cálculo do IPI for de valor por unidade. 
        /// </summary>
        public String QuantidadeUnidade
        {
            get { return this.qUnid; }
            set { this.qUnid = value; }
        }

        /// <summary>
        /// Valor por Unidade Tributável
        /// Informar se o cálculo do IPI for de valor por unidade
        /// </summary>
        public String ValorUidadeTributavel
        {
            get { return this.vUnid; }
            set { this.vUnid = value; }
        }

        /// <summary>
        /// Valor do IPI.
        /// </summary>
        public String ValorIPI
        {
            get { return this.vIPI; }
            set { this.vIPI = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(IPITributadoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return IPITributadoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return IPITributadoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
