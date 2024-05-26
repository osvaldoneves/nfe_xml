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
    public class RetencaoTributoXML : BaseXML<RetencaoTributoVO>
    {
        public static CampoNo vRetPIS = new CampoNo("retTrib", "vRetPIS", 16, TipoDadoXml.Numerico, 0, 1,TipoCampoXml.Elemento);
        public static CampoNo vRetCOFINS = new CampoNo("retTrib", "vRetCOFINS", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vRetCSLL = new CampoNo("retTrib", "vRetCSLL", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vBCIRRF = new CampoNo("retTrib", "vBCIRRF", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vIRRF = new CampoNo("retTrib", "vIRRF", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vBCRetPrev = new CampoNo("retTrib", "vBCRetPrev", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vRetPrev = new CampoNo("retTrib", "vRetPrev", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("retTrib");

            no.AdicionarCampo("vRetPIS", vRetPIS);
            no.AdicionarCampo("vRetCOFINS", vRetCOFINS);
            no.AdicionarCampo("vRetCSLL", vRetCSLL);
            no.AdicionarCampo("vBCIRRF", vBCIRRF);
            no.AdicionarCampo("vIRRF", vIRRF);
            no.AdicionarCampo("vBCRetPrev", vBCRetPrev);
            no.AdicionarCampo("vRetPrev", vRetPrev);

            return no;
        }

        
        public override RetencaoTributoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(RetencaoTributoVO retTrib)
        {
            return this.controleXml.ObterElementoXML(retTrib, grupo);
        }
    }
}
