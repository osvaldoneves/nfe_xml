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
    public class RetencaoICMSTransporteXML : BaseXML<RetencaoICMSTransporteVO>
    {
        public static CampoNo vServ = new CampoNo("retTransp", "vServ", 16, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo vBCRet = new CampoNo("retTransp", "vBCRet", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pICMSRet = new CampoNo("retTransp", "pICMSRet", 8, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vICMSRet = new CampoNo("retTransp", "vICMSRet", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo CFOP = new CampoNo("retTransp", "CFOP", 4, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cMunFG = new CampoNo("retTransp", "cMunFG", 7, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("retTransp");

            no.AdicionarCampo("vServ", vServ);
            no.AdicionarCampo("vBCRet ", vBCRet);
            no.AdicionarCampo("pICMSRet ", pICMSRet);
            no.AdicionarCampo("vICMSRet ", vICMSRet);
            no.AdicionarCampo("cfop ", CFOP);
            no.AdicionarCampo("cMunFG ", cMunFG);

            return no;
        }

        
        public override RetencaoICMSTransporteVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(RetencaoICMSTransporteVO retTransp)
        {
            return this.controleXml.ObterElementoXML(retTransp, grupo);
        }
    }
}
