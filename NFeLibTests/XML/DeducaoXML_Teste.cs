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
    public class DeducaoXML_Teste
    {
        [TestMethod()]
        public void DeducaoXML_ObterEntidade_Teste()
        {
            try
            {
                DeducaoXML xml = new DeducaoXML();
                DeducaoVO vo1 = new DeducaoVO();


                String strXml = "<deduc><xDed>xDed</xDed><vDed>vDed</vDed><vFor>vFor</vFor><vTotDed>vTotDed</vTotDed><vLiqFor>vLiqFor</vLiqFor></deduc>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = DeducaoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.DescricaoDeducao.Equals(ideNode["xDed"].InnerText) &&
                                  vo1.ValorDeducao.Equals(ideNode["vDed"].InnerText) &&
                                  vo1.ValorFornecimentos.Equals(ideNode["vFor"].InnerText) &&
                                  vo1.ValorTotalDeducao.Equals(ideNode["vTotDed"].InnerText) &&
                                  vo1.ValorLiquidoFornecimentos.Equals(ideNode["vLiqFor"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void DeducaoXML_ObterElementoXML_Teste()
        {
            try
            {
                DeducaoXML xml = new DeducaoXML();
                DeducaoVO vo1 = new DeducaoVO();

                vo1.DescricaoDeducao = "xDed";
                vo1.ValorDeducao = "vDed";
                vo1.ValorFornecimentos = "vFor";
                vo1.ValorTotalDeducao = "vTotDed";
                vo1.ValorLiquidoFornecimentos = "vLiqFor";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.DescricaoDeducao.Equals(ideNode["xDed"].InnerText) &&
                                  vo1.ValorDeducao.Equals(ideNode["vDed"].InnerText) &&
                                  vo1.ValorFornecimentos.Equals(ideNode["vFor"].InnerText) &&
                                  vo1.ValorTotalDeducao.Equals(ideNode["vTotDed"].InnerText) &&
                                  vo1.ValorLiquidoFornecimentos.Equals(ideNode["vLiqFor"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}