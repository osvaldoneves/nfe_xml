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
    public class AdicaoVO  : BaseVO
    {
        #region Campos
        private String nAdicao = "";
        private String nSeqAdic = "";
        private String cFabricante = "";
        private String vDescDI = "";
        private String nDraw = "";
        #endregion Campos


        #region Propriedades
        public String NumeroAdicao
        {
            get { return this.nAdicao; }
            set { this.nAdicao = value; }
        }

        public String NumeroSequencialItemAdicao
        {
            get { return this.nSeqAdic; }
            set { this.nSeqAdic = value; }
        }

        public String CodigoFabricante
        {
            get { return this.cFabricante; }
            set { this.cFabricante = value; }
        }

        public String ValorDescontoItemDI
        {
            get { return this.vDescDI; }
            set { this.vDescDI = value; }
        }

        public String NumeroAtoConcessorioDrawback
        {
            get { return this.nDraw; }
            set { this.nDraw = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(AdicaoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return AdicaoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return AdicaoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
