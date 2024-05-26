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
    public class CombustivelXML : BaseXML<CombustivelVO>
    {
        public static CampoNo cProdANP = new CampoNo("comb", "cProdANP", 9, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo pMixGN = new CampoNo("comb", "pMixGN", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo CODIF = new CampoNo("comb", "CODIF", 21, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo qTemp = new CampoNo("comb", "qTemp", 17, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo UFCons = new CampoNo("comb", "UFCons", 2, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);

        public static CampoNo CIDE = new CampoNo("comb", "CIDE", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("comb");

            no.AdicionarCampo("cProdANP", cProdANP);
            no.AdicionarCampo("pMixGN", pMixGN);
            no.AdicionarCampo("codif", CODIF);
            no.AdicionarCampo("qTemp", qTemp);
            no.AdicionarCampo("UFCons", UFCons);
            no.AdicionarCampo("cide", CIDE);

            return no;
        }

        
        public override CombustivelVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(CombustivelVO combustivel)
        {
            return this.controleXml.ObterElementoXML(combustivel, grupo);
        }
    }
}
