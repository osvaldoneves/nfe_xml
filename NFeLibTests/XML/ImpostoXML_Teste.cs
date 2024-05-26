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
    public class ImpostoXML_Teste
    {
        [TestMethod()]
        public void ImpostoXML_ObterEntidade_Teste()
        {
            try
            {
                ImpostoXML xml = new ImpostoXML();
                ImpostoVO vo1 = new ImpostoVO();


                String strXml = "<imposto><vTotTrib>vTotTrib</vTotTrib></imposto>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ImpostoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.ValorTotalTributos.Equals(ideNode["vTotTrib"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ImpostoXML_ObterElementoXML_Teste()
        {
            try
            {
                ImpostoXML xml = new ImpostoXML();
                ImpostoVO vo1 = new ImpostoVO();

                vo1.ValorTotalTributos = "vTotTrib";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.ValorTotalTributos.Equals(ideNode["vTotTrib"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}