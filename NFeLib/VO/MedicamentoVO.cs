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
    public class MedicamentoVO  : BaseVO
    {
        #region Campos
        private String nLote = "";
        private String qLote = "";
        private String dFab = "";
        private String dVal = "";
        private String vPMC = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Número do Lote de medicamentos ou de matérias-primas farmacêuticas.
        /// Tamanho 1-20
        /// </summary>
        public String NumeroLote
        {
            get { return this.nLote; }
            set { this.nLote = value; }
        }

        /// <summary>
        /// Quantidade de produto no Lote de medicamentos ou de matérias-primas farmacêuticas
        /// Formato 8v3
        /// </summary>
        public String QuantidadeLote
        {
            get { return this.qLote; }
            set { this.qLote = value; }
        }

        /// <summary>
        /// Data de fabricação
        /// Formato: “AAAA-MM-DD”
        /// </summary>
        public String DataFabricacao
        {
            get { return this.dFab; }
            set { this.dFab = value; }
        }

        /// <summary>
        /// Data de validade
        /// Formato: “AAAA-MM-DD”
        /// </summary>
        public String DataValidade
        {
            get { return this.dVal; }
            set { this.dVal = value; }
        }

        /// <summary>
        /// Preço máximo consumidor
        /// Formato 13v2
        /// </summary>
        public String PrecoMaximoConsumidor
        {
            get { return this.vPMC; }
            set { this.vPMC = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(MedicamentoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return MedicamentoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return MedicamentoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
