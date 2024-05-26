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
    public class ICMS90XML : BaseXML<ICMSxxVO>
    {
        public static CampoNo orig = new CampoNo("ICMS90", "orig", 1, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo CST = new CampoNo("ICMS90", "CST", 2, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo modBC = new CampoNo("ICMS90", "modBC", 1, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vBC = new CampoNo("ICMS90", "vBC", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pRedBC = new CampoNo("ICMS90", "pRedBC", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pICMS = new CampoNo("ICMS90", "pICMS", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMS = new CampoNo("ICMS90", "vICMS", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo modBCST = new CampoNo("ICMS90", "modBCST", 1, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pMVAST = new CampoNo("ICMS90", "pMVAST", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pRedBCST = new CampoNo("ICMS90", "pRedBCST", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vBCST = new CampoNo("ICMS90", "vBCST", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pICMSST = new CampoNo("ICMS90", "pICMSST", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSST = new CampoNo("ICMS90", "vICMSST", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSDeson = new CampoNo("ICMS90", "vICMSDeson", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo motDesICMS = new CampoNo("ICMS90", "motDesICMS", 2, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("ICMS90");

            no.AdicionarCampo("orig", orig);
            no.AdicionarCampo("cst", CST);
            no.AdicionarCampo("modBC", modBC);
            no.AdicionarCampo("vBC", vBC);
            no.AdicionarCampo("pRedBC", pRedBC);
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
