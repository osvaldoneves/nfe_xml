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
    public class DuplicataXML_Teste
    {
        [TestMethod()]
        public void DuplicataXML_ObterEntidade_Teste()
        {
            try
            {
                DuplicataXML xml = new DuplicataXML();
                DuplicataVO vo1 = new DuplicataVO();


                String strXml = "<dup><nDup>nDup</nDup><dVenc>dVenc</dVenc><vDup>vDup</vDup></dup>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = DuplicataXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.NumeroDuplicata.Equals(ideNode["nDup"].InnerText) &&
                                  vo1.DataVencimento.Equals(ideNode["dVenc"].InnerText) &&
                                  vo1.ValorDuplicata.Equals(ideNode["vDup"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void DuplicataXML_ObterElementoXML_Teste()
        {
            try
            {
                DuplicataXML xml = new DuplicataXML();
                DuplicataVO vo1 = new DuplicataVO();

                vo1.NumeroDuplicata = "nDup";
                vo1.DataVencimento = "dVenc";
                vo1.ValorDuplicata = "vDup";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.NumeroDuplicata.Equals(ideNode["nDup"].InnerText) &&
                                  vo1.DataVencimento.Equals(ideNode["dVenc"].InnerText) &&
                                  vo1.ValorDuplicata.Equals(ideNode["vDup"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}