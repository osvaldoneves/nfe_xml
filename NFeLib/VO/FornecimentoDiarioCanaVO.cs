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
    public class FornecimentoDiarioCanaVO : BaseVO
    {
        #region Campos
        private String dia = "";
        private String qtde = "";
        private String qTotMes = "";
        private String qTotAnt = "";
        private String qTotGer = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Dia
        /// Tamanho 1-2
        /// </summary>
        public String Dia
        {
            get { return this.dia; }
            set { this.dia = value; }
        }

        /// <summary>
        /// Quantidade
        /// Quantidade em KG v2.0 
        /// </summary>
        public String Quantidade
        {
            get { return this.qtde; }
            set { this.qtde = value; }
        }

        /// <summary>
        /// Quantidade Total do Mês.
        /// Formato: 11v10
        /// </summary>
        public String QuantidadeTotalMes
        {
            get { return this.qTotMes; }
            set { this.qTotMes = value; }
        }

        /// <summary>
        /// Quantidade Total Anterior.
        /// Foramto: 11v10
        /// </summary>
        public String QuantidadeTotalAnterior
        {
            get { return this.qTotAnt; }
            set { this.qTotAnt = value; }
        }

        /// <summary>
        /// Quantidade Total Geral.
        /// Formato: 11v10
        /// </summary>
        public String QuantidadeTotalGeral
        {
            get { return this.qTotGer; }
            set { this.qTotGer = value; } }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(FornecimentoDiarioCanaXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return FornecimentoDiarioCanaXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return FornecimentoDiarioCanaXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
