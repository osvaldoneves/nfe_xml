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
    public class ISSQNTotalXML : BaseXML<ISSQNTotalVO>
    {
        public static CampoNo vServ = new CampoNo("ISSQNtot", "vServ", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vBC = new CampoNo("ISSQNtot", "vBC", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vISS = new CampoNo("ISSQNtot", "vISS", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vPIS = new CampoNo("ISSQNtot", "vPIS", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vCOFINS = new CampoNo("ISSQNtot", "vCOFINS", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo dCompet = new CampoNo("ISSQNtot", "dCompet", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vDeducao = new CampoNo("ISSQNtot", "vDeducao", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vOutro = new CampoNo("ISSQNtot", "vOutro", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vDescIncond = new CampoNo("ISSQNtot", "vDescIncond", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vDescCond = new CampoNo("ISSQNtot", "vDescCond", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vISSRet = new CampoNo("ISSQNtot", "vISSRet", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo cRegTrib = new CampoNo("ISSQNtot", "cRegTrib", 2, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("ISSQNtot");

            no.AdicionarCampo("vServ", vServ);
            no.AdicionarCampo("vBC", vBC);
            no.AdicionarCampo("vISS", vISS);
            no.AdicionarCampo("vPIS", vPIS);
            no.AdicionarCampo("vCOFINS", vCOFINS);
            no.AdicionarCampo("dCompet", dCompet);
            no.AdicionarCampo("vDeducao", vDeducao);
            no.AdicionarCampo("vOutro", vOutro);
            no.AdicionarCampo("vDescIncond", vDescIncond);
            no.AdicionarCampo("vDescCond", vDescCond);
            no.AdicionarCampo("vISSRet", vISSRet);
            no.AdicionarCampo("cRegTrib", cRegTrib);

            return no;
        }

        
        public override ISSQNTotalVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ISSQNTotalVO issqnTotal)
        {
            return this.controleXml.ObterElementoXML(issqnTotal, grupo);
        }
    }
}
