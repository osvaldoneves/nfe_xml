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
    public class ICMSSTXML : BaseXML<ICMSxxVO>
    {
        public static CampoNo orig = new CampoNo("ICMSST", "orig", 1, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo CST = new CampoNo("ICMSST", "CST", 2, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vBCSTRet = new CampoNo("ICMSST", "vBCSTRet", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSSTRet = new CampoNo("ICMSST", "vICMSSTRet", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vBCSTDest = new CampoNo("ICMSST", "vBCSTDest", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSSTDest = new CampoNo("ICMSST", "vICMSSTDest", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        
        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("ICMSST");

            no.AdicionarCampo("orig", orig);
            no.AdicionarCampo("cst", CST);
            no.AdicionarCampo("vBCSTRet", vBCSTRet);
            no.AdicionarCampo("vICMSSTRet", vICMSSTRet);
            no.AdicionarCampo("vBCSTDest", vBCSTDest);
            no.AdicionarCampo("vICMSSTDest", vICMSSTDest);
            
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
