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
    public class ISSQNXML_Teste
    {
        [TestMethod()]
        public void ISSQNXML_ObterEntidade_Teste()
        {
            try
            {
                ISSQNXML xml = new ISSQNXML();
                ISSQNVO vo1 = new ISSQNVO();


                String strXml = "<ISSQN><vBC>vBC</vBC><vAliq>vAliq</vAliq><vISSQN>vISSQN</vISSQN><cMunFG>cMunFG</cMunFG><cListServ>cListServ</cListServ><vDeducao>vDeducao</vDeducao><vOutro>vOutro</vOutro><vDescIncond>vDescIncond</vDescIncond><vDescCond>vDescCond</vDescCond><vISSRet>vISSRet</vISSRet><indISS>indISS</indISS><cServico>cServico</cServico><cMun>cMun</cMun><cPais>cPais</cPais><nProcesso>nProcesso</nProcesso><indIncentivo>indIncentivo</indIncentivo></ISSQN>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ISSQNXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.ValorBaseCalculoISSQN.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.AliquotaISSQN.Equals(ideNode["vAliq"].InnerText) &&
                                  vo1.ValorISSQN.Equals(ideNode["vISSQN"].InnerText) &&
                                  vo1.CodigoMunicipioFatoGerador.Equals(ideNode["cMunFG"].InnerText) &&
                                  vo1.ItemListaServicos.Equals(ideNode["cListServ"].InnerText) &&
                                  vo1.ValorDeducao.Equals(ideNode["vDeducao"].InnerText) &&
                                  vo1.ValorOutrasRetencoes.Equals(ideNode["vOutro"].InnerText) &&
                                  vo1.ValorDescontoIncondicionado.Equals(ideNode["vDescIncond"].InnerText) &&
                                  vo1.ValorDescontoCondicionado.Equals(ideNode["vDescCond"].InnerText) &&
                                  vo1.ValorRetençãoISS.Equals(ideNode["vISSRet"].InnerText) &&
                                  vo1.IndicadorExigibilidadeISS.Equals(ideNode["indISS"].InnerText) &&
                                  vo1.CodigoServico.Equals(ideNode["cServico"].InnerText) &&
                                  vo1.CodigoMunicipio.Equals(ideNode["cMun"].InnerText) &&
                                  vo1.CodigoPais.Equals(ideNode["cPais"].InnerText) &&
                                  vo1.NumeroProcesso.Equals(ideNode["nProcesso"].InnerText) &&
                                  vo1.IndicadorIncentivoFiscal.Equals(ideNode["indIncentivo"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ISSQNXML_ObterElementoXML_Teste()
        {
            try
            {
                ISSQNXML xml = new ISSQNXML();
                ISSQNVO vo1 = new ISSQNVO();

                vo1.ValorBaseCalculoISSQN = "vBC";
                vo1.AliquotaISSQN = "vAliq";
                vo1.ValorISSQN = "vISSQN";
                vo1.CodigoMunicipioFatoGerador = "cMunFG";
                vo1.ItemListaServicos = "cListServ";
                vo1.ValorDeducao = "vDeducao";
                vo1.ValorOutrasRetencoes = "vOutro";
                vo1.ValorDescontoIncondicionado = "vDescIncond";
                vo1.ValorDescontoCondicionado = "vDescCond";
                vo1.ValorRetençãoISS = "vISSRet";
                vo1.IndicadorExigibilidadeISS = "indISS";
                vo1.CodigoServico = "cServico";
                vo1.CodigoMunicipio = "cMun";
                vo1.CodigoPais = "cPais";
                vo1.NumeroProcesso = "nProcesso";
                vo1.IndicadorIncentivoFiscal = "indIncentivo";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.ValorBaseCalculoISSQN.Equals(ideNode["vBC"].InnerText) &&
                                  vo1.AliquotaISSQN.Equals(ideNode["vAliq"].InnerText) &&
                                  vo1.ValorISSQN.Equals(ideNode["vISSQN"].InnerText) &&
                                  vo1.CodigoMunicipioFatoGerador.Equals(ideNode["cMunFG"].InnerText) &&
                                  vo1.ItemListaServicos.Equals(ideNode["cListServ"].InnerText) &&
                                  vo1.ValorDeducao.Equals(ideNode["vDeducao"].InnerText) &&
                                  vo1.ValorOutrasRetencoes.Equals(ideNode["vOutro"].InnerText) &&
                                  vo1.ValorDescontoIncondicionado.Equals(ideNode["vDescIncond"].InnerText) &&
                                  vo1.ValorDescontoCondicionado.Equals(ideNode["vDescCond"].InnerText) &&
                                  vo1.ValorRetençãoISS.Equals(ideNode["vISSRet"].InnerText) &&
                                  vo1.IndicadorExigibilidadeISS.Equals(ideNode["indISS"].InnerText) &&
                                  vo1.CodigoServico.Equals(ideNode["cServico"].InnerText) &&
                                  vo1.CodigoMunicipio.Equals(ideNode["cMun"].InnerText) &&
                                  vo1.CodigoPais.Equals(ideNode["cPais"].InnerText) &&
                                  vo1.NumeroProcesso.Equals(ideNode["nProcesso"].InnerText) &&
                                  vo1.IndicadorIncentivoFiscal.Equals(ideNode["indIncentivo"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}