using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.Base;
using OLNG.Bibliotecas.NFeLib.XML.COFINS;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public enum TipoCOFINS : int { Nenhum, COFINSAliq, COFINSQtde, COFINSNT, COFINSOutr };

    public class COFINSxxVO : BaseVO
    {
        public COFINSxxVO()
        {            
        }

        public COFINSxxVO(String CST)
        {
            this.cst = CST;
        }

        #region Campos
        private String cst = "";
        private String qBCProd = "";
        private String vAliqProd = "";
        private String vCOFINS = "";
        private String vBC = "";
        private String pCOFINS = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// 01=Operação Tributável (base de cálculo = valor da operação alíquota normal (cumulativo/não cumulativo)); 
        /// <para/>02=Operação Tributável (base de cálculo = valor da operação (alíquota diferenciada));  
        /// <para/>03=Operação Tributável (base de cálculo = quantidade vendida x alíquota por unidade de produto); 
        /// <para/>04=Operação Tributável (tributação monofásica (alíquota zero)); 
        /// <para/>05=Operação Tributável (Substituição Tributária); 
        /// <para/>06=Operação Tributável (alíquota zero); 
        /// <para/>07=Operação Isenta da Contribuição; 
        /// <para/>08=Operação Sem Incidência da Contribuição; 
        /// <para/>09=Operação com Suspensão da Contribuição;
        /// <para/>49=Outras Operações de Saída; 
        /// <para/>50=Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno; 
        /// <para/>51=Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno; 
        /// <para/>52=Operação com Direito a Crédito – Vinculada Exclusivamente a Receita de Exportação; 
        /// <para/>53=Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno; 
        /// <para/>54=Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação; 
        /// <para/>55=Operação com Direito a Crédito - Vinculada a Receitas NãoTributadas no Mercado Interno e de Exportação; 
        /// <para/>56=Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação; 
        /// <para/>60=Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno; 
        /// <para/>61=Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno; 
        /// <para/>62=Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação;
        /// <para/>63=Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno; 
        /// <para/>64=Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação; 
        /// <para/>65=Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação; 
        /// <para/>66=Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação; 
        /// <para/>67=Crédito Presumido - Outras Operações; 
        /// <para/>70=Operação de Aquisição sem Direito a Crédito; 
        /// <para/>71=Operação de Aquisição com Isenção; 
        /// <para/>72=Operação de Aquisição com Suspensão; 
        /// <para/>73=Operação de Aquisição a Alíquota Zero; 
        /// <para/>74=Operação de Aquisição; sem Incidência da Contribuição; 
        /// <para/>75=Operação de Aquisição por Substituição Tributária; 
        /// <para/>98=Outras Operações de Entrada; 
        /// <para/>99=Outras Operações; 
        /// </summary>
        public String CST
        {
            get { return this.cst; }
            set { this.cst = value; }
        }


        /// <summary>
        /// Quantidade Vendida.
        /// <para/>Informar se o cálculo do COFINS for em valor. 
        /// <para/>Campo: qBCProd.
        /// <para/>Formato 12v0-4
        /// </summary>
        public String QuantidadeVendida
        {
            get { return this.qBCProd; }
            set { this.qBCProd = value; }
        }

        /// <summary>
        /// Alíquota do COFINS (em reais).
        /// <para/>Informar se o cálculo do COFINS for em valor.
        /// <para/>Campo: vAliqProd.
        /// <para/>Formato 11v0-4. 
        /// </summary>
        public String ValorAliquotaCOFINS
        {
            get { return this.vAliqProd; }
            set { this.vAliqProd = value; }
        }

        /// <summary>
        /// Valor do COFINS.
        /// <para/>Campo: vCOFINS
        /// <para/>Formato: 13v2
        /// </summary>
        public String ValorCOFINS
        {
            get { return this.vCOFINS; }
            set { this.vCOFINS = value; }
        }

        /// <summary>
        /// Valor da BC do COFINS.
        /// <para/>Informar se o cálculo do COFINS em percentual.
        /// <para/>Campo: vBC.
        /// <para/>Formato 13v2
        /// </summary>
        public String ValorBaseCalculoCOFINS
        {
            get { return this.vBC; }
            set { this.vBC = value; }
        }

        /// <summary>
        /// Alíquota do COFINS (em percentual).
        /// <para/>Informar os campos Q07 e Q08 se o cálculo do COFINS em percentual.
        /// <para/>Campo: pCOFINS.
        /// <para/>Formato 3v2-4.
        /// </summary>
        public String AliquotaCOFINS
        {
            get { return this.pCOFINS; }
            set { this.pCOFINS = value; }
        }

        public TipoCOFINS TipoCOFINS
        {
            get {
                switch (this.CST)
                {
                    case "01":
                    case "02":
                        return TipoCOFINS.COFINSAliq;
                    case "03":
                        return TipoCOFINS.COFINSQtde;
                    case "04":
                    case "05":
                    case "06":
                    case "07":
                    case "08":
                    case "09":
                        return TipoCOFINS.COFINSNT;
                    case "49":
                    case "50":
                    case "51":
                    case "52":
                    case "53":
                    case "54":
                    case "55":
                    case "56":
                    case "60":
                    case "61":
                    case "62":
                    case "63":
                    case "64":
                    case "65":
                    case "66":
                    case "70":
                    case "71":
                    case "72":
                    case "73":
                    case "74":
                    case "75":
                    case "98":
                    case "99":
                        return TipoCOFINS.COFINSOutr;
                    default:
                        throw new Exception("CST do COFINS desconhecido.");
                }
            }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(FabricaCOFINS.ObterGrupo(this.TipoCOFINS).CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return FabricaCOFINS.ObterGrupo(this.TipoCOFINS).CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return FabricaCOFINS.ObterGrupo(this.TipoCOFINS).CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
