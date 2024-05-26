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
    public class PISSTXML : BaseXML<PISSTVO>
    {
        public static CampoNo vBC = new CampoNo("PISST", "vBC", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pPIS = new CampoNo("PISST", "pPIS", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo qBCProd = new CampoNo("PISST", "qBCProd", 17, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vAliqProd = new CampoNo("PISST", "vAliqProd", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vPIS = new CampoNo("PISST", "vPIS", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("PISST");

            no.AdicionarCampo("vBC", vBC);
            no.AdicionarCampo("pPIS", pPIS);
            no.AdicionarCampo("qBCProd", qBCProd);
            no.AdicionarCampo("vAliqProd", vAliqProd);
            no.AdicionarCampo("vPIS", vPIS);

            return no;
        }

        
        public override PISSTVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(PISSTVO pis)
        {
            return this.controleXml.ObterElementoXML(pis, grupo);
        }
    }
}
