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
    public class EmitenteXML : BaseXML<EmitenteVO>
    {
        public static CampoNo cpf = new CampoNo("emit", "CPF", 11, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.ElementoEscolha);
        public static CampoNo cnpj = new CampoNo("emit", "CNPJ", 14, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.ElementoEscolha);
        public static CampoNo xNome = new CampoNo("emit", "xNome", 60, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo xFant = new CampoNo("emit", "xFant", 60, TipoDadoXml.String, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo IE = new CampoNo("emit", "IE", 14, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo IEST = new CampoNo("emit", "IEST", 14, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo IM = new CampoNo("emit", "IM", 15, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo CNAE = new CampoNo("emit", "CNAE", 7, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo CRT = new CampoNo("emit", "CRT", 1, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);

        public static CampoNo enderEmit = new CampoNo("emit", "enderEmit", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo); 

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("emit");

            no.AdicionarCampo("cpf", cpf);
            no.AdicionarCampo("cnpj", cnpj);
            no.AdicionarCampo("xNome", xNome);
            no.AdicionarCampo("xFant", xFant);
            no.AdicionarCampo("IE", IE);
            no.AdicionarCampo("IEST", IEST);
            no.AdicionarCampo("im", IM);
            no.AdicionarCampo("cnae", CNAE);
            no.AdicionarCampo("CRT", CRT);
            no.AdicionarCampo("enderEmit", enderEmit);

            return no;
        }

        
        public override EmitenteVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(EmitenteVO emitente)
        {
            return this.controleXml.ObterElementoXML(emitente, grupo);
        }
    }
}
