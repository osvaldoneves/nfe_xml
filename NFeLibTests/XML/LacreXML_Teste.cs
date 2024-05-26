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
    public class LacreXML_Teste
    {
        [TestMethod()]
        public void LacreXML_ObterEntidade_Teste()
        {
            try
            {
                LacreXML xml = new LacreXML();
                LacreVO vo1 = new LacreVO();


                String strXml = "<lacres><nLacre>nLacre</nLacre></lacres>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = LacreXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.NumeroLacre.Equals(ideNode["nLacre"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void LacreXML_ObterElementoXML_Teste()
        {
            try
            {
                LacreXML xml = new LacreXML();
                LacreVO vo1 = new LacreVO();

                vo1.NumeroLacre = "nLacre";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.NumeroLacre.Equals(ideNode["nLacre"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}