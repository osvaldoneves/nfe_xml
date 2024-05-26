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
    public class RetiradaXML : BaseXML<RetiradaVO>
    {
        public static CampoNo cpf = new CampoNo("retirada", "CPF", 11, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.ElementoEscolha);
        public static CampoNo cnpj = new CampoNo("retirada", "CNPJ", 14, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.ElementoEscolha);
        public static CampoNo xLgr = new CampoNo("retirada", "xLgr", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo nro = new CampoNo("retirada", "nro", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo xCpl = new CampoNo("retirada", "xCpl", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo xBairro = new CampoNo("retirada", "xBairro", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cMun = new CampoNo("retirada", "cMun", 7, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo xMun = new CampoNo("retirada", "xMun", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo uf = new CampoNo("retirada", "uf", 2, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("retirada");

            no.AdicionarCampo("cpf", cpf);
            no.AdicionarCampo("cnpj", cnpj);
            no.AdicionarCampo("xLgr", xLgr);
            no.AdicionarCampo("nro", nro);
            no.AdicionarCampo("xCpl", xCpl);
            no.AdicionarCampo("xBairro", xBairro);
            no.AdicionarCampo("cMun", cMun);
            no.AdicionarCampo("xMun", xMun);
            no.AdicionarCampo("uf", uf);

            return no;
        }

        
        public override RetiradaVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(RetiradaVO retirada)
        {
            return this.controleXml.ObterElementoXML(retirada, grupo);
        }
    }
}
