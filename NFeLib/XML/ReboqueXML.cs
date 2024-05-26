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
    public class ReboqueXML : BaseXML<ReboqueVO>
    {
        public static CampoNo placa = new CampoNo("reboque", "placa", 7, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo UF = new CampoNo("reboque", "UF", 2, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo RNTC = new CampoNo("reboque", "RNTC", 20, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vagao = new CampoNo("reboque", "vagao", 20, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo balsa = new CampoNo("reboque", "balsa", 20, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("reboque");

            no.AdicionarCampo("placa", placa);
            no.AdicionarCampo("uf", UF);
            no.AdicionarCampo("rntc", RNTC);
            no.AdicionarCampo("vagao", vagao);
            no.AdicionarCampo("balsa", balsa);

            return no;
        }

        
        public override ReboqueVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ReboqueVO reboque)
        {
            return this.controleXml.ObterElementoXML(reboque, grupo);
        }
    }
}
