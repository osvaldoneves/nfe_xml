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
    public class COFINSXML : BaseXML<COFINSVO>
    {
        public static CampoNo cofins = new CampoNo("COFINS", "COFINS", 0, TipoDadoXml.Nenhum, 1, 1,TipoCampoXml.GrupoEscolha);
        //public static CampoNo icms10 = new CampoNo("COFINS", "COFINS10", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);
        //public static CampoNo icms20 = new CampoNo("COFINS", "COFINS20", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);
        //public static CampoNo icms30 = new CampoNo("ICMS", "COFINS30", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);
        //public static CampoNo icms40 = new CampoNo("ICMS", "COFINS40", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);
        //public static CampoNo icms41 = new CampoNo("ICMS", "COFINS41", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);
        //public static CampoNo icms50 = new CampoNo("ICMS", "COFINS50", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);
        
        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("COFINS");

            no.AdicionarCampo("cofins", cofins);

            return no;
        }

        
        public override COFINSVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(COFINSVO cofins)
        {
            return this.controleXml.ObterElementoXML(cofins, grupo);
        }
    }
}
