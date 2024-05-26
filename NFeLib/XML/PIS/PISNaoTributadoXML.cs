using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;
using OLNG.Bibliotecas.NFeLib.VO;
using OLNG.Bibliotecas.NFeLib.Base;

namespace OLNG.Bibliotecas.NFeLib.XML.PIS
{
    public class PISNaoTributadoXML : BaseXML<PISxxVO>
    {
        public static CampoNo CST = new CampoNo("PISNT", "CST", 2, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        
        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("PISNT");

            no.AdicionarCampo("cst", CST);
            
            return no;
        }

        
        public override PISxxVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(PISxxVO pis)
        {
            return this.controleXml.ObterElementoXML(pis, grupo);
        }
    }
}
