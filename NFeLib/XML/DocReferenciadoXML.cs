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
    public class DocReferenciadoXML : BaseXML<DocReferenciadoVO>
    {
        public static CampoNo refNFe = new CampoNo("NFref", "refNFe", 44, TipoDadoXml.String, 1, 1,TipoCampoXml.ElementoEscolha);

        public static CampoNo refNF = new CampoNo("NFref", "refNF", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);
        public static CampoNo refNFP = new CampoNo("NFref", "refNFP", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("NFref");

            no.AdicionarCampo("refNFe", refNFe);
            no.AdicionarCampo("refNF", refNF);
            no.AdicionarCampo("refNFP", refNFP);

            return no;
        }

        
        public override DocReferenciadoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(DocReferenciadoVO docReferenciado)
        {
            return this.controleXml.ObterElementoXML(docReferenciado, grupo);
        }
    }
}
