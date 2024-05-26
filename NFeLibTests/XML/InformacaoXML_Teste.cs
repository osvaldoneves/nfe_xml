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
    public class InformacaoXML_Teste
    {
        [TestMethod()]
        public void InformacaoXML_ObterEntidade_Teste()
        {
            try
            {
                InformacaoXML xml = new InformacaoXML();
                InformacaoVO vo1 = new InformacaoVO();


                String strXml = "<infNFe versao=\"versao\" Id=\"Id\"></infNFe>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = InformacaoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.Versao.Equals(ideNode.Attributes["versao"].Value) &&
                                  vo1.ID.Equals(ideNode.Attributes["Id"].Value);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void InformacaoXML_ObterElementoXML_Teste()
        {
            try
            {
                InformacaoXML xml = new InformacaoXML();
                InformacaoVO vo1 = new InformacaoVO();

                vo1.Versao = "versao";
                vo1.ID = "Id";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.Versao.Equals(ideNode.Attributes["versao"].Value) &&
                                  vo1.ID.Equals(ideNode.Attributes["Id"].Value);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}