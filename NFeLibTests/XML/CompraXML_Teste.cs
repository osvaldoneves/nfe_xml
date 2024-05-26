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
    public class CompraXML_Teste
    {
        [TestMethod()]
        public void CompraXML_ObterEntidade_Teste()
        {
            try
            {
                CompraXML xml = new CompraXML();
                CompraVO vo1 = new CompraVO();


                String strXml = "<compra><xNEmp>xNEmp</xNEmp><xPed>xPed</xPed><xCont>xCont</xCont></compra>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = CompraXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.NotaEmpenho.Equals(ideNode["xNEmp"].InnerText) &&
                                  vo1.Pedido.Equals(ideNode["xPed"].InnerText) &&
                                  vo1.Contrato.Equals(ideNode["xCont"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void CompraXML_ObterElementoXML_Teste()
        {
            try
            {
                CompraXML xml = new CompraXML();
                CompraVO vo1 = new CompraVO();

                vo1.NotaEmpenho = "xNEmp";
                vo1.Pedido = "xPed";
                vo1.Contrato = "xCont";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.NotaEmpenho.Equals(ideNode["xNEmp"].InnerText) &&
                                  vo1.Pedido.Equals(ideNode["xPed"].InnerText) &&
                                  vo1.Contrato.Equals(ideNode["xCont"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}