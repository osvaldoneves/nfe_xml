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
    public class AutorizacaoXML : BaseXML<AutorizacaoVO>
    {
        public static CampoNo cpf = new CampoNo("autXML", "CPF", 11, TipoDadoXml.String, 1, 1,TipoCampoXml.ElementoEscolha);
        public static CampoNo cnpj = new CampoNo("autXML", "CNPJ", 14, TipoDadoXml.String, 1, 1, TipoCampoXml.ElementoEscolha);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("autXML");

            no.AdicionarCampo("cpf", cpf);
            no.AdicionarCampo("cnpj", cnpj);

            return no;
        }

        
        public override AutorizacaoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(AutorizacaoVO autorizacao)
        {
            return this.controleXml.ObterElementoXML(autorizacao, grupo);
        }
    }
}
