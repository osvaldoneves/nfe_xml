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
    public class ArmamentoXML_Teste
    {
        [TestMethod()]
        public void ArmamentoXML_ObterEntidade_Teste()
        {
            try
            {
                ArmamentoXML xml = new ArmamentoXML();
                ArmamentoVO vo1 = new ArmamentoVO();


                String strXml = "<arma><tpArma>tpArma</tpArma><nSerie>nSerie</nSerie><nCano>nCano</nCano><descr>descr</descr></arma>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                //XmlNode ideNode = doc.SelectSingleNode("//ide");
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = vo1.TipoArma.Equals(ideNode["tpArma"].InnerText) &&
                                  vo1.NumeroSerieArma.Equals(ideNode["nSerie"].InnerText) &&
                                  vo1.NumeroSerieCano.Equals(ideNode["nCano"].InnerText) &&
                                  vo1.Descricao.Equals(ideNode["descr"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ArmamentoXML_ObterElementoXML_Teste()
        {
            try
            {
                ArmamentoXML xml = new ArmamentoXML();
                ArmamentoVO vo1 = new ArmamentoVO();

                vo1.TipoArma = "tpArma";
                vo1.NumeroSerieArma = "nSerie";
                vo1.NumeroSerieCano = "nCano";
                vo1.Descricao = "descr";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.TipoArma.Equals(ideNode["tpArma"].InnerText) &&
                                  vo1.NumeroSerieArma.Equals(ideNode["nSerie"].InnerText) &&
                                  vo1.NumeroSerieCano.Equals(ideNode["nCano"].InnerText) &&
                                  vo1.Descricao.Equals(ideNode["descr"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}