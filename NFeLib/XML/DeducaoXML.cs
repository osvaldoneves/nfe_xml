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
    public class DeducaoXML : BaseXML<DeducaoVO>
    {
        public static CampoNo xDed = new CampoNo("deduc", "xDed", 60, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo vDed = new CampoNo("deduc", "vDed", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vFor = new CampoNo("deduc", "vFor", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vTotDed = new CampoNo("deduc", "vTotDed", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vLiqFor = new CampoNo("deduc", "vLiqFor", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("deduc");

            no.AdicionarCampo("xDed", xDed);
            no.AdicionarCampo("vDed", vDed);
            no.AdicionarCampo("vFor", vFor);
            no.AdicionarCampo("vTotDed", vTotDed);
            no.AdicionarCampo("vLiqFor", vLiqFor);

            return no;
        }

        
        public override DeducaoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(DeducaoVO deduc)
        {
            return this.controleXml.ObterElementoXML(deduc, grupo);
        }
    }
}
