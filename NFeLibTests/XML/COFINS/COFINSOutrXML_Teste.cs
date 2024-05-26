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
    public class COFINSOutrXML_Teste
    {
        [TestMethod()]
        public void COFINSOutrXML_ObterEntidade_Teste()
        {
            try
            {
                COFINSOutrXML xml = new COFINSOutrXML();
                COFINSxxVO vo1 = null;


                String strXml = "<COFINSOutr><CST>60</CST><vBC>vBC</vBC><pCOFINS>pCOFINS</pCOFINS><qBCProd>qBCProd</qBCProd><vAliqProd>vAliqProd</vAliqProd><vCOFINS>vCOFINS</vCOFINS></COFINSOutr>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = COFINSOutrXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.TipoCOFINS == TipoCOFINS.COFINSOutr &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.ValorCOFINS.Equals(ideNode["vCOFINS"].InnerText) &&
                                  vo1.AliquotaCOFINS.Equals(ideNode["pCOFINS"].InnerText) &&
                                  vo1.ValorBaseCalculoCOFINS.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.ValorAliquotaCOFINS.Equals(ideNode["vAliqProd"].InnerText) &&
                                  vo1.QuantidadeVendida.Equals(ideNode["qBCProd"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void COFINSOutrXML_ObterElementoXML_Teste()
        {
            try
            {
                COFINSOutrXML xml = new COFINSOutrXML();
                COFINSxxVO vo1 = new COFINSxxVO();

                vo1.ValorCOFINS = "vCOFINS";
                vo1.AliquotaCOFINS = "pCOFINS";
                vo1.ValorBaseCalculoCOFINS = "vBC";
                vo1.CST = "60";
                vo1.ValorAliquotaCOFINS = "vAliqProd";
                vo1.QuantidadeVendida = "qBCProd";


                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = COFINSOutrXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.ValorCOFINS.Equals(ideNode["vCOFINS"].InnerText) &&
                                  vo1.AliquotaCOFINS.Equals(ideNode["pCOFINS"].InnerText) &&
                                  vo1.ValorBaseCalculoCOFINS.Equals(ideNode["vBC"].InnerText) &&
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