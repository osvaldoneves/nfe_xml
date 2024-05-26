﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class ObsContribuinteXML_Teste
    {
        [TestMethod()]
        public void ObsContribuinteXML_ObterEntidade_Teste()
        {
            try
            {
                ObsContribuinteXML xml = new ObsContribuinteXML();
                ObsContribuinteVO vo1 = new ObsContribuinteVO();


                String strXml = "<obsCont><xCampo>xCampo</xCampo><xTexto>xTexto</xTexto></obsCont>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strXml);
                XmlNode ideNode = doc.DocumentElement;
                vo1 = xml.ObterEntidade(ideNode);

                Boolean retTest = ObsContribuinteXML.grupo.Nome.Equals(ideNode.Name) &&
                                  vo1.Campo.Equals(ideNode["xCampo"].InnerText) &&
                                  vo1.Texto.Equals(ideNode["xTexto"].InnerText);


                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void ObsContribuinteXML_ObterElementoXML_Teste()
        {
            try
            {
                ObsContribuinteXML xml = new ObsContribuinteXML();
                ObsContribuinteVO vo1 = new ObsContribuinteVO();

                vo1.Campo = "xCampo";
                vo1.Texto = "xTexto";

                XmlNode ideNode = xml.ObterElementoXML(vo1);

                Boolean retTest = vo1.Campo.Equals(ideNode["xCampo"].InnerText) &&
                                  vo1.Texto.Equals(ideNode["xTexto"].InnerText);

                Assert.IsTrue(retTest);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}