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
    public class VeiculoTransporteXML_Teste
    {
        [TestMethod()]
        public void VeiculoTransporteXML_ObterEntidade_Teste()
        {
            try
            {
                VeiculoTransporteXML xml = new VeiculoTransporteXML();
                VeiculoTransporteVO vo1 = new VeiculoTransporteVO();


                String strXml = "<veicTransp><placa>placa</placa><UF>UF</UF><RNTC>RNTC</RNTC></veicTransp>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = VeiculoTransporteXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.Placa.Equals(ideNode["placa"].InnerText) &&
                                  vo1.UF.Equals(ideNode["UF"].InnerText) &&
                                  vo1.RNTC.Equals(ideNode["RNTC"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void VeiculoTransporteXML_ObterElementoXML_Teste()
        {
            try
            {
                VeiculoTransporteXML xml = new VeiculoTransporteXML();
                VeiculoTransporteVO vo1 = new VeiculoTransporteVO();

                vo1.Placa = "placa";
                vo1.UF = "UF";
                vo1.RNTC = "RNTC";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.Placa.Equals(ideNode["placa"].InnerText) &&
                                  vo1.UF.Equals(ideNode["UF"].InnerText) &&
                                  vo1.RNTC.Equals(ideNode["RNTC"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}