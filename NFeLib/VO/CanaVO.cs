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
    public class CanaVO  : BaseVO
    {
        #region Campos
        private String safra = "";
        private String refe = "";
        private List<FornecimentoDiarioCanaVO> forDia = null;
        private List<DeducaoVO> deduc = null;
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Identificação da safra
        /// Informar a safra, no formato: "AAAA" ou "AAAA/AAAA". v2.0
        /// Tamanho: 4-9
        /// </summary>
        public String Safra
        {
            get { return this.safra; }
            set { this.safra = value; }
        }

        /// <summary>
        /// Mês e ano de referência.
        /// Informar o mês e ano de referência, no formato: "MM/AAAA". v2.0
        /// </summary>
        public String MesAnoReferência
        {
            get { return this.refe; }
            set { this.refe = value; }
        }

        /// <summary>
        /// Grupo Fornecimento diário de cana
        /// Informar os fornecimentos diários de cana v2.0
        /// Ocorrência: 1-31
        /// </summary>
        public List<FornecimentoDiarioCanaVO> FornecimentoDiarioCana
        {
            get { return this.forDia; }
            set { this.forDia = value; }
        }

        /// <summary>
        /// Informar a Descrição da Dedução
        /// Tamanho: 0-10
        /// </summary>
        public List<DeducaoVO> Deducao
        {
            get { return this.deduc; }
            set { this.deduc = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(CanaXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return CanaXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return CanaXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
