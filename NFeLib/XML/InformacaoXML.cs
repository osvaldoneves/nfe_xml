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
    public class InformacaoXML : BaseXML<InformacaoVO>
    {
        public static CampoNo versao = new CampoNo("infNFe", "versao", 4, TipoDadoXml.String, 1, 1,TipoCampoXml.Atributo);
        public static CampoNo Id = new CampoNo("infNFe", "Id", 47, TipoDadoXml.String, 1, 1, TipoCampoXml.Atributo);
        public static CampoNo ide = new CampoNo("infNFe", "ide", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        public static CampoNo emit = new CampoNo("infNFe", "emit", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        public static CampoNo dest = new CampoNo("infNFe", "dest", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo retirada = new CampoNo("infNFe", "retirada", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo entrega = new CampoNo("infNFe", "entrega", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo autXML = new CampoNo("infNFe", "autXML", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo det = new CampoNo("infNFe", "det", 0, TipoDadoXml.Nenhum, 1, 990, TipoCampoXml.Grupo);
        public static CampoNo total = new CampoNo("infNFe", "total", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        public static CampoNo transp = new CampoNo("infNFe", "transp", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        public static CampoNo cobr = new CampoNo("infNFe", "cobr", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo pag = new CampoNo("infNFe", "pag", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo infoAdic = new CampoNo("infNFe", "infoAdic", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo exporta = new CampoNo("infNFe", "exporta", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo compra = new CampoNo("infNFe", "compra", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);
        public static CampoNo cana = new CampoNo("infNFe", "cana", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("infNFe");

            no.AdicionarCampo("versao", versao);
            no.AdicionarCampo("Id", Id);
            no.AdicionarCampo("ide", ide);
            no.AdicionarCampo("emit", emit);
            no.AdicionarCampo("dest", dest);
            no.AdicionarCampo("retirada", retirada);
            no.AdicionarCampo("entrega", entrega);
            no.AdicionarCampo("autXML", autXML);
            no.AdicionarCampo("det", det);
            no.AdicionarCampo("total", total);
            no.AdicionarCampo("transp", transp);
            no.AdicionarCampo("cobr", cobr);
            no.AdicionarCampo("pag", pag);
            no.AdicionarCampo("infoAdic", infoAdic);
            no.AdicionarCampo("exporta", exporta);
            no.AdicionarCampo("compra", compra);
            no.AdicionarCampo("cana", cana);

            return no;
        }

        
        public override InformacaoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(InformacaoVO infoNFe)
        {
            return this.controleXml.ObterElementoXML(infoNFe, grupo);
        }
    }
}
