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
    public class ComercioExteriorXML : BaseXML<ComercioExteriorVO>
    {
        public static CampoNo UFSaidaPais = new CampoNo("exporta", "UFSaidaPais", 2, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo xLocExporta = new CampoNo("exporta", "xLocExporta", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo xLocDespacho = new CampoNo("exporta", "xLocDespacho", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("exporta");

            no.AdicionarCampo("ufSaidaPais", UFSaidaPais);
            no.AdicionarCampo("xLocExporta", xLocExporta);
            no.AdicionarCampo("xLocDespacho", xLocDespacho);

            return no;
        }

        
        public override ComercioExteriorVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ComercioExteriorVO exporta)
        {
            return this.controleXml.ObterElementoXML(exporta, grupo);
        }
    }
}
