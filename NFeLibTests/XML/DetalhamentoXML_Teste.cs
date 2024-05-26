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
    public class DetalhamentoXML_Teste
    {
        [TestMethod()]
        public void DetalhamentoXML_ObterEntidade_Teste()
        {
            try
            {
                DetalhamentoXML xml = new DetalhamentoXML();
                DetalhamentoVO vo1 = new DetalhamentoVO();


                String strXml = "<det nItem=\"1\"><infAdProd>infAdProd</infAdProd></det>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = DetalhamentoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.NumeroItem.Equals(ideNode.Attributes["nItem"].Value) &&
                                  vo1.InformacoesAdicionaisProduto.Equals(ideNode["infAdProd"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void DetalhamentoXML_ObterElementoXML_Teste()
        {
            try
            {
                DetalhamentoXML xml = new DetalhamentoXML();
                DetalhamentoVO vo1 = new DetalhamentoVO();

                vo1.NumeroItem = "1";
                vo1.InformacoesAdicionaisProduto = "infAdProd";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.NumeroItem.Equals(ideNode.Attributes["nItem"].Value) &&
                                  vo1.InformacoesAdicionaisProduto.Equals(ideNode["infAdProd"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}