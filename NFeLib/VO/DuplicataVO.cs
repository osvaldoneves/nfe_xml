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
    public class DuplicataVO  : BaseVO
    {
        #region Campos
        private String nDup = "";
        private String dVenc = "";
        private String vDup = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Número da Duplicata
        /// Tamanho: 1-60
        /// </summary>
        public String NumeroDuplicata
        {
            get { return this.nDup; }
            set { this.nDup = value; }
        }

        /// <summary>
        /// Data de vencimento
        /// Formato: “AAAA-MM-DD”
        /// </summary>
        public String DataVencimento
        {
            get { return this.dVenc; }
            set { this.dVenc = value; }
        }

        /// <summary>
        /// Valor da duplicata
        /// Formato 13v2
        /// </summary>
        public String ValorDuplicata
        {
            get { return this.vDup; }
            set { this.vDup = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(DuplicataXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return DuplicataXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return DuplicataXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
