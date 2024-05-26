
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
    public class CobrancaXML : BaseXML<CobrancaVO>
    {
        public static CampoNo fat = new CampoNo("cobr", "fat", 0, TipoDadoXml.Nenhum, 0, 1,TipoCampoXml.Grupo);
        public static CampoNo dup = new CampoNo("cobr", "dup", 0, TipoDadoXml.Nenhum, 0, 120, TipoCampoXml.Grupo);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("cobr");

            no.AdicionarCampo("fat", fat);
            no.AdicionarCampo("dup", dup);

            return no;
        }

        
        public override CobrancaVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(CobrancaVO cobr)
        {
            return this.controleXml.ObterElementoXML(cobr, grupo);
        }
    }
}
