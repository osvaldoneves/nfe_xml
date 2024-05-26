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
    public class ArmamentoXML : BaseXML<ArmamentoVO>
    {
        public static CampoNo tpArma = new CampoNo("arma", "tpArma", 1, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo nSerie = new CampoNo("arma", "nSerie", 15, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo nCano = new CampoNo("arma", "nCano", 15, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo descr = new CampoNo("arma", "descr", 256, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("arma");

            no.AdicionarCampo("tpArma", tpArma);
            no.AdicionarCampo("nSerie", nSerie);
            no.AdicionarCampo("nCano", nCano);
            no.AdicionarCampo("descr", descr);

            return no;
        }

        
        public override ArmamentoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ArmamentoVO arma)
        {
            return this.controleXml.ObterElementoXML(arma, grupo);
        }
    }
}
