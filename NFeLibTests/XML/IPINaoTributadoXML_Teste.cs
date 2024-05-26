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
    public class IPINaoTributadoXML_Teste
    {
        [TestMethod()]
        public void IPINaoTributadoXML_ObterEntidade_Teste()
        {
            try
            {
                IPINaoTributadoXML xml = new IPINaoTributadoXML();
                IPINaoTributadoVO vo1 = new IPINaoTributadoVO();


                String strXml = "<IPINT><CST>CST</CST></IPINT>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = IPINaoTributadoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void IPINaoTributadoXML_ObterElementoXML_Teste()
        {
            try
            {
                IPINaoTributadoXML xml = new IPINaoTributadoXML();
                IPINaoTributadoVO vo1 = new IPINaoTributadoVO();

                vo1.CST = "CST";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.CST.Equals(ideNode["CST"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}