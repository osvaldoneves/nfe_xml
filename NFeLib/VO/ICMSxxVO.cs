using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.XML.ICMS;
using OLNG.Bibliotecas.NFeLib.Base;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public enum TipoICMS : int { ICMS00, ICMS10, ICMS20, ICMS30, ICMS40, ICMS51, ICMS60, ICMS70, ICMS90, ICMSSN101, ICMSSN102, ICMSSN201, ICMSSN202, ICMSSN500, ICMSSN900 };

    public class ICMSxxVO  : BaseVO
    {
        #region Campos
        private TipoICMS tpICMS;
        private String orig = "";
        private String cst = "";
        private String modBC = "";
        private String pRedBC = "";
        private String vBC = "";
        private String pICMS = "";
        private String vICMS = "";
        private String modBCST = "";
        private String pMVAST = "";
        private String pRedBCST = "";
        private String vBCST = "";
        private String pICMSST = "";
        private String vICMSST = "";
        private String vICMSOp = "";
        private String pDif = "";
        private String vICMSDif = "";
        private String vICMSDeson = "";
        private String motDesICMS = "";
        private String vBCSTRet = "";
        private String vICMSSTRet = "";
        private String pBCOp = "";
        private String UFST = "";
        private String vBCSTDest = "";
        private String vICMSSTDest = "";

        private String csosn = "";
        private String pCredSN = "";
        private String vCredICMSSN = "";
        #endregion Campos


        #region Construtor
        public ICMSxxVO()
        {
        }
        #endregion Construtor


        #region Propriedades
        /// <summary>
        /// Origem da mercadoria
        /// 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8; 
        /// 1 - Estrangeira - Importação direta, exceto a indicada no código 6; 
        /// 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7; 
        /// 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40% e inferior ou igual a 70%; 
        /// 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes; 
        /// 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%; 
        /// 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural; 
        /// 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural. 
        /// 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%; 167 
        /// </summary>
        public String Origem
        {
            get { return this.orig; }
            set { this.orig = value; }
        }

        /// <summary>
        /// Tributação do ICMS = 00
        /// </summary>
        public String CST
        {
            get { return this.cst; }
            set { this.cst = value; }
        }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS 
        /// 0=Margem Valor Agregado(%); 
        /// 1=Pauta(Valor); 
        /// 2=Preço Tabelado Máx. (valor); 
        /// 3=Valor da operação
        /// </summary>
        public String ModalidadeBC
        {
            get { return this.modBC; }
            set { this.modBC = value; }
        }

        /// <summary>
        /// Percentual da Redução de BC
        /// Formato 3v2-4
        /// </summary>
        public String PercentualReducaoBC
        {
            get { return this.pRedBC; }
            set { this.pRedBC = value; }
        }

        /// <summary>
        /// Valor da BC do ICMS
        /// 13v2
        /// </summary>
        public String ValorBC
        {
            get { return this.vBC; }
            set { this.vBC = value; }
        }

        /// <summary>
        /// Alíquota do imposto
        /// Formato 3v2-4
        /// </summary>
        public String AliquotaICMS
        {
            get { return this.pICMS; }
            set { this.pICMS = value; }
        }

        /// <summary>
        /// Valor do ICMS
        /// Formato 13v2
        /// </summary>
        public String ValorICMS
        {
            get { return this.vICMS; }
            set { this.vICMS = value; }
        }
        /// <summary>
        /// Modalidade de determinação da BC do ICMS ST
        /// 0=Preço tabelado ou máximo sugerido; 
        /// 1=Lista Negativa(valor); 
        /// 2=Lista Positiva(valor); 
        /// 3=Lista Neutra(valor); 
        /// 4=Margem Valor Agregado(%); 
        /// 5=Pauta(valor);
        /// </summary>
        public String ModalidadeBCST
        {
            get { return this.modBCST; }
            set { this.modBCST = value; }
        }

        /// <summary>
        /// Percentual da margem de valor Adicionado do ICMS ST
        /// Campo: pMVAST
        /// Formato 3v2-4
        /// </summary>
        public String PercentualMargemValorAdicionadoST
        {
            get { return this.pMVAST; }
            set { this.pMVAST = value; }
        }

        /// <summary>
        /// Percentual da Redução de BC do ICMS ST.
        /// Campo: pRedBCST.
        /// Formato: 3v2-4.
        /// </summary>
        public String PercentualReducaoBCST
        {
            get { return this.pRedBCST; }
            set { this.pRedBCST = value; }
        }

        /// <summary>
        /// Valor da BC do ICMS ST
        /// Formato 13v2
        /// </summary>
        public String ValorBCST
        {
            get { return this.vBCST; }
            set { this.vBCST = value; }
        }

        /// <summary>
        /// Alíquota do imposto do ICMS ST
        /// Formato 3v2-4
        /// </summary>
        public String PercentualICMSST
        {
            get { return this.pICMSST; }
            set { this.pICMSST = value; }
        }

        /// <summary>
        /// Valor do ICMS ST retido
        /// Formato 13v2
        /// </summary>
        public String ValorICMSST
        {
            get { return this.vICMSST; }
            set { this.vICMSST = value; }
        }

        /// <summary>
        /// Valor como se não tivesse o diferimento
        /// Formato 13v2
        /// </summary>
        public String ValorICMSOperacao
        {
            get { return this.vICMSOp; }
            set { this.vICMSOp = value; }
        }

        /// <summary>
        /// Percentual do diferimento
        /// Formato 3v2-4
        /// No caso de diferimento total, informar o percentual de diferimento "100".
        /// </summary>
        public String PercentualDeferimento
        {
            get { return this.pDif; }
            set { this.pDif = value; }
        }


        /// <summary>
        /// Valor do ICMS diferido
        /// Formato 13v2
        /// </summary>
        public String ValorICMSDeferido
        {
            get { return this.vICMSDif; }
            set { this.vICMSDif = value; }
        }


        /// <summary>
        /// Valor do ICMS desonerado
        /// Informar apenas nos motivos de desoneração documentados.
        /// Formato 13v2
        /// </summary>
        public String ValorICMSDesonerado
        {
            get { return this.vICMSDeson; }
            set { this.vICMSDeson = value; }
        }


        /// <summary>
        /// Motivo da desoneração do ICMS
        /// Campo será preenchido quando o campo anterior estiver preenchido. Informar o motivo da desoneração: 
        /// 1=Táxi; 
        /// 3=Produtor Agropecuário; 
        /// 4=Frotista/Locadora; 
        /// 5=Diplomático/Consular; 
        /// 6=Utilitários e Motocicletas da Amazônia Ocidental e Áreas de Livre Comércio (Resolução 714/88 e 790/94 – CONTRAN e suas alterações); 
        /// 7=SUFRAMA; 8=Venda a Órgão Público; 
        /// 9=Outros. (NT 2011/004); 
        /// 10=Deficiente Condutor (Convênio ICMS 38/12); 
        /// 11=Deficiente Não Condutor (Convênio ICMS 38/12) 
        /// 12=Órgão de fomento e desenvolvimento agropecuário
        /// </summary>
        public String MotivoDesoneracaoICMS
        {
            get { return this.motDesICMS; }
            set { this.motDesICMS = value; }
        }


        /// <summary>
        /// Valor da BC do ICMS ST retido
        /// Valor da BC do ICMS ST cobrado anteriormente por ST (v2.0). O valor pode ser omitido quando a legislação não exigir a sua informação
        /// Formato 13v2
        /// </summary>
        public String ValorBCICMSSTRetido
        {
            get { return this.vBCSTRet; }
            set { this.vBCSTRet = value; }
        }


        /// <summary>
        /// Valor do ICMS ST retido
        /// Valor do ICMS ST cobrado anteriormente por ST (v2.0). O valor pode ser omitido quando a legislação não exigir a sua informação.
        /// Formato 13v2
        /// </summary>
        public String ValorICMSSTRetido
        {
            get { return this.vICMSSTRet; }
            set { this.vICMSSTRet = value; }
        }

        /// <summary>
        /// Percentual para determinação do valor da Base de Cálculo da operação própria. 
        /// Formato 3v2-4
        /// </summary>
        public String PercentualBCOperacaoPropria
        {
            get { return this.pBCOp; }
            set { this.pBCOp = value; }
        }


        /// <summary>
        /// Sigla da UF para qual é devido o ICMS ST da operação. Informar "EX" para Exterior.
        /// </summary>
        public String UFICMSSTDevido
        {
            get { return this.UFST; }
            set { this.UFST = value; }
        }

        /// <summary>
        /// Valor da BC do ICMS ST da UF destino.
        /// Formato: 13v2
        /// </summary>
        public String ValorBCSTDestino
        {
            get { return this.vBCSTDest; }
            set { this.vBCSTDest = value; }
        }

        /// <summary>
        /// Valor do ICMS ST da UF destino 
        /// Formato: 13v2
        /// </summary>
        public String ValorICMSSTDestino
        {
            get { return this.vICMSSTDest; }
            set { this.vICMSSTDest = value; }
        }

        /// <summary>
        /// Código de Situação da Operação – Simples Nacional
        /// 101=Tributada pelo Simples Nacional com permissão de crédito. 
        /// 102=Tributada pelo Simples Nacional sem permissão de crédito. 
        /// 103=Isenção do ICMS no Simples Nacional para faixa de receita bruta. 
        /// 201=Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por Substituição Tributária.
        /// 202=Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por Substituição Tributária; 
        /// 203=Isenção do ICMS nos Simples Nacional para faixa de receita bruta e com cobrança do ICMS por Substituição Tributária 
        /// 300=Imune. 
        /// 400=Não tributada pelo Simples Nacional
        /// 500=ICMS cobrado anteriormente por substituição tributária(substituído) ou por antecipação
        /// 900=Outros
        /// </summary>
        public String CSOSN
        {
            get { return this.csosn; }
            set { this.csosn = value; }
        }

        /// <summary>
        /// Alíquota aplicável de cálculo do crédito 
        /// Formato 3v2-4 
        /// </summary>
        public String AliquotaCredito
        {
            get { return this.pCredSN; }
            set { this.pCredSN = value; }
        }

        /// <summary>
        /// Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC 123
        /// Formato 13v2
        /// </summary>
        public String ValorCreditoICMS
        {
            get { return this.vCredICMSSN; }
            set { this.vCredICMSSN = value; }
        }

        public TipoICMS TipoICMS
        {
            get
            {
                if (this.CST == "" && this.CSOSN != "")
                {
                    switch (this.CSOSN)
                    {
                        case "101":
                            return TipoICMS.ICMSSN101;
                        case "102":
                        case "103":
                        case "300":
                        case "400":
                            return TipoICMS.ICMSSN102;
                        case "201":
                            return TipoICMS.ICMSSN201;
                        case "202":
                        case "203":
                            return TipoICMS.ICMSSN202;
                        case "500":
                            return TipoICMS.ICMSSN500;
                        case "900":
                            return TipoICMS.ICMSSN900;
                        default:
                            throw new Exception("Tipo ICMS inválido.");
                    }
                }
                else if (this.CST != "" && this.CSOSN == "")
                {
                    switch (this.CST)
                    {
                        case "00":
                            return TipoICMS.ICMS00;
                        case "10":
                            return TipoICMS.ICMS10;
                        case "20":
                            return TipoICMS.ICMS20;
                        case "30":
                            return TipoICMS.ICMS30;
                        case "40":
                        case "41":
                        case "50":
                            return TipoICMS.ICMS40;
                        case "51":
                            return TipoICMS.ICMS51;
                        case "60":
                            return TipoICMS.ICMS60;
                        case "70":
                            return TipoICMS.ICMS70;
                        case "90":
                            return TipoICMS.ICMS90;
                        default:
                            throw new Exception("Tipo ICMS inválido.");
                    }
                }
                else
                {
                    throw new Exception("Tipo ICMS inválido.");
                }
            }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(FabricaICMS.ObterGrupo(this.TipoICMS).CamposNo.Keys);            
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return FabricaICMS.ObterGrupo(this.TipoICMS).CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return FabricaICMS.ObterGrupo(this.TipoICMS).CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
