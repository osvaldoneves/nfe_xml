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
    public class CompraVO  : BaseVO
    {
        #region Campos
        private String xNEmp = "";
        private String xPed = "";
        private String xCont = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Nota de Empenho
        /// Identificação da Nota de Empenho, quando se tratar de compras públicas (NT 2011/004) 
        /// Tamanho: 1-22
        /// </summary>
        public String NotaEmpenho
        {
            get { return this.xNEmp; }
            set { this.xNEmp = value; }
        }

        /// <summary>
        /// Pedido
        /// Informar o pedido. 
        /// Tamanho: 1-60
        /// </summary>
        public String Pedido
        {
            get { return this.xPed; }
            set { this.xPed = value; }
        }

        /// <summary>
        /// Contrato
        /// Informar o contrato de compra 
        /// Tamanho: 1-60
        /// </summary>
        public String Contrato
        {
            get { return this.xCont; }
            set { this.xCont = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(CompraXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return CompraXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return CompraXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
