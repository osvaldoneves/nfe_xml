using Microsoft.VisualStudio.TestTools.UnitTesting;
using OLNG.Bibliotecas.NFeLib.XML.ICMS;
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
    public class ICMSSN500XML_Teste
    {
        [TestMethod()]
        public void ICMSSN500XML_ObterEntidade_Teste()
        {
            try
            {
                ICMSSN500XML xml = new ICMSSN500XML();
                ICMSxxVO vo1 = null;


                String strXml = "<ICMSSN500><CST>00</CST><CSOSN>500</CSOSN><orig>orig</orig><modBC>modBC</modBC><modBCST>modBCST</modBCST><motDesICMS>motDesICMS</motDesICMS><pBCOp>pBCOp</pBCOp><vCredICMSSN>vCredICMSSN</vCredICMSSN><pCredSN>pCredSN</pCredSN><pDif>pDif</pDif><pICMS>pICMS</pICMS><pICMSST>pICMSST</pICMSST><pMVAST>pMVAST</pMVAST><pRedBC>pRedBC</pRedBC><pRedBCST>pRedBCST</pRedBCST><UFST>UFST</UFST><vBC>vBC</vBC><vBCST>vBCST</vBCST><vBCSTRet>vBCSTRet</vBCSTRet><vICMS>vICMS</vICMS><vICMSDeson>vICMSDeson</vICMSDeson><vICMSDif>vICMSDif</vICMSDif><vICMSOp>vICMSOp</vICMSOp><vICMSSTRet>vICMSSTRet</vICMSSTRet><vICMSST>vICMSST</vICMSST></ICMSSN500>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode node = doc.DocumentElement;
                vo1 = xml.ObterEntidade(node);

                Boolean retTest = FabricaICMS.ObterGrupo(vo1.TipoICMS).Nome.Equals(node.Name) &&
                                  vo1.CSOSN.Equals(node["CSOSN"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ValorBCICMSSTRetido.Equals(node["vBCSTRet"].InnerText) &&
                                  vo1.ValorICMSSTRetido.Equals(node["vICMSSTRet "].InnerText) &&
                                  FabricaICMS.ObterGrupo(vo1.TipoICMS).CamposNo.Count == 4;


            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMSSN500XML_ObterElementoXML_Teste()
        {
            try
            {
                ICMSSN500XML xml = new ICMSSN500XML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.CSOSN = "500";
                vo1.Origem = "orig";
                vo1.ValorBCICMSSTRetido = "vBCSTRet";
                vo1.ValorICMSSTRetido = "vICMSSTRet";

                XmlNode node = xml.ObterElementoXML(vo1);

                Boolean retTest = node.Name.Equals("ICMSSN500") &&
                                  vo1.CSOSN.Equals(node["CSOSN"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ValorBCICMSSTRetido.Equals(node["vBCSTRet"].InnerText) &&
                                  vo1.ValorICMSSTRetido.Equals(node["vICMSSTRet"].InnerText) &&
                                  node.ChildNodes.Count == 4;

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}