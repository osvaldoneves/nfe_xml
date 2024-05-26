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
    public class ExportacaoIndiretaXML : BaseXML<ExportacaoIndiretaVO>
    {
        public static CampoNo nRE = new CampoNo("exportInd", "nRE", 12, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo chNFe = new CampoNo("exportInd", "chNFe", 44, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo qExport = new CampoNo("exportInd", "qExport", 15, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("exportInd");

            no.AdicionarCampo("nRE", nRE);
            no.AdicionarCampo("chNFe", chNFe);
            no.AdicionarCampo("qExport", qExport);

            return no;
        }

        
        public override ExportacaoIndiretaVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ExportacaoIndiretaVO exportIndi)
        {
            return this.controleXml.ObterElementoXML(exportIndi, grupo);
        }
    }
}
