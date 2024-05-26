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
    public class FormaPagamentoXML : BaseXML<FormaPagamentoVO>
    {
        public static CampoNo tPag = new CampoNo("pag", "tPag", 2, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo vPag = new CampoNo("pag", "vPag", 16, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo card = new CampoNo("pag", "card", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("pag");

            no.AdicionarCampo("tPag", tPag);
            no.AdicionarCampo("vPag", vPag);
            no.AdicionarCampo("card", card);

            return no;
        }

        
        public override FormaPagamentoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(FormaPagamentoVO pag)
        {
            return this.controleXml.ObterElementoXML(pag, grupo);
        }
    }
}
