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
    public class ICMSSN500XML : BaseXML<ICMSxxVO>
    {
        public static CampoNo orig = new CampoNo("ICMSNS500", "orig", 1, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo CSOSN = new CampoNo("ICMSSN500", "CSOSN", 3, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vBCSTRet = new CampoNo("ICMSSN500", "vBCSTRet", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSSTRet = new CampoNo("ICMSSN500", "vICMSSTRet", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("ICMSSN500");

            no.AdicionarCampo("orig", orig);
            no.AdicionarCampo("csosn", CSOSN);
            no.AdicionarCampo("vBCSTRet", vBCSTRet);
            no.AdicionarCampo("vICMSSTRet", vICMSSTRet);

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
