using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;
using OLNG.Bibliotecas.NFeLib.VO;
using OLNG.Bibliotecas.NFeLib.Base;


namespace OLNG.Bibliotecas.NFeLib.XML.ICMS
{
    public class ICMSSN101XML : BaseXML<ICMSxxVO>
    {
        public static CampoNo orig = new CampoNo("ICMSNS101", "orig", 1, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo CSOSN = new CampoNo("ICMSSN101", "CSOSN", 3, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pCredSN = new CampoNo("ICMSSN101", "pCredSN", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vCredICMSSN = new CampoNo("ICMSSN101", "vCredICMSSN", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("ICMSSN101");

            no.AdicionarCampo("orig", orig);
            no.AdicionarCampo("csosn", CSOSN);
            no.AdicionarCampo("pCredSN", pCredSN);
            no.AdicionarCampo("vCredICMSSN", vCredICMSSN);

            return no;
        }

        
        public override ICMSxxVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ICMSxxVO ICMSxx)
        {
            return this.controleXml.ObterElementoXML(ICMSxx, grupo);
        }
    }
}
