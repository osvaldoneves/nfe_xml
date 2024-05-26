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
    public class CanaXML : BaseXML<CanaVO>
    {
        public static CampoNo safra = new CampoNo("cana", "safra", 9, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo refe = new CampoNo("cana", "ref", 7, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo forDia = new CampoNo("cana", "forDia", 0, TipoDadoXml.Nenhum, 1, 31, TipoCampoXml.Grupo);
        public static CampoNo deduc = new CampoNo("cana", "deduc", 0, TipoDadoXml.Nenhum, 1, 10, TipoCampoXml.Grupo);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("cana");

            no.AdicionarCampo("safra", safra);
            no.AdicionarCampo("refe", refe);
            no.AdicionarCampo("forDia", forDia);
            no.AdicionarCampo("deduc", deduc);

            return no;
        }

        
        public override CanaVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(CanaVO cana)
        {
            return this.controleXml.ObterElementoXML(cana, grupo);
        }
    }
}
