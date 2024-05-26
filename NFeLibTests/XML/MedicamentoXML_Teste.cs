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
    public class MedicamentoXML_Teste
    {
        [TestMethod()]
        public void MedicamentoXML_ObterEntidade_Teste()
        {
            try
            {
                MedicamentoXML xml = new MedicamentoXML();
                MedicamentoVO vo1 = new MedicamentoVO();


                String strXml = "<med><nLote>nLote</nLote><qLote>qLote</qLote><dFab>dFab</dFab><dVal>dVal</dVal><vPMC>vPMC</vPMC></med>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = MedicamentoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.NumeroLote.Equals(ideNode["nLote"].InnerText) &&
                                  vo1.QuantidadeLote.Equals(ideNode["qLote"].InnerText) &&
                                  vo1.DataFabricacao.Equals(ideNode["dFab"].InnerText) &&
                                  vo1.DataValidade.Equals(ideNode["dVal"].InnerText) &&
                                  vo1.PrecoMaximoConsumidor.Equals(ideNode["vPMC"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void MedicamentoXML_ObterElementoXML_Teste()
        {
            try
            {
                MedicamentoXML xml = new MedicamentoXML();
                MedicamentoVO vo1 = new MedicamentoVO();

                vo1.NumeroLote = "nLote";
                vo1.QuantidadeLote = "qLote";
                vo1.DataFabricacao = "dFab";
                vo1.DataValidade = "dVal";
                vo1.PrecoMaximoConsumidor = "vPMC";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.NumeroLote.Equals(ideNode["nLote"].InnerText) &&
                                  vo1.QuantidadeLote.Equals(ideNode["qLote"].InnerText) &&
                                  vo1.DataFabricacao.Equals(ideNode["dFab"].InnerText) &&
                                  vo1.DataValidade.Equals(ideNode["dVal"].InnerText) &&
                                  vo1.PrecoMaximoConsumidor.Equals(ideNode["vPMC"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}