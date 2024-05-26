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
    public class ReboqueXML_Teste
    {
        [TestMethod()]
        public void ReboqueXML_ObterEntidade_Teste()
        {
            try
            {
                ReboqueXML xml = new ReboqueXML();
                ReboqueVO vo1 = new ReboqueVO();


                String strXml = "<reboque><placa>placa</placa><UF>UF</UF><RNTC>RNTC</RNTC><vagao>vagao</vagao><balsa>balsa</balsa></reboque>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ReboqueXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.Placa.Equals(ideNode["placa"].InnerText) &&
                                  vo1.UF.Equals(ideNode["UF"].InnerText) &&
                                  vo1.RNTC.Equals(ideNode["RNTC"].InnerText) &&
                                  vo1.Vagao.Equals(ideNode["vagao"].InnerText) &&
                                  vo1.Balsa.Equals(ideNode["balsa"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ReboqueXML_ObterElementoXML_Teste()
        {
            try
            {
                ReboqueXML xml = new ReboqueXML();
                ReboqueVO vo1 = new ReboqueVO();

                vo1.Placa = "placa";
                vo1.UF = "UF";
                vo1.RNTC = "RNTC";
                vo1.Vagao = "vagao";
                vo1.Balsa = "balsa";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.Placa.Equals(ideNode["placa"].InnerText) &&
                                  vo1.UF.Equals(ideNode["UF"].InnerText) &&
                                  vo1.RNTC.Equals(ideNode["RNTC"].InnerText) &&
                                  vo1.Vagao.Equals(ideNode["vagao"].InnerText) &&
                                  vo1.Balsa.Equals(ideNode["balsa"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}