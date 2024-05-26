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
    public class IPITributadoXML_Teste
    {
        [TestMethod()]
        public void IPITributadoXML_ObterEntidade_Teste()
        {
            try
            {
                IPITributadoXML xml = new IPITributadoXML();
                IPITributadoVO vo1 = new IPITributadoVO();


                String strXml = "<IPITrib><CST>CST</CST><vBC>vBC</vBC><pIPI>pIPI</pIPI><qUnid>qUnid</qUnid><vUnid>vUnid</vUnid><vIPI>vIPI</vIPI></IPITrib>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = IPITributadoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.ValorBCIPI.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.AliquotaIPI.Equals(ideNode["pIPI"].InnerText) &&
                                  vo1.QuantidadeUnidade.Equals(ideNode["qUnid"].InnerText) &&
                                  vo1.ValorUidadeTributavel.Equals(ideNode["vUnid"].InnerText) &&
                                  vo1.ValorIPI.Equals(ideNode["vIPI"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void IPITributadoXML_ObterElementoXML_Teste()
        {
            try
            {
                IPITributadoXML xml = new IPITributadoXML();
                IPITributadoVO vo1 = new IPITributadoVO();

                vo1.CST = "CST";
                vo1.ValorBCIPI = "vBC";
                vo1.AliquotaIPI = "pIPI";
                vo1.QuantidadeUnidade = "qUnid";
                vo1.ValorUidadeTributavel = "vUnid";
                vo1.ValorIPI = "vIPI";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.CST.Equals(ideNode["CST"].InnerText) &&
                                  vo1.ValorBCIPI.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.AliquotaIPI.Equals(ideNode["pIPI"].InnerText) &&
                                  vo1.QuantidadeUnidade.Equals(ideNode["qUnid"].InnerText) &&
                                  vo1.ValorUidadeTributavel.Equals(ideNode["vUnid"].InnerText) &&
                                  vo1.ValorIPI.Equals(ideNode["vIPI"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}