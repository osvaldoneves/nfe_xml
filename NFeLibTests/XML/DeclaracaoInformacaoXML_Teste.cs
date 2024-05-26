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
    public class DeclaracaoImportacaoXML_Teste
    {
        [TestMethod()]
        public void DeclaracaoImportacaoXML_ObterEntidade_Teste()
        {
            try
            {
                DeclaracaoImportacaoXML xml = new DeclaracaoImportacaoXML();
                DeclaracaoImportacaoVO vo1 = new DeclaracaoImportacaoVO();


                String strXml = "<DI><nDI>nDI</nDI><dDI>dDI</dDI><xLocDesemb>xLocDesemb</xLocDesemb><UFDesemb>UFDesemb</UFDesemb><dDesemb>dDesemb</dDesemb><tpViaTransp>tpViaTransp</tpViaTransp><vAFRMM>vAFRMM</vAFRMM><tpIntermedio>tpIntermedio</tpIntermedio><CNPJ>CNPJ</CNPJ><UFTerceiro>UFTerceiro</UFTerceiro><cExportador>cExportador</cExportador></DI>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = DeclaracaoImportacaoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.NumeroDocumentoImportacao.Equals(ideNode["nDI"].InnerText) &&
                                  vo1.DataRegistroDocumento.Equals(ideNode["dDI"].InnerText) &&
                                  vo1.UFDesembaraco.Equals(ideNode["UFDesemb"].InnerText) &&
                                  vo1.DataDesembaraco.Equals(ideNode["dDesemb"].InnerText) &&
                                  vo1.TipoViaTransporte.Equals(ideNode["tpViaTransp"].InnerText) &&
                                  vo1.ValorAFRMM.Equals(ideNode["vAFRMM"].InnerText) &&
                                  vo1.TipoIntermedioImportacao.Equals(ideNode["tpIntermedio"].InnerText) &&
                                  vo1.CNPJ.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.UFTerceiro.Equals(ideNode["UFTerceiro"].InnerText) &&
                                  vo1.CodigoExportador.Equals(ideNode["cExportador"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void DeclaracaoImportacaoXML_ObterElementoXML_Teste()
        {
            try
            {
                DeclaracaoImportacaoXML xml = new DeclaracaoImportacaoXML();
                DeclaracaoImportacaoVO vo1 = new DeclaracaoImportacaoVO();

                vo1.NumeroDocumentoImportacao = "nDI";
                vo1.DataRegistroDocumento = "dDI";
                vo1.UFDesembaraco = "UFDesemb";
                vo1.DataDesembaraco = "dDesemb";
                vo1.TipoViaTransporte = "tpViaTransp";
                vo1.ValorAFRMM = "vAFRMM";
                vo1.TipoIntermedioImportacao = "tpIntermedio";
                vo1.CNPJ = "CNPJ";
                vo1.UFTerceiro = "UFTerceiro";
                vo1.CodigoExportador = "cExportador";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.NumeroDocumentoImportacao.Equals(ideNode["nDI"].InnerText) &&
                                  vo1.DataRegistroDocumento.Equals(ideNode["dDI"].InnerText) &&
                                  vo1.UFDesembaraco.Equals(ideNode["UFDesemb"].InnerText) &&
                                  vo1.DataDesembaraco.Equals(ideNode["dDesemb"].InnerText) &&
                                  vo1.TipoViaTransporte.Equals(ideNode["tpViaTransp"].InnerText) &&
                                  vo1.ValorAFRMM.Equals(ideNode["vAFRMM"].InnerText) &&
                                  vo1.TipoIntermedioImportacao.Equals(ideNode["tpIntermedio"].InnerText) &&
                                  vo1.CNPJ.Equals(ideNode["CNPJ"].InnerText) &&
                                  vo1.UFTerceiro.Equals(ideNode["UFTerceiro"].InnerText) &&
                                  vo1.CodigoExportador.Equals(ideNode["cExportador"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}