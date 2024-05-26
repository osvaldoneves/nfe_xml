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
    public class InfoAdicionalXML : BaseXML<InfoAdicionalVO>
    {
        public static CampoNo infAdFisco = new CampoNo("infAdic", "infAdFisco", 2000, TipoDadoXml.String, 0, 1,TipoCampoXml.Elemento);
        public static CampoNo infCpl = new CampoNo("infAdic", "infCpl", 5000, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo obsCont = new CampoNo("infAdic", "obsCont", 0, TipoDadoXml.Nenhum, 0, 10, TipoCampoXml.Grupo);
        public static CampoNo obsFisco = new CampoNo("infAdic", "obsFisco", 0, TipoDadoXml.Nenhum, 0, 10, TipoCampoXml.Grupo);
        public static CampoNo procRef = new CampoNo("infAdic", "procRef", 0, TipoDadoXml.Nenhum, 0, 100, TipoCampoXml.Grupo);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("infAdic");

            no.AdicionarCampo("infAdFisco", infAdFisco);
            no.AdicionarCampo("infCpl", infCpl);
            no.AdicionarCampo("obsCont", obsCont);
            no.AdicionarCampo("obsFisco", obsFisco);
            no.AdicionarCampo("procRef", procRef);

            return no;
        }

        
        public override InfoAdicionalVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(InfoAdicionalVO infoAdic)
        {
            return this.controleXml.ObterElementoXML(infoAdic, grupo);
        }
    }
}
