using System;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.VO;

namespace NFeLibTeste.Xml
{
    [TestClass]
    public class IdentificacaoXml_Teste
    {
        [TestMethod]
        public void Test_ObterEntidade()
        {
            try
            {
                IdentificacaoXML xml = new IdentificacaoXML();
                IdentificacaoVO vo1 = new IdentificacaoVO();

                
                /*
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\exemplo.xml");

                XmlNode root = doc.DocumentElement;
                String nameSpace = root.Attributes["xmlns"].Value;
                XmlNamespaceManager namespaces = new XmlNamespaceManager(doc.NameTable);
                namespaces.AddNamespace("ns", nameSpace);

                XmlNode ideNode = doc.SelectSingleNode("//ns:ide", namespaces);
                */

                String strXml = "<ide><cUF>33</cUF><cNF>00013040</cNF><natOp>VENDA</natOp><indPag>0</indPag><mod>65</mod><serie>2</serie><nNF>2525</nNF><dhEmi>2016-11-30T14:34:43-02:00</dhEmi><dhSaiEnt>2016-11-30T14:34:43-02:00</dhSaiEnt><tpNF>1</tpNF><idDest>1</idDest><cMunFG>3304557</cMunFG><tpImp>4</tpImp><tpEmis>1</tpEmis><cDV>0</cDV><tpAmb>1</tpAmb><finNFe>1</finNFe><indFinal>1</indFinal><indPres>1</indPres><procEmi>0</procEmi><verProc>Invistto</verProc></ide>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode root = doc.DocumentElement;
                XmlNode ideNode = doc.SelectSingleNode("//ide");
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = vo1.CodigoUF.Equals(ideNode["cUF"].InnerText) &&
                                  vo1.CodigoNF.Equals(ideNode["cNF"].InnerText) &&
                                  vo1.NaturezaOperacao.Equals(ideNode["natOp"].InnerText) &&
                                  vo1.IndicadorPagamento.Equals(ideNode["indPag"].InnerText) &&
                                  vo1.ModeloNF.Equals(ideNode["mod"].InnerText) &&
                                  vo1.Serie.Equals(ideNode["serie"].InnerText) &&
                                  vo1.NumeroNF.Equals(ideNode["nNF"].InnerText) &&
                                  vo1.DataHoraEmissao.Equals(ideNode["dhEmi"].InnerText) &&
                                  vo1.DataHoraSaidaEntrada.Equals(ideNode["dhSaiEnt"].InnerText) &&
                                  vo1.TipoOperacaoNF.Equals(ideNode["tpNF"].InnerText) &&
                                  vo1.IdentificadorDestino.Equals(ideNode["idDest"].InnerText) &&
                                  vo1.CodigoMunicipioFatorGerador.Equals(ideNode["cMunFG"].InnerText) &&
                                  vo1.TipoImpressaoDanfe.Equals(ideNode["tpImp"].InnerText) &&
                                  vo1.TipoEmissao.Equals(ideNode["tpEmis"].InnerText) &&
                                  vo1.DigitoVerificadorChaveAcesso.Equals(ideNode["cDV"].InnerText) &&
                                  vo1.TipoAmbiente.Equals(ideNode["tpAmb"].InnerText) &&
                                  vo1.FinalidadeEmissaoNF.Equals(ideNode["finNFe"].InnerText) &&
                                  vo1.IndicadorOperacaoConsumidorFinal.Equals(ideNode["indFinal"].InnerText) &&
                                  vo1.IndicadorPresencaComprador.Equals(ideNode["indPres"].InnerText) &&
                                  vo1.ProcessoEmissao.Equals(ideNode["procEmi"].InnerText) &&
                                  vo1.VersaoProcessamento.Equals(ideNode["verProc"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }

        [TestMethod]
        public void Test_ObterElementoXML()
        {
            try
            {
                IdentificacaoXML xml = new IdentificacaoXML();
                IdentificacaoVO vo1 = new IdentificacaoVO();

                vo1.CodigoUF = "33";
                vo1.CodigoNF = "00013040";
                vo1.NaturezaOperacao = "VENDA";
                vo1.NaturezaOperacao = "0";
                vo1.IndicadorPagamento = "0";
                vo1.ModeloNF = "65";
                vo1.Serie = "2";
                vo1.NumeroNF = "2525";
                vo1.DataHoraEmissao = "2016-11-30T14:34:43-02:00";
                vo1.DataHoraSaidaEntrada = "2016-11-30T14:34:43-02:00";
                vo1.TipoOperacaoNF = "1";
                vo1.IdentificadorDestino = "1";
                vo1.CodigoMunicipioFatorGerador = "3304557";
                vo1.TipoImpressaoDanfe = "4";
                vo1.TipoEmissao = "1";
                vo1.DigitoVerificadorChaveAcesso = "0";
                vo1.TipoAmbiente = "1";
                vo1.FinalidadeEmissaoNF = "1";
                vo1.IndicadorOperacaoConsumidorFinal = "1";
                vo1.IndicadorPresencaComprador = "1";
                vo1.ProcessoEmissao = "0";
                vo1.VersaoProcessamento = "Invistto";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.CodigoUF.Equals(ideNode["cUF"].InnerText) &&
                                  vo1.CodigoNF.Equals(ideNode["cNF"].InnerText) &&
                                  vo1.NaturezaOperacao.Equals(ideNode["natOp"].InnerText) &&
                                  vo1.IndicadorPagamento.Equals(ideNode["indPag"].InnerText) &&
                                  vo1.ModeloNF.Equals(ideNode["mod"].InnerText) &&
                                  vo1.Serie.Equals(ideNode["serie"].InnerText) &&
                                  vo1.NumeroNF.Equals(ideNode["nNF"].InnerText) &&
                                  vo1.DataHoraEmissao.Equals(ideNode["dhEmi"].InnerText) &&
                                  vo1.DataHoraSaidaEntrada.Equals(ideNode["dhSaiEnt"].InnerText) &&
                                  vo1.TipoOperacaoNF.Equals(ideNode["tpNF"].InnerText) &&
                                  vo1.IdentificadorDestino.Equals(ideNode["idDest"].InnerText) &&
                                  vo1.CodigoMunicipioFatorGerador.Equals(ideNode["cMunFG"].InnerText) &&
                                  vo1.TipoImpressaoDanfe.Equals(ideNode["tpImp"].InnerText) &&
                                  vo1.TipoEmissao.Equals(ideNode["tpEmis"].InnerText) &&
                                  vo1.DigitoVerificadorChaveAcesso.Equals(ideNode["cDV"].InnerText) &&
                                  vo1.TipoAmbiente.Equals(ideNode["tpAmb"].InnerText) &&
                                  vo1.FinalidadeEmissaoNF.Equals(ideNode["finNFe"].InnerText) &&
                                  vo1.IndicadorOperacaoConsumidorFinal.Equals(ideNode["indFinal"].InnerText) &&
                                  vo1.IndicadorPresencaComprador.Equals(ideNode["indPres"].InnerText) &&
                                  vo1.ProcessoEmissao.Equals(ideNode["procEmi"].InnerText) &&
                                  vo1.VersaoProcessamento.Equals(ideNode["verProc"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
