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
    public class ObsContribuinteXML : BaseXML<ObsContribuinteVO>
    {
        public static CampoNo xCampo = new CampoNo("obsCont", "xCampo", 20, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo xTexto = new CampoNo("obsCont", "xTexto", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("obsCont");

            no.AdicionarCampo("xCampo", xCampo);
            no.AdicionarCampo("xTexto", xTexto);

            return no;
        }

        
        public override ObsContribuinteVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ObsContribuinteVO obsCont)
        {
            return this.controleXml.ObterElementoXML(obsCont, grupo);
        }
    }
}
