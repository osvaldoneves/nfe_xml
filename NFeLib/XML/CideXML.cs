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
    public class CideXML : BaseXML<CideVO>
    {
        public static CampoNo qBCProd = new CampoNo("CIDE", "qBCProd", 17, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo vAliqProd = new CampoNo("CIDE", "vAliqProd", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vCIDE = new CampoNo("CIDE", "vCIDE", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("CIDE");

            no.AdicionarCampo("qBCProd", qBCProd);
            no.AdicionarCampo("vAliqProd", vAliqProd);
            no.AdicionarCampo("vCIDE", vCIDE);

            return no;
        }

        
        public override CideVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(CideVO cide)
        {
            return this.controleXml.ObterElementoXML(cide, grupo);
        }
    }
}
