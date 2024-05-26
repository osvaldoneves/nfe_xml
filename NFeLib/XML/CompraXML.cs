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
    public class CompraXML : BaseXML<CompraVO>
    {
        public static CampoNo xNEmp = new CampoNo("compra", "xNEmp", 22, TipoDadoXml.String, 0, 1,TipoCampoXml.Elemento);
        public static CampoNo xPed = new CampoNo("compra", "xPed", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo xCont = new CampoNo("compra", "xCont", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("compra");

            no.AdicionarCampo("xNEmp", xNEmp);
            no.AdicionarCampo("xPed", xPed);
            no.AdicionarCampo("xCont", xCont);

            return no;
        }

        
        public override CompraVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(CompraVO compra)
        {
            return this.controleXml.ObterElementoXML(compra, grupo);
        }
    }
}
