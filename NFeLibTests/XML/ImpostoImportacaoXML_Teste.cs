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
    public class ImpostoImportacaoXML_Teste
    {
        [TestMethod()]
        public void ImpostoImportacaoXML_ObterEntidade_Teste()
        {
            try
            {
                ImpostoImportacaoXML xml = new ImpostoImportacaoXML();
                ImpostoImportacaoVO vo1 = new ImpostoImportacaoVO();


                String strXml = "<II><vBC>vBC</vBC><vDespAdu>vDespAdu</vDespAdu><vII>vII</vII><vIOF>vIOF</vIOF></II>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ImpostoImportacaoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.ValorBCImpostoImportacao.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.ValorDespesasAduaneiras.Equals(ideNode["vDespAdu"].InnerText) &&
                                  vo1.ValorImpostoImportacao.Equals(ideNode["vII"].InnerText) &&
                                  vo1.ValorIOF.Equals(ideNode["vIOF"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ImpostoImportacaoXML_ObterElementoXML_Teste()
        {
            try
            {
                ImpostoImportacaoXML xml = new ImpostoImportacaoXML();
                ImpostoImportacaoVO vo1 = new ImpostoImportacaoVO();

                vo1.ValorBCImpostoImportacao = "vBC";
                vo1.ValorDespesasAduaneiras = "vDespAdu";
                vo1.ValorImpostoImportacao = "vII";
                vo1.ValorIOF = "vIOF";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.ValorBCImpostoImportacao.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.ValorDespesasAduaneiras.Equals(ideNode["vDespAdu"].InnerText) &&
                                  vo1.ValorImpostoImportacao.Equals(ideNode["vII"].InnerText) &&
                                  vo1.ValorIOF.Equals(ideNode["vIOF"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}