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
    public class ExportacaoXML : BaseXML<ExportacaoVO>
    {
        public static CampoNo nDraw = new CampoNo("detExport", "nDraw", 11, TipoDadoXml.Numerico, 0, 1,TipoCampoXml.Elemento);

        public static CampoNo exportInd = new CampoNo("detExport", "exportInd", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("detExport");

            no.AdicionarCampo("nDraw", nDraw);
            no.AdicionarCampo("exportInd", exportInd);

            return no;
        }

        
        public override ExportacaoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ExportacaoVO exportacao)
        {
            return this.controleXml.ObterElementoXML(exportacao, grupo);
        }
    }
}
