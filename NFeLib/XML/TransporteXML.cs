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
    public class TransporteXML : BaseXML<TransporteVO>
    {
        public static CampoNo modFrete = new CampoNo("transp", "modFrete", 1, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo transporta = new CampoNo("transp", "transporta", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo retTransp = new CampoNo("transp", "retTransp", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo veicTransp = new CampoNo("transp", "veicTransp", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo reboque = new CampoNo("transp", "reboque", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo vol = new CampoNo("transp", "vol", 0, TipoDadoXml.Nenhum, 0, 5000, TipoCampoXml.Grupo);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("transp");

            no.AdicionarCampo("modFrete", modFrete);
            no.AdicionarCampo("transporta", transporta);
            no.AdicionarCampo("retTransp", retTransp);
            no.AdicionarCampo("veicTransp", veicTransp);
            no.AdicionarCampo("reboque", reboque);
            no.AdicionarCampo("vol", vol);

            return no;
        }

        
        public override TransporteVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(TransporteVO transp)
        {
            return this.controleXml.ObterElementoXML(transp, grupo);
        }
    }
}
