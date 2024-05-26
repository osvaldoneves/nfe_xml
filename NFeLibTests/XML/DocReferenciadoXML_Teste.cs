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
    public class DocReferenciadoXML_Teste
    {
        [TestMethod()]
        public void DocReferenciadoXML_ObterEntidade_Teste()
        {
            try
            {
                DocReferenciadoXML xml = new DocReferenciadoXML();
                DocReferenciadoVO vo1 = new DocReferenciadoVO();


                String strXml = "<NFref><refNFe>refNFe</refNFe></NFref>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = DocReferenciadoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.ChaveAcesso.Equals(ideNode["refNFe"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void DocReferenciadoXML_ObterElementoXML_Teste()
        {
            try
            {
                DocReferenciadoXML xml = new DocReferenciadoXML();
                DocReferenciadoVO vo1 = new DocReferenciadoVO();

                vo1.ChaveAcesso = "refNFe";
                
                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.ChaveAcesso.Equals(ideNode["refNFe"].InnerText) ;

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}