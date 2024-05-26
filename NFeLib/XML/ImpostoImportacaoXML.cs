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
    public class ImpostoImportacaoXML : BaseXML<ImpostoImportacaoVO>
    {
        public static CampoNo vBC = new CampoNo("II", "vBC", 16, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo vDespAdu = new CampoNo("II", "vDespAdu", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vII = new CampoNo("II", "vII", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo vIOF = new CampoNo("II", "vIOF", 16, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("II");

            no.AdicionarCampo("vBC", vBC);
            no.AdicionarCampo("vDespAdu", vDespAdu);
            no.AdicionarCampo("vII", vII);
            no.AdicionarCampo("vIOF", vIOF);

            return no;
        }

        
        public override ImpostoImportacaoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ImpostoImportacaoVO ii)
        {
            return this.controleXml.ObterElementoXML(ii, grupo);
        }
    }
}
