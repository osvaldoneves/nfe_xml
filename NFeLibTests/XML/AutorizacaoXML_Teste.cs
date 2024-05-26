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
    public class AutorizacaoXML_Teste
    {
        [TestMethod()]
        public void AutorizacaoXML_ObterEntidade_Teste()
        {
            try
            {
                AutorizacaoXML xml = new AutorizacaoXML();
                AutorizacaoVO vo1 = new AutorizacaoVO();


                String strXml = "<autXML><CNPJ>CNPJ</CNPJ><CPF>CPF</CPF></autXML>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = vo1.CNPJ.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.CPF.Equals(ideNode["CPF"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void AutorizacaoXML_ObterElementoXML_Teste()
        {
            try
            {
                AutorizacaoXML xml = new AutorizacaoXML();
                AutorizacaoVO vo1 = new AutorizacaoVO();

                vo1.CNPJ = "CNPJ";
                vo1.CPF = "CPF";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.CNPJ.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.CPF.Equals(ideNode["CPF"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}