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
    public class VeiculoXML_Teste
    {
        [TestMethod()]
        public void VeiculoXML_ObterEntidade_Teste()
        {
            try
            {
                VeiculoXML xml = new VeiculoXML();
                VeiculoVO vo1 = new VeiculoVO();


                String strXml = "<veicProd><tpOp>tpOp</tpOp><chassi>chassi</chassi><cCor>cCor</cCor><xCor>xCor</xCor><pot>pot</pot><cilin>cilin</cilin><pesoL>pesoL</pesoL><pesoB>pesoB</pesoB><nSerie>nSerie</nSerie><tpComb>tpComb</tpComb><nMotor>nMotor</nMotor><CMT>CMT</CMT><dist>dist</dist><anoMod>anoMod</anoMod><anoFab>anoFab</anoFab><tpPint>tpPint</tpPint><tpVeic>tpVeic</tpVeic><espVeic>espVeic</espVeic><VIN>VIN</VIN><condVeic>condVeic</condVeic><cMod>cMod</cMod><cCorDENATRAN>cCorDENATRAN</cCorDENATRAN><lota>lota</lota><tpRest>tpRest</tpRest></veicProd>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = VeiculoXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.TipoOperacao.Equals(ideNode["tpOp"].InnerText) &&
                                  vo1.ChassiVeiculo.Equals(ideNode["chassi"].InnerText) &&
                                  vo1.CodigoCorMontadora.Equals(ideNode["cCor"].InnerText) &&
                                  vo1.DescricaoCor.Equals(ideNode["xCor"].InnerText) &&
                                  vo1.Potencia.Equals(ideNode["pot"].InnerText) &&
                                  vo1.Cilindradas.Equals(ideNode["cilin"].InnerText) &&
                                  vo1.PesoLiquido.Equals(ideNode["pesoL"].InnerText) &&
                                  vo1.PesoBruto.Equals(ideNode["pesoB"].InnerText) &&
                                  vo1.Serie.Equals(ideNode["nSerie"].InnerText) &&
                                  vo1.TipoCombustivel.Equals(ideNode["tpComb"].InnerText) &&
                                  vo1.NumeroMotor.Equals(ideNode["nMotor"].InnerText) &&
                                  vo1.CMT.Equals(ideNode["CMT"].InnerText) &&
                                  vo1.DistanciaEntreEixos.Equals(ideNode["dist"].InnerText) &&
                                  vo1.AnoModelo.Equals(ideNode["anoMod"].InnerText) &&
                                  vo1.AnoFabricacao.Equals(ideNode["anoFab"].InnerText) &&
                                  vo1.TipoPintura.Equals(ideNode["tpPint"].InnerText) &&
                                  vo1.TipoVeiculo.Equals(ideNode["tpVeic"].InnerText) &&
                                  vo1.EspecieVeiculo.Equals(ideNode["espVeic"].InnerText) &&
                                  vo1.CondicaoVIN.Equals(ideNode["VIN"].InnerText) &&
                                  vo1.CondicaoVeiculo.Equals(ideNode["condVeic"].InnerText) &&
                                  vo1.CodigoMarcaModelo.Equals(ideNode["cMod"].InnerText) &&
                                  vo1.CodigoCor.Equals(ideNode["cCorDENATRAN"].InnerText) &&
                                  vo1.CapacidadeMaximaLotacao.Equals(ideNode["lota"].InnerText) &&
                                  vo1.Restricao.Equals(ideNode["tpRest"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void VeiculoXML_ObterElementoXML_Teste()
        {
            try
            {
                VeiculoXML xml = new VeiculoXML();
                VeiculoVO vo1 = new VeiculoVO();

                vo1.TipoOperacao = "tpOp";
                vo1.ChassiVeiculo = "chassi";
                vo1.CodigoCorMontadora = "cCor";
                vo1.DescricaoCor = "xCor";
                vo1.Potencia = "pot";
                vo1.Cilindradas = "cilin";
                vo1.PesoLiquido = "pesoL";
                vo1.PesoBruto = "pesoB";
                vo1.Serie = "nSerie";
                vo1.TipoCombustivel = "tpComb";
                vo1.NumeroMotor = "nMotor";
                vo1.CMT = "CMT";
                vo1.DistanciaEntreEixos = "dist";
                vo1.AnoModelo = "anoMod";
                vo1.AnoFabricacao = "anoFab";
                vo1.TipoPintura = "tpPint";
                vo1.TipoVeiculo = "tpVeic";
                vo1.EspecieVeiculo = "espVeic";
                vo1.CondicaoVIN = "VIN";
                vo1.CondicaoVeiculo = "condVeic";
                vo1.CodigoMarcaModelo = "cMod";
                vo1.CodigoCor = "cCorDENATRAN";
                vo1.CapacidadeMaximaLotacao = "lota";
                vo1.Restricao = "tpRest";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.TipoOperacao.Equals(ideNode["tpOp"].InnerText) &&
                                  vo1.ChassiVeiculo.Equals(ideNode["chassi"].InnerText) &&
                                  vo1.CodigoCorMontadora.Equals(ideNode["cCor"].InnerText) &&
                                  vo1.DescricaoCor.Equals(ideNode["xCor"].InnerText) &&
                                  vo1.Potencia.Equals(ideNode["pot"].InnerText) &&
                                  vo1.Cilindradas.Equals(ideNode["cilin"].InnerText) &&
                                  vo1.PesoLiquido.Equals(ideNode["pesoL"].InnerText) &&
                                  vo1.PesoBruto.Equals(ideNode["pesoB"].InnerText) &&
                                  vo1.Serie.Equals(ideNode["nSerie"].InnerText) &&
                                  vo1.TipoCombustivel.Equals(ideNode["tpComb"].InnerText) &&
                                  vo1.NumeroMotor.Equals(ideNode["nMotor"].InnerText) &&
                                  vo1.CMT.Equals(ideNode["CMT"].InnerText) &&
                                  vo1.DistanciaEntreEixos.Equals(ideNode["dist"].InnerText) &&
                                  vo1.AnoModelo.Equals(ideNode["anoMod"].InnerText) &&
                                  vo1.AnoFabricacao.Equals(ideNode["anoFab"].InnerText) &&
                                  vo1.TipoPintura.Equals(ideNode["tpPint"].InnerText) &&
                                  vo1.TipoVeiculo.Equals(ideNode["tpVeic"].InnerText) &&
                                  vo1.EspecieVeiculo.Equals(ideNode["espVeic"].InnerText) &&
                                  vo1.CondicaoVIN.Equals(ideNode["VIN"].InnerText) &&
                                  vo1.CondicaoVeiculo.Equals(ideNode["condVeic"].InnerText) &&
                                  vo1.CodigoMarcaModelo.Equals(ideNode["cMod"].InnerText) &&
                                  vo1.CodigoCor.Equals(ideNode["cCorDENATRAN"].InnerText) &&
                                  vo1.CapacidadeMaximaLotacao.Equals(ideNode["lota"].InnerText) &&
                                  vo1.Restricao.Equals(ideNode["tpRest"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}