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
    public class TotalXML : BaseXML<TotalVO>
    {
        public static CampoNo ICMSTot = new CampoNo("total", "ICMSTot ", 0, TipoDadoXml.String, 1, 1,TipoCampoXml.Grupo);
        public static CampoNo ISSNQTot = new CampoNo("total", "ISSNQTot", 0, TipoDadoXml.String, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo retTrib = new CampoNo("total", "retTrib", 0, TipoDadoXml.String, 0, 1, TipoCampoXml.Grupo);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("total");

            no.AdicionarCampo("ICMSTot", ICMSTot);
            no.AdicionarCampo("ISSNQTot", ISSNQTot);
            no.AdicionarCampo("retTrib", retTrib);

            return no;
        }

        
        public override TotalVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(TotalVO total)
        {
            return this.controleXml.ObterElementoXML(total, grupo);
        }
    }
}
