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
    /// <summary>
    /// Detalhamento de Armamento
    /// Informar apenas quando se tratar de armamento, permite ocorrências.
    /// </summary>
    public class ArmamentoVO  : BaseVO
    {
        #region Campos
        private String tpArma = "";
        private String nSerie = "";
        private String nCano = "";
        private String descr = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Indicador do tipo de arma de fogo
        /// 0=Uso permitido; 1=Uso restrito;
        /// </summary>
        public String TipoArma
        {
            get { return this.tpArma; }
            set { this.tpArma = value; }
        }

        /// <summary>
        /// Número de série da arma
        /// Tamanho 1-15
        /// </summary>
        public String NumeroSerieArma
        {
            get { return this.nSerie; }
            set { this.nSerie = value; }
        }

        /// <summary>
        /// Número de série do cano
        /// Tamanho 1-15
        /// </summary>
        public String NumeroSerieCano
        {
            get { return this.nCano; }
            set { this.nCano = value; }
        }

        /// <summary>
        /// Descrição completa da arma, compreendendo: calibre, marca, capacidade, tipo de funcionamento, 
        /// comprimento e demais elementos que permitam a sua perfeita identificação.
        /// Tamanho 1-256
        /// </summary>
        public String Descricao
        {
            get { return this.descr; }
            set { this.descr = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(ArmamentoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return ArmamentoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return ArmamentoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
