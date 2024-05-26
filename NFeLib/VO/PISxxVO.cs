using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.Base;
using OLNG.Bibliotecas.NFeLib.XML.PIS;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public enum TipoPIS : int { PISAliq, PISQtde, PISNT, PISOutr };

    public class PISxxVO : BaseVO
    {
        public PISxxVO(String CST)
        {
            this.cst = CST;
        }

        #region Campos
        private String cst = "";
        private String qBCProd = "";
        private String vAliqProd = "";
        private String vPIS = "";
        private String vBC = "";
        private String pPIS = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// 01=Operação Tributável (base de cálculo = valor da operação alíquota normal (cumulativo/não cumulativo)); 
        /// 02=Operação Tributável (base de cálculo = valor da operação (alíquota diferenciada));  
        /// 03=Operação Tributável (base de cálculo = quantidade vendida x alíquota por unidade de produto); 
        /// 04=Operação Tributável (tributação monofásica (alíquota zero)); 
        /// 05=Operação Tributável (Substituição Tributária); 
        /// 06=Operação Tributável (alíquota zero); 
        /// 07=Operação Isenta da Contribuição; 
        /// 08=Operação Sem Incidência da Contribuição; 
        /// 09=Operação com Suspensão da Contribuição;
        /// 49=Outras Operações de Saída; 
        /// 50=Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno; 
        /// 51=Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno; 
        /// 52=Operação com Direito a Crédito – Vinculada Exclusivamente a Receita de Exportação; 
        /// 53=Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno; 
        /// 54=Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação; 
        /// 55=Operação com Direito a Crédito - Vinculada a Receitas NãoTributadas no Mercado Interno e de Exportação; 
        /// 56=Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação; 
        /// 60=Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno; 
        /// 61=Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno; 
        /// 62=Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação;
        /// 63=Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno; 
        /// 64=Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação; 
        /// 65=Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação; 
        /// 66=Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação; 
        /// 67=Crédito Presumido - Outras Operações; 
        /// 70=Operação de Aquisição sem Direito a Crédito; 
        /// 71=Operação de Aquisição com Isenção; 
        /// 72=Operação de Aquisição com Suspensão; 
        /// 73=Operação de Aquisição a Alíquota Zero; 
        /// 74=Operação de Aquisição; sem Incidência da Contribuição; 
        /// 75=Operação de Aquisição por Substituição Tributária; 
        /// 98=Outras Operações de Entrada; 
        /// 99=Outras Operações; 
        /// </summary>
        public String CST
        {
            get { return this.cst; }
            set { this.cst = value; }
        }


        /// <summary>
        /// Quantidade Vendida
        /// Informar se o cálculo do PIS for em valor. 
        /// Formato 12v0-4
        /// </summary>
        public String QuantidadeVendida
        {
            get { return this.qBCProd; }
            set { this.qBCProd = value; }
        }

        /// <summary>
        /// Alíquota do PIS (em reais)
        /// Informar se o cálculo do PIS for em valor
        /// Formato 11v0-4 
        /// </summary>
        public String ValorAliquotaPIS
        {
            get { return this.vAliqProd; }
            set { this.vAliqProd = value; }
        }

        /// <summary>
        /// Valor do PIS
        /// 13v2
        /// </summary>
        public String ValorPIS
        {
            get { return this.vPIS; }
            set { this.vPIS = value; }
        }

        /// <summary>
        /// Valor da BC do IPI
        /// Informar se o cálculo do PIS em percentual
        /// Formato 13v2
        /// </summary>
        public String ValorBCIPI
        {
            get { return this.vBC; }
            set { this.vBC = value; }
        }

        /// <summary>
        /// Alíquota do PIS (em percentual)
        /// Informar os campos Q07 e Q08 se o cálculo do PIS em percentual
        /// Formato 3v2-4
        /// </summary>
        public String AliquotaPIS
        {
            get { return this.pPIS; }
            set { this.pPIS = value; }
        }

        public TipoPIS TipoPIS
        {
            get {
                switch (this.CST)
                {
                    case "01":
                    case "02":
                        return TipoPIS.PISAliq;
                    case "03":
                        return TipoPIS.PISQtde;
                    case "04":
                    case "05":
                    case "06":
                    case "07":
                    case "08":
                    case "09":
                        return TipoPIS.PISNT;
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
                        return TipoPIS.PISOutr;
                    default:
                        throw new Exception("CST do PIS desconhecido.");
                }
            }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            switch (this.TipoPIS)
            {
                case TipoPIS.PISQtde:
                    return new List<string>(PISQtdeXML.grupo.CamposNo.Keys);
                case TipoPIS.PISAliq:
                    return new List<string>(PISAliqXML.grupo.CamposNo.Keys);
                case TipoPIS.PISNT:
                    return new List<string>(PISNaoTributadoXML.grupo.CamposNo.Keys);
                case TipoPIS.PISOutr:
                    return new List<string>(PISOutrXML.grupo.CamposNo.Keys);
                default:
                    throw new Exception("Tipo de PIS desconhecinho.");
            }
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            switch (this.TipoPIS)
            {
                case TipoPIS.PISQtde:
                    return PISQtdeXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
                case TipoPIS.PISAliq:
                    return PISAliqXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
                case TipoPIS.PISNT:
                    return PISNaoTributadoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
                case TipoPIS.PISOutr:
                    return PISOutrXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
                default:
                    throw new Exception("Tipo de PIS desconhecinho.");
            }
            
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            switch (this.TipoPIS)
            {
                case TipoPIS.PISQtde:
                    return PISQtdeXML.grupo.CamposNo[nomeCampo].TipoDado;
                case TipoPIS.PISAliq:
                    return PISAliqXML.grupo.CamposNo[nomeCampo].TipoDado;
                case TipoPIS.PISNT:
                    return PISNaoTributadoXML.grupo.CamposNo[nomeCampo].TipoDado;
                case TipoPIS.PISOutr:
                    return PISOutrXML.grupo.CamposNo[nomeCampo].TipoDado;
                default:
                    throw new Exception("Tipo de PIS desconhecinho.");
            }
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
