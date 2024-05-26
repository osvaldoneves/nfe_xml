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
    public class CideXML_Teste
    {
        [TestMethod()]
        public void CideXML_ObterEntidade_Teste()
        {
            try
            {
                CideXML xml = new CideXML();
                CideVO vo1 = new CideVO();


                String strXml = "<card><qBCProd>qBCProd</qBCProd><vAliqProd>vAliqProd</vAliqProd><vCIDE>vCIDE</vCIDE></card>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = CideXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.BaseCalculoCIDE.Equals(ideNode["qBCProd"].InnerText) &&
                                  vo1.ValorAlicotaCIDE.Equals(ideNode["vAliqProd"].InnerText) &&
                                  vo1.ValorCIDE.Equals(ideNode["vCIDE"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void CideXML_ObterElementoXML_Teste()
        {
            try
            {
                CideXML xml = new CideXML();
                CideVO vo1 = new CideVO();

                vo1.BaseCalculoCIDE = "qBCProd";
                vo1.ValorAlicotaCIDE = "vAliqProd";
                vo1.ValorCIDE = "vCIDE";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.BaseCalculoCIDE.Equals(ideNode["qBCProd"].InnerText) &&
                                  vo1.ValorAlicotaCIDE.Equals(ideNode["vAliqProd"].InnerText) &&
                                  vo1.ValorCIDE.Equals(ideNode["vCIDE"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}