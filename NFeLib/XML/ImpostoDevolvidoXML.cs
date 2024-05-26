
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
    public class ImpostoDevolvidoXML : BaseXML<ImpostoDevolvidoVO>
    {
        public static CampoNo pDevol = new CampoNo("impostoDevol", "pDevol", 6, TipoDadoXml.String, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo ipiDevol = new CampoNo("impostoDevol", "ipiDevol", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.Grupo);
        

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("impostoDevol");

            no.AdicionarCampo("pDevol", pDevol);
            no.AdicionarCampo("ipiDevol", ipiDevol);
            

            return no;
        }

        
        public override ImpostoDevolvidoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(ImpostoDevolvidoVO impostoDevolvido)
        {
            return this.controleXml.ObterElementoXML(impostoDevolvido, grupo);
        }
    }
}
