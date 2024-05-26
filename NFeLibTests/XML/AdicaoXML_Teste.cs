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
    public class AdicaoXML_Teste
    {
        [TestMethod()]
        public void AdicaoXML_ObterEntidade_Teste()
        {
            try
            {
                AdicaoXML xml = new AdicaoXML();
                AdicaoVO vo1 = new AdicaoVO();


                String strXml = "<adi><nAdicao>nAdicao</nAdicao><nSeqAdic>nSeqAdic</nSeqAdic><cFabricante>cFabricante</cFabricante><vDescDI>vDescDI</vDescDI><nDraw>nDraw</nDraw></adi>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = vo1.NumeroAdicao.Equals(ideNode["nAdicao"].InnerText) &&
                                  vo1.NumeroSequencialItemAdicao.Equals(ideNode["nSeqAdic"].InnerText) &&
                                  vo1.CodigoFabricante.Equals(ideNode["cFabricante"].InnerText) &&
                                  vo1.ValorDescontoItemDI.Equals(ideNode["vDescDI"].InnerText) &&
                                  vo1.NumeroAtoConcessorioDrawback.Equals(ideNode["nDraw"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void AdicaoXML_ObterElementoXML_Teste()
        {
            try
            {
                AdicaoXML xml = new AdicaoXML();
                AdicaoVO vo1 = new AdicaoVO();

                vo1.NumeroAdicao = "nAdicao";
                vo1.NumeroSequencialItemAdicao = "nSeqAdic";
                vo1.CodigoFabricante = "cFabricante";
                vo1.ValorDescontoItemDI = "vDescDI";
                vo1.NumeroAtoConcessorioDrawback = "nDraw";
                
                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.NumeroAdicao.Equals(ideNode["nAdicao"].InnerText) &&
                                  vo1.NumeroSequencialItemAdicao.Equals(ideNode["nSeqAdic"].InnerText) &&
                                  vo1.CodigoFabricante.Equals(ideNode["cFabricante"].InnerText) &&
                                  vo1.ValorDescontoItemDI.Equals(ideNode["vDescDI"].InnerText) &&
                                  vo1.NumeroAtoConcessorioDrawback.Equals(ideNode["nDraw"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}