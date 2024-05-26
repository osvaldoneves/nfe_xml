using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.Base;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public class IdentificacaoVO : BaseVO
    {
        #region Campos
        #region ide
        private String cUF = "";      // Configo da UF (2)
        private String cNF = "";        // Codigo numérico que compõe a chave de acesso da nota (8)
        private String natOp = ""; // Natureza da Operação (venda, compra, tranferência, devolução, consignação, remessa) (1-60)
        private String indPag = "";    // Indicador da forma de pagamento (0-à vista; 1-à prazo; 2-outros)
        private String mod = "";      // Modelo da nota fiscal (55-nfe; 65-nfce)
        private String serie = "";      // Série do Documento Fiscal (3)
        private String nNF = "";        // Numero da Nota Fiscal (incremental)
        private String dhEmi = "";      // Data e hora de emissão do Documento Fiscal (AAAA-MM-DDThh:mm:ssTZD)
        private String dhSaiEnt = "";   // [Não informar este campo para a NFC-e] Data e hora de Saída ou da Entrada da Mercadoria/Produto (AAAA-MM-DDThh:mm:ssTZD) 
        private String tpNF = "";      // Tipo Operação 
        private String idDest = "";     // Identificador de local de destino da operação (1-Operação interna ; 2-Operação interestadual ; 3-Operação com exterior)
        private String cMunFG = "";     // Código do Municírpio de Ocorrencia do Fator Gerador
        private String tpImp = "";      // Formato de Impressão do DANFE
        private String tpEmis = "";     // Tipo de Emissão da NF-e
        private String cDV = "";        // Dígito Verificador da Chave de Acesso da NF-e
        private String tpAmb = "";      // Tipo de Ambiente (1=Produção ; 2=Homologação)
        private String finNFe = "";     // Finalidade de emissão da NF-e (1=NF-e normal; 2=NF-e complementar; 3=NF-e de ajuste; 4=Devolução de mercadoria)
        private String indFinal = "";   // Indica operação com Consumidor final (0=Normal; 1=Consumidor final)
        private String indPres = "";    // Indicador de presença do comprador no estabelecimento comercial no momento da operação.
        private String procEmi = "";    // Processo de emissão da NF-e (0=Emissão de NF-e com aplicativo do contribuinte; 1=Emissão de NF-e avulsa pelo Fisco; 2=Emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site do Fisco; 3=Emissão NF-e pelo contribuinte com aplicativo fornecido pelo Fisco)
        private String verProc = "";    // Versão do Processo de emissão da NF-e
        private String dhCont = "";     // Data e Hora da entrada em contingência
        private String xJust = "";      // Justificativa da entrada em contingência

        private List<DocReferenciadoVO> NFref = null;
        #endregion ide
        #endregion Campos

        #region Propriedades
        /// <summary>
        /// Código da UF do emitente do Documento Fiscal.
        /// tag: cUF
        /// </summary>
        public String CodigoUF
        {
            get { return this.cUF; }
            set { this.cUF = value; }
        }

        /// <summary>
        /// Código Numérico que compõe a Chave de Acesso.
        /// tag: cNF
        /// </summary>
        public String CodigoNF
        {
            get { return this.cNF; }
            set { this.cNF = value; }
        }

        /// <summary>
        /// Descrição da Natureza da Operação.
        /// tag: natOp
        /// </summary>
        public String NaturezaOperacao
        {
            get { return this.natOp; }
            set { this.natOp = value; }
        }

        /// <summary>
        /// Indicador da forma de pagamento.
        /// tag: indPag
        /// </summary>
        public String IndicadorPagamento
        {
            get { return this.indPag; }
            set { this.indPag = value; }
        }

        /// <summary>
        /// Código do Modelo do Documento Fiscal.
        /// tag: mod
        /// </summary>
        public String ModeloNF
        {
            get { return this.mod; }
            set { this.mod = value; }
        }

        /// <summary>
        /// Série do Documento Fiscal.
        /// tag: serie
        /// </summary>
        public String Serie
        {
            get { return this.serie; }
            set { this.serie = value; }
        }

        /// <summary>
        /// Número do Documento Fiscal.
        /// tag: nNF
        /// </summary>
        public String NumeroNF
        {
            get { return this.nNF; }
            set { this.nNF = value; }
        }

        /// <summary>
        /// Data e hora de emissão do Documento Fiscal.
        /// tag: dhEmi
        /// </summary>
        public String DataHoraEmissao
        {
            get { return this.dhEmi; }
            set { this.dhEmi = value; }
        }

        /// <summary>
        /// Data e hora de Saída ou da Entrada da Mercadoria/Produto.
        /// tag: dhSaiEnt
        /// </summary>
        public String DataHoraSaidaEntrada
        {
            get { return this.dhSaiEnt; }
            set { this.dhSaiEnt = value; }
        }

        /// <summary>
        /// Tipo de Operação.
        /// tag: tpNF
        /// </summary>
        public String TipoOperacaoNF
        {
            get { return this.tpNF; }
            set { this.tpNF = value; }
        }

        /// <summary>
        /// Identificador de local de destino da operação.
        /// tag: idDest 
        /// </summary>
        public String IdentificadorDestino
        {
            get { return this.idDest; }
            set { this.idDest = value; }
        }

        /// <summary>
        /// Código do Município de Ocorrência do Fato Gerador
        /// tag: cMunFG 
        /// </summary>
        public String CodigoMunicipioFatorGerador
        {
            get { return this.cMunFG; }
            set { this.cMunFG = value; }
        }

        /// <summary>
        /// Formato de Impressão do DANFE.
        /// tag: tpImp
        /// </summary>
        public String TipoImpressaoDanfe
        {
            get { return this.tpImp; }
            set { this.tpImp = value; }
        }

        /// <summary>
        /// Tipo de Emissão da NF-e.
        /// </summary>
        public String TipoEmissao
        {
            get { return this.tpEmis; }
            set { this.tpEmis = value; }
        }

        /// <summary>
        /// Dígito Verificador da Chave de Acesso da NF-e.
        /// Informar o DV da Chave de Acesso da NF-e, o DV será calculado com a aplicação do algoritmo módulo 11 (base 2,9) da Chave de Acesso. (vide item 5 do Manual de Orientação) 
        /// </summary>
        public String DigitoVerificadorChaveAcesso
        {
            get { return this.cDV; }
            set { this.cDV = value; }
        }

        /// <summary>
        /// Identificação do Ambiente.
        /// 1=Produção;
        /// 2=Homologação;
        /// </summary>
        public String TipoAmbiente
        {
            get { return this.tpAmb; }
            set { this.tpAmb = value; }
        }

        /// <summary>
        /// Finalidade de emissão da NF-e.
        /// 1=NF-e normal; 
        /// 2=NF-e complementar; 
        /// 3=NF-e de ajuste; 
        /// 4=Devolução de mercadoria.
        /// </summary>
        public String FinalidadeEmissaoNF
        {
            get { return this.finNFe; }
            set { this.finNFe = value; }
        }

        /// <summary>
        /// Indica operação com Consumidor final.
        /// 0=Normal; 
        /// 1=Consumidor final; 
        /// </summary>
        public String IndicadorOperacaoConsumidorFinal
        {
            get { return this.indFinal; }
            set { this.indFinal = value; }
        }

        /// <summary>
        /// Indicador de presença do comprador no estabelecimento comercial no momento da operação.
        /// 0=Não se aplica(por exemplo, Nota Fiscal complementar ou de ajuste); 
        /// 1=Operação presencial; 
        /// 2=Operação não presencial, pela Internet; 
        /// 3=Operação não presencial, Teleatendimento; 
        /// 4=NFC-e em operação com entrega a domicílio; 
        /// 9=Operação não presencial, outros.
        /// </summary>
        public String IndicadorPresencaComprador
        {
            get { return this.indPres; }
            set { this.indPres = value; }
        }

        /// <summary>
        /// Processo de emissão da NF-e.
        /// 0=Emissão de NF-e com aplicativo do contribuinte; 
        /// 1=Emissão de NF-e avulsa pelo Fisco; 
        /// 2=Emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site do Fisco; 
        /// 3=Emissão NF-e pelo contribuinte com aplicativo fornecido pelo Fisco. 
        /// </summary>
        public String ProcessoEmissao
        {
            get { return this.procEmi; }
            set { this.procEmi = value; }
        }

        /// <summary>
        /// Versão do Processo de emissão da NF-e.
        /// Informar a versão do aplicativo emissor de NF-e.
        /// </summary>
        public String VersaoProcessamento
        {
            get { return this.verProc; }
            set { this.verProc = value; }
        }

        /// <summary>
        /// Data e Hora da entrada em contingência.
        /// Data e hora no formato UTC (Universal Coordinated Time): AAAA-MM-DDThh:mm:ssTZD.
        /// </summary>
        public String DataHoraEntradaContingencia
        {
            get { return this.dhCont; }
            set { this.dhCont = value; }
        }

        /// <summary>
        /// Justificativa da entrada em contingência.
        /// Tamanho: 15-256
        /// </summary>
        public String JustificativaEntradaContingencia
        {
            get { return this.xJust; }
            set { this.xJust = value; }
        }

        /// <summary>
        /// Informação de Documentos Fiscais referenciados.
        /// Ocorrência: 0-500
        /// </summary>
        public List<DocReferenciadoVO> DocsReferenciados
        {
            get { return this.NFref; }
            set { this.NFref = value; }
        }
        #endregion Propriedades

        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(IdentificacaoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return IdentificacaoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return IdentificacaoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
