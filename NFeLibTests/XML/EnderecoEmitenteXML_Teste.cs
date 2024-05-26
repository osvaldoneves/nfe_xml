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
    public class EnderecoEmitenteXML_Teste
    {
        [TestMethod()]
        public void EnderecoEmitenteXML_ObterEntidade_Teste()
        {
            try
            {
                EnderecoEmitenteXML xml = new EnderecoEmitenteXML();
                EnderecoVO vo1 = new EnderecoVO();


                String strXml = "<enderEmit><xLgr>xLgr</xLgr><nro>nro</nro><xCpl>xCpl</xCpl><xBairro>xBairro</xBairro><cMun>cMun</cMun><xMun>xMun</xMun><UF>UF</UF><CEP>CEP</CEP><cPais>cPais</cPais><xPais>xPais</xPais><fone>fone</fone></enderEmit>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = EnderecoEmitenteXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.Logradouro.Equals(ideNode["xLgr"].InnerText) &&
                                  vo1.Numero.Equals(ideNode["nro"].InnerText) &&
                                  vo1.Complemento.Equals(ideNode["xCpl"].InnerText) &&
                                  vo1.Bairro.Equals(ideNode["xBairro"].InnerText) &&
                                  vo1.CodigoMunicipio.Equals(ideNode["cMun"].InnerText) &&
                                  vo1.NomeMunicipio.Equals(ideNode["xMun"].InnerText) &&
                                  vo1.UF.Equals(ideNode["UF"].InnerText) &&
                                  vo1.CEP.Equals(ideNode["CEP"].InnerText) &&
                                  vo1.CodigoPais.Equals(ideNode["cPais"].InnerText) &&
                                  vo1.NomePais.Equals(ideNode["xPais"].InnerText) &&
                                  vo1.Telefone.Equals(ideNode["fone"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void EnderecoEmitenteXML_ObterElementoXML_Teste()
        {
            try
            {
                EnderecoEmitenteXML xml = new EnderecoEmitenteXML();
                EnderecoVO vo1 = new EnderecoVO();

                vo1.Logradouro = "xLgr";
                vo1.Numero = "nro";
                vo1.Complemento = "xCpl";
                vo1.Bairro = "xBairro";
                vo1.CodigoMunicipio = "cMun";
                vo1.NomeMunicipio = "xMun";
                vo1.UF = "UF";
                vo1.CEP = "CEP";
                vo1.CodigoPais = "cPais";
                vo1.NomePais = "xPais";
                vo1.Telefone = "fone";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.Logradouro.Equals(ideNode["xLgr"].InnerText) &&
                                  vo1.Numero.Equals(ideNode["nro"].InnerText) &&
                                  vo1.Complemento.Equals(ideNode["xCpl"].InnerText) &&
                                  vo1.Bairro.Equals(ideNode["xBairro"].InnerText) &&
                                  vo1.CodigoMunicipio.Equals(ideNode["cMun"].InnerText) &&
                                  vo1.NomeMunicipio.Equals(ideNode["xMun"].InnerText) &&
                                  vo1.UF.Equals(ideNode["UF"].InnerText) &&
                                  vo1.CEP.Equals(ideNode["CEP"].InnerText) &&
                                  vo1.CodigoPais.Equals(ideNode["cPais"].InnerText) &&
                                  vo1.NomePais.Equals(ideNode["xPais"].InnerText) &&
                                  vo1.Telefone.Equals(ideNode["fone"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}