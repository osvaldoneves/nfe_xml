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
    public class DestinatarioXML_Teste
    {
        [TestMethod()]
        public void DestinatarioXML_ObterEntidade_Teste()
        {
            try
            {
                DestinatarioXML xml = new DestinatarioXML();
                DestinatarioVO vo1 = new DestinatarioVO();


                String strXml = "<dest><CNPJ>CNPJ</CNPJ><CPF>CPF</CPF><idEstrangeiro>idEstrangeiro</idEstrangeiro><xNome>xNome</xNome><indIEDest>indIEDest</indIEDest><IE>IE</IE><ISUF>ISUF</ISUF><IM>IM</IM><email>email</email></dest>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = DestinatarioXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.CNPJ.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.CPF.Equals(ideNode["CPF"].InnerText) &&
                                  vo1.IdEstrangeiro.Equals(ideNode["idEstrangeiro"].InnerText) &&
                                  vo1.Nome.Equals(ideNode["xNome"].InnerText) &&
                                  vo1.IndIEDestinatario.Equals(ideNode["indIEDest"].InnerText) &&
                                  vo1.InscricaoEstadual.Equals(ideNode["IE"].InnerText) &&
                                  vo1.InscricaoSUFRAMA.Equals(ideNode["ISUF"].InnerText) &&
                                  vo1.InscricaoMunicipal.Equals(ideNode["IM"].InnerText) &&
                                  vo1.eMail.Equals(ideNode["email"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void DestinatarioXML_ObterElementoXML_Teste()
        {
            try
            {
                DestinatarioXML xml = new DestinatarioXML();
                DestinatarioVO vo1 = new DestinatarioVO();

                vo1.CNPJ = "CNPJ";
                vo1.CPF = "CPF";
                vo1.IdEstrangeiro = "idEstrangeiro";
                vo1.Nome = "xNome";
                vo1.IndIEDestinatario = "indIEDest";
                vo1.InscricaoEstadual = "IE";
                vo1.InscricaoSUFRAMA = "ISUF";
                vo1.InscricaoMunicipal = "IM";
                vo1.eMail = "email";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.CNPJ.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.CPF.Equals(ideNode["CPF"].InnerText) &&
                                  vo1.IdEstrangeiro.Equals(ideNode["idEstrangeiro"].InnerText) &&
                                  vo1.Nome.Equals(ideNode["xNome"].InnerText) &&
                                  vo1.IndIEDestinatario.Equals(ideNode["indIEDest"].InnerText) &&
                                  vo1.InscricaoEstadual.Equals(ideNode["IE"].InnerText) &&
                                  vo1.InscricaoSUFRAMA.Equals(ideNode["ISUF"].InnerText) &&
                                  vo1.InscricaoMunicipal.Equals(ideNode["IM"].InnerText) &&
                                  vo1.eMail.Equals(ideNode["email"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}