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
    public class CobrancaVO  : BaseVO
    {
        #region Campos
        private FaturaVO fat = null;
        private List<DuplicataVO> dup = null;
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Grupo Fatura
        /// </summary>
        public FaturaVO Fatura
        {
            get { return this.fat; }
            set { this.fat = value; }
        }

        /// <summary>
        /// Grupo Duplicata
        /// </summary>
        private List<DuplicataVO> Duplicata
        {
            get { return this.dup; }
            set { this.dup = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(CobrancaXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return CobrancaXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return CobrancaXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
