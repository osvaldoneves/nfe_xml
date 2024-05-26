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
    public class ICMSTotalXML : BaseXML<ICMSTotalVO>
    {
        public static CampoNo vBC = new CampoNo("ICMSTot", "vBC", 16, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo vICMS = new CampoNo("ICMSTot", "vICMS", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSDeson= new CampoNo("ICMSTot", "vICMSDeson", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vBCST = new CampoNo("ICMSTot", "vBCST", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vST = new CampoNo("ICMSTot", "vST", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vProd = new CampoNo("ICMSTot", "vProd", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vFrete = new CampoNo("ICMSTot", "vFrete", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vSeg = new CampoNo("ICMSTot", "vSeg", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vDesc = new CampoNo("ICMSTot", "vDesc", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vII = new CampoNo("ICMSTot", "vII", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vIPI = new CampoNo("ICMSTot", "vIPI", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vPIS = new CampoNo("ICMSTot", "vPIS", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vCOFINS = new CampoNo("ICMSTot", "vCOFINS", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vOutro = new CampoNo("ICMSTot", "vOutro", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vNF = new CampoNo("ICMSTot", "vNF", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vTotTrib = new CampoNo("ICMSTot", "vTotTrib", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("ICMSTot");

            no.AdicionarCampo("vBC", vBC);
            no.AdicionarCampo("vICMS", vICMS);
            no.AdicionarCampo("vICMSDeson", vICMSDeson);
            no.AdicionarCampo("vBCST", vBCST);
            no.AdicionarCampo("vST", vST);
            no.AdicionarCampo("vProd", vProd);
            no.AdicionarCampo("vFrete", vFrete);
            no.AdicionarCampo("vSeg", vSeg);
            no.AdicionarCampo("vDesc", vDesc);
            no.AdicionarCampo("vII", vII);
            no.AdicionarCampo("vIPI", vIPI);
            no.AdicionarCampo("vPIS", vPIS);
            no.AdicionarCampo("vCOFINS", vCOFINS);
            no.AdicionarCampo("vOutro", vOutro);
            no.AdicionarCampo("vNF", vNF);
            no.AdicionarCampo("vTotTrib", vTotTrib);

            return no;
        }

        
        public override ICMSTotalVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ICMSTotalVO icmsTot)
        {
            return this.controleXml.ObterElementoXML(icmsTot, grupo);
        }
    }
}
