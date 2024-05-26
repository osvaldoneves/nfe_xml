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
    public class TransporteVO  : BaseVO
    {
        #region Campos
        private String modFrete = "";
        private TransportadoraVO transporta = null;
        private RetencaoICMSTransporteVO retTransp = null;
        private VeiculoTransporteVO veicTransp = null;
        private ReboqueVO reboque = null;
        private List<VolumeVO> vol = null;
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Modalidade do frete 
        /// 0=Por conta do emitente; 
        /// 1=Por conta do destinatário/remetente; 
        /// 2=Por conta de terceiros; 
        /// 9=Sem frete. (V2.0) 
        /// </summary>
        public String ModalidadeFrete
        {
            get { return this.modFrete; }
            set { this.modFrete = value; }
        }


        /// <summary>
        /// Grupo Transportador 
        /// </summary>
        public TransportadoraVO Transportadora
        {
            get { return this.transporta; }
            set { this.transporta = value; }
        }

        /// <summary>
        /// Grupo Retenção ICMS transporte
        /// </summary>
        public RetencaoICMSTransporteVO RetencaoICMSTransporte
        {
            get { return this.retTransp; }
            set { this.retTransp = value; }
        }

        /// <summary>
        /// Grupo Veículo Transporte
        /// Informar o veículo trator (v2.0) 
        /// </summary>
        public VeiculoTransporteVO VeiculoTransporte
        {
            get { return this.veicTransp; }
            set { this.veicTransp = value; }
        }

        /// <summary>
        /// Grupo Reboque 
        /// Informar os reboques/Dolly (v2.0) 
        /// </summary>
        public ReboqueVO Reboque
        {
            get { return this.reboque; }
            set { this.reboque = value; }
        }

        /// <summary>
        /// Grupo Volumes 
        /// </summary>
        public List<VolumeVO> Volumes
        {
            get { return this.vol; }
            set { this.vol = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(AutorizacaoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return AutorizacaoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return AutorizacaoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
