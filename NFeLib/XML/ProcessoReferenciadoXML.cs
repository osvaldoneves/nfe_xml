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
    public class ProcessoReferenciadoXML : BaseXML<ProcessoReferenciadoVO>
    {
        public static CampoNo nProc = new CampoNo("procRef", "nProc", 11, TipoDadoXml.String, 1, 1,TipoCampoXml.ElementoEscolha);
        public static CampoNo indProc = new CampoNo("procRef", "indProc", 14, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.ElementoEscolha);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("procRef");

            no.AdicionarCampo("nProc", nProc);
            no.AdicionarCampo("indProc", indProc);

            return no;
        }

        
        public override ProcessoReferenciadoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ProcessoReferenciadoVO procRef)
        {
            return this.controleXml.ObterElementoXML(procRef, grupo);
        }
    }
}
