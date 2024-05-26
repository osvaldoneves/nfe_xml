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
    public class COFINSSTXML : BaseXML<COFINSSTVO>
    {
        public static CampoNo vBC = new CampoNo("COFINSST", "vBC", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pCOFINS = new CampoNo("COFINSST", "pCOFINS", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo qBCProd = new CampoNo("COFINSST", "qBCProd", 17, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vAliqProd = new CampoNo("COFINSST", "vAliqProd", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vCOFINS = new CampoNo("COFINSST", "vCOFINS", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("COFINSST");

            no.AdicionarCampo("vBC", vBC);
            no.AdicionarCampo("pCOFINS", pCOFINS);
            no.AdicionarCampo("qBCProd", qBCProd);
            no.AdicionarCampo("vAliqProd", vAliqProd);
            no.AdicionarCampo("vCOFINS", vCOFINS);

            return no;
        }

        
        public override COFINSSTVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(COFINSSTVO cofins)
        {
            return this.controleXml.ObterElementoXML(cofins, grupo);
        }
    }
}
