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
    public class ICMS10XML : BaseXML<ICMSxxVO>
    {
        public static CampoNo orig = new CampoNo("ICMS10", "orig", 1, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo CST = new CampoNo("ICMS10", "CST", 2, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo modBC = new CampoNo("ICMS10", "modBC", 1, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vBC = new CampoNo("ICMS10", "vBC", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pICMS = new CampoNo("ICMS10", "pICMS", 8, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMS = new CampoNo("ICMS10", "vICMS", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo modBCST = new CampoNo("ICMS10", "modBCST", 1, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pMVAST = new CampoNo("ICMS10", "pMVAST", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pRedBCST = new CampoNo("ICMS10", "pRedBCST", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vBCST = new CampoNo("ICMS10", "vBCST", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pICMSST = new CampoNo("ICMS10", "pICMSST", 8, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSST = new CampoNo("ICMS10", "vICMSST", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("ICMS10");

            no.AdicionarCampo("orig", orig);
            no.AdicionarCampo("cst", CST);
            no.AdicionarCampo("modBC", modBC);
            no.AdicionarCampo("vBC", vBC);
            no.AdicionarCampo("pICMS", pICMS);
            no.AdicionarCampo("vICMS", vICMS);
            no.AdicionarCampo("modBCST", modBCST);
            no.AdicionarCampo("pMVAST", pMVAST);
            no.AdicionarCampo("pRedBCST", pRedBCST);
            no.AdicionarCampo("vBCST", vBCST);
            no.AdicionarCampo("pICMSST", pICMSST);
            no.AdicionarCampo("vICMSST", vICMSST);

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
