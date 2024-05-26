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
    public class LacreXML : BaseXML<LacreVO>
    {
        public static CampoNo nLacre = new CampoNo("lacres", "nLacre", 60, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        
        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("lacres");

            no.AdicionarCampo("nLacre", nLacre);

            return no;
        }

        
        public override LacreVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(LacreVO lacre)
        {
            return this.controleXml.ObterElementoXML(lacre, grupo);
        }
    }
}
