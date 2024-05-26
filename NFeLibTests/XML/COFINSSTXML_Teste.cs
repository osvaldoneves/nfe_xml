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
    public class COFINSSTXML_Teste
    {
        [TestMethod()]
        public void COFINSSTXML_ObterEntidade_Teste()
        {
            try
            {
                COFINSSTXML xml = new COFINSSTXML();
                COFINSSTVO vo1 = new COFINSSTVO();


                String strXml = "<COFINSST><vBC>vBC</vBC><pCOFINS>pCOFINS</pCOFINS><qBCProd>qBCProd</qBCProd><vAliqProd>vAliqProd</vAliqProd><vCOFINS>vCOFINS</vCOFINS></COFINSST>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = vo1.QuantidadeVendida.Equals(ideNode["qBCProd"].InnerText) &&
                                  vo1.ValorAliquotaProduto.Equals(ideNode["vAliqProd"].InnerText) &&
                                  vo1.ValorCOFINS.Equals(ideNode["vCOFINS"].InnerText) &&
                                  vo1.ValorBC.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.AliquotaCOFINS.Equals(ideNode["pCOFINS"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void COFINSSTXML_ObterElementoXML_Teste()
        {
            try
            {
                COFINSSTXML xml = new COFINSSTXML();
                COFINSSTVO vo1 = new COFINSSTVO();

                vo1.QuantidadeVendida = "qBCProd";
                vo1.ValorAliquotaProduto = "vAliqProd";
                vo1.ValorCOFINS = "vCOFINS";
                vo1.ValorBC = "vBC";
                vo1.AliquotaCOFINS = "pCOFINS";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.QuantidadeVendida.Equals(ideNode["qBCProd"].InnerText) &&
                                  vo1.ValorAliquotaProduto.Equals(ideNode["vAliqProd"].InnerText) &&
                                  vo1.ValorCOFINS.Equals(ideNode["vCOFINS"].InnerText) &&
                                  vo1.ValorBC.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.AliquotaCOFINS.Equals(ideNode["pCOFINS"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}