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
    public class ICMSSN201XML_Teste
    {
        [TestMethod()]
        public void ICMSSN201XML_ObterEntidade_Teste()
        {
            try
            {
                ICMSSN201XML xml = new ICMSSN201XML();
                ICMSxxVO vo1 = null;


                String strXml = "<ICMSSN201><CST>00</CST><CSOSN>201</CSOSN><orig>orig</orig><modBC>modBC</modBC><modBCST>modBCST</modBCST><motDesICMS>motDesICMS</motDesICMS><pBCOp>pBCOp</pBCOp><vCredICMSSN>vCredICMSSN</vCredICMSSN><pCredSN>pCredSN</pCredSN><pDif>pDif</pDif><pICMS>pICMS</pICMS><pICMSST>pICMSST</pICMSST><pMVAST>pMVAST</pMVAST><pRedBC>pRedBC</pRedBC><pRedBCST>pRedBCST</pRedBCST><UFST>UFST</UFST><vBC>vBC</vBC><vBCST>vBCST</vBCST><vBCSTRet>vBCSTRet</vBCSTRet><vICMS>vICMS</vICMS><vICMSDeson>vICMSDeson</vICMSDeson><vICMSDif>vICMSDif</vICMSDif><vICMSOp>vICMSOp</vICMSOp><vICMSSTRet>vICMSSTRet</vICMSSTRet><vICMSST>vICMSST</vICMSST></ICMSSN201>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode node = doc.DocumentElement;
                vo1 = xml.ObterEntidade(node);

                Boolean retTest = FabricaICMS.ObterGrupo(vo1.TipoICMS).Nome.Equals(node.Name) &&
                                  vo1.CSOSN.Equals(node["CSOSN"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ModalidadeBCST.Equals(node["modBCST"].InnerText) &&
                                  vo1.PercentualMargemValorAdicionadoST.Equals(node["pMVAST"].InnerText) &&
                                  vo1.PercentualReducaoBCST.Equals(node["pRedBCST"].InnerText) &&
                                  vo1.ValorBCST.Equals(node["vBCST"].InnerText) &&
                                  vo1.PercentualICMSST.Equals(node["pICMSST"].InnerText) &&
                                  vo1.ValorICMSST.Equals(node["vICMSST"].InnerText) &&
                                  vo1.AliquotaCredito.Equals(node["pCredSN"].InnerText) &&
                                  vo1.ValorCreditoICMS.Equals(node["vCredICMSSN"].InnerText) &&
                                  FabricaICMS.ObterGrupo(vo1.TipoICMS).CamposNo.Count == 10;


            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMSSN201XML_ObterElementoXML_Teste()
        {
            try
            {
                ICMSSN201XML xml = new ICMSSN201XML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.CSOSN = "201";
                vo1.Origem = "orig";
                vo1.ModalidadeBCST = "modBCST";
                vo1.PercentualMargemValorAdicionadoST = "pMVAST";
                vo1.PercentualReducaoBCST = "pRedBCST";
                vo1.ValorBCST = "vBCST";
                vo1.PercentualICMSST = "pICMSST";
                vo1.ValorICMSST = "vICMSST";
                vo1.AliquotaCredito = "pCredSN";
                vo1.ValorCreditoICMS = "vCredICMSSN";

                XmlNode node = xml.ObterElementoXML(vo1);

                Boolean retTest = node.Name.Equals("ICMSSN201") &&
                                  vo1.CSOSN.Equals(node["CSOSN"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ModalidadeBCST.Equals(node["modBCST"].InnerText) &&
                                  vo1.PercentualMargemValorAdicionadoST.Equals(node["pMVAST"].InnerText) &&
                                  vo1.PercentualReducaoBCST.Equals(node["pRedBCST"].InnerText) &&
                                  vo1.ValorBCST.Equals(node["vBCST"].InnerText) &&
                                  vo1.PercentualICMSST.Equals(node["pICMSST"].InnerText) &&
                                  vo1.ValorICMSST.Equals(node["vICMSST"].InnerText) &&
                                  vo1.AliquotaCredito.Equals(node["pCredSN"].InnerText) &&
                                  vo1.ValorCreditoICMS.Equals(node["vCredICMSSN"].InnerText) &&
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