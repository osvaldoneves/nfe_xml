using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.Base;
using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.VO;


namespace OLNG.Bibliotecas.NFeLib.XML.PIS
{
    class FabricaPIS
    {
        private FabricaPIS() { }

        public static BaseXML<PISxxVO> ObterPISxxXML(TipoPIS tipoPIS)
        {
            switch (tipoPIS)
            {
                case TipoPIS.PISAliq:
                    return new PISAliqXML();
                case TipoPIS.PISQtde:
                    return new PISQtdeXML();
                case TipoPIS.PISNT:
                    return new PISNaoTributadoXML();
                case TipoPIS.PISOutr:
                    return new PISOutrXML();
                default:
                    throw new Exception("Tipo de PIS indefinido.");
            }
        }

        public static BaseXML<PISxxVO> ObterPISxxXML(String tagXML)
        {
            switch (tagXML)
            {
                case "PISAliq":
                    return new PISAliqXML();
                case "PISQtde":
                    return new PISQtdeXML();
                case "PISNT":
                    return new PISNaoTributadoXML();
                case "PISOutr":
                    return new PISOutrXML();
                default:
                    throw new Exception("Tipo de PIS indefinido.");
            }
        }

        public static Grupo ObterGrupo(TipoPIS tipoPIS)
        {
            switch (tipoPIS)
            {
                case TipoPIS.PISAliq:
                    return PISAliqXML.grupo;
                case TipoPIS.PISQtde:
                    return PISQtdeXML.grupo;
                case TipoPIS.PISNT:
                    return PISNaoTributadoXML.grupo;
                case TipoPIS.PISOutr:
                    return PISOutrXML.grupo;
                default:
                    throw new Exception("Tipo de PIS indefinido.");
            }
        }

        public static Grupo ObterGrupo(String tagXML)
        {
            switch (tagXML)
            {
                case "PISAliq":
                    return PISAliqXML.grupo;
                case "PISQtde":
                    return PISQtdeXML.grupo;
                case "PISNT":
                    return PISNaoTributadoXML.grupo;
                case "PISOutr":
                    return PISOutrXML.grupo;
                default:
                    throw new Exception("Tipo de PIS indefinido.");
            }
        }
    }
}
