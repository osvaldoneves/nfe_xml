using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;
using OLNG.Bibliotecas.NFeLib.VO;
using OLNG.Bibliotecas.NFeLib.Base;
using OLNG.Bibliotecas.NFeLib.XML.PIS;

namespace OLNG.Bibliotecas.NFeLib.XML
{
    public class PISXML : BaseXML<PISVO>
    {
        public static CampoNo PISxx = new CampoNo("PIS", "PISxx", 0, TipoDadoXml.Nenhum, 1, 1, TipoCampoXml.GrupoEscolha);
        
        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("PIS");

            no.AdicionarCampo("pis", PISxx);

            return no;
        }

        
        public override PISVO ObterEntidade(XmlNode elemento)
        {
            PISVO pis = this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

            List<String> nomeGrupo = this.controleXml.ObterGruposFilhos(elemento, grupo.CamposNo);

            if (pis == null || nomeGrupo.Count == 0)
                return null;

            pis.PISxx = FabricaPIS.ObterPISxxXML(nomeGrupo[0]).ObterEntidade(elemento[nomeGrupo[0]]);

            return pis;
        }


        public override XmlNode ObterElementoXML(PISVO pis)
        {
            if (pis == null || pis.PISxx == null)
                return null;

            XmlNode noPIS = this.controleXml.ObterElementoXML(pis, grupo);
            XmlNode noPISxx = FabricaPIS.ObterPISxxXML(pis.PISxx.TipoPIS).ObterElementoXML(pis.PISxx);

            return this.controleXml.ApendarFilho(noPIS, noPISxx);
        }
    }
}
