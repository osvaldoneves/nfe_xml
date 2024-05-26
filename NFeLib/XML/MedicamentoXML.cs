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
    public class MedicamentoXML : BaseXML<MedicamentoVO>
    {
        public static CampoNo nLote = new CampoNo("med", "nLote", 20, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo qLote = new CampoNo("med", "qLote", 12, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo dFab = new CampoNo("med", "dFab", 10, TipoDadoXml.Data, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo dVal = new CampoNo("med", "dVal", 10, TipoDadoXml.Data, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vPMC = new CampoNo("med", "vPMC", 16, TipoDadoXml.Data, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("med");

            no.AdicionarCampo("nLote", nLote);
            no.AdicionarCampo("qLote", qLote);
            no.AdicionarCampo("dFab", dFab);
            no.AdicionarCampo("dVal", dVal);
            no.AdicionarCampo("vPMC", vPMC);

            return no;
        }

        
        public override MedicamentoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(MedicamentoVO medicamento)
        {
            return this.controleXml.ObterElementoXML(medicamento, grupo);
        }
    }
}
