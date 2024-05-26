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
    public class CartaoXML : BaseXML<CartaoVO>
    {
        public static CampoNo CNPJ = new CampoNo("card", "CNPJ", 14, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo tBand = new CampoNo("card", "tBand", 2, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cAut = new CampoNo("card", "cAut", 20, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);


        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("card");

            no.AdicionarCampo("CNPJ", CNPJ);
            no.AdicionarCampo("tBand", tBand);
            no.AdicionarCampo("cAut", cAut);

            return no;
        }

        
        public override CartaoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(CartaoVO card)
        {
            return this.controleXml.ObterElementoXML(card, grupo);
        }
    }
}
