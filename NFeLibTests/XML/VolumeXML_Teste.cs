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
    public class VolumeXML_Teste
    {
        [TestMethod()]
        public void VolumeXML_ObterEntidade_Teste()
        {
            try
            {
                VolumeXML xml = new VolumeXML();
                VolumeVO vo1 = new VolumeVO();


                String strXml = "<vol><qVol>qVol</qVol><esp>esp</esp><marca>marca</marca><nVol>nVol</nVol><pesoL>pesoL</pesoL><pesoB>pesoB</pesoB></vol>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = VolumeXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.QuantidadeVolumes.Equals(ideNode["qVol"].InnerText) &&
                                  vo1.EspecieVolumes.Equals(ideNode["esp"].InnerText) &&
                                  vo1.Marca.Equals(ideNode["marca"].InnerText) &&
                                  vo1.NumeracaoVolumes.Equals(ideNode["nVol"].InnerText) &&
                                  vo1.PesoLiquido.Equals(ideNode["pesoL"].InnerText) &&
                                  vo1.PesoBruto.Equals(ideNode["pesoB"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void VolumeXML_ObterElementoXML_Teste()
        {
            try
            {
                VolumeXML xml = new VolumeXML();
                VolumeVO vo1 = new VolumeVO();

                vo1.QuantidadeVolumes = "qVol";
                vo1.EspecieVolumes = "esp";
                vo1.Marca = "marca";
                vo1.NumeracaoVolumes = "nVol";
                vo1.PesoLiquido = "pesoL";
                vo1.PesoBruto = "pesoB";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.QuantidadeVolumes.Equals(ideNode["qVol"].InnerText) &&
                                  vo1.EspecieVolumes.Equals(ideNode["esp"].InnerText) &&
                                  vo1.Marca.Equals(ideNode["marca"].InnerText) &&
                                  vo1.NumeracaoVolumes.Equals(ideNode["nVol"].InnerText) &&
                                  vo1.PesoLiquido.Equals(ideNode["pesoL"].InnerText) &&
                                  vo1.PesoBruto.Equals(ideNode["pesoB"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}