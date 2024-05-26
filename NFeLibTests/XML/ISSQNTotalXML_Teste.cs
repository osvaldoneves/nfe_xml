using Microsoft.VisualStudio.TestTools.UnitTesting;
using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.VO;
using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFeLibTeste.Xml
{
    [TestClass()]
    public class ISSQNTotalXML_Teste
    {
        [TestMethod()]
        public void ISSQNTotalXML_ObterEntidade_Teste()
        {
            try
            {
                ISSQNTotalXML xml = new ISSQNTotalXML();
                ISSQNTotalVO vo1 = new ISSQNTotalVO();


                String strXml = "<ISSQNtot><vServ>vServ</vServ><vBC>vBC</vBC><vISS>vISS</vISS><vPIS>vPIS</vPIS><vCOFINS>vCOFINS</vCOFINS><dCompet>dCompet</dCompet><vDeducao>vDeducao</vDeducao><vOutro>vOutro</vOutro><vDescIncond>vDescIncond</vDescIncond><vDescCond>vDescCond</vDescCond><vISSRet>vISSRet</vISSRet><cRegTrib>cRegTrib</cRegTrib></ISSQNtot>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ISSQNTotalXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.ValorTotalServicos.Equals(ideNode["vServ"].InnerText) &&
                                  vo1.ValorTotalBaseCalculoISS.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.ValorTotalISS.Equals(ideNode["vISS"].InnerText) &&
                                  vo1.ValorTotalPIS.Equals(ideNode["vPIS"].InnerText) &&
                                  vo1.ValorTotalCOFINS.Equals(ideNode["vCOFINS"].InnerText) &&
                                  vo1.DataPrestacaoServico.Equals(ideNode["dCompet"].InnerText) &&
                                  vo1.ValorTotalDeducaoReducaoBaseCalculo.Equals(ideNode["vDeducao"].InnerText) &&
                                  vo1.ValorTotalOutrasRetencoes.Equals(ideNode["vOutro"].InnerText) &&
                                  vo1.ValorTotalDescontoIncondicionado.Equals(ideNode["vDescIncond"].InnerText) &&
                                  vo1.ValorTotalDescontoCondicionado.Equals(ideNode["vDescCond"].InnerText) &&
                                  vo1.ValorTotalRetencaoISS.Equals(ideNode["vISSRet"].InnerText) &&
                                  vo1.CodigoRegimeEspecialTributacao.Equals(ideNode["cRegTrib"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ISSQNTotalXML_ObterElementoXML_Teste()
        {
            try
            {
                ISSQNTotalXML xml = new ISSQNTotalXML();
                ISSQNTotalVO vo1 = new ISSQNTotalVO();

                vo1.ValorTotalServicos = "vServ";
                vo1.ValorTotalBaseCalculoISS = "vBC";
                vo1.ValorTotalISS = "vISS";
                vo1.ValorTotalPIS = "vPIS";
                vo1.ValorTotalCOFINS = "vCOFINS";
                vo1.DataPrestacaoServico = "dCompet";
                vo1.ValorTotalDeducaoReducaoBaseCalculo = "vDeducao";
                vo1.ValorTotalOutrasRetencoes = "vOutro";
                vo1.ValorTotalDescontoIncondicionado = "vDescIncond";
                vo1.ValorTotalDescontoCondicionado = "vDescCond";
                vo1.ValorTotalRetencaoISS = "vISSRet";
                vo1.CodigoRegimeEspecialTributacao = "cRegTrib";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.ValorTotalServicos.Equals(ideNode["vServ"].InnerText) &&
                                  vo1.ValorTotalBaseCalculoISS.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.ValorTotalISS.Equals(ideNode["vISS"].InnerText) &&
                                  vo1.ValorTotalPIS.Equals(ideNode["vPIS"].InnerText) &&
                                  vo1.ValorTotalCOFINS.Equals(ideNode["vCOFINS"].InnerText) &&
                                  vo1.DataPrestacaoServico.Equals(ideNode["dCompet"].InnerText) &&
                                  vo1.ValorTotalDeducaoReducaoBaseCalculo.Equals(ideNode["vDeducao"].InnerText) &&
                                  vo1.ValorTotalOutrasRetencoes.Equals(ideNode["vOutro"].InnerText) &&
                                  vo1.ValorTotalDescontoIncondicionado.Equals(ideNode["vDescIncond"].InnerText) &&
                                  vo1.ValorTotalDescontoCondicionado.Equals(ideNode["vDescCond"].InnerText) &&
                                  vo1.ValorTotalRetencaoISS.Equals(ideNode["vISSRet"].InnerText) &&
                                  vo1.CodigoRegimeEspecialTributacao.Equals(ideNode["cRegTrib"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}