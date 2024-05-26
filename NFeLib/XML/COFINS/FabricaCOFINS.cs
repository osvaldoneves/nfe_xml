using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.Base;
using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.VO;


namespace OLNG.Bibliotecas.NFeLib.XML.COFINS
{
    class FabricaCOFINS
    {
        private FabricaCOFINS() { }

        public static BaseXML<COFINSxxVO> ObterCOFINSxxXML(TipoCOFINS tipoCOFINS)
        {
            switch (tipoCOFINS)
            {
                case TipoCOFINS.COFINSAliq:
                    return new COFINSAliqXML();
                case TipoCOFINS.COFINSQtde:
                    return new COFINSQtdeXML();
                case TipoCOFINS.COFINSNT:
                    return new COFINSNaoTributadoXML();
                case TipoCOFINS.COFINSOutr:
                    return new COFINSOutrXML();
                default:
                    throw new Exception("Tipo de COFINS indefinido.");
            }
        }


        public static BaseXML<COFINSxxVO> ObterCOFINSxxXML(String tagXml)
        {
            switch (tagXml)
            {
                case "COFINSAliq":
                    return new COFINSAliqXML();
                case "COFINSQtde":
                    return new COFINSQtdeXML();
                case "COFINSNT":
                    return new COFINSNaoTributadoXML();
                case "COFINSOutr":
                    return new COFINSOutrXML();
                default:
                    throw new Exception("Tipo de COFINS indefinido.");
            }
        }


        public static Grupo ObterGrupo(TipoCOFINS tipoCOFINS)
        {
            switch (tipoCOFINS)
            {
                case TipoCOFINS.COFINSAliq:
                    return COFINSAliqXML.grupo;
                case TipoCOFINS.COFINSQtde:
                    return COFINSQtdeXML.grupo;
                case TipoCOFINS.COFINSNT:
                    return COFINSNaoTributadoXML.grupo;
                case TipoCOFINS.COFINSOutr:
                    return COFINSOutrXML.grupo;
                default:
                    throw new Exception("Tipo de COFINS indefinido.");
            }
        }

        public static Grupo ObterGrupo(String tagXML)
        {
            switch (tagXML)
            {
                case "COFINSAliq":
                    return COFINSAliqXML.grupo;
                case "COFINSQtde":
                    return COFINSQtdeXML.grupo;
                case "COFINSNT":
                    return COFINSNaoTributadoXML.grupo;
                case "COFINSOutr":
                    return COFINSOutrXML.grupo;
                default:
                    throw new Exception("Tipo de COFINS indefinido.");
            }
        }
    }
}
