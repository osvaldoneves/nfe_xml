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
    public class EmitenteXML_Teste
    {
        [TestMethod()]
        public void EmitenteXML_ObterEntidade_Teste()
        {
            try
            {
                EmitenteXML xml = new EmitenteXML();
                EmitenteVO vo1 = new EmitenteVO();


                String strXml = "<emit><CNPJ>CNPJ</CNPJ><CPF>CPF</CPF><xNome>xNome</xNome><xFant>xFant</xFant><IE>IE</IE><IEST>IEST</IEST><IM>IM</IM><CNAE>CNAE</CNAE><CRT>CRT</CRT></emit>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = EmitenteXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.CNPJ.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.CPF.Equals(ideNode["CPF"].InnerText) &&
                                  vo1.Nome.Equals(ideNode["xNome"].InnerText) &&
                                  vo1.NomeFantasia.Equals(ideNode["xFant"].InnerText) &&
                                  vo1.InscricaoEstadual.Equals(ideNode["IE"].InnerText) &&
                                  vo1.InscricaoEstadualST.Equals(ideNode["IEST"].InnerText) &&
                                  vo1.InscricaoMunicial.Equals(ideNode["IM"].InnerText) &&
                                  vo1.CNAE.Equals(ideNode["CNAE"].InnerText) &&
                                  vo1.CodRegimeTributario.Equals(ideNode["CRT"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void EmitenteXML_ObterElementoXML_Teste()
        {
            try
            {
                EmitenteXML xml = new EmitenteXML();
                EmitenteVO vo1 = new EmitenteVO();

                vo1.CNPJ = "CNPJ";
                vo1.CPF = "CPF  ";
                vo1.Nome = "xNome ";
                vo1.NomeFantasia = "xFant";
                vo1.InscricaoEstadual = "IE";
                vo1.InscricaoEstadualST = "IEST";
                vo1.InscricaoMunicial = "IM";
                vo1.CNAE = "CNAE";
                vo1.CodRegimeTributario = "CRT";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.CNPJ.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.CPF.Equals(ideNode["CPF"].InnerText) &&
                                  vo1.Nome.Equals(ideNode["xNome"].InnerText) &&
                                  vo1.NomeFantasia.Equals(ideNode["xFant"].InnerText) &&
                                  vo1.InscricaoEstadual.Equals(ideNode["IE"].InnerText) &&
                                  vo1.InscricaoEstadualST.Equals(ideNode["IEST"].InnerText) &&
                                  vo1.InscricaoMunicial.Equals(ideNode["IM"].InnerText) &&
                                  vo1.CNAE.Equals(ideNode["CNAE"].InnerText) &&
                                  vo1.CodRegimeTributario.Equals(ideNode["CRT"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}