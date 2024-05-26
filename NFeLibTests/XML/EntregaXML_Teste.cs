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
    public class EntregaXML_Teste
    {
        [TestMethod()]
        public void EntregaXML_ObterEntidade_Teste()
        {
            try
            {
                EntregaXML xml = new EntregaXML();
                EntregaVO vo1 = new EntregaVO();


                String strXml = "<entrega><CNPJ>CNPJ</CNPJ><CPF>CPF</CPF><xLgr>xLgr</xLgr><nro>nro</nro><xCpl>xCpl</xCpl><xBairro>xBairro</xBairro><cMun>cMun</cMun><xMun>xMun</xMun><UF>UF</UF></entrega>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = EntregaXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.CNPJ.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.CPF.Equals(ideNode["CPF"].InnerText) &&
                                  vo1.Logradouro.Equals(ideNode["xLgr"].InnerText) &&
                                  vo1.Numero.Equals(ideNode["nro"].InnerText) &&
                                  vo1.Complemento.Equals(ideNode["xCpl"].InnerText) &&
                                  vo1.Bairro.Equals(ideNode["xBairro"].InnerText) &&
                                  vo1.CodigoMunicipio.Equals(ideNode["cMun"].InnerText) &&
                                  vo1.NomeMunicipio.Equals(ideNode["xMun"].InnerText) &&
                                  vo1.UF.Equals(ideNode["UF"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void EntregaXML_ObterElementoXML_Teste()
        {
            try
            {
                EntregaXML xml = new EntregaXML();
                EntregaVO vo1 = new EntregaVO();

                vo1.CNPJ = "CNPF";
                vo1.CPF = "CPF";
                vo1.Logradouro = "xLgr";
                vo1.Numero = "nro";
                vo1.Complemento = "xCpl";
                vo1.Bairro = "xBairro";
                vo1.CodigoMunicipio = "cMun";
                vo1.NomeMunicipio = "xMun";
                vo1.UF = "UF";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.CNPJ.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.CPF.Equals(ideNode["CPF"].InnerText) &&
                                  vo1.Logradouro.Equals(ideNode["xLgr"].InnerText) &&
                                  vo1.Numero.Equals(ideNode["nro"].InnerText) &&
                                  vo1.Complemento.Equals(ideNode["xCpl"].InnerText) &&
                                  vo1.Bairro.Equals(ideNode["xBairro"].InnerText) &&
                                  vo1.CodigoMunicipio.Equals(ideNode["cMun"].InnerText) &&
                                  vo1.NomeMunicipio.Equals(ideNode["xMun"].InnerText) &&
                                  vo1.UF.Equals(ideNode["UF"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}