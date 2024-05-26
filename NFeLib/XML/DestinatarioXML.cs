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
    public class DestinatarioXML : BaseXML<DestinatarioVO>
    {
        public static CampoNo cpf = new CampoNo("dest", "CPF", 11, TipoDadoXml.Numerico , 1, 1,TipoCampoXml.ElementoEscolha);
        public static CampoNo cnpj = new CampoNo("dest", "CNPJ", 14, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.ElementoEscolha);
        public static CampoNo idEstrangeiro = new CampoNo("dest", "idEstrangeiro", 20, TipoDadoXml.String, 1, 1, TipoCampoXml.ElementoEscolha);
        public static CampoNo xNome = new CampoNo("dest", "xNome", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo indIEDest = new CampoNo("dest", "indIEDest", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo IE = new CampoNo("dest", "IE", 14, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo ISUF = new CampoNo("dest", "ISUF", 9, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo IM = new CampoNo("dest", "IM", 15, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo email= new CampoNo("dest", "email", 60, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static CampoNo enderDest = new CampoNo("dest", "enderDest", 0, TipoDadoXml.Nenhum, 0, 1, TipoCampoXml.Grupo);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("dest");

            no.AdicionarCampo("cpf", cpf);
            no.AdicionarCampo("cnpj", cnpj);
            no.AdicionarCampo("idEstrangeiro", idEstrangeiro);
            no.AdicionarCampo("xNome", xNome);
            no.AdicionarCampo("indIEDest", indIEDest);
            no.AdicionarCampo("IE", IE);
            no.AdicionarCampo("ISUF", ISUF);
            no.AdicionarCampo("IM", IM);
            no.AdicionarCampo("email", email);
            no.AdicionarCampo("enderDest", enderDest);

            return no;
        }

        
        public override DestinatarioVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(DestinatarioVO destinatario)
        {
            return this.controleXml.ObterElementoXML(destinatario, grupo);
        }
    }
}
