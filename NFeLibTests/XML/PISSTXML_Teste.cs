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
    public class PISSTXML_Teste
    {
        [TestMethod()]
        public void PISSTXML_ObterEntidade_Teste()
        {
            try
            {
                PISSTXML xml = new PISSTXML();
                PISSTVO vo1 = new PISSTVO();


                String strXml = "<PISST><vBC>vBC</vBC><pPIS>pPIS</pPIS><qBCProd>qBCProd</qBCProd><vAliqProd>vAliqProd</vAliqProd><vPIS>vPIS</vPIS></PISST>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = PISSTXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.ValorBCPIS.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.AliquotaPIS.Equals(ideNode["pPIS"].InnerText) &&
                                  vo1.QuantidadeVendida.Equals(ideNode["qBCProd"].InnerText) &&
                                  vo1.ValorAliquotaPIS.Equals(ideNode["vAliqProd"].InnerText) &&
                                  vo1.ValorPIS.Equals(ideNode["vPIS"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void PISSTXML_ObterElementoXML_Teste()
        {
            try
            {
                PISSTXML xml = new PISSTXML();
                PISSTVO vo1 = new PISSTVO();

                vo1.ValorBCPIS = "vBC";
                vo1.AliquotaPIS = "pPIS";
                vo1.QuantidadeVendida = "qBCProd";
                vo1.ValorAliquotaPIS = "vAliqProd";
                vo1.ValorPIS = "vPIS";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.ValorBCPIS.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.AliquotaPIS.Equals(ideNode["pPIS"].InnerText) &&
                                  vo1.QuantidadeVendida.Equals(ideNode["qBCProd"].InnerText) &&
                                  vo1.ValorAliquotaPIS.Equals(ideNode["vAliqProd"].InnerText) &&
                                  vo1.ValorPIS.Equals(ideNode["vPIS"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}