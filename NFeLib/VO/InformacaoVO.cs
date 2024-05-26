using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.Base;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public class InformacaoVO : BaseVO
    {
        #region Campos
        private String versao = ""; 
        private String Id = "";
        private IdentificacaoVO ide = null;
        private EmitenteVO emit = null;
        private DestinatarioVO dest = null;
        private RetiradaVO retirada = null;
        private EntregaVO entrega = null;
        private AutorizacaoVO autXML = null;
        private List<DetalhamentoVO> det = null;
        private TotalVO total = null;
        private TransporteVO transp = null;
        private CobrancaVO cobr = null;
        private List<FormaPagamentoVO> pag = null;
        private InfoAdicionalVO infoAdic = null;
        private ComercioExteriorVO exporta = null;
        private CompraVO compra = null;
        private CanaVO cana = null;
        #endregion Campos

        #region Propriedades
        /// <summary>
        /// Versão do leiaute
        /// </summary>
        public String Versao
        {
            get { return this.versao; }
            set { this.versao = value; }
        }

        /// <summary>
        /// Identificador da TAG a ser assinada.
        /// Informar a Chave de Acesso precedida do literal ‘NFe’
        /// </summary>
        public String ID
        {
            get { return this.Id; }
            set { this.Id = value; }
        }

        /// <summary>
        /// Informações de identificação da NF-e 
        /// </summary>
        public IdentificacaoVO Identificacao
        {
            get { return this.ide; }
            set { this.ide = value; }
        }


        /// <summary>
        /// Identificação do emitente da NF-e 
        /// </summary>
        public EmitenteVO Emitente
        {
            get { return this.emit; }
            set { this.emit = value; }
        }

        /// <summary>
        /// Identificação do Destinatário da NF-e
        /// Grupo obrigatório para a NF-e (modelo 55) 
        /// </summary>
        public DestinatarioVO Destinatario
        {
            get { return this.dest; }
            set { this.dest = value; }
        }

        /// <summary>
        /// Identificação do Local de retirada.
        /// Informar somente se diferente do endereço do remetente.
        /// </summary>
        public RetiradaVO Retirada
        {
            get { return this.retirada; }
            set { this.retirada = value; }
        }

        /// <summary>
        /// Identificação do Local de entrega.
        /// Informar somente se diferente do endereço destinatário.
        /// </summary>
        public EntregaVO Entrega
        {
            get { return this.entrega; }
            set { this.entrega = value; }
        }

        /// <summary>
        /// Pessoas autorizadas a acessar o XML da NF-e
        /// </summary>
        public AutorizacaoVO Autorizacao
        {
            get { return this.autXML; }
            set { this.autXML = value; }
        }

        /// <summary>
        /// Detalhamento de Produtos e Serviços.
        /// Múltiplas ocorrências (máximo = 990).
        /// </summary>
        public List<DetalhamentoVO> Detalhamentos
        {
            get { return this.det; }
            set { this.det = value; }
        }

        /// <summary>
        /// O grupo de valores totais da NF-e deve ser informado com o somatório do campo correspondente dos itens
        /// </summary>
        public TotalVO Total
        {
            get { return this.total; }
            set { this.total = value; }
        }

        /// <summary>
        /// Grupo Informações do Transporte 
        /// </summary>
        public TransporteVO Transporte
        {
            get { return this.transp; }
            set { this.transp = value; }
        }

        /// <summary>
        /// Grupo Cobrança
        /// </summary>
        public CobrancaVO Cobranca
        {
            get { return this.cobr; }
            set { this.cobr = value; }
        }

        /// <summary>
        /// Grupo de Formas de Pagamento
        /// Grupo obrigatório para a NFC-e, a critério da UF. Não informar para a NF-e.
        /// </summary>
        public List<FormaPagamentoVO> FormaPagamento
        {
            get { return this.pag; }
            set { this.pag = value; }
        }

        /// <summary>
        /// Grupo de Informações Adicionais
        /// </summary>
        public InfoAdicionalVO InformacaoAdicional
        {
            get { return this.infoAdic; }
            set { this.infoAdic = value; }
        }

        /// <summary>
        /// Grupo Exportação
        /// Informar apenas na exportação.
        /// </summary>
        public ComercioExteriorVO Exportacao
        {
            get { return this.exporta; }
            set { this.exporta = value; }
        }

        /// <summary>
        /// Informação adicional de compra
        /// Ocorrência: 0-1
        /// </summary>
        public CompraVO Compra
        {
            get { return this.compra; }
            set { this.compra = value; }
        }

        /// <summary>
        /// Grupo Cana
        /// Ocorrência: 0-1
        /// </summary>
        public CanaVO Cana
        {
            get { return this.cana; }
            set { this.cana = value; }
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
