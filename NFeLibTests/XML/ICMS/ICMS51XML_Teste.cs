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
    public class ICMS51XML_Teste
    {
        [TestMethod()]
        public void ICMS51XML_ObterEntidade_Teste()
        {
            try
            {
                ICMS51XML xml = new ICMS51XML();
                ICMSxxVO vo1 = null;


                String strXml = "<ICMS51><CST>51</CST><CSOSN>00</CSOSN><orig>orig</orig><modBC>modBC</modBC><modBCST>modBCST</modBCST><motDesICMS>motDesICMS</motDesICMS><pBCOp>pBCOp</pBCOp><vCredICMSSN>vCredICMSSN</vCredICMSSN><pCredSN>pCredSN</pCredSN><pDif>pDif</pDif><pICMS>pICMS</pICMS><pICMSST>pICMSST</pICMSST><pMVAST>pMVAST</pMVAST><pRedBC>pRedBC</pRedBC><pRedBCST>pRedBCST</pRedBCST><UFST>UFST</UFST><vBC>vBC</vBC><vBCST>vBCST</vBCST><vBCSTRet>vBCSTRet</vBCSTRet><vICMS>vICMS</vICMS><vICMSDeson>vICMSDeson</vICMSDeson><vICMSDif>vICMSDif</vICMSDif><vICMSOp>vICMSOp</vICMSOp><vICMSSTRet>vICMSSTRet</vICMSSTRet><vICMSST>vICMSST</vICMSST></ICMS51>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode node = doc.DocumentElement;
                vo1 = xml.ObterEntidade(node);

                Boolean retTest = FabricaICMS.ObterGrupo(vo1.TipoICMS).Nome.Equals(node.Name) &&
                                  vo1.CST.Equals(node["CST"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ModalidadeBC.Equals(node["modBC"].InnerText) &&
                                  vo1.PercentualReducaoBC.Equals(node["pRedBC"].InnerText) &&
                                  vo1.ValorBC.Equals(node["vBC"].InnerText) &&
                                  vo1.AliquotaICMS.Equals(node["pICMS"].InnerText) &&
                                  vo1.ValorICMSOperacao.Equals(node["vICMSOp"].InnerText) &&
                                  vo1.PercentualDeferimento.Equals(node["pDif"].InnerText) &&
                                  vo1.ValorICMSDeferido.Equals(node["vICMSDif"].InnerText) &&
                                  vo1.ValorICMS.Equals(node["vICMS"].InnerText) &&
                                  FabricaICMS.ObterGrupo(vo1.TipoICMS).CamposNo.Count == 10;


            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMS51XML_ObterElementoXML_Teste()
        {
            try
            {
                ICMS51XML xml = new ICMS51XML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.CST = "51";
                vo1.Origem = "orig";
                vo1.ModalidadeBC = "modBC";
                vo1.PercentualReducaoBC = "pRedBC";
                vo1.ValorBC = "vBC";
                vo1.AliquotaICMS = "pICMS";
                vo1.ValorICMSOperacao = "vICMSOp";
                vo1.PercentualDeferimento = "pDif";
                vo1.ValorICMSDeferido = "vICMSDif";
                vo1.ValorICMS = "vICMS";

                XmlNode node = xml.ObterElementoXML(vo1);

                Boolean retTest = node.Name.Equals("ICMS51") &&
                                  vo1.CST.Equals(node["CST"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ModalidadeBC.Equals(node["modBC"].InnerText) &&
                                  vo1.PercentualReducaoBC.Equals(node["pRedBC"].InnerText) &&
                                  vo1.ValorBC.Equals(node["vBC"].InnerText) &&
                                  vo1.AliquotaICMS.Equals(node["pICMS"].InnerText) &&
                                  vo1.ValorICMSOperacao.Equals(node["vICMSOp"].InnerText) &&
                                  vo1.PercentualDeferimento.Equals(node["pDif"].InnerText) &&
                                  vo1.ValorICMSDeferido.Equals(node["vICMSDif"].InnerText) &&
                                  vo1.ValorICMS.Equals(node["vICMS"].InnerText) &&
                                  node.ChildNodes.Count == 10;

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}