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
    public class ICMS70XML : BaseXML<ICMSxxVO>
    {
        public static CampoNo orig = new CampoNo("ICMS70", "orig", 1, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo CST = new CampoNo("ICMS70", "CST", 2, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo modBC = new CampoNo("ICMS70", "modBC", 1, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pRedBC = new CampoNo("ICMS70", "pRedBC", 8, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vBC = new CampoNo("ICMS70", "vBC", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pICMS = new CampoNo("ICMS70", "pICMS", 8, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMS = new CampoNo("ICMS70", "vICMS", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo modBCST = new CampoNo("ICMS70", "modBCST", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pMVAST = new CampoNo("ICMS70", "pMVAST", 8, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pRedBCST = new CampoNo("ICMS70", "pRedBCST", 8, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vBCST = new CampoNo("ICMS70", "vBCST", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pICMSST = new CampoNo("ICMS70", "pICMSST", 8, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSST = new CampoNo("ICMS70", "vICMSST", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSDeson = new CampoNo("ICMS70", "vICMSDeson", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo motDesICMS = new CampoNo("ICMS70", "motDesICMS", 2, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("ICMS70");

            no.AdicionarCampo("orig", orig);
            no.AdicionarCampo("cst", CST);
            no.AdicionarCampo("modBC", modBC);
            no.AdicionarCampo("pRedBC", pRedBC);
            no.AdicionarCampo("vBC", vBC);
            no.AdicionarCampo("pICMS", pICMS);
            no.AdicionarCampo("vICMS", vICMS);
            no.AdicionarCampo("modBCST", modBCST);
            no.AdicionarCampo("pMVAST", pMVAST);
            no.AdicionarCampo("pRedBCST", pRedBCST);
            no.AdicionarCampo("vBCST", vBCST);
            no.AdicionarCampo("pICMSST", pICMSST);
            no.AdicionarCampo("vICMSST", vICMSST);
            no.AdicionarCampo("vICMSDeson", vICMSDeson);
            no.AdicionarCampo("motDesICMS", motDesICMS);

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
