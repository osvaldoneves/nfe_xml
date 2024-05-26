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
    public class COFINSQtdeXML_Teste
    {
        [TestMethod()]
        public void COFINSQtdeXML_ObterEntidade_Teste()
        {
            try
            {
                COFINSQtdeXML xml = new COFINSQtdeXML();
                COFINSxxVO vo1 = null;


                String strXml = "<COFINSQtde><CST>03</CST><qBCProd>qBCProd</qBCProd><vAliqProd>vAliqProd</vAliqProd><vCOFINS>vCOFINS</vCOFINS></COFINSQtde>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = COFINSQtdeXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.TipoCOFINS == TipoCOFINS.COFINSQtde &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.QuantidadeVendida.Equals(ideNode["qBCProd"].InnerText) &&
                                  vo1.ValorAliquotaCOFINS.Equals(ideNode["vAliqProd"].InnerText) &&
                                  vo1.ValorCOFINS.Equals(ideNode["vCOFINS"].InnerText) &&
                                  vo1.AliquotaCOFINS.Equals("") &&
                                  vo1.ValorBaseCalculoCOFINS.Equals("");

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void COFINSQtdeXML_ObterElementoXML_Teste()
        {
            try
            {
                COFINSQtdeXML xml = new COFINSQtdeXML();
                COFINSxxVO vo1 = new COFINSxxVO();

                vo1.CST = "03";
                vo1.ValorCOFINS = "vCOFINS";
                vo1.ValorAliquotaCOFINS = "vAliqProd";
                vo1.QuantidadeVendida = "qBCProd";


                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = COFINSQtdeXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.ValorCOFINS.Equals(ideNode["vCOFINS"].InnerText) &&
                                  vo1.AliquotaCOFINS.Equals("") &&
                                  vo1.ValorBaseCalculoCOFINS.Equals("") &&
                                  vo1.ValorAliquotaCOFINS.Equals(ideNode["vAliqProd"].InnerText) &&
                                  vo1.QuantidadeVendida.Equals(ideNode["qBCProd"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}