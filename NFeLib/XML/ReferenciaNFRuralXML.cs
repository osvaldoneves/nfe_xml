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
    public class ReferenciaNFRuralXML : BaseXML<ReferenciaNFRuralVO>
    {
        public static CampoNo nNF = new CampoNo("refNFP", "nNF", 9, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        //public static CampoNo cUF = new CampoNo("refNFP", "cUF", 2, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        //public static CampoNo AAMM = new CampoNo("refNFP", "AAMM", 4, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        //public static CampoNo CNPJ = new CampoNo("refNFP", "CNPJ", 14, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.ElementoEscolha);
        //public static CampoNo CPF = new CampoNo("refNFP", "CPF", 11, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.ElementoEscolha);
        //public static CampoNo IE = new CampoNo("refNFP", "IE", 14, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        //public static CampoNo mod = new CampoNo("refNFP", "mod", 2, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        //public static CampoNo serie = new CampoNo("refNFP", "serie", 3, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        //public static CampoNo refCTe = new CampoNo("refNFP", "refCTe", 44, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("refNFP");

            //no.AdicionarCampo("cUF", cUF);
            //no.AdicionarCampo("AAMM", AAMM);
            //no.AdicionarCampo("cnpj", CNPJ);
            //no.AdicionarCampo("cpf", CPF);
            //no.AdicionarCampo("ie", IE);
            //no.AdicionarCampo("mod", mod);
            //no.AdicionarCampo("serie", serie);
            no.AdicionarCampo("nNF", nNF);

            return no;
        }

        
        public override ReferenciaNFRuralVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ReferenciaNFRuralVO refNfRural)
        {
            return this.controleXml.ObterElementoXML(refNfRural, grupo);
        }
    }
}
