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
    public class VeiculoTransporteVO  : BaseVO
    {
        #region Campos
        private String placa = "";
        private String uf = "";
        private String rntc = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Placa do Veículo
        /// Informar em um dos seguintes formatos: XXX9999, XXX999, XX9999 ou XXXX999.
        /// Informar a placa em informações complementares quando a placa do veículo tiver lei de formação diversa. (NT 2011/005)
        /// Tamanho: 7
        /// </summary>
        public String Placa
        {
            get { return this.placa; }
            set { this.placa = value; }
        }

        /// <summary>
        /// Sigla da UF
        /// Informar "EX" se Exterior
        /// Tamanho: 2
        /// </summary>
        public String UF
        {
            get { return this.uf; }
            set { this.uf = value; }
        }

        /// <summary>
        /// Registro Nacional de Transportador de Carga (ANTT)
        /// Tamanho: 1-20
        /// </summary>
        public String RNTC
        {
            get { return this.rntc; }
            set { this.rntc = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(VeiculoTransporteXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return VeiculoTransporteXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return VeiculoTransporteXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
