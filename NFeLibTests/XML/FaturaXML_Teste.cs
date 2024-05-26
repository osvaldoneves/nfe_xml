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
    public class FaturaXML_Teste
    {
        [TestMethod()]
        public void FaturaXML_ObterEntidade_Teste()
        {
            try
            {
                FaturaXML xml = new FaturaXML();
                FaturaVO vo1 = new FaturaVO();


                String strXml = "<fat><nFat>nFat</nFat><vOrig>vOrig</vOrig><vDesc>vDesc</vDesc><vLiq>vLiq</vLiq></fat>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = FaturaXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.NumeroFatura.Equals(ideNode["nFat"].InnerText) &&
                                  vo1.ValorOriginalFatura.Equals(ideNode["vOrig"].InnerText) &&
                                  vo1.ValorDesconto.Equals(ideNode["vDesc"].InnerText) &&
                                  vo1.ValorLiquidoFatura.Equals(ideNode["vLiq"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void FaturaXML_ObterElementoXML_Teste()
        {
            try
            {
                FaturaXML xml = new FaturaXML();
                FaturaVO vo1 = new FaturaVO();

                vo1.NumeroFatura = "nFat";
                vo1.ValorOriginalFatura = "vOrig";
                vo1.ValorDesconto = "vDesc";
                vo1.ValorLiquidoFatura = "vLiq";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.NumeroFatura.Equals(ideNode["nFat"].InnerText) &&
                                  vo1.ValorOriginalFatura.Equals(ideNode["vOrig"].InnerText) &&
                                  vo1.ValorDesconto.Equals(ideNode["vDesc"].InnerText) &&
                                  vo1.ValorLiquidoFatura.Equals(ideNode["vLiq"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}