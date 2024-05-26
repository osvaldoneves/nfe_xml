using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.Base;
using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.VO;


namespace OLNG.Bibliotecas.NFeLib.XML.ICMS
{
    public class FabricaICMS
    {
        private FabricaICMS() { }

        public static BaseXML<ICMSxxVO> ObterICMSxxXML(TipoICMS tipoICMS)
        {
            switch (tipoICMS)
            {
                case TipoICMS.ICMS00:
                    return new ICMS00XML();
                case TipoICMS.ICMS10:
                    return new ICMS10XML();
                case TipoICMS.ICMS20:
                    return new ICMS20XML();
                case TipoICMS.ICMS30:
                    return new ICMS30XML();
                case TipoICMS.ICMS40:
                    return new ICMS40XML();
                case TipoICMS.ICMS51:
                    return new ICMS51XML();
                case TipoICMS.ICMS60:
                    return new ICMS60XML();
                case TipoICMS.ICMS70:
                    return new ICMS70XML();
                case TipoICMS.ICMS90:
                    return new ICMS90XML();
                case TipoICMS.ICMSSN101:
                    return new ICMSSN101XML();
                case TipoICMS.ICMSSN102:
                    return new ICMSSN102XML();
                case TipoICMS.ICMSSN201:
                    return new ICMSSN201XML();
                case TipoICMS.ICMSSN202:
                    return new ICMSSN202XML();
                case TipoICMS.ICMSSN500:
                    return new ICMSSN500XML();
                case TipoICMS.ICMSSN900:
                    return new ICMSSN900XML();
                default:
                    throw new Exception("Tipo de ICMS indefinido.");
            }
        }

        public static BaseXML<ICMSxxVO> ObterICMSxxXML(String tagXML)
        {
            switch (tagXML)
            {
                case "ICMS00":
                    return new ICMS00XML();
                case "ICMS10":
                    return new ICMS10XML();
                case "ICMS20":
                    return new ICMS20XML();
                case "ICMS30":
                    return new ICMS30XML();
                case "ICMS40":
                case "ICMS41":
                case "ICMS50":
                    return new ICMS40XML();
                case "ICMS60":
                    return new ICMS60XML();
                case "ICMS70":
                    return new ICMS70XML();
                case "ICMS90":
                    return new ICMS90XML();
                case "ICMSParte":
                    return new ICMSParteXML();
                case "ICMSSN101":
                    return new ICMSSN101XML();
                case "ICMSSN102":
                case "ICMSSN103":
                case "ICMSSN300":
                case "ICMSSN400":
                    return new ICMSSN102XML();
                case "ICMSSN201":
                    return new ICMSSN201XML();
                case "ICMSSN202":
                case "ICMSSN203":
                    return new ICMSSN202XML();
                case "ICMSSN500":
                    return new ICMSSN500XML();
                case "ICMSSN900":
                    return new ICMSSN900XML();
                default:
                    throw new Exception("Tipo de ICMS indefinido.");
            }
        }

        public static Grupo ObterGrupo(TipoICMS tipoICMS)
        {
            switch (tipoICMS)
            {
                case TipoICMS.ICMS00:
                    return ICMS00XML.grupo;
                case TipoICMS.ICMS10:
                    return ICMS10XML.grupo;
                case TipoICMS.ICMS20:
                    return ICMS20XML.grupo;
                case TipoICMS.ICMS30:
                    return ICMS30XML.grupo;
                case TipoICMS.ICMS40:
                    return ICMS40XML.grupo;
                case TipoICMS.ICMS51:
                    return ICMS51XML.grupo;
                case TipoICMS.ICMS60:
                    return ICMS60XML.grupo;
                case TipoICMS.ICMS70:
                    return ICMS70XML.grupo;
                case TipoICMS.ICMS90:
                    return ICMS90XML.grupo;
                case TipoICMS.ICMSSN101:
                    return ICMSSN101XML.grupo;
                case TipoICMS.ICMSSN102:
                    return ICMSSN102XML.grupo;
                case TipoICMS.ICMSSN201:
                    return ICMSSN201XML.grupo;
                case TipoICMS.ICMSSN202:
                    return ICMSSN202XML.grupo;
                case TipoICMS.ICMSSN500:
                    return ICMSSN500XML.grupo;
                case TipoICMS.ICMSSN900:
                    return ICMSSN900XML.grupo;
                default:
                    throw new Exception("Tipo de ICMS indefinido.");
            }
        }

        public static Grupo ObterGrupo(String tagXML)
        {
            switch (tagXML)
            {
                case "ICMS00":
                    return ICMS00XML.grupo;
                case "ICMS10":
                    return ICMS10XML.grupo;
                case "ICMS20":
                    return ICMS20XML.grupo;
                case "ICMS30":
                    return ICMS30XML.grupo;
                case "ICMS40":
                case "ICMS41":
                case "ICMS50":
                    return ICMS40XML.grupo;
                case "ICMS60":
                    return ICMS60XML.grupo;
                case "ICMS70":
                    return ICMS70XML.grupo;
                case "ICMS90":
                    return ICMS90XML.grupo;
                case "ICMSParte":
                    return ICMSParteXML.grupo;
                case "ICMSSN101":
                    return ICMSSN101XML.grupo;
                case "ICMSSN102":
                case "ICMSSN103":
                case "ICMSSN300":
                case "ICMSSN400":
                    return ICMSSN102XML.grupo;
                case "ICMSSN201":
                    return ICMSSN201XML.grupo;
                case "ICMSSN202":
                case "ICMSSN203":
                    return ICMSSN202XML.grupo;
                case "ICMSSN500":
                    return ICMSSN500XML.grupo;
                case "ICMSSN900":
                    return ICMSSN900XML.grupo;
                default:
                    throw new Exception("Tipo de ICMS indefinido.");
            }
        }
    }
}
