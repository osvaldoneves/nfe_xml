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
    public class ProcessoReferenciadoXML_Teste
    {
        [TestMethod()]
        public void ProcessoReferenciadoXML_ObterEntidade_Teste()
        {
            try
            {
                ProcessoReferenciadoXML xml = new ProcessoReferenciadoXML();
                ProcessoReferenciadoVO vo1 = new ProcessoReferenciadoVO();


                String strXml = "<procRef><nProc>nProc</nProc><indProc>indProc</indProc></procRef>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ProcessoReferenciadoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.IdentificadorProcesso.Equals(ideNode["nProc"].InnerText) &&
                                  vo1.IndicadorOrigemProcesso.Equals(ideNode["indProc"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ProcessoReferenciadoXML_ObterElementoXML_Teste()
        {
            try
            {
                ProcessoReferenciadoXML xml = new ProcessoReferenciadoXML();
                ProcessoReferenciadoVO vo1 = new ProcessoReferenciadoVO();

                vo1.IdentificadorProcesso = "nProc";
                vo1.IndicadorOrigemProcesso = "indProc";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.IdentificadorProcesso.Equals(ideNode["nProc"].InnerText) &&
                                  vo1.IndicadorOrigemProcesso.Equals(ideNode["indProc"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}