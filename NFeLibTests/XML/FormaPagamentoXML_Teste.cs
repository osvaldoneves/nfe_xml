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
    public class FormaPagamentoXML_Teste
    {
        [TestMethod()]
        public void FormaPagamentoXML_ObterEntidade_Teste()
        {
            try
            {
                FormaPagamentoXML xml = new FormaPagamentoXML();
                FormaPagamentoVO vo1 = new FormaPagamentoVO();


                String strXml = "<pag><tPag>tPag</tPag><vPag>vPag</vPag></pag>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = FormaPagamentoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.TipoPagamento.Equals(ideNode["tPag"].InnerText) &&
                                  vo1.ValorPagamento.Equals(ideNode["vPag"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void FormaPagamentoXML_ObterElementoXML_Teste()
        {
            try
            {
                FormaPagamentoXML xml = new FormaPagamentoXML();
                FormaPagamentoVO vo1 = new FormaPagamentoVO();

                vo1.TipoPagamento = "tPag";
                vo1.ValorPagamento = "vPag";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.TipoPagamento.Equals(ideNode["tPag"].InnerText) &&
                                  vo1.ValorPagamento.Equals(ideNode["vPag"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}