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
    public class ICMSParteXML_Teste
    {
        [TestMethod()]
        public void ICMSParteXML_ObterEntidade_Teste()
        {
            try
            {
                ICMSParteXML xml = new ICMSParteXML();
                ICMSxxVO vo1 = new ICMSxxVO();


                String strXml = "<ICMSPart><orig>orig</orig><CST>10</CST><modBC>modBC</modBC><vBC>vBC</vBC><pRedBC>pRedBC</pRedBC><pICMS>pICMS</pICMS><vICMS>vICMS</vICMS><modBCST>modBCST</modBCST><pMVAST>pMVAST</pMVAST><pRedBCST>pRedBCST</pRedBCST><vBCST>vBCST</vBCST><pICMSST>pICMSST</pICMSST><vICMSST>vICMSST</vICMSST><pBCOp>pBCOp</pBCOp><UFST>UFST</UFST></ICMSPart>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ICMSParteXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.Origem.Equals(ideNode["orig"].InnerText) &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.ModalidadeBC.Equals(ideNode["modBC"].InnerText) &&
                                  vo1.ValorBC.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.PercentualReducaoBC.Equals(ideNode["pRedBC"].InnerText) &&
                                  vo1.AliquotaICMS.Equals(ideNode["pICMS"].InnerText) &&
                                  vo1.ValorICMS.Equals(ideNode["vICMS"].InnerText) &&
                                  vo1.ModalidadeBCST.Equals(ideNode["modBCST"].InnerText) &&
                                  vo1.PercentualMargemValorAdicionadoST.Equals(ideNode["pMVAST"].InnerText) &&
                                  vo1.PercentualReducaoBCST.Equals(ideNode["pRedBCST"].InnerText) &&
                                  vo1.ValorBCST.Equals(ideNode["vBCST"].InnerText) &&
                                  vo1.PercentualICMSST.Equals(ideNode["pICMSST"].InnerText) &&
                                  vo1.ValorICMSST.Equals(ideNode["vICMSST"].InnerText) &&
                                  vo1.PercentualBCOperacaoPropria.Equals(ideNode["pBCOp"].InnerText) &&
                                  vo1.UFICMSSTDevido.Equals(ideNode["UFST"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMSParteXML_ObterElementoXML_Teste()
        {
            try
            {
                ICMSParteXML xml = new ICMSParteXML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.Origem = "orig";
                vo1.CST = "10";
                vo1.ModalidadeBC = "modBC";
                vo1.ValorBC = "vBC";
                vo1.PercentualReducaoBC = "pRedBC";
                vo1.AliquotaICMS = "pICMS";
                vo1.ValorICMS = "vICMS";
                vo1.ModalidadeBCST = "modBCST";
                vo1.PercentualMargemValorAdicionadoST = "pMVAST";
                vo1.PercentualReducaoBCST = "pRedBCST";
                vo1.ValorBCST = "vBCST";
                vo1.PercentualICMSST = "pICMSST";
                vo1.ValorICMSST = "vICMSST";
                vo1.PercentualBCOperacaoPropria = "pBCOp";
                vo1.UFICMSSTDevido = "UFST";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.Origem.Equals(ideNode["orig"].InnerText) &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.ModalidadeBC.Equals(ideNode["modBC"].InnerText) &&
                                  vo1.ValorBC.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.PercentualReducaoBC.Equals(ideNode["pRedBC"].InnerText) &&
                                  vo1.AliquotaICMS.Equals(ideNode["pICMS"].InnerText) &&
                                  vo1.ValorICMS.Equals(ideNode["vICMS"].InnerText) &&
                                  vo1.ModalidadeBCST.Equals(ideNode["modBCST"].InnerText) &&
                                  vo1.PercentualMargemValorAdicionadoST.Equals(ideNode["pMVAST"].InnerText) &&
                                  vo1.PercentualReducaoBCST.Equals(ideNode["pRedBCST"].InnerText) &&
                                  vo1.ValorBCST.Equals(ideNode["vBCST"].InnerText) &&
                                  vo1.PercentualICMSST.Equals(ideNode["pICMSST"].InnerText) &&
                                  vo1.ValorICMSST.Equals(ideNode["vICMSST"].InnerText) &&
                                  vo1.PercentualBCOperacaoPropria.Equals(ideNode["pBCOp"].InnerText) &&
                                  vo1.UFICMSSTDevido.Equals(ideNode["UFST"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}