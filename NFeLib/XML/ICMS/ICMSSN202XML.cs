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
    public class ICMSSN202XML : BaseXML<ICMSxxVO>
    {
        public static CampoNo orig = new CampoNo("ICMSNS202", "orig", 1, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo CSOSN = new CampoNo("ICMSSN202", "CSOSN", 2, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo modBCST = new CampoNo("ICMSSN202", "modBCST", 1, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pMVAST = new CampoNo("ICMSSN202", "pMVAST", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pRedBCST = new CampoNo("ICMSSN202", "pRedBCST", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vBCST = new CampoNo("ICMSSN202", "vBCST", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pICMSST = new CampoNo("ICMSSN202", "pICMSST", 8, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSST = new CampoNo("ICMSSN202", "vICMSST", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        
        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("ICMSSN202");

            no.AdicionarCampo("orig", orig);
            no.AdicionarCampo("csosn", CSOSN);
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
