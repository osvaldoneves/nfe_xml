using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;
using OLNG.Bibliotecas.NFeLib.VO;
using OLNG.Bibliotecas.NFeLib.Base;

namespace OLNG.Bibliotecas.NFeLib.XML
{
    public class FornecimentoDiarioCanaXML : BaseXML<FornecimentoDiarioCanaVO>
    {
        public static CampoNo dia = new CampoNo("forDia", "dia", 2, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo qtde = new CampoNo("forDia", "qtde", 22, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo qTotMes = new CampoNo("forDia", "qTotMes", 22, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo qTotAnt = new CampoNo("forDia", "qTotAnt", 22, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo qTotGer = new CampoNo("forDia", "qTotGer", 22, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        
        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("forDia");

            no.AdicionarCampo("dia", dia);
            no.AdicionarCampo("qtde", qtde);
            no.AdicionarCampo("qTotMes", qTotMes);
            no.AdicionarCampo("qTotAnt", qTotAnt);
            no.AdicionarCampo("qTotGer", qTotGer);

            return no;
        }

        
        public override FornecimentoDiarioCanaVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(FornecimentoDiarioCanaVO forDia)
        {
            return this.controleXml.ObterElementoXML(forDia, grupo);
        }
    }
}
