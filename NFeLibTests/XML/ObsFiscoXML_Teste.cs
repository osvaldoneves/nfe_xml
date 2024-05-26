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
    public class ObsFiscoXML_Teste
    {
        [TestMethod()]
        public void ObsFiscoXML_ObterEntidade_Teste()
        {
            try
            {
                ObsFiscoXML xml = new ObsFiscoXML();
                ObsFiscoVO vo1 = new ObsFiscoVO();


                String strXml = "<obsFisco><xCampo>xCampo</xCampo><xTexto>xTexto</xTexto></obsFisco>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ObsFiscoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.Campo.Equals(ideNode["xCampo"].InnerText) &&
                                  vo1.Texto.Equals(ideNode["xTexto"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ObsFiscoXML_ObterElementoXML_Teste()
        {
            try
            {
                ObsFiscoXML xml = new ObsFiscoXML();
                ObsFiscoVO vo1 = new ObsFiscoVO();

                vo1.Campo = "xCampo";
                vo1.Texto = "xTexto";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.Campo.Equals(ideNode["xCampo"].InnerText) &&
                                  vo1.Texto.Equals(ideNode["xTexto"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}