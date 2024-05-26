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
    public class DetalhamentoXML : BaseXML<DetalhamentoVO>
    {
        public static CampoNo nItem = new CampoNo("det", "nItem", 3, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Atributo);

        public static CampoNo prod = new CampoNo("det", "prod", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        public static CampoNo imposto = new CampoNo("det", "imposto", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        public static CampoNo impostoDevol = new CampoNo("det", "impostoDevol", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo infAdProd = new CampoNo("det", "infAdProd", 500, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("det");

            no.AdicionarCampo("nItem", nItem);
            no.AdicionarCampo("prod", prod);
            no.AdicionarCampo("imposto", imposto);
            no.AdicionarCampo("impostoDevol", impostoDevol);
            no.AdicionarCampo("infAdProd", infAdProd);

            return no;
        }

        
        public override DetalhamentoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(DetalhamentoVO detalhamento)
        {
            return this.controleXml.ObterElementoXML(detalhamento, grupo);
        }
    }
}
