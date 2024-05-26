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
    public class VolumeXML : BaseXML<VolumeVO>
    {
        public static CampoNo qVol = new CampoNo("vol", "qVol", 15, TipoDadoXml.Numerico, 0, 1,TipoCampoXml.Elemento);
        public static CampoNo esp = new CampoNo("vol", "esp", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo marca = new CampoNo("vol", "marca", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo nVol = new CampoNo("vol", "nVol", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pesoL = new CampoNo("vol", "pesoL", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pesoB = new CampoNo("vol", "pesoB", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static CampoNo lacre = new CampoNo("vol", "lacre ", 0, TipoDadoXml.Nenhum, 0, 5000, TipoCampoXml.Grupo);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("vol");

            no.AdicionarCampo("qVol", qVol);
            no.AdicionarCampo("esp", esp);
            no.AdicionarCampo("marca", marca);
            no.AdicionarCampo("nVol", nVol);
            no.AdicionarCampo("pesoL", pesoL);
            no.AdicionarCampo("pesoB", pesoB);
            no.AdicionarCampo("lacre", lacre);

            return no;
        }

        
        public override VolumeVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(VolumeVO vol)
        {
            return this.controleXml.ObterElementoXML(vol, grupo);
        }
    }
}
