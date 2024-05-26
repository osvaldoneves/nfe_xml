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
    public class ICMSSTXML_Teste
    {
        [TestMethod()]
        public void ICMSSTXML_ObterEntidade_Teste()
        {
            try
            {
                ICMSSTXML xml = new ICMSSTXML();
                ICMSxxVO vo1 = new ICMSxxVO();


                String strXml = "<ICMSST><orig>orig</orig><CST>41</CST><vBCSTRet>vBCSTRet</vBCSTRet><vICMSSTRet>vICMSSTRet</vICMSSTRet><vBCSTDest>vBCSTDest</vBCSTDest><vICMSSTDest>vICMSSTDest</vICMSSTDest></ICMSST>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ICMSSTXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.Origem.Equals(ideNode["orig"].InnerText) &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.ValorBCICMSSTRetido.Equals(ideNode["vBCSTRet"].InnerText) &&
                                  vo1.ValorICMSSTRetido.Equals(ideNode["vICMSSTRet"].InnerText) &&
                                  vo1.ValorBCSTDestino.Equals(ideNode["vBCSTDest"].InnerText) &&
                                  vo1.ValorICMSSTDestino.Equals(ideNode["vICMSSTDest"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMSSTXML_ObterElementoXML_Teste()
        {
            try
            {
                ICMSSTXML xml = new ICMSSTXML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.Origem = "orig";
                vo1.CST = "41";
                vo1.ValorBCICMSSTRetido = "vBCSTRet";
                vo1.ValorICMSSTRetido = "vICMSSTRet";
                vo1.ValorBCSTDestino = "vBCSTDest";
                vo1.ValorICMSSTDestino = "vICMSSTDest";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.Origem.Equals(ideNode["orig"].InnerText) &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.ValorBCICMSSTRetido.Equals(ideNode["vBCSTRet"].InnerText) &&
                                  vo1.ValorICMSSTRetido.Equals(ideNode["vICMSSTRet"].InnerText) &&
                                  vo1.ValorBCSTDestino.Equals(ideNode["vBCSTDest"].InnerText) &&
                                  vo1.ValorICMSSTDestino.Equals(ideNode["vICMSSTDest"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}