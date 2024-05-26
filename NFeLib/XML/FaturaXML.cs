
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
    public class FaturaXML : BaseXML<FaturaVO>
    {
        public static CampoNo nFat = new CampoNo("fat", "nFat", 60, TipoDadoXml.String, 0, 1,TipoCampoXml.Elemento);
        public static CampoNo vOrig = new CampoNo("fat", "vOrig", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vDesc = new CampoNo("fat", "vDesc", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vLiq = new CampoNo("fat", "vLiq", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("fat");

            no.AdicionarCampo("nFat", nFat);
            no.AdicionarCampo("vOrig", vOrig);
            no.AdicionarCampo("vDesc", vDesc);
            no.AdicionarCampo("vLiq", vLiq);

            return no;
        }

        
        public override FaturaVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(FaturaVO fat)
        {
            return this.controleXml.ObterElementoXML(fat, grupo);
        }
    }
}
