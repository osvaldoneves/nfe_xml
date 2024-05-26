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
    public class VeiculoTransporteXML : BaseXML<VeiculoTransporteVO>
    {
        public static CampoNo placa = new CampoNo("veicTransp", "placa", 7, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo UF = new CampoNo("veicTransp", "UF", 2, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo RNTC = new CampoNo("veicTransp", "RNTC", 20, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("veicTransp");

            no.AdicionarCampo("placa", placa);
            no.AdicionarCampo("uf", UF);
            no.AdicionarCampo("rntc", RNTC);

            return no;
        }

        
        public override VeiculoTransporteVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(VeiculoTransporteVO veicTransp)
        {
            return this.controleXml.ObterElementoXML(veicTransp, grupo);
        }
    }
}
