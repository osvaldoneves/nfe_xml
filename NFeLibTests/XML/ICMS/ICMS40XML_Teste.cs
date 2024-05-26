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
    public class ICMS40XML_Teste
    {
        #region CST40
        [TestMethod()]
        public void ICMS40XML_ObterEntidade_CST40_Teste()
        {
            try
            {
                ICMS40XML xml = new ICMS40XML();
                ICMSxxVO vo1 = null;


                String strXml = "<ICMS40><CST>40</CST><CSOSN>00</CSOSN><orig>orig</orig><modBC>modBC</modBC><modBCST>modBCST</modBCST><motDesICMS>motDesICMS</motDesICMS><pBCOp>pBCOp</pBCOp><vCredICMSSN>vCredICMSSN</vCredICMSSN><pCredSN>pCredSN</pCredSN><pDif>pDif</pDif><pICMS>pICMS</pICMS><pICMSST>pICMSST</pICMSST><pMVAST>pMVAST</pMVAST><pRedBC>pRedBC</pRedBC><pRedBCST>pRedBCST</pRedBCST><UFST>UFST</UFST><vBC>vBC</vBC><vBCST>vBCST</vBCST><vBCSTRet>vBCSTRet</vBCSTRet><vICMS>vICMS</vICMS><vICMSDeson>vICMSDeson</vICMSDeson><vICMSDif>vICMSDif</vICMSDif><vICMSOp>vICMSOp</vICMSOp><vICMSSTRet>vICMSSTRet</vICMSSTRet><vICMSST>vICMSST</vICMSST></ICMS40>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode node = doc.DocumentElement;
                vo1 = xml.ObterEntidade(node);

                Boolean retTest = FabricaICMS.ObterGrupo(vo1.TipoICMS).Nome.Equals(node.Name) &&
                                  vo1.CST.Equals(node["CST"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ValorICMSDesonerado.Equals(node["vICMSDeson"].InnerText) &&
                                  vo1.MotivoDesoneracaoICMS.Equals(node["motDesICMS"].InnerText) &&
                                  FabricaICMS.ObterGrupo(vo1.TipoICMS).CamposNo.Count == 4;


            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMS40XML_ObterElementoXML_CST40_Teste()
        {
            try
            {
                ICMS40XML xml = new ICMS40XML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.CST = "40";
                vo1.Origem = "orig";
                vo1.ValorICMSDesonerado = "vICMSDeson";
                vo1.MotivoDesoneracaoICMS = "motDesICMS";

                XmlNode node = xml.ObterElementoXML(vo1);

                Boolean retTest = node.Name.Equals("ICMS40") &&
                                  vo1.CST.Equals(node["CST"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ValorICMSDesonerado.Equals(node["vICMSDeson"].InnerText) &&
                                  vo1.MotivoDesoneracaoICMS.Equals(node["motDesICMS"].InnerText) &&
                                  node.ChildNodes.Count == 4;

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion CST40


        #region CST41
        [TestMethod()]
        public void ICMS40XML_ObterEntidade_CST41_Teste()
        {
            try
            {
                ICMS40XML xml = new ICMS40XML();
                ICMSxxVO vo1 = null;


                String strXml = "<ICMS40><CST>41</CST><CSOSN>00</CSOSN><orig>orig</orig><modBC>modBC</modBC><modBCST>modBCST</modBCST><motDesICMS>motDesICMS</motDesICMS><pBCOp>pBCOp</pBCOp><vCredICMSSN>vCredICMSSN</vCredICMSSN><pCredSN>pCredSN</pCredSN><pDif>pDif</pDif><pICMS>pICMS</pICMS><pICMSST>pICMSST</pICMSST><pMVAST>pMVAST</pMVAST><pRedBC>pRedBC</pRedBC><pRedBCST>pRedBCST</pRedBCST><UFST>UFST</UFST><vBC>vBC</vBC><vBCST>vBCST</vBCST><vBCSTRet>vBCSTRet</vBCSTRet><vICMS>vICMS</vICMS><vICMSDeson>vICMSDeson</vICMSDeson><vICMSDif>vICMSDif</vICMSDif><vICMSOp>vICMSOp</vICMSOp><vICMSSTRet>vICMSSTRet</vICMSSTRet><vICMSST>vICMSST</vICMSST></ICMS40>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode node = doc.DocumentElement;
                vo1 = xml.ObterEntidade(node);

                Boolean retTest = FabricaICMS.ObterGrupo(vo1.TipoICMS).Nome.Equals(node.Name) &&
                                  vo1.CST.Equals(node["CST"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ValorICMSDesonerado.Equals(node["vICMSDeson"].InnerText) &&
                                  vo1.MotivoDesoneracaoICMS.Equals(node["motDesICMS"].InnerText) &&
                                  FabricaICMS.ObterGrupo(vo1.TipoICMS).CamposNo.Count == 4;


            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMS40XML_ObterElementoXML_CST41_Teste()
        {
            try
            {
                ICMS40XML xml = new ICMS40XML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.CST = "41";
                vo1.Origem = "orig";
                vo1.ValorICMSDesonerado = "vICMSDeson";
                vo1.MotivoDesoneracaoICMS = "motDesICMS";

                XmlNode node = xml.ObterElementoXML(vo1);

                Boolean retTest = node.Name.Equals("ICMS40") &&
                                  vo1.CST.Equals(node["CST"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ValorICMSDesonerado.Equals(node["vICMSDeson"].InnerText) &&
                                  vo1.MotivoDesoneracaoICMS.Equals(node["motDesICMS"].InnerText) &&
                                  node.ChildNodes.Count == 4;

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion CST41


        #region CST50
        [TestMethod()]
        public void ICMS40XML_ObterEntidade_CST50_Teste()
        {
            try
            {
                ICMS40XML xml = new ICMS40XML();
                ICMSxxVO vo1 = null;


                String strXml = "<ICMS40><CST>50</CST><CSOSN>00</CSOSN><orig>orig</orig><modBC>modBC</modBC><modBCST>modBCST</modBCST><motDesICMS>motDesICMS</motDesICMS><pBCOp>pBCOp</pBCOp><vCredICMSSN>vCredICMSSN</vCredICMSSN><pCredSN>pCredSN</pCredSN><pDif>pDif</pDif><pICMS>pICMS</pICMS><pICMSST>pICMSST</pICMSST><pMVAST>pMVAST</pMVAST><pRedBC>pRedBC</pRedBC><pRedBCST>pRedBCST</pRedBCST><UFST>UFST</UFST><vBC>vBC</vBC><vBCST>vBCST</vBCST><vBCSTRet>vBCSTRet</vBCSTRet><vICMS>vICMS</vICMS><vICMSDeson>vICMSDeson</vICMSDeson><vICMSDif>vICMSDif</vICMSDif><vICMSOp>vICMSOp</vICMSOp><vICMSSTRet>vICMSSTRet</vICMSSTRet><vICMSST>vICMSST</vICMSST></ICMS40>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode node = doc.DocumentElement;
                vo1 = xml.ObterEntidade(node);

                Boolean retTest = FabricaICMS.ObterGrupo(vo1.TipoICMS).Nome.Equals(node.Name) &&
                                  vo1.CST.Equals(node["CST"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ValorICMSDesonerado.Equals(node["vICMSDeson"].InnerText) &&
                                  vo1.MotivoDesoneracaoICMS.Equals(node["motDesICMS"].InnerText) &&
                                  FabricaICMS.ObterGrupo(vo1.TipoICMS).CamposNo.Count == 4;


            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMS40XML_ObterElementoXML_CST50_Teste()
        {
            try
            {
                ICMS40XML xml = new ICMS40XML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.CST = "50";
                vo1.Origem = "orig";
                vo1.ValorICMSDesonerado = "vICMSDeson";
                vo1.MotivoDesoneracaoICMS = "motDesICMS";

                XmlNode node = xml.ObterElementoXML(vo1);

                Boolean retTest = node.Name.Equals("ICMS40") &&
                                  vo1.CST.Equals(node["CST"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  vo1.ValorICMSDesonerado.Equals(node["vICMSDeson"].InnerText) &&
                                  vo1.MotivoDesoneracaoICMS.Equals(node["motDesICMS"].InnerText) &&
                                  node.ChildNodes.Count == 4;

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion CST50
    }
}