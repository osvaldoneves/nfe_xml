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
    public class IPIDevolvidoXML : BaseXML<IPIDevolvidoVO>
    {
        public static CampoNo vIPIDevol = new CampoNo("IPI", "vIPIDevol", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        
        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("IPI");

            no.AdicionarCampo("vIPIDevol", vIPIDevol);
            
            return no;
        }

        
        public override IPIDevolvidoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(IPIDevolvidoVO ipiDevolvido)
        {
            return this.controleXml.ObterElementoXML(ipiDevolvido, grupo);
        }
    }
}
