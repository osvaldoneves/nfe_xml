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
    public class ICMSTotalXML_Teste
    {
        [TestMethod()]
        public void ICMSTotalXML_ObterEntidade_Teste()
        {
            try
            {
                ICMSTotalXML xml = new ICMSTotalXML();
                ICMSTotalVO vo1 = new ICMSTotalVO();


                String strXml = "<ICMSTot><vBC>vBC</vBC><vICMS>vICMS</vICMS><vICMSDeson>vICMSDeson</vICMSDeson><vBCST>vBCST</vBCST><vST>vST</vST><vProd>vProd</vProd><vFrete>vFrete</vFrete><vSeg>vSeg</vSeg><vDesc>vDesc</vDesc><vII>vII</vII><vIPI>vIPI</vIPI><vPIS>vPIS</vPIS><vCOFINS>vCOFINS</vCOFINS><vOutro>vOutro</vOutro><vNF>vNF</vNF><vTotTrib>vTotTrib</vTotTrib></ICMSTot>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ICMSTotalXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.ValorBaseCalculoICMS.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.ValorTotalICMS.Equals(ideNode["vICMS"].InnerText) &&
                                  vo1.ValorTotalICMSDesonerado.Equals(ideNode["vICMSDeson"].InnerText) &&
                                  vo1.BaseCalculoICMSST.Equals(ideNode["vBCST"].InnerText) &&
                                  vo1.ValorTotalICMSST.Equals(ideNode["vST"].InnerText) &&
                                  vo1.ValorTotalProdutosServicos.Equals(ideNode["vProd"].InnerText) &&
                                  vo1.ValorTotalFrete.Equals(ideNode["vFrete"].InnerText) &&
                                  vo1.ValorTotalSeguro.Equals(ideNode["vSeg"].InnerText) &&
                                  vo1.ValorTotalDesconto.Equals(ideNode["vDesc"].InnerText) &&
                                  vo1.ValorTotalImpostoImportacao.Equals(ideNode["vII"].InnerText) &&
                                  vo1.ValorTotalIPI.Equals(ideNode["vIPI"].InnerText) &&
                                  vo1.ValorTotalPIS.Equals(ideNode["vPIS"].InnerText) &&
                                  vo1.ValorTotalCOFINS.Equals(ideNode["vCOFINS"].InnerText) &&
                                  vo1.OutrasDespesas.Equals(ideNode["vOutro"].InnerText) &&
                                  vo1.ValorTotalNF.Equals(ideNode["vNF"].InnerText) &&
                                  vo1.ValorTotalTributos.Equals(ideNode["vTotTrib"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMSTotalXML_ObterElementoXML_Teste()
        {
            try
            {
                ICMSTotalXML xml = new ICMSTotalXML();
                ICMSTotalVO vo1 = new ICMSTotalVO();

                vo1.ValorBaseCalculoICMS = "vBC";
                vo1.ValorTotalICMS = "vICMS";
                vo1.ValorTotalICMSDesonerado = "vICMSDeson";
                vo1.BaseCalculoICMSST = "vBCST";
                vo1.ValorTotalICMSST = "vST";
                vo1.ValorTotalProdutosServicos = "vProd";
                vo1.ValorTotalFrete = "vFrete";
                vo1.ValorTotalSeguro = "vSeg";
                vo1.ValorTotalDesconto = "vDesc";
                vo1.ValorTotalImpostoImportacao = "vII";
                vo1.ValorTotalIPI = "vIPI";
                vo1.ValorTotalPIS = "vPIS";
                vo1.ValorTotalCOFINS = "vCOFINS";
                vo1.OutrasDespesas = "vOutro";
                vo1.ValorTotalNF = "vNF";
                vo1.ValorTotalTributos = "vTotTrib";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.ValorBaseCalculoICMS.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.ValorTotalICMS.Equals(ideNode["vICMS"].InnerText) &&
                                  vo1.ValorTotalICMSDesonerado.Equals(ideNode["vICMSDeson"].InnerText) &&
                                  vo1.BaseCalculoICMSST.Equals(ideNode["vBCST"].InnerText) &&
                                  vo1.ValorTotalICMSST.Equals(ideNode["vST"].InnerText) &&
                                  vo1.ValorTotalProdutosServicos.Equals(ideNode["vProd"].InnerText) &&
                                  vo1.ValorTotalFrete.Equals(ideNode["vFrete"].InnerText) &&
                                  vo1.ValorTotalSeguro.Equals(ideNode["vSeg"].InnerText) &&
                                  vo1.ValorTotalDesconto.Equals(ideNode["vDesc"].InnerText) &&
                                  vo1.ValorTotalImpostoImportacao.Equals(ideNode["vII"].InnerText) &&
                                  vo1.ValorTotalIPI.Equals(ideNode["vIPI"].InnerText) &&
                                  vo1.ValorTotalPIS.Equals(ideNode["vPIS"].InnerText) &&
                                  vo1.ValorTotalCOFINS.Equals(ideNode["vCOFINS"].InnerText) &&
                                  vo1.OutrasDespesas.Equals(ideNode["vOutro"].InnerText) &&
                                  vo1.ValorTotalNF.Equals(ideNode["vNF"].InnerText) &&
                                  vo1.ValorTotalTributos.Equals(ideNode["vTotTrib"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}