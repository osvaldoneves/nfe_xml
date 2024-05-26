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
    public class DuplicataXML : BaseXML<DuplicataVO>
    {
        public static CampoNo nDup = new CampoNo("dup", "nDup", 60, TipoDadoXml.String, 0, 1,TipoCampoXml.Elemento);
        public static CampoNo dVenc = new CampoNo("dup", "dVenc", 10, TipoDadoXml.Data, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vDup = new CampoNo("dup", "vDup", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("dup");

            no.AdicionarCampo("nDup", nDup);
            no.AdicionarCampo("dVenc", dVenc);
            no.AdicionarCampo("vDup", vDup);

            return no;
        }

        
        public override DuplicataVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(DuplicataVO dup)
        {
            return this.controleXml.ObterElementoXML(dup, grupo);
        }
    }
}
