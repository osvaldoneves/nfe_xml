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
    public class VeiculoXML : BaseXML<VeiculoVO>
    {
        public static CampoNo tpOp = new CampoNo("veicProd", "tpOp", 1, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo chassi = new CampoNo("veicProd", "chassi", 17, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cCor = new CampoNo("veicProd", "cCor", 4, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo xCor = new CampoNo("veicProd", "xCor", 40, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pot = new CampoNo("veicProd", "pot", 4, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cilin = new CampoNo("veicProd", "cilin", 4, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pesoL = new CampoNo("veicProd", "pesoL", 9, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo pesoB = new CampoNo("veicProd", "pesoB", 9, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo nSerie = new CampoNo("veicProd", "nSerie", 9, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo tpComb = new CampoNo("veicProd", "tpComb", 2, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo nMotor = new CampoNo("veicProd", "nMotor", 21, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo CMT = new CampoNo("veicProd", "CMT", 9, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo dist = new CampoNo("veicProd", "dist", 4, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo anoMod = new CampoNo("veicProd", "anoMod", 4, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo anoFab = new CampoNo("veicProd", "anoFab", 4, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo tpPint = new CampoNo("veicProd", "tpPint", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo tpVeic = new CampoNo("veicProd", "tpVeic", 2, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo espVeic = new CampoNo("veicProd", "espVeic", 1, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo VIN = new CampoNo("veicProd", "VIN", 1, TipoDadoXml.String, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo condVeic = new CampoNo("veicProd", "condVeic", 1, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cMod = new CampoNo("veicProd", "cMod", 6, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo cCorDENATRAN = new CampoNo("veicProd", "cCorDENATRAN", 2, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo lota = new CampoNo("veicProd", "lota", 3, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);
        public static CampoNo tpRest = new CampoNo("veicProd", "tpRest", 1, TipoDadoXml.Numerico, 1, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("veicProd");

            no.AdicionarCampo("tpOp", tpOp);
            no.AdicionarCampo("chassi", chassi);
            no.AdicionarCampo("cCor", cCor);
            no.AdicionarCampo("xCor", xCor);
            no.AdicionarCampo("pot", pot);
            no.AdicionarCampo("cilin", cilin);
            no.AdicionarCampo("pesoL", pesoL);
            no.AdicionarCampo("pesoB", pesoB);
            no.AdicionarCampo("nSerie", nSerie);
            no.AdicionarCampo("tpComb", tpComb);
            no.AdicionarCampo("nMotor", nMotor);
            no.AdicionarCampo("cmt", CMT);
            no.AdicionarCampo("dist", dist);
            no.AdicionarCampo("anoMod", anoMod);
            no.AdicionarCampo("anoFab", anoFab);
            no.AdicionarCampo("tpPint", tpPint);
            no.AdicionarCampo("tpVeic", tpVeic);
            no.AdicionarCampo("espVeic", espVeic);
            no.AdicionarCampo("VIN", VIN);
            no.AdicionarCampo("condVeic", condVeic);
            no.AdicionarCampo("cMod", cMod);
            no.AdicionarCampo("cCorDENATRAN", cCorDENATRAN);
            no.AdicionarCampo("lota", lota);
            no.AdicionarCampo("tpRest", tpRest);

            return no;
        }

        
        public override VeiculoVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(VeiculoVO veiculo)
        {
            return this.controleXml.ObterElementoXML(veiculo, grupo);
        }
    }
}
