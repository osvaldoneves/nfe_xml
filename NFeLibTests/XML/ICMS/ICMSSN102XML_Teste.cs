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
    public class ICMSSN102XML_Teste
    {

        #region CSOSN102
        [TestMethod()]
        public void ICMSSN102XML_ObterEntidade_CSOSN102_Teste()
        {
            try
            {
                ICMSSN102XML xml = new ICMSSN102XML();
                ICMSxxVO vo1 = null;


                String strXml = "<ICMSSN102><CST>00</CST><CSOSN>102</CSOSN><orig>orig</orig><modBC>modBC</modBC><modBCST>modBCST</modBCST><motDesICMS>motDesICMS</motDesICMS><pBCOp>pBCOp</pBCOp><vCredICMSSN>vCredICMSSN</vCredICMSSN><pCredSN>pCredSN</pCredSN><pDif>pDif</pDif><pICMS>pICMS</pICMS><pICMSST>pICMSST</pICMSST><pMVAST>pMVAST</pMVAST><pRedBC>pRedBC</pRedBC><pRedBCST>pRedBCST</pRedBCST><UFST>UFST</UFST><vBC>vBC</vBC><vBCST>vBCST</vBCST><vBCSTRet>vBCSTRet</vBCSTRet><vICMS>vICMS</vICMS><vICMSDeson>vICMSDeson</vICMSDeson><vICMSDif>vICMSDif</vICMSDif><vICMSOp>vICMSOp</vICMSOp><vICMSSTRet>vICMSSTRet</vICMSSTRet><vICMSST>vICMSST</vICMSST></ICMSSN102>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode node = doc.DocumentElement;
                vo1 = xml.ObterEntidade(node);

                Boolean retTest = FabricaICMS.ObterGrupo(vo1.TipoICMS).Nome.Equals(node.Name) &&
                                  vo1.CSOSN.Equals(node["CSOSN"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  FabricaICMS.ObterGrupo(vo1.TipoICMS).CamposNo.Count == 2;


            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMSSN102XML_ObterElementoXML_CSOSN102_Teste()
        {
            try
            {
                ICMSSN102XML xml = new ICMSSN102XML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.CSOSN = "102";
                vo1.Origem = "orig";
                
                XmlNode node = xml.ObterElementoXML(vo1);

                Boolean retTest = node.Name.Equals("ICMSSN102") &&
                                  vo1.CSOSN.Equals(node["CSOSN"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  node.ChildNodes.Count == 2;

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion CSOSN102


        #region CSOSN103
        [TestMethod()]
        public void ICMSSN102XML_ObterEntidade_CSOSN103_Teste()
        {
            try
            {
                ICMSSN102XML xml = new ICMSSN102XML();
                ICMSxxVO vo1 = null;


                String strXml = "<ICMSSN102><CST>00</CST><CSOSN>103</CSOSN><orig>orig</orig><modBC>modBC</modBC><modBCST>modBCST</modBCST><motDesICMS>motDesICMS</motDesICMS><pBCOp>pBCOp</pBCOp><vCredICMSSN>vCredICMSSN</vCredICMSSN><pCredSN>pCredSN</pCredSN><pDif>pDif</pDif><pICMS>pICMS</pICMS><pICMSST>pICMSST</pICMSST><pMVAST>pMVAST</pMVAST><pRedBC>pRedBC</pRedBC><pRedBCST>pRedBCST</pRedBCST><UFST>UFST</UFST><vBC>vBC</vBC><vBCST>vBCST</vBCST><vBCSTRet>vBCSTRet</vBCSTRet><vICMS>vICMS</vICMS><vICMSDeson>vICMSDeson</vICMSDeson><vICMSDif>vICMSDif</vICMSDif><vICMSOp>vICMSOp</vICMSOp><vICMSSTRet>vICMSSTRet</vICMSSTRet><vICMSST>vICMSST</vICMSST></ICMSSN102>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode node = doc.DocumentElement;
                vo1 = xml.ObterEntidade(node);

                Boolean retTest = FabricaICMS.ObterGrupo(vo1.TipoICMS).Nome.Equals(node.Name) &&
                                  vo1.CSOSN.Equals(node["CSOSN"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  FabricaICMS.ObterGrupo(vo1.TipoICMS).CamposNo.Count == 2;


            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMSSN102XML_ObterElementoXML_CSOSN103_Teste()
        {
            try
            {
                ICMSSN102XML xml = new ICMSSN102XML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.CSOSN = "103";
                vo1.Origem = "orig";

                XmlNode node = xml.ObterElementoXML(vo1);

                Boolean retTest = node.Name.Equals("ICMSSN102") &&
                                  vo1.CSOSN.Equals(node["CSOSN"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  node.ChildNodes.Count == 2;

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion CSOSN103


        #region CSOSN300
        [TestMethod()]
        public void ICMSSN102XML_ObterEntidade_CSOSN300_Teste()
        {
            try
            {
                ICMSSN102XML xml = new ICMSSN102XML();
                ICMSxxVO vo1 = null;


                String strXml = "<ICMSSN102><CST>00</CST><CSOSN>300</CSOSN><orig>orig</orig><modBC>modBC</modBC><modBCST>modBCST</modBCST><motDesICMS>motDesICMS</motDesICMS><pBCOp>pBCOp</pBCOp><vCredICMSSN>vCredICMSSN</vCredICMSSN><pCredSN>pCredSN</pCredSN><pDif>pDif</pDif><pICMS>pICMS</pICMS><pICMSST>pICMSST</pICMSST><pMVAST>pMVAST</pMVAST><pRedBC>pRedBC</pRedBC><pRedBCST>pRedBCST</pRedBCST><UFST>UFST</UFST><vBC>vBC</vBC><vBCST>vBCST</vBCST><vBCSTRet>vBCSTRet</vBCSTRet><vICMS>vICMS</vICMS><vICMSDeson>vICMSDeson</vICMSDeson><vICMSDif>vICMSDif</vICMSDif><vICMSOp>vICMSOp</vICMSOp><vICMSSTRet>vICMSSTRet</vICMSSTRet><vICMSST>vICMSST</vICMSST></ICMSSN102>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode node = doc.DocumentElement;
                vo1 = xml.ObterEntidade(node);

                Boolean retTest = FabricaICMS.ObterGrupo(vo1.TipoICMS).Nome.Equals(node.Name) &&
                                  vo1.CSOSN.Equals(node["CSOSN"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  FabricaICMS.ObterGrupo(vo1.TipoICMS).CamposNo.Count == 2;


            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMSSN102XML_ObterElementoXML_CSOSN300_Teste()
        {
            try
            {
                ICMSSN102XML xml = new ICMSSN102XML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.CSOSN = "300";
                vo1.Origem = "orig";

                XmlNode node = xml.ObterElementoXML(vo1);

                Boolean retTest = node.Name.Equals("ICMSSN102") &&
                                  vo1.CSOSN.Equals(node["CSOSN"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  node.ChildNodes.Count == 2;

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion CSOSN300


        #region CSOSN400
        [TestMethod()]
        public void ICMSSN102XML_ObterEntidade_CSOSN400_Teste()
        {
            try
            {
                ICMSSN102XML xml = new ICMSSN102XML();
                ICMSxxVO vo1 = null;


                String strXml = "<ICMSSN102><CST>00</CST><CSOSN>400</CSOSN><orig>orig</orig><modBC>modBC</modBC><modBCST>modBCST</modBCST><motDesICMS>motDesICMS</motDesICMS><pBCOp>pBCOp</pBCOp><vCredICMSSN>vCredICMSSN</vCredICMSSN><pCredSN>pCredSN</pCredSN><pDif>pDif</pDif><pICMS>pICMS</pICMS><pICMSST>pICMSST</pICMSST><pMVAST>pMVAST</pMVAST><pRedBC>pRedBC</pRedBC><pRedBCST>pRedBCST</pRedBCST><UFST>UFST</UFST><vBC>vBC</vBC><vBCST>vBCST</vBCST><vBCSTRet>vBCSTRet</vBCSTRet><vICMS>vICMS</vICMS><vICMSDeson>vICMSDeson</vICMSDeson><vICMSDif>vICMSDif</vICMSDif><vICMSOp>vICMSOp</vICMSOp><vICMSSTRet>vICMSSTRet</vICMSSTRet><vICMSST>vICMSST</vICMSST></ICMSSN102>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode node = doc.DocumentElement;
                vo1 = xml.ObterEntidade(node);

                Boolean retTest = FabricaICMS.ObterGrupo(vo1.TipoICMS).Nome.Equals(node.Name) &&
                                  vo1.CSOSN.Equals(node["CSOSN"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  FabricaICMS.ObterGrupo(vo1.TipoICMS).CamposNo.Count == 2;


            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ICMSSN102XML_ObterElementoXML_CSOSN400_Teste()
        {
            try
            {
                ICMSSN102XML xml = new ICMSSN102XML();
                ICMSxxVO vo1 = new ICMSxxVO();

                vo1.CSOSN = "400";
                vo1.Origem = "orig";

                XmlNode node = xml.ObterElementoXML(vo1);

                Boolean retTest = node.Name.Equals("ICMSSN102") &&
                                  vo1.CSOSN.Equals(node["CSOSN"].InnerText) &&
                                  vo1.Origem.Equals(node["orig"].InnerText) &&
                                  node.ChildNodes.Count == 2;

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion CSOSN400
    }
}