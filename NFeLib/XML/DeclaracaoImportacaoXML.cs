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
    public class DeclaracaoImportacaoXML : BaseXML<DeclaracaoImportacaoVO>
    {
        public static CampoNo nDI = new CampoNo("DI", "nDI", 12, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo dDI = new CampoNo("DI", "dDI", 10, TipoDadoXml.Data, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo xLocDesemb = new CampoNo("DI", "xLocDesemb", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo UFDesemb = new CampoNo("DI", "UFDesemb", 2, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo dDesemb = new CampoNo("DI", "dDesemb", 10, TipoDadoXml.Data, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo tpViaTransp = new CampoNo("DI", "tpViaTransp", 2, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vAFRMM = new CampoNo("DI", "vAFRMM", 15, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo tpIntermedio = new CampoNo("DI", "tpIntermedio", 1, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo CNPJ = new CampoNo("DI", "CNPJ", 14, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo UFTerceiro = new CampoNo("DI", "UFTerceiro", 2, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo cExportador = new CampoNo("DI", "cExportador", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);

        public static CampoNo adi = new CampoNo("DI", "adi", 3, TipoDadoXml.Nenhum, 0, 100, TipoCampoXml.Grupo);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("DI");

            no.AdicionarCampo("nDI", nDI);
            no.AdicionarCampo("dDI", dDI);
            no.AdicionarCampo("xLocDesemb", xLocDesemb);
            no.AdicionarCampo("UFDesemb", UFDesemb);
            no.AdicionarCampo("dDesemb", dDesemb);
            no.AdicionarCampo("tpViaTransp", tpViaTransp);
            no.AdicionarCampo("vAFRMM", vAFRMM);
            no.AdicionarCampo("tpIntermedio", tpIntermedio);
            no.AdicionarCampo("cnpj", CNPJ);
            no.AdicionarCampo("ufTerceiro", UFTerceiro);
            no.AdicionarCampo("cExportador", cExportador);
            no.AdicionarCampo("adicoes", adi);

            return no;
        }

        
        public override DeclaracaoImportacaoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(DeclaracaoImportacaoVO di)
        {
            return this.controleXml.ObterElementoXML(di, grupo);
        }
    }
}
