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
    public class FornecimentoDiarioCanaXML_Teste
    {
        [TestMethod()]
        public void FornecimentoDiarioCanaXML_ObterEntidade_Teste()
        {
            try
            {
                FornecimentoDiarioCanaXML xml = new FornecimentoDiarioCanaXML();
                FornecimentoDiarioCanaVO vo1 = new FornecimentoDiarioCanaVO();


                String strXml = "<forDia><dia>dia</dia><qtde>qtde</qtde><qTotMes>qTotMes</qTotMes><qTotAnt>qTotAnt</qTotAnt><qTotGer>qTotGer</qTotGer></forDia>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = FornecimentoDiarioCanaXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.Dia.Equals(ideNode["dia"].InnerText) &&
                                  vo1.Quantidade.Equals(ideNode["qtde"].InnerText) &&
                                  vo1.QuantidadeTotalMes.Equals(ideNode["qTotMes"].InnerText) &&
                                  vo1.QuantidadeTotalAnterior.Equals(ideNode["qTotAnt"].InnerText) &&
                                  vo1.QuantidadeTotalGeral.Equals(ideNode["qTotGer"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void FornecimentoDiarioCanaXML_ObterElementoXML_Teste()
        {
            try
            {
                FornecimentoDiarioCanaXML xml = new FornecimentoDiarioCanaXML();
                FornecimentoDiarioCanaVO vo1 = new FornecimentoDiarioCanaVO();

                vo1.Dia = "dia";
                vo1.Quantidade = "qtde";
                vo1.QuantidadeTotalMes = "qTotMes";
                vo1.QuantidadeTotalAnterior = "qTotAnt";
                vo1.QuantidadeTotalGeral = "qTotGer";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.Dia.Equals(ideNode["dia"].InnerText) &&
                                  vo1.Quantidade.Equals(ideNode["qtde"].InnerText) &&
                                  vo1.QuantidadeTotalMes.Equals(ideNode["qTotMes"].InnerText) &&
                                  vo1.QuantidadeTotalAnterior.Equals(ideNode["qTotAnt"].InnerText) &&
                                  vo1.QuantidadeTotalGeral.Equals(ideNode["qTotGer"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}