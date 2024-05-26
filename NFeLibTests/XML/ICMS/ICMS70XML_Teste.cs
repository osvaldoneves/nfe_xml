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
    public class ICMS70XML_Teste
    {
        [TestMethod()]
        public void ICMS70XML_ObterEntidade_Teste()
        {
            try
            {
                ICMS70XML xml = new ICMS70XML();
                ICMSxxVO vo1 = null;


                String strXml = "<ICMS70><CST>70</CST><CSOSN>00</CSOSN><orig>orig</orig><modBC>modBC</modBC><modBCST>modBCST</modBCST><motDesICMS>motDesICMS</motDesICMS><pBCOp>pBCOp</pBCOp><vCredICMSSN>vCredICMSSN</vCredICMSSN><pCredSN>pCredSN</pCredSN><pDif>pDif</pDif><pICMS>pICMS</pICMS><pICMSST>pICMSST</pICMSST><pMVAST>pMVAST</pMVAST><pRedBC>pRedBC</pRedBC><pRedBCST>pRedBCST</pRedBCST><UFST>UFST</UFST><vBC>vBC</vBC><vBCST>vBCST</vBCST><vBCSTRet>vBCSTRet</vBCSTRet><vICMS>vICMS</vICMS><vICMSDeson>vICMSDeson</vICMSDeson><vICMSDif>vICMSDif</vICMSDif><vICMSOp>vICMSOp</vICMSOp><vICMSSTRet>vICMSSTRet</vICMSSTRet><vICMSST>vICMSST</vICMSST></ICMS70>";
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
                                  vo1.ValorICMS.Equals(node["vICMS"].InnerText) &&
                                  vo1.ModalidadeBCST.Equals(node["modBCST"].InnerText) &&
                                  vo1.PercentualMargemValorAdicionadoST.Equals(node["pMVAST"].InnerText) &&
                                  vo1.PercentualReducaoBCST.Equals(node["pRedBCST"].InnerText) &&
                                  vo1.ValorBCST.Equals(node["vBCST"].InnerText) &&
                                  vo1.PercentualICMSST.Equals(node["pICMSST"].InnerText) &&
                                  vo1.ValorICMSST.Equals(node["vICMSST"].InnerText) &&
                                  vo1.ValorICMSDesonerado.Equals(node["vICMSDeson"].InnerText) &&
                                  vo1.MotivoDesoneracaoICMS.Equals(node["motDesICMS"].InnerText) &&
                                  FabricaICMS.ObterGrupo(vo1.TipoICMS).CamposNo.Count == 15;


            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMS70XML_ObterElementoXML_Teste()
        {
            try
            {
                ICMS70XML xml = new ICMS70XML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.CST = "70";
                vo1.Origem = "orig";
                vo1.ModalidadeBC = "modBC";
                vo1.PercentualReducaoBC = "pRedBC";
                vo1.ValorBC = "vBC";
                vo1.AliquotaICMS = "pICMS";
                vo1.ValorICMS = "vICMS";
                vo1.ModalidadeBCST = "modBCST";
                vo1.PercentualMargemValorAdicionadoST = "pMVAST";
                vo1.PercentualReducaoBCST = "pRedBCST";
                vo1.ValorBCST = "vBCST";
                vo1.PercentualICMSST = "pICMSST";
                vo1.ValorICMSST = "vICMSST";
                vo1.ValorICMSDesonerado = "vICMSDeson";
                vo1.MotivoDesoneracaoICMS = "motDesICMS";

                XmlNode node = xml.ObterElementoXML(vo1);

                Boolean retTest = node.Name.Equals("ICMS70") &&
                                  vo1.CST.Equals(node["CST"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ModalidadeBC.Equals(node["modBC"].InnerText) &&
                                  vo1.PercentualReducaoBC.Equals(node["pRedBC"].InnerText) &&
                                  vo1.ValorBC.Equals(node["vBC"].InnerText) &&
                                  vo1.AliquotaICMS.Equals(node["pICMS"].InnerText) &&
                                  vo1.ValorICMS.Equals(node["vICMS"].InnerText) &&
                                  vo1.ModalidadeBCST.Equals(node["modBCST"].InnerText) &&
                                  vo1.PercentualMargemValorAdicionadoST.Equals(node["pMVAST"].InnerText) &&
                                  vo1.PercentualReducaoBCST.Equals(node["pRedBCST"].InnerText) &&
                                  vo1.ValorBCST.Equals(node["vBCST"].InnerText) &&
                                  vo1.PercentualICMSST.Equals(node["pICMSST"].InnerText) &&
                                  vo1.ValorICMSST.Equals(node["vICMSST"].InnerText) &&
                                  vo1.ValorICMSDesonerado.Equals(node["vICMSDeson"].InnerText) &&
                                  vo1.MotivoDesoneracaoICMS.Equals(node["motDesICMS"].InnerText) &&
                                  node.ChildNodes.Count == 15;

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}