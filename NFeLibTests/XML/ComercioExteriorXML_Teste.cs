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
    public class ComercioExteriorXML_Teste
    {
        [TestMethod()]
        public void ComercioExteriorXML_ObterEntidade_Teste()
        {
            try
            {
                ComercioExteriorXML xml = new ComercioExteriorXML();
                ComercioExteriorVO vo1 = new ComercioExteriorVO();


                String strXml = "<exporta><UFSaidaPais>UFSaidaPais</UFSaidaPais><xLocExporta>xLocExporta</xLocExporta><xLocDespacho>xLocDespacho</xLocDespacho></exporta>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ComercioExteriorXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.UFSaidaPais.Equals(ideNode["UFSaidaPais"].InnerText) &&
                                  vo1.LocalExportacao.Equals(ideNode["xLocExporta"].InnerText) &&
                                  vo1.LocalDespacho.Equals(ideNode["xLocDespacho"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ComercioExteriorXML_ObterElementoXML_Teste()
        {
            try
            {
                ComercioExteriorXML xml = new ComercioExteriorXML();
                ComercioExteriorVO vo1 = new ComercioExteriorVO();

                vo1.UFSaidaPais = "UFSaidaPais";
                vo1.LocalExportacao = "xLocExporta";
                vo1.LocalDespacho = "xLocDespacho";
                
                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.UFSaidaPais.Equals(ideNode["UFSaidaPais"].InnerText) &&
                                  vo1.LocalExportacao.Equals(ideNode["xLocExporta"].InnerText) &&
                                  vo1.LocalDespacho.Equals(ideNode["xLocDespacho"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}