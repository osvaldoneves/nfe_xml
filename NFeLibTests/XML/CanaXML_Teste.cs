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
    public class CanaXML_Teste
    {
        [TestMethod()]
        public void CanaXML_ObterEntidade_Teste()
        {
            try
            {
                CanaXML xml = new CanaXML();
                CanaVO vo1 = new CanaVO();


                String strXml = "<card><CNPJ>CNPJ</CNPJ><tBand>tBand</tBand><cAut>cAut</cAut></card>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = vo1.Safra.Equals(ideNode["safra"].InnerText) &&
                                  vo1.MesAnoReferência.Equals(ideNode["ref"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void CanaXML_ObterElementoXML_Teste()
        {
            try
            {
                CanaXML xml = new CanaXML();
                CanaVO vo1 = new CanaVO();

                vo1.Safra = "safra";
                vo1.MesAnoReferência = "ref";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.Safra.Equals(ideNode["safra"].InnerText) &&
                                  vo1.MesAnoReferência.Equals(ideNode["ref"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}