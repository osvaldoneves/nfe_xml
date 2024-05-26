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
    public class ProdutoXML_Teste
    {
        [TestMethod()]
        public void ProdutoXML_ObterEntidade_Teste()
        {
            try
            {
                ProdutoXML xml = new ProdutoXML();
                ProdutoVO vo1 = new ProdutoVO();

                String strXml = "<prod><cProd>cProd</cProd><cEAN>cEAN</cEAN><xProd>xProd</xProd><NCM>NCM</NCM><NVE>NVE1</NVE><NVE>NVE2</NVE><EXTIPI>EXTIPI</EXTIPI><CFOP>CFOP</CFOP><uCom>uCom</uCom><qCom>qCom</qCom><vUnCom>vUnCom</vUnCom><vProd>vProd</vProd><cEANTrib>cEANTrib</cEANTrib><uTrib>uTrib</uTrib><qTrib>qTrib</qTrib><vUnTrib>vUnTrib</vUnTrib><vFrete>vFrete</vFrete><vSeg>vSeg</vSeg><vDesc>vDesc</vDesc><vOutro>vOutro</vOutro><indTot>indTot</indTot></prod>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                XmlNodeList listNVE = ideNode.SelectNodes("//prod/NVE");

                Boolean retTest = ProdutoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.CodigoProduto.Equals(ideNode["cProd"].InnerText) &&
                                  vo1.CodigoEAN.Equals(ideNode["cEAN"].InnerText) &&
                                  vo1.DescricaoProduto.Equals(ideNode["xProd"].InnerText) &&
                                  vo1.NCM.Equals(ideNode["NCM"].InnerText) &&
                                  vo1.NVE.Count == listNVE.Count &&
                                  vo1.EXTIPI.Equals(ideNode["EXTIPI"].InnerText) &&
                                  vo1.CFOP.Equals(ideNode["CFOP"].InnerText) &&
                                  vo1.UnidadeComercial.Equals(ideNode["uCom"].InnerText) &&
                                  vo1.QuantidadeComercial.Equals(ideNode["qCom"].InnerText) &&
                                  vo1.ValorUnitarioComercializacao.Equals(ideNode["vUnCom"].InnerText) &&
                                  vo1.ValorTotalBruto.Equals(ideNode["vProd"].InnerText) &&
                                  vo1.CodigoEANTributavel.Equals(ideNode["cEANTrib"].InnerText) &&
                                  vo1.UnidadeTributavel.Equals(ideNode["uTrib"].InnerText) &&
                                  vo1.QuantidadeTributavel.Equals(ideNode["qTrib"].InnerText) &&
                                  vo1.ValorUnitarioTributacao.Equals(ideNode["vUnTrib"].InnerText) &&
                                  vo1.ValorFrete.Equals(ideNode["vFrete"].InnerText) &&
                                  vo1.ValorSeguro.Equals(ideNode["vSeg"].InnerText) &&
                                  vo1.ValorDesconto.Equals(ideNode["vDesc"].InnerText) &&
                                  vo1.OutrasDespesas.Equals(ideNode["vOutro"].InnerText) &&
                                  vo1.IndicadorValorTotal.Equals(ideNode["indTot"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ProdutoXML_ObterElementoXML_Teste()
        {
            try
            {
                ProdutoXML xml = new ProdutoXML();
                ProdutoVO vo1 = new ProdutoVO();

                vo1.CodigoProduto = "cProd";
                vo1.CodigoEAN = "cEAN";
                vo1.DescricaoProduto = "xProd";
                vo1.NCM = "NCM";

                List<String> listNVE = new List<String>();
                listNVE.Add("NVE1");
                listNVE.Add("NVE2");
                vo1.NVE = listNVE;

                vo1.EXTIPI = "EXTIPI";
                vo1.CFOP = "CFOP";
                vo1.UnidadeComercial = "uCom";
                vo1.QuantidadeComercial = "qCom";
                vo1.ValorUnitarioComercializacao = "vUnCom";
                vo1.ValorTotalBruto = "vProd";
                vo1.CodigoEANTributavel = "cEANTrib";
                vo1.UnidadeTributavel = "uTrib";
                vo1.QuantidadeTributavel = "qTrib";
                vo1.ValorUnitarioTributacao = "vUnTrib";
                vo1.ValorFrete = "vFrete";
                vo1.ValorSeguro = "vSeg";
                vo1.ValorDesconto = "vDesc";
                vo1.OutrasDespesas = "vOutro";
                vo1.IndicadorValorTotal = "indTot";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                XmlNodeList listNodeNVE = ideNode.SelectNodes("//NVE");

                Boolean retTest = vo1.CodigoProduto.Equals(ideNode["cProd"].InnerText) &&
                                  vo1.CodigoEAN.Equals(ideNode["cEAN"].InnerText) &&
                                  vo1.DescricaoProduto.Equals(ideNode["xProd"].InnerText) &&
                                  vo1.NCM.Equals(ideNode["NCM"].InnerText) &&
                                  vo1.NVE.Count == listNodeNVE.Count &&
                                  vo1.EXTIPI.Equals(ideNode["EXTIPI"].InnerText) &&
                                  vo1.CFOP.Equals(ideNode["CFOP"].InnerText) &&
                                  vo1.UnidadeComercial.Equals(ideNode["uCom"].InnerText) &&
                                  vo1.QuantidadeComercial.Equals(ideNode["qCom"].InnerText) &&
                                  vo1.ValorUnitarioComercializacao.Equals(ideNode["vUnCom"].InnerText) &&
                                  vo1.ValorTotalBruto.Equals(ideNode["vProd"].InnerText) &&
                                  vo1.CodigoEANTributavel.Equals(ideNode["cEANTrib"].InnerText) &&
                                  vo1.UnidadeTributavel.Equals(ideNode["uTrib"].InnerText) &&
                                  vo1.QuantidadeTributavel.Equals(ideNode["qTrib"].InnerText) &&
                                  vo1.ValorUnitarioTributacao.Equals(ideNode["vUnTrib"].InnerText) &&
                                  vo1.ValorFrete.Equals(ideNode["vFrete"].InnerText) &&
                                  vo1.ValorSeguro.Equals(ideNode["vSeg"].InnerText) &&
                                  vo1.ValorDesconto.Equals(ideNode["vDesc"].InnerText) &&
                                  vo1.OutrasDespesas.Equals(ideNode["vOutro"].InnerText) &&
                                  vo1.IndicadorValorTotal.Equals(ideNode["indTot"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}