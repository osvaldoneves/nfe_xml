using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public class NotaFiscalVO
    {
        #region Construtor
        #endregion Construtor

        #region Campos
        private String identificadorNF = "";
        private String versao = "";

        private IdentificacaoVO ideVO = null;
        private EmitenteVO emitVO = null;
        private DestinatarioVO destVO = null;
        private RetiradaVO retirada = null;

        #region retirada
        private String CNPJretirada = ""; //CNPJ do emitente
        private String CPFretirada = ""; //CPF do emitente
        
        #region enderRetirada
        private String xLgrRetirada = ""; //Logradouro (60)
        private String nroRetirada = ""; // Número (60)
        private String xCplRetirada = ""; //Complemento (60)
        private String xBairroRetirada = ""; //Bairro (60)
        private String cMunRetirada = ""; // Código do Município (7)
        private String xMunRetirada = ""; //Nome do Município (60)
        private String UFretirada = ""; //UF (2)
        #endregion enderRetirada

        #endregion retirada

        #region entrega
        private String CNPJentrega = ""; //CNPJ do emitente
        private String CPFentrega = ""; //CPF do emitente

        #region enderEntrega
        private String xLgrEntrega = ""; //Logradouro (60)
        private String nroEntrega = ""; // Número (60)
        private String xCplEntrega = ""; //Complemento (60)
        private String xBairroEntrega = ""; //Bairro (60)
        private String cMunEntrega = ""; // Código do Município (7)
        private String xMunEntrega = ""; //Nome do Município (60)
        private String UFentrega = ""; //UF (2)
        #endregion enderEntrega

        #endregion entrega

        List<ItemNFeVO> itens = null;
        List<AutorizacaoVO> autorizados = null;
        #endregion Campos


    }
}
