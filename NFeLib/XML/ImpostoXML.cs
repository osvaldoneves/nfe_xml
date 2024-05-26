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
    public class ImpostoXML : BaseXML<ImpostoVO>
    {
        public static CampoNo vTotTrib = new CampoNo("imposto", "vTotTrib", 16, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo ICMS = new CampoNo("imposto", "ICMS", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        public static CampoNo IPI = new CampoNo("imposto", "IPI", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        public static CampoNo II = new CampoNo("imposto", "II", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        public static CampoNo PIS = new CampoNo("imposto", "PIS", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        public static CampoNo PISST = new CampoNo("imposto", "PISST", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        public static CampoNo COFINS = new CampoNo("imposto", "COFINS", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        public static CampoNo COFINSST = new CampoNo("imposto", "COFINSST", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        public static CampoNo ISSQN = new CampoNo("imposto", "ISSQN", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("imposto");

            no.AdicionarCampo("vTotTrib", vTotTrib);
            no.AdicionarCampo("icms", ICMS);
            no.AdicionarCampo("ipi", IPI);
            no.AdicionarCampo("ii", II);
            no.AdicionarCampo("pis", PIS);
            no.AdicionarCampo("pisst", PISST);
            no.AdicionarCampo("cofins", COFINS);
            no.AdicionarCampo("cofinsst", COFINSST);
            no.AdicionarCampo("issqn", ISSQN);

            return no;
        }

        
        public override ImpostoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ImpostoVO imposto)
        {
            return this.controleXml.ObterElementoXML(imposto, grupo);
        }
    }
}
