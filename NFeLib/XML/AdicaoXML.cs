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
    public class AdicaoXML : BaseXML<AdicaoVO>
    {
        public static CampoNo nAdicao = new CampoNo("adi", "nAdicao", 3, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo nSeqAdic = new CampoNo("adi", "nSeqAdic", 3, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cFabricante = new CampoNo("adi", "cFabricante", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vDescDI = new CampoNo("adi", "vDescDI", 15, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo nDraw = new CampoNo("adi", "nDraw", 11, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("adi");

            no.AdicionarCampo("nAdicao", nAdicao);
            no.AdicionarCampo("nSeqAdic", nSeqAdic);
            no.AdicionarCampo("cFabricante", cFabricante);
            no.AdicionarCampo("vDescDI", vDescDI);
            no.AdicionarCampo("nDraw", nDraw);

            return no;
        }

        
        public override AdicaoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(AdicaoVO adicao)
        {
            return this.controleXml.ObterElementoXML(adicao, grupo);
        }
    }
}
