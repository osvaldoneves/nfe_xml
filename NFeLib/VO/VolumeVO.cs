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
    public class VolumeVO  : BaseVO
    {
        #region Campos
        private String qVol = "";
        private String esp = "";
        private String marca = "";
        private String nVol = "";
        private String pesoL = "";
        private String pesoB = "";
        private List<LacreVO> lacre = null;
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Quantidade de volumes transportados 
        /// </summary>
        public String QuantidadeVolumes
        {
            get { return this.qVol; }
            set { this.qVol = value; }
        }

        /// <summary>
        /// Espécie dos volumes transportados
        /// Tamanho: 1-60
        /// </summary>
        public String EspecieVolumes
        {
            get { return this.esp; }
            set { this.esp = value; }
        }

        /// <summary>
        /// Marca dos volumes transportados
        /// Tamanho: 1-60
        /// </summary>
        public String Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        /// <summary>
        /// Numeração dos volumes transportados
        /// Tamanho: 1-60
        /// </summary>
        public String NumeracaoVolumes
        {
            get { return this.nVol; }
            set { this.nVol = value; }
        }

        /// <summary>
        /// Peso Líquido (em kg) 
        /// Formato: 12v3
        /// </summary>
        public String PesoLiquido
        {
            get { return this.pesoL; }
            set { this.pesoL = value; }
        }

        /// <summary>
        /// Peso Bruto (em kg)
        /// Formato: 12v3
        /// </summary>
        public String PesoBruto
        {
            get { return this.pesoB; }
            set { this.pesoB = value; }
        }


        /// <summary>
        /// Grupo Lacres
        /// </summary>
        public List<LacreVO> Lacres
        {
            get { return this.lacre; }
            set { this.lacre = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(VolumeXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return VolumeXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return VolumeXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
