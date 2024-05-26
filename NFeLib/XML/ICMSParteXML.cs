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
    public class ICMSParteXML : BaseXML<ICMSxxVO>
    {
        public static CampoNo orig = new CampoNo("ICMSPart", "orig", 1, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo CST = new CampoNo("ICMSPart", "CST", 2, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo modBC = new CampoNo("ICMSPart", "modBC", 1, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vBC = new CampoNo("ICMSPart", "vBC", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pRedBC = new CampoNo("ICMSPart", "pRedBC", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pICMS = new CampoNo("ICMSPart", "pICMS", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMS = new CampoNo("ICMSPart", "vICMS", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo modBCST = new CampoNo("ICMSPart", "modBCST", 1, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pMVAST = new CampoNo("ICMSPart", "pMVAST", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pRedBCST = new CampoNo("ICMSPart", "pRedBCST", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vBCST = new CampoNo("ICMSPart", "vBCST", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pICMSST = new CampoNo("ICMSPart", "pICMSST", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSST = new CampoNo("ICMSPart", "vICMSST", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pBCOp = new CampoNo("ICMSPart", "pBCOp", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo UFST = new CampoNo("ICMSPart", "UFST", 2, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("ICMSPart");

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
            no.AdicionarCampo("pBCOp", pBCOp);
            no.AdicionarCampo("UFST", UFST);
            
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
