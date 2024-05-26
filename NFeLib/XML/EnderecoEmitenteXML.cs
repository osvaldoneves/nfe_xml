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
    public class EnderecoEmitenteXML : BaseXML<EnderecoVO>
    {
        public static CampoNo xLgr = new CampoNo("enderEmit", "xLgr", 60, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo nro = new CampoNo("enderEmit", "nro", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo xCpl = new CampoNo("enderEmit", "xCpl", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo xBairro = new CampoNo("enderEmit", "xBairro", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cMun = new CampoNo("enderEmit", "cMun", 7, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo xMun = new CampoNo("enderEmit", "xMun", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo uf = new CampoNo("enderEmit", "UF", 2, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cep = new CampoNo("enderEmit", "CEP", 8, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cPais = new CampoNo("enderEmit", "cPais", 4, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo xPais = new CampoNo("enderEmit", "xPais", 60, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo fone = new CampoNo("enderEmit", "fone", 14, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("enderEmit");

            no.AdicionarCampo("xLgr", xLgr);
            no.AdicionarCampo("nro", nro);
            no.AdicionarCampo("xCpl", xCpl);
            no.AdicionarCampo("xBairro", xBairro);
            no.AdicionarCampo("cMun", cMun);
            no.AdicionarCampo("xMun", xMun);
            no.AdicionarCampo("uf", uf);
            no.AdicionarCampo("cep", cep);
            no.AdicionarCampo("cPais", cPais);
            no.AdicionarCampo("xPais", xPais);
            no.AdicionarCampo("fone", fone);

            return no;
        }

        
        public override EnderecoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(EnderecoVO endereco)
        {
            return this.controleXml.ObterElementoXML(endereco, grupo);
        }
    }
}
