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
    public class ICMS00XML_Teste
    {
        [TestMethod()]
        public void ICMS00XML_ObterEntidade_Teste()
        {
            try
            {
                ICMS00XML xml = new ICMS00XML();
                ICMSxxVO vo1 = null;


                String strXml = "<ICMS00><CST>00</CST><CSOSN>00</CSOSN><orig>orig</orig><modBC>modBC</modBC><modBCST>modBCST</modBCST><motDesICMS>motDesICMS</motDesICMS><pBCOp>pBCOp</pBCOp><vCredICMSSN>vCredICMSSN</vCredICMSSN><pCredSN>pCredSN</pCredSN><pDif>pDif</pDif><pICMS>pICMS</pICMS><pICMSST>pICMSST</pICMSST><pMVAST>pMVAST</pMVAST><pRedBC>pRedBC</pRedBC><pRedBCST>pRedBCST</pRedBCST><UFST>UFST</UFST><vBC>vBC</vBC><vBCST>vBCST</vBCST><vBCSTRet>vBCSTRet</vBCSTRet><vICMS>vICMS</vICMS><vICMSDeson>vICMSDeson</vICMSDeson><vICMSDif>vICMSDif</vICMSDif><vICMSOp>vICMSOp</vICMSOp><vICMSSTRet>vICMSSTRet</vICMSSTRet><vICMSST>vICMSST</vICMSST></ICMS00>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = FabricaICMS.ObterGrupo(vo1.TipoICMS).Nome.Equals(ideNode.Name) &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.Origem.Equals(ideNode["orig"].InnerText) &&
                                  vo1.ModalidadeBC.Equals(ideNode["modBC"].InnerText) &&
                                  vo1.ValorBC.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.AliquotaICMS.Equals(ideNode["pICMS"].InnerText) &&
                                  vo1.ValorICMS.Equals(ideNode["vICMS"].InnerText) &&
                                  FabricaICMS.ObterGrupo(vo1.TipoICMS).CamposNo.Count == 6;

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMS00XML_ObterElementoXML_Teste()
        {
            try
            {
                ICMS00XML xml = new ICMS00XML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.CST = "00";
                vo1.Origem = "orig";
                vo1.ModalidadeBC = "modBC";
                vo1.ValorBC = "vBC";
                vo1.AliquotaICMS = "pICMS";
                vo1.ValorICMS = "vICMS";


                XmlNode node = xml.ObterElementoXML(vo1);

                Boolean retTest = node.Name.Equals("ICMS00") &&
                                  vo1.CST.Equals(node["CST"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ValorBC.Equals(node["vBC"].InnerText) &&
                                  vo1.AliquotaICMS.Equals(node["pICMS"].InnerText) &&
                                  vo1.ValorICMS.Equals(node["vICMS"].InnerText) &&
                                  vo1.TipoICMS == TipoICMS.ICMS00 &&
                                  node.ChildNodes.Count == 6;

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}