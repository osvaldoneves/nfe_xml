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
    public class EntregaXML : BaseXML<EntregaVO>
    {
        public static CampoNo CNPJ = new CampoNo("entrega", "CNPJ", 14, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo CPF = new CampoNo("entrega", "CPF", 11, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo xLgr = new CampoNo("entrega", "xLgr", 60, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo nro = new CampoNo("entrega", "nro", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo xCpl = new CampoNo("entrega", "xCpl", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo xBairro = new CampoNo("entrega", "xBairro", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cMun = new CampoNo("entrega", "cMun", 7, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo xMun = new CampoNo("entrega", "xMun", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo uf = new CampoNo("entrega", "UF", 2, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        
        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("entrega");

            no.AdicionarCampo("cnpj", CNPJ);
            no.AdicionarCampo("cpf", CPF);
            no.AdicionarCampo("xLgr", xLgr);
            no.AdicionarCampo("nro", nro);
            no.AdicionarCampo("xCpl", xCpl);
            no.AdicionarCampo("xBairro", xBairro);
            no.AdicionarCampo("cMun", cMun);
            no.AdicionarCampo("xMun", xMun);
            no.AdicionarCampo("uf", uf);


            return no;
        }

        
        public override EntregaVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(EntregaVO entrega)
        {
            return this.controleXml.ObterElementoXML(entrega, grupo);
        }
    }
}
