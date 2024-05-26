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
    public class IPITributadoXML : BaseXML<IPITributadoVO>
    {
        public static CampoNo CST = new CampoNo("IPITrib", "CST", 2, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo vBC = new CampoNo("IPITrib", "vBC", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pIPI = new CampoNo("IPITrib", "pIPI", 8, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo qUnid = new CampoNo("IPITrib", "qUnid", 17, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vUnid = new CampoNo("IPITrib", "vUnid", 16, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vIPI = new CampoNo("IPITrib", "vIPI", 16, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("IPITrib");

            no.AdicionarCampo("cst", CST);
            no.AdicionarCampo("vBC", vBC);
            no.AdicionarCampo("pIPI", pIPI);
            no.AdicionarCampo("qUnid", qUnid);
            no.AdicionarCampo("vUnid", vUnid);
            no.AdicionarCampo("vIPI", vIPI);

            return no;
        }

        
        public override IPITributadoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(IPITributadoVO ipiTributado)
        {
            return this.controleXml.ObterElementoXML(ipiTributado, grupo);
        }
    }
}
