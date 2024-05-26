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
    public class CartaoXML_Teste
    {
        [TestMethod()]
        public void CartaoXML_ObterEntidade_Teste()
        {
            try
            {
                CartaoXML xml = new CartaoXML();
                CartaoVO vo1 = new CartaoVO();


                String strXml = "<card><CNPJ>CNPJ</CNPJ><tBand>tBand</tBand><cAut>cAut</cAut></card>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = vo1.CNPJCredenciadora.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.BandeiraOperadora.Equals(ideNode["tBand"].InnerText) &&
                                  vo1.NumeroAutorizacaoOperacao.Equals(ideNode["cAut"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void CartaoXML_ObterElementoXML_Teste()
        {
            try
            {
                CartaoXML xml = new CartaoXML();
                CartaoVO vo1 = new CartaoVO();

                vo1.CNPJCredenciadora = "CNPJ";
                vo1.BandeiraOperadora = "tBand";
                vo1.NumeroAutorizacaoOperacao = "cAut";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.CNPJCredenciadora.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.BandeiraOperadora.Equals(ideNode["tBand"].InnerText) &&
                                  vo1.NumeroAutorizacaoOperacao.Equals(ideNode["cAut"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}