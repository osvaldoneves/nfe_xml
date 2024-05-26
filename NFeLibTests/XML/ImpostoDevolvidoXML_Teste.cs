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
    public class ImpostoDevolvidoXML_Teste
    {
        [TestMethod()]
        public void ImpostoDevolvidoXML_ObterEntidade_Teste()
        {
            try
            {
                ImpostoDevolvidoXML xml = new ImpostoDevolvidoXML();
                ImpostoDevolvidoVO vo1 = new ImpostoDevolvidoVO();


                String strXml = "<impostoDevol><pDevol>pDevol</pDevol></impostoDevol>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ImpostoDevolvidoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.PercentualMercadoriaDevolvida.Equals(ideNode["pDevol"].InnerText);
                                  

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ImpostoDevolvidoXML_ObterElementoXML_Teste()
        {
            try
            {
                ImpostoDevolvidoXML xml = new ImpostoDevolvidoXML();
                ImpostoDevolvidoVO vo1 = new ImpostoDevolvidoVO();

                vo1.PercentualMercadoriaDevolvida = "pDevol";
                
                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.PercentualMercadoriaDevolvida.Equals(ideNode["pDevol"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}