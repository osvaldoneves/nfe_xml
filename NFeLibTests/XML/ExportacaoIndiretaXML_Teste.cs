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
    public class ExportacaoIndiretaXML_Teste
    {
        [TestMethod()]
        public void ExportacaoIndiretaXML_ObterEntidade_Teste()
        {
            try
            {
                ExportacaoIndiretaXML xml = new ExportacaoIndiretaXML();
                ExportacaoIndiretaVO vo1 = new ExportacaoIndiretaVO();


                String strXml = "<exportInd><nRE>nRE</nRE><chNFe>chNFe</chNFe><qExport>qExport</qExport></exportInd>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ExportacaoIndiretaXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.NumeroRegistroExportacao.Equals(ideNode["nRE"].InnerText) &&
                                  vo1.ChaveAcessoNFExportacao.Equals(ideNode["chNFe"].InnerText) &&
                                  vo1.QuantidadeExportada.Equals(ideNode["qExport"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ExportacaoIndiretaXML_ObterElementoXML_Teste()
        {
            try
            {
                ExportacaoIndiretaXML xml = new ExportacaoIndiretaXML();
                ExportacaoIndiretaVO vo1 = new ExportacaoIndiretaVO();

                vo1.NumeroRegistroExportacao = "nRE";
                vo1.ChaveAcessoNFExportacao = "chNFe";
                vo1.QuantidadeExportada = "qExport";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.NumeroRegistroExportacao.Equals(ideNode["nRE"].InnerText) &&
                                  vo1.ChaveAcessoNFExportacao.Equals(ideNode["chNFe"].InnerText) &&
                                  vo1.QuantidadeExportada.Equals(ideNode["qExport"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}