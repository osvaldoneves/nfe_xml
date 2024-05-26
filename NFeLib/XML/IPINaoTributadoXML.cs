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
    public class IPINaoTributadoXML : BaseXML<IPINaoTributadoVO>
    {
        public static CampoNo CST = new CampoNo("IPINT", "CST", 2, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        
        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("IPINT");

            no.AdicionarCampo("cst", CST);
            
            return no;
        }

        
        public override IPINaoTributadoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(IPINaoTributadoVO ipiNT)
        {
            return this.controleXml.ObterElementoXML(ipiNT, grupo);
        }
    }
}
