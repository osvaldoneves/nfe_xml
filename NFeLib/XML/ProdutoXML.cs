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
    public class ProdutoXML : BaseXML<ProdutoVO>
    {
        public static CampoNo cProd = new CampoNo("prod", "cProd", 60, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo cEAN = new CampoNo("prod", "cEAN", 14, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo xProd = new CampoNo("prod", "xProd", 120, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo NCM = new CampoNo("prod", "NCM", 8, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo NVE = new CampoNo("prod", "NVE", 6, TipoDadoXml.Numerico, 0, 8, TipoCampoXml.Elemento);
        public static CampoNo EXTIPI = new CampoNo("prod", "EXTIPI", 3, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo CFOP = new CampoNo("prod", "CFOP", 4, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo uCom = new CampoNo("prod", "uCom", 6, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo qCom = new CampoNo("prod", "qCom", 15, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vUnCom = new CampoNo("prod", "vUnCom", 21, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vProd = new CampoNo("prod", "vProd", 15, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cEANTrib = new CampoNo("prod", "cEANTrib", 14, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo uTrib = new CampoNo("prod", "uTrib", 6, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo qTrib = new CampoNo("prod", "qTrib", 15, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vUnTrib = new CampoNo("prod", "vUnTrib", 21, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vFrete = new CampoNo("prod", "vFrete", 15, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vSeg = new CampoNo("prod", "vSeg", 15, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vDesc = new CampoNo("prod", "vDesc", 15, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vOutro = new CampoNo("prod", "vOutro", 15, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo indTot = new CampoNo("prod", "indTot", 15, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        
        public static CampoNo di = new CampoNo("prod", "di", 0, TipoDadoXml.Nenhum, 1, 100, TipoCampoXml.Grupo);
        public static CampoNo detExport = new CampoNo("prod", "detExport", 0, TipoDadoXml.Nenhum, 1, 500, TipoCampoXml.Grupo);


        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("prod");

            no.AdicionarCampo("cProd", cProd);
            no.AdicionarCampo("cEAN", cEAN);
            no.AdicionarCampo("xProd", xProd);
            no.AdicionarCampo("ncm", NCM);
            no.AdicionarCampo("nve", NVE);
            no.AdicionarCampo("extipi", EXTIPI);
            no.AdicionarCampo("cfop", CFOP);
            no.AdicionarCampo("uCom", uCom);
            no.AdicionarCampo("qCom", qCom);
            no.AdicionarCampo("vUnCom", vUnCom);
            no.AdicionarCampo("vProd", vProd);
            no.AdicionarCampo("cEANTrib", cEANTrib);
            no.AdicionarCampo("uTrib", uTrib);
            no.AdicionarCampo("qTrib", qTrib);
            no.AdicionarCampo("vUnTrib", vUnTrib);
            no.AdicionarCampo("vFrete", vFrete);
            no.AdicionarCampo("vSeg", vSeg);
            no.AdicionarCampo("vDesc", vDesc);
            no.AdicionarCampo("vOutro", vOutro);
            no.AdicionarCampo("indTot", indTot);

            no.AdicionarCampo("dis", di);
            no.AdicionarCampo("detExport", detExport);
            return no;
        }

        
        public override ProdutoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ProdutoVO produto)
        {
            return this.controleXml.ObterElementoXML(produto, grupo);
        }
    }
}
