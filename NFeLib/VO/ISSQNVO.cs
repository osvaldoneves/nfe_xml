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
    public class ISSQNVO  : BaseVO
    {
        #region Campos
        private String vBC = "";
        private String vAliq = "";
        private String vISSQN = "";
        private String cMunFG = "";
        private String cListServ = "";
        private String vDeducao = "";
        private String vOutro = "";
        private String vDescIncond = "";
        private String vDescCond = "";
        private String vISSRet = "";
        private String indISS = "";
        private String cServico = "";
        private String cMun = "";
        private String cPais = "";
        private String nProcesso = "";
        private String indIncentivo = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Valor da Base de Cálculo do ISSQN 
        /// Formato: 13v2
        /// </summary>
        public String ValorBaseCalculoISSQN
        {
            get { return this.vBC; }
            set { this.vBC = value; }
        }

        /// <summary>
        /// Alíquota do ISSQN
        /// Formato: 3v2-4
        /// </summary>
        public String AliquotaISSQN
        {
            get { return this.vAliq; }
            set { this.vAliq = value; }
        }

        /// <summary>
        /// Valor do ISSQN
        /// Formato: 13v2
        /// </summary>
        public String ValorISSQN
        {
            get { return this.vISSQN; }
            set { this.vISSQN = value; }
        }

        /// <summary>
        /// Código do município de ocorrência do fato gerador do ISSQN
        /// Informar o município de ocorrência do fato gerador do ISSQN.Utilizar a Tabela do IBGE(Anexo IX - Tabela de UF, Município e País). 
        /// Nota 1: Não vincular com o município do fato gerador de ICMS(id:B12), ou com o município do emitente(id:C10) ou do destinatário(id:E10). 
        /// Nota 2: Pode ser informado 9999999 se a prestação de serviço for no Exterior.
        /// </summary>
        public String CodigoMunicipioFatoGerador
        {
            get { return this.cMunFG; }
            set { this.cMunFG = value; }
        }

        /// <summary>
        /// Item da Lista de Serviços
        /// Informar o Item da lista de serviços em que se classifica o serviço no padrão ABRASF (Formato: NN.NN).
        /// </summary>
        public String ItemListaServicos
        {
            get { return this.cListServ; }
            set { this.cListServ = value; }
        }

        /// <summary>
        /// Valor dedução para redução da Base de Cálculo
        /// Formato: 13v2
        /// </summary>
        public String ValorDeducao
        {
            get { return this.vDeducao; }
            set { this.vDeducao = value; }
        }

        /// <summary>
        /// Valor outras retenções
        /// Valor declaratório 
        /// Formato: 13v2
        /// </summary>
        public String ValorOutrasRetencoes
        {
            get { return this.vOutro; }
            set { this.vOutro = value; }
        }

        /// <summary>
        /// Valor desconto incondicionado
        /// Formato: 13v2
        /// </summary>
        public String ValorDescontoIncondicionado
        {
            get { return this.vDescIncond; }
            set { this.vDescIncond = value; }
        }

        /// <summary>
        /// Valor desconto condicionado
        /// Formato: 13v2
        /// </summary>
        public String ValorDescontoCondicionado
        {
            get { return this.vDescCond; }
            set { this.vDescCond = value; }
        }

        /// <summary>
        /// Valor retenção ISS
        /// Valor declaratório
        /// Formato: 13v2
        /// </summary>
        public String ValorRetençãoISS
        {
            get { return this.vISSRet; }
            set { this.vISSRet = value; }
        }

        /// <summary>
        /// Indicador da exigibilidade do ISS
        /// 1=Exigível 
        /// 2=Não incidência 
        /// 3=Isenção 
        /// 4=Exportação 
        /// 5=Imunidade 
        /// 6=Exigibilidade Suspensa por Decisão Judicial 
        /// 7=Exigibilidade Suspensa por Processo Administrativo
        /// </summary>
        public String IndicadorExigibilidadeISS
        {
            get { return this.indISS; }
            set { this.indISS = value; }
        }

        /// <summary>
        /// Código do serviço prestado dentro do município.
        /// </summary>
        public String CodigoServico
        {
            get { return this.cServico; }
            set { this.cServico = value; }
        }

        /// <summary>
        /// Código do Município de incidência do imposto.
        /// Tabela do IBGE. Informar "9999999" para serviço fora do País.
        /// </summary>
        public String CodigoMunicipio
        {
            get { return this.cMun; }
            set { this.cMun = value; }
        }

        /// <summary>
        /// Código do País onde o serviço foi prestado. 
        /// Tabela do BACEN. Informar somente se o município da prestação do serviço for "9999999".
        /// </summary>
        public String CodigoPais
        {
            get { return this.cPais; }
            set { this.cPais = value; }
        }

        /// <summary>
        /// Número do processo judicial ou administrativo de suspensão da exigibilidade
        /// Informar somente quando declarada a suspensão da exigibilidade do ISSQN.
        /// </summary>
        public String NumeroProcesso
        {
            get { return this.nProcesso; }
            set { this.nProcesso = value; }
        }

        /// <summary>
        /// Indicador de incentivo Fiscal 
        /// 1=Sim; 2=Não; 
        /// </summary>
        public String IndicadorIncentivoFiscal
        {
            get { return this.indIncentivo; }
            set { this.indIncentivo = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(ISSQNXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return ISSQNXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return ISSQNXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
