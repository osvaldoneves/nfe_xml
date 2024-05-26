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
        public void IdentificacaoXml_ObterEntidade_Test()
        {
            try
            {
                IdentificacaoXML xml = new IdentificacaoXML();
                IdentificacaoVO vo1 = new IdentificacaoVO();

                
                String strXml = "<ide><cUF>cUF</cUF><cNF>cNF</cNF><natOp>natOp</natOp><indPag>indPag</indPag><mod>mod</mod><serie>serie</serie><nNF>nNF</nNF><dhEmi>dhEmi</dhEmi><dhSaiEnt>dhSaiEnt</dhSaiEnt><tpNF>tpNF</tpNF><idDest>idDest</idDest><cMunFG>cMunFG</cMunFG><tpImp>tpImp</tpImp><tpEmis>tpEmis</tpEmis><cDV>cDV</cDV><tpAmb>tpAmb</tpAmb><finNFe>finNFe</finNFe><indFinal>indFinal</indFinal><indPres>indPres</indPres><procEmi>procEmi</procEmi><verProc>verProc</verProc><dhCont>dhCont</dhCont><xJust>xJust</xJust></ide>";
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
                                  vo1.VersaoProcessamento.Equals(ideNode["verProc"].InnerText) &&
                                  vo1.DataHoraEntradaContingencia.Equals(ideNode["dhCont"].InnerText) &&
                                  vo1.JustificativaEntradaContingencia.Equals(ideNode["xJust"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }

        [TestMethod]
        public void IdentificacaoXml_ObterElementoXML_Test()
        {
            try
            {
                IdentificacaoXML xml = new IdentificacaoXML();
                IdentificacaoVO vo1 = new IdentificacaoVO();

                vo1.CodigoUF = "33";
                vo1.CodigoNF = "00013040";
                vo1.NaturezaOperacao = "VENDA";
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
                vo1.DataHoraEntradaContingencia = "dhCont";
                vo1.JustificativaEntradaContingencia = "xJust";

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
                                  vo1.VersaoProcessamento.Equals(ideNode["verProc"].InnerText) &&
                                  vo1.DataHoraEntradaContingencia.Equals(ideNode["dhCont"].InnerText) &&
                                  vo1.JustificativaEntradaContingencia.Equals(ideNode["xJust"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
