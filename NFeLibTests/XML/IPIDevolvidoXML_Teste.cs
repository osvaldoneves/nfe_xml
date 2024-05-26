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
    public class IPIDevolvidoXML_Teste
    {
        [TestMethod()]
        public void IPIDevolvidoXML_ObterEntidade_Teste()
        {
            try
            {
                IPIDevolvidoXML xml = new IPIDevolvidoXML();
                IPIDevolvidoVO vo1 = new IPIDevolvidoVO();


                String strXml = "<IPI><vIPIDevol>vIPIDevol</vIPIDevol></IPI>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = IPIDevolvidoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.ValorIPIDevolvido.Equals(ideNode["vIPIDevol"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void IPIDevolvidoXML_ObterElementoXML_Teste()
        {
            try
            {
                IPIDevolvidoXML xml = new IPIDevolvidoXML();
                IPIDevolvidoVO vo1 = new IPIDevolvidoVO();

                vo1.ValorIPIDevolvido = "vIPIDevol";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.ValorIPIDevolvido.Equals(ideNode["vIPIDevol"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}