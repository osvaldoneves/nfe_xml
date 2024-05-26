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
    public class ISSQNXML : BaseXML<ISSQNVO>
    {
        public static CampoNo vBC = new CampoNo("ISSQN", "vBC", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vAliq = new CampoNo("ISSQN", "vAliq", 8, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vISSQN = new CampoNo("ISSQN", "vISSQN", 6, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cMunFG = new CampoNo("ISSQN", "cMunFG", 7, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cListServ = new CampoNo("ISSQN", "cListServ", 5, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vDeducao = new CampoNo("ISSQN", "vDeducao", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vOutro = new CampoNo("ISSQN", "vOutro", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vDescIncond = new CampoNo("ISSQN", "vDescIncond", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vDescCond = new CampoNo("ISSQN", "vDescCond", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vISSRet = new CampoNo("ISSQN", "vISSRet", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo indISS = new CampoNo("ISSQN", "indISS", 2, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cServico = new CampoNo("ISSQN", "cServico", 20, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo cMun = new CampoNo("ISSQN", "cMun", 7, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo cPais = new CampoNo("ISSQN", "cPais", 4, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo nProcesso = new CampoNo("ISSQN", "nProcesso", 30, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo indIncentivo = new CampoNo("ISSQN", "indIncentivo", 1, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("ISSQN");

            no.AdicionarCampo("vBC", vBC);
            no.AdicionarCampo("vAliq", vAliq);
            no.AdicionarCampo("vISSQN", vISSQN);
            no.AdicionarCampo("cMunFG", cMunFG);
            no.AdicionarCampo("cListServ", cListServ);
            no.AdicionarCampo("vDeducao", vDeducao);
            no.AdicionarCampo("vOutro", vOutro);
            no.AdicionarCampo("vDescIncond", vDescIncond);
            no.AdicionarCampo("vDescCond", vDescCond);
            no.AdicionarCampo("vISSRet", vISSRet);
            no.AdicionarCampo("indISS", indISS);
            no.AdicionarCampo("cServico", cServico);
            no.AdicionarCampo("cMun", cMun);
            no.AdicionarCampo("cPais", cPais);
            no.AdicionarCampo("nProcesso", nProcesso);
            no.AdicionarCampo("indIncentivo", indIncentivo);

            return no;
        }

        
        public override ISSQNVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ISSQNVO issqn)
        {
            return this.controleXml.ObterElementoXML(issqn, grupo);
        }
    }
}
