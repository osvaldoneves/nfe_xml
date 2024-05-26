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
    public class ICMSVO  : BaseVO
    {
        #region Campos
        private ICMSxxVO icms = null;
        private ICMSxxVO icmsPart = null;
        private ICMSxxVO icmsST = null;
        private String cnpj = "";
        #endregion Campos


        #region Propriedades
        public ICMSxxVO ICMS
        {
            get { return this.icms; }
            set { this.icms = value; }
        }

        public ICMSxxVO ICMSPart
        {
            get { return this.icmsPart; }
            set { this.icmsPart = value; }
        }

        public ICMSxxVO ICMSST
        {
            get { return this.icmsST; }
            set { this.icmsST = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(ICMSXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return ICMSXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return ICMSXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
