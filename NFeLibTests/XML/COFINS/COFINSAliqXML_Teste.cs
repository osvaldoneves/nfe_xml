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
    public class COFINSAliqXML_Teste
    {
        [TestMethod()]
        public void COFINSAliqXML_ObterEntidade_Teste()
        {
            try
            {
                COFINSAliqXML xml = new COFINSAliqXML();
                COFINSxxVO vo1 = new COFINSxxVO("01");


                String strXml = "<COFINSAliq><CST>02</CST><vBC>vBC</vBC><pCOFINS>pCOFINS</pCOFINS><vCOFINS>vCOFINS</vCOFINS></COFINSAliq>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = COFINSAliqXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.TipoCOFINS == TipoCOFINS.COFINSAliq &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.ValorCOFINS.Equals(ideNode["vCOFINS"].InnerText) &&
                                  vo1.AliquotaCOFINS.Equals(ideNode["pCOFINS"].InnerText) &&
                                  vo1.ValorBaseCalculoCOFINS.Equals(ideNode["vBC"].InnerText) &&
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
        public void COFINSAliqXML_ObterElementoXML_Teste()
        {
            try
            {
                COFINSAliqXML xml = new COFINSAliqXML();
                COFINSxxVO vo1 = new COFINSxxVO("02");

                vo1.ValorCOFINS = "vCOFINS";
                vo1.AliquotaCOFINS = "pCOFINS";
                vo1.ValorBaseCalculoCOFINS = "vBC";
                vo1.CST = "CST";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = COFINSAliqXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.ValorCOFINS.Equals(ideNode["vCOFINS"].InnerText) &&
                                  vo1.AliquotaCOFINS.Equals(ideNode["pCOFINS"].InnerText) &&
                                  vo1.ValorBaseCalculoCOFINS.Equals(ideNode["vBC"].InnerText) &&
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