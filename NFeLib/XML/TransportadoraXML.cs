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
    public class TransportadoraXML : BaseXML<TransportadoraVO>
    {
        public static CampoNo cpf = new CampoNo("transporta", "CPF", 11, TipoDadoXml.Numerico, 0, 1,TipoCampoXml.ElementoEscolha);
        public static CampoNo cnpj = new CampoNo("transporta", "CNPJ", 14, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.ElementoEscolha);
        public static CampoNo xNome= new CampoNo("transporta", "xNome", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo IE = new CampoNo("transporta", "IE", 14, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo xEnder = new CampoNo("transporta", "xEnder", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo xMun = new CampoNo("transporta", "xMun", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo UF = new CampoNo("transporta", "UF", 2, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("transporta");

            no.AdicionarCampo("cpf", cpf);
            no.AdicionarCampo("cnpj", cnpj);
            no.AdicionarCampo("xNome", xNome);
            no.AdicionarCampo("IE", IE);
            no.AdicionarCampo("xEnder", xEnder);
            no.AdicionarCampo("xMun", xMun);
            no.AdicionarCampo("uf", UF);

            return no;
        }

        
        public override TransportadoraVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(TransportadoraVO transporta)
        {
            return this.controleXml.ObterElementoXML(transporta, grupo);
        }
    }
}
