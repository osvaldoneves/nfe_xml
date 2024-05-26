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
    public class ICMS51XML : BaseXML<ICMSxxVO>
    {
        public static CampoNo orig = new CampoNo("ICMS51", "orig", 1, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo CST = new CampoNo("ICMS51", "CST", 2, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo modBC = new CampoNo("ICMS51", "modBC", 1, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pRedBC = new CampoNo("ICMS51", "pRedBC", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vBC = new CampoNo("ICMS51", "vBC", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pICMS = new CampoNo("ICMS51", "pICMS", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSOp = new CampoNo("ICMS51", "vICMSOp", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pDif = new CampoNo("ICMS51", "pDif", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSDif = new CampoNo("ICMS51", "vICMSDif", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMS = new CampoNo("ICMS51", "vICMS", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("ICMS51");

            no.AdicionarCampo("orig", orig);
            no.AdicionarCampo("cst", CST);
            no.AdicionarCampo("modBC", modBC);
            no.AdicionarCampo("pRedBC", pRedBC);
            no.AdicionarCampo("vBC", vBC);
            no.AdicionarCampo("pICMS", pICMS);
            no.AdicionarCampo("vICMSOp", vICMSOp);
            no.AdicionarCampo("pDif", pDif);
            no.AdicionarCampo("vICMSDif", vICMSDif);
            no.AdicionarCampo("vICMS", vICMS);

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
