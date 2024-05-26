using Microsoft.VisualStudio.TestTools.UnitTesting;
using OLNG.Bibliotecas.NFeLib.XML.COFINS;
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
    public class COFINSNaoTributadoXML_Teste
    {
        [TestMethod()]
        public void COFINSNaoTributadoXML_ObterEntidade_Teste()
        {
            try
            {
                COFINSNaoTributadoXML xml = new COFINSNaoTributadoXML();
                COFINSxxVO vo1 = null;


                String strXml = "<COFINSNT><CST>50</CST></COFINSNT>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = COFINSNaoTributadoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.ValorCOFINS.Equals("") &&
                                  vo1.AliquotaCOFINS.Equals("") &&
                                  vo1.ValorBaseCalculoCOFINS.Equals("") &&
                                  vo1.ValorAliquotaCOFINS.Equals("") &&
                                  vo1.QuantidadeVendida.Equals("");

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void COFINSNaoTributadoXML_ObterElementoXML_Teste()
        {
            try
            {
                COFINSNaoTributadoXML xml = new COFINSNaoTributadoXML();
                COFINSxxVO vo1 = new COFINSxxVO("50");

                vo1.CST = "50";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = COFINSNaoTributadoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.ValorCOFINS.Equals("") &&
                                  vo1.AliquotaCOFINS.Equals("") &&
                                  vo1.ValorBaseCalculoCOFINS.Equals("") &&
                                  vo1.ValorAliquotaCOFINS.Equals("") &&
                                  vo1.QuantidadeVendida.Equals("");

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}