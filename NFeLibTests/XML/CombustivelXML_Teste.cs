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
    public class CombustivelXML_Teste
    {
        [TestMethod()]
        public void CombustivelXML_ObterEntidade_Teste()
        {
            try
            {
                CombustivelXML xml = new CombustivelXML();
                CombustivelVO vo1 = new CombustivelVO();


                String strXml = "<comb><cProdANP>cProdANP</cProdANP><pMixGN>pMixGN</pMixGN><CODIF>CODIF</CODIF><qTemp>qTemp</qTemp><UFCons>UFCons</UFCons></comb>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = CombustivelXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.CodigoProdutoANP.Equals(ideNode["cProdANP"].InnerText) &&
                                  vo1.PercentualGasNaturalGLP.Equals(ideNode["pMixGN"].InnerText) &&
                                  vo1.CODIF.Equals(ideNode["CODIF"].InnerText) &&
                                  vo1.QuantidadeTemperaturaAmbiente.Equals(ideNode["qTemp"].InnerText) &&
                                  vo1.UFConsumo.Equals(ideNode["UFCons"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void CombustivelXML_ObterElementoXML_Teste()
        {
            try
            {
                CombustivelXML xml = new CombustivelXML();
                CombustivelVO vo1 = new CombustivelVO();

                vo1.CodigoProdutoANP = "cProdANP";
                vo1.PercentualGasNaturalGLP = "pMixGN";
                vo1.CODIF = "CODIF";
                vo1.QuantidadeTemperaturaAmbiente = "qTemp";
                vo1.UFConsumo = "UFCons";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.CodigoProdutoANP.Equals(ideNode["cProdANP"].InnerText) &&
                                  vo1.PercentualGasNaturalGLP.Equals(ideNode["pMixGN"].InnerText) &&
                                  vo1.CODIF.Equals(ideNode["CODIF"].InnerText) &&
                                  vo1.QuantidadeTemperaturaAmbiente.Equals(ideNode["qTemp"].InnerText) &&
                                  vo1.UFConsumo.Equals(ideNode["UFCons"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}