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
    public class IPIXML : BaseXML<IPIVO>
    {
        public static CampoNo clEnq = new CampoNo("IPI", "clEnq", 5, TipoDadoXml.String, 0, 1,TipoCampoXml.Elemento);
        public static CampoNo CNPJProd = new CampoNo("IPI", "CNPJProd", 14, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo cSelo = new CampoNo("IPI", "cSelo", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo qSelo = new CampoNo("IPI", "qSelo", 12, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo cEnq = new CampoNo("IPI", "cEnq", 3, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);

        public static CampoNo IPITrib = new CampoNo("IPI", "IPITrib", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);
        public static CampoNo IPINT = new CampoNo("IPI", "IPINT", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("IPI");

            no.AdicionarCampo("clEnq", clEnq);
            no.AdicionarCampo("CNPJProd", CNPJProd);
            no.AdicionarCampo("cSelo", cSelo);
            no.AdicionarCampo("qSelo", qSelo);
            no.AdicionarCampo("cEnq", cEnq);
            no.AdicionarCampo("ipiTrib", IPITrib);
            no.AdicionarCampo("ipiNT", IPINT);

            return no;
        }

        
        public override IPIVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(IPIVO ipi)
        {
            return this.controleXml.ObterElementoXML(ipi, grupo);
        }
    }
}
