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
    public class IPIXML_Teste
    {
        [TestMethod()]
        public void IPIXML_ObterEntidade_Teste()
        {
            try
            {
                IPIXML xml = new IPIXML();
                IPIVO vo1 = new IPIVO();


                String strXml = "<IPI><clEnq>clEnq</clEnq><CNPJProd>CNPJProd</CNPJProd><cSelo>cSelo</cSelo><qSelo>qSelo</qSelo><cEnq>cEnq</cEnq></IPI>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = IPIXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.ClasseEnquadramentoIPI.Equals(ideNode["clEnq"].InnerText) &&
                                  vo1.CNPJProdutor.Equals(ideNode["CNPJProd"].InnerText) &&
                                  vo1.CodigoSelo.Equals(ideNode["cSelo"].InnerText) &&
                                  vo1.QuantidadeSelo.Equals(ideNode["qSelo"].InnerText) &&
                                  vo1.CodigoEnquadramento.Equals(ideNode["cEnq"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void IPIXML_ObterElementoXML_Teste()
        {
            try
            {
                IPIXML xml = new IPIXML();
                IPIVO vo1 = new IPIVO();

                vo1.ClasseEnquadramentoIPI = "clEnq";
                vo1.CNPJProdutor = "CNPJProd";
                vo1.CodigoSelo = "cSelo";
                vo1.QuantidadeSelo = "qSelo";
                vo1.CodigoEnquadramento = "cEnq";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.ClasseEnquadramentoIPI.Equals(ideNode["clEnq"].InnerText) &&
                                  vo1.CNPJProdutor.Equals(ideNode["CNPJProd"].InnerText) &&
                                  vo1.CodigoSelo.Equals(ideNode["cSelo"].InnerText) &&
                                  vo1.QuantidadeSelo.Equals(ideNode["qSelo"].InnerText) &&
                                  vo1.CodigoEnquadramento.Equals(ideNode["cEnq"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}