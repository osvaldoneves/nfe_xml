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
    public class IdentificacaoXML : BaseXML<IdentificacaoVO>
    {
        public static CampoNo cUF = new CampoNo("ide", "cUF", 2, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cNF = new CampoNo("ide", "cNF", 8, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo natOp = new CampoNo("ide", "natOp", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo indPag = new CampoNo("ide", "indPag", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo mod = new CampoNo("ide", "mod", 2, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo serie = new CampoNo("ide", "serie", 3, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo nNF = new CampoNo("ide", "nNF", 9, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo dhEmi = new CampoNo("ide", "dhEmi", 25, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo dhSaiEnt = new CampoNo("ide", "dhSaiEnt", 25, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo tpNF = new CampoNo("ide", "tpNF", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo idDest = new CampoNo("ide", "idDest", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cMunFG = new CampoNo("ide", "cMunFG", 7, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo tpImp = new CampoNo("ide", "tpImp", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo tpEmis = new CampoNo("ide", "tpEmis", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cDV = new CampoNo("ide", "cDV", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo tpAmb = new CampoNo("ide", "tpAmb", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo finNFe = new CampoNo("ide", "finNFe", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo indFinal = new CampoNo("ide", "indFinal", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo indPres = new CampoNo("ide", "indPres", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo procEmi = new CampoNo("ide", "procEmi", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo verProc = new CampoNo("ide", "verProc", 20, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo dhCont = new CampoNo("ide", "dhCont", 25, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo xJust = new CampoNo("ide", "xJust", 256, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);

        public static CampoNo NFref = new CampoNo("ide", "NFref", 0, TipoDadoXml.Nenhum, 0, 500, TipoCampoXml.Grupo);

        public static Grupo grupo = SetGrupo();

        private static Grupo SetGrupo()
        {
            Grupo no = new Grupo("ide");

            no.AdicionarCampo("cUF", cUF);
            no.AdicionarCampo("cNF", cNF);
            no.AdicionarCampo("natOp", natOp);
            no.AdicionarCampo("indPag", indPag);
            no.AdicionarCampo("mod", mod);
            no.AdicionarCampo("serie", serie);
            no.AdicionarCampo("nNF", nNF);
            no.AdicionarCampo("dhEmi", dhEmi);
            no.AdicionarCampo("dhSaiEnt", dhSaiEnt);
            no.AdicionarCampo("tpNF", tpNF);
            no.AdicionarCampo("idDest", idDest);
            no.AdicionarCampo("cMunFG", cMunFG);
            no.AdicionarCampo("tpImp", tpImp);
            no.AdicionarCampo("tpEmis", tpEmis);
            no.AdicionarCampo("cDV", cDV);
            no.AdicionarCampo("tpAmb", tpAmb);
            no.AdicionarCampo("finNFe", finNFe);
            no.AdicionarCampo("indFinal", indFinal);
            no.AdicionarCampo("indPres", indPres);
            no.AdicionarCampo("procEmi", procEmi);
            no.AdicionarCampo("verProc", verProc);
            no.AdicionarCampo("dhCont", dhCont);
            no.AdicionarCampo("xJust", xJust);

            no.AdicionarCampo("NFref", NFref);

            return no;
        }

        public override IdentificacaoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(IdentificacaoVO identificacao)
        {
            return this.controleXml.ObterElementoXML(identificacao, grupo);
        }
    }
}
