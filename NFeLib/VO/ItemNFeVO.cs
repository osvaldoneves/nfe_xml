using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    class ItemNFeVO
    {
        #region Campos

        #region nItem

        #region prod
        private String cProd = "";    // Código do produto ou serviço (60)
        private String cEAN = "";     // Global Trade Item Number (0, 8,12, 13, 14)
        private String xProd = "";    // Descrição do produto ou serviço (0-120)
        private String NCM = "";      // Código NCM com 8 dígitos ou 2 dígitos(gênero) (2, 8)
        private String EXTIPI = "";   // Código EX da TIPI (2-3)
        private String CFOP = "";     // Codigo Fiscal de Operações e Prestações (4)
        private String uCom = "";     // Unidade Comercial (1-6)
        private String qCom = "";     // Quantidade Comercial
        private String vUnCom = "";   // Valor Unitário de Comercialização
        private String vProd = "";    // Valor total Bruto dos Produtos ou Serviços
        private String cEANTrib = ""; // Global Trade Item Number (0, 8,12, 13, 14)
        private String uTrib = "";    // Unidade Tributável (1-6)
        private String qTrib = "";    // Quantidade Tributável
        private String vUnTrib = "";  // Valor Unitário de tributação
        private String vFrete = "";   // Valor do Frete
        private String vSeg = "";     // Valor Total do Seguro
        private String vDesc = "";    // Valor do Desconto
        private String vOutro = "";   // Outras despesas acessórias
        private String indTot = "";   // Indica se o valor do Item entra no valor total da NF-e (0 – o valor do item (vProd) não compõe o valor total da NF-e ; 1 – o valor do item (vProd) compõe o valor total da NF-e)
        private List<String> listNVE = null; 
        #endregion prod

        #region imposto
        private String vTotTrib = "";

        #region ICMS
        private String orig = "";     // Origem da mercadoria 
        private String CST = "";      // Tributação do ICMS (00, 10, 20, 30, 40, 41, 50, 51, 60, 70, 90, 101, 102, 103, 201, 202, 203, 300, 400, 500, 900)
        private String modBC = "";    // Modalidade de determinação da BC do ICMS (0, 1, 2, 3)
        private String vBC = "";      // Valor da BC do ICMS 
        private String pICMS = "";    // Alíquota do imposto
        private String vICMS = "";    // Valor do ICMS
        private String modBCST = "";  // Modalidade de determinação da BC do ICMS ST
        private String pMVAST = "";   // Percentual da Margem de Valor Adicionado do ICMS ST
        private String pRedBCST = ""; // Percentual de Redução de BC do ICMS ST
        private String vBCST = "";    // Valor de BC do ICMS ST
        private String pICMSST = "";  // Aliquota do imposto do ICMS ST
        private String vICMSST = "";  // Valor do ICMS ST
        private String UFST = "";     // UF para qual é devido o ICMS ST
        private String pBCop = "";    // Percentural da BC operação própria
        private String vBCSTRet = ""; // Valor da BC do ICMS Retido Anteriormente
        private String vICMSSTRet = ""; // Valor do ICMS Retido anteriormente
        private String motDesICMS = ""; // Motivo de desoneração do ICMS
        private String vBCSTDest = ""; // Valor da BC do ST da UF destino
        private String vICMSSTDest = ""; // Valor do ICMS ST da UF destino
        private String pCredSN = "";     // Alíquota aplicável para cálculo do crédito (Simples Nacional) (4)
        private String vCredICMSSN = ""; // Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC123 (Simples Nacional)
        private String CSOSN = "";       // Código de Situação da Operação –Simples Nacional (3)
        #endregion ICMS

        #region PIS

        #endregion PIS
        #endregion imposto

        #endregion nItem

        #endregion Campos
    }
}
