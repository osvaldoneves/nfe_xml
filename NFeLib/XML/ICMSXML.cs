using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;
using OLNG.Bibliotecas.NFeLib.VO;
using OLNG.Bibliotecas.NFeLib.Base;
using OLNG.Bibliotecas.NFeLib.XML.ICMS;

namespace OLNG.Bibliotecas.NFeLib.XML
{
    public class ICMSXML : BaseXML<ICMSVO>
    {
        public static CampoNo cnpj = new CampoNo("ICMS", "CNPJ", 14, TipoDadoXml.String, 1, 1, TipoCampoXml.ElementoEscolha);

        public static CampoNo ICMS = new CampoNo("ICMS", "ICMS", 0, TipoDadoXml.Nenhum, 1, 1,TipoCampoXml.GrupoEscolha);
        public static CampoNo ICMSPart = new CampoNo("ICMS", "ICMSPart", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);
        public static CampoNo ICMSST = new CampoNo("ICMS", "ICMSST", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);
        
        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("ICMS");

            no.AdicionarCampo("icms", ICMS);
            no.AdicionarCampo("icmsPart", ICMSPart);
            no.AdicionarCampo("ICMSST", ICMSST);
            no.AdicionarCampo("cnpj", cnpj);

            return no;
        }
        
                
        public override ICMSVO ObterEntidade(XmlNode elemento)
        {
            ICMSVO icms = this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

            List<String> grupos = this.controleXml.ObterGruposFilhos(elemento, grupo.CamposNo);

            foreach (String tagGrupo in grupos)
            {
                if (tagGrupo.Equals(ICMSParteXML.grupo.Nome))
                {
                    icms.ICMSPart = new ICMSParteXML().ObterEntidade(elemento[ICMSParteXML.grupo.Nome]);
                }
                else if (tagGrupo.Equals(ICMSSTXML.grupo.Nome))
                {
                    icms.ICMSST = new ICMSSTXML().ObterEntidade(elemento[ICMSSTXML.grupo.Nome]);
                }
                else
                {
                    icms.ICMS = FabricaICMS.ObterICMSxxXML(tagGrupo).ObterEntidade(elemento[tagGrupo]);
                }
            }

            return icms;
        }

        public override XmlNode ObterElementoXML(ICMSVO ICMS)
        {
            XmlNode icmsNode = this.controleXml.ObterElementoXML(ICMS, grupo);

            if (ICMS.ICMSPart != null)
            {
                this.controleXml.ApendarFilho(icmsNode, new ICMSParteXML().ObterElementoXML(ICMS.ICMSPart));
            }

            if (ICMS.ICMSST != null)
            {
                this.controleXml.ApendarFilho(icmsNode, new ICMSSTXML().ObterElementoXML(ICMS.ICMSST));
            }

            this.controleXml.ApendarFilho(icmsNode, FabricaICMS.ObterICMSxxXML(ICMS.ICMS.TipoICMS).ObterElementoXML(ICMS.ICMS));
            
            return icmsNode;
        }
    }
}
