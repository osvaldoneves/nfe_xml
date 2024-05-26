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
    public class ExportacaoXML_Teste
    {
        [TestMethod()]
        public void ExportacaoXML_ObterEntidade_Teste()
        {
            try
            {
                ExportacaoXML xml = new ExportacaoXML();
                ExportacaoVO vo1 = new ExportacaoVO();


                String strXml = "<detExport><nDraw>nDraw</nDraw></detExport>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ExportacaoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.NumeroAtoConcessorioDrawback.Equals(ideNode["nDraw"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ExportacaoXML_ObterElementoXML_Teste()
        {
            try
            {
                ExportacaoXML xml = new ExportacaoXML();
                ExportacaoVO vo1 = new ExportacaoVO();

                vo1.NumeroAtoConcessorioDrawback = "nDraw";
                
                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.NumeroAtoConcessorioDrawback.Equals(ideNode["nDraw"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}