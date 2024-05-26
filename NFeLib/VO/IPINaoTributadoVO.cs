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
    public class IPINaoTributadoVO  : BaseVO
    {
        #region Campos
        private String cst = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Código da situação tributária do IPI.
        /// 01=Entrada tributada com alíquota zero 
        /// 02=Entrada isenta 
        /// 03=Entrada não-tributada 
        /// 04=Entrada imune 
        /// 05=Entrada com suspensão 
        /// 51=Saída tributada com alíquota zero 
        /// 52=Saída isenta 
        /// 53=Saída não-tributada 
        /// 54=Saída imune 
        /// 55=Saída com suspensão 
        /// </summary>
        public String CST
        {
            get { return this.cst; }
            set { this.cst = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(IPINaoTributadoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return IPINaoTributadoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return IPINaoTributadoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
