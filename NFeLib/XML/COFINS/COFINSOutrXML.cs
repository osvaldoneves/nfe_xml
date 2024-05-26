﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;
using OLNG.Bibliotecas.NFeLib.VO;
using OLNG.Bibliotecas.NFeLib.Base;

namespace OLNG.Bibliotecas.NFeLib.XML.COFINS
{
    public class COFINSOutrXML : BaseXML<COFINSxxVO>
    {
        public static CampoNo CST = new CampoNo("COFINSOutr", "CST", 2, TipoDadoXml.Numerico, 1, 1,TipoCampoXml.Elemento);
        public static CampoNo vBC = new CampoNo("COFINSOutr", "vBC", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo pCOFINS = new CampoNo("COFINSOutr", "pCOFINS", 8, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo qBCProd = new CampoNo("COFINSOutr", "qBCProd", 17, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vAliqProd = new CampoNo("COFINSOutr", "vAliqProd", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);
        public static CampoNo vCOFINS = new CampoNo("COFINSOutr", "vCOFINS", 16, TipoDadoXml.Numerico, 0, 1, TipoCampoXml.Elemento);

        public static Grupo grupo = SetNo();

        private static Grupo SetNo()
        {
            Grupo no = new Grupo("COFINSOutr");

            no.AdicionarCampo("cst", CST);
            no.AdicionarCampo("vBC", vBC);
            no.AdicionarCampo("pCOFINS", pCOFINS);
            no.AdicionarCampo("qBCProd", qBCProd);
            no.AdicionarCampo("vAliqProd", vAliqProd);
            no.AdicionarCampo("vCOFINS", vCOFINS);

            return no;
        }

        
        public override COFINSxxVO ObterEntidade(XmlNode elemento)
        {
            return this.controleXml.ObterEntidade(elemento, grupo.CamposNo);

        }
        public override XmlNode ObterElementoXML(COFINSxxVO cofins)
        {
            return this.controleXml.ObterElementoXML(cofins, grupo);
        }
    }
}
