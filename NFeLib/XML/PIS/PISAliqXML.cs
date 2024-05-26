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
    public class PISAliqXML : BaseXML<PISxxVO>
    {
        public static CampoNo CST = new CampoNo("PISAliq", "CST", 2, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo vBC = new CampoNo("PISAliq", "vBC", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pPIS = new CampoNo("PISAliq", "pPIS", 8, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        
        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("PISAliq");

            no.AdicionarCampo("cst", CST);
            no.AdicionarCampo("vBC", vBC);
            no.AdicionarCampo("pPIS", pPIS);
            
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
