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
    public class InfoAdicionalXML_Teste
    {
        [TestMethod()]
        public void InfoAdicionalXML_ObterEntidade_Teste()
        {
            try
            {
                InfoAdicionalXML xml = new InfoAdicionalXML();
                InfoAdicionalVO vo1 = new InfoAdicionalVO();


                String strXml = "<infAdic><infAdFisco>infAdFisco</infAdFisco><infCpl>infCpl</infCpl></infAdic>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = InfoAdicionalXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.InformacoesAdicionaisFisco.Equals(ideNode["infAdFisco"].InnerText) &&
                                  vo1.InformacoesComplementaresContribuinte.Equals(ideNode["infCpl"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void InfoAdicionalXML_ObterElementoXML_Teste()
        {
            try
            {
                InfoAdicionalXML xml = new InfoAdicionalXML();
                InfoAdicionalVO vo1 = new InfoAdicionalVO();

                vo1.InformacoesAdicionaisFisco = "infAdFisco";
                vo1.InformacoesComplementaresContribuinte = "infCpl";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.InformacoesAdicionaisFisco.Equals(ideNode["infAdFisco"].InnerText) &&
                                  vo1.InformacoesComplementaresContribuinte.Equals(ideNode["infCpl"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}