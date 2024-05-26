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
    public class TransportadoraXML_Teste
    {
        [TestMethod()]
        public void TransportadoraXML_ObterEntidade_Teste()
        {
            try
            {
                TransportadoraXML xml = new TransportadoraXML();
                TransportadoraVO vo1 = new TransportadoraVO();


                String strXml = "<transporta><CNPJ>CNPJ</CNPJ><CPF>CPF</CPF><xNome>xNome</xNome><IE>IE</IE><xEnder>xEnder</xEnder><xMun>xMun</xMun><UF>UF</UF></transporta>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = TransportadoraXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.CNPJ.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.CPF.Equals(ideNode["CPF"].InnerText) &&
                                  vo1.InscricaoEstadual.Equals(ideNode["IE"].InnerText) &&
                                  vo1.EnderecoCompleto.Equals(ideNode["xEnder"].InnerText) &&
                                  vo1.NomeMunicipio.Equals(ideNode["xMun"].InnerText) &&
                                  vo1.SiglaUF.Equals(ideNode["UF"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void TransportadoraXML_ObterElementoXML_Teste()
        {
            try
            {
                TransportadoraXML xml = new TransportadoraXML();
                TransportadoraVO vo1 = new TransportadoraVO();

                vo1.CNPJ = "CNPJ";
                vo1.CPF = "CPF";
                vo1.InscricaoEstadual = "IE";
                vo1.EnderecoCompleto = "xEnder";
                vo1.NomeMunicipio = "xMun";
                vo1.SiglaUF = "UF";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.CNPJ.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.CPF.Equals(ideNode["CPF"].InnerText) &&
                                  vo1.InscricaoEstadual.Equals(ideNode["IE"].InnerText) &&
                                  vo1.EnderecoCompleto.Equals(ideNode["xEnder"].InnerText) &&
                                  vo1.NomeMunicipio.Equals(ideNode["xMun"].InnerText) &&
                                  vo1.SiglaUF.Equals(ideNode["UF"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}