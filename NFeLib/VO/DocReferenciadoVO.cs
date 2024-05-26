﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.Base;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public class DocReferenciadoVO : BaseVO
    {
        #region Campos
        private String refNFe = "";

        private ReferenciaNFVO refNF = null;
        private ReferenciaNFRuralVO refNFP = null;
        #endregion Campos


        #region Propriedades

        public String ChaveAcesso
        {
            get { return this.refNFe; }
            set { this.refNFe = value; }
        }

        public ReferenciaNFVO ReferenciaNF
        {
            get { return this.refNF; }
            set { this.refNF = value; }
        }

        public ReferenciaNFRuralVO ReferenciaNFRural
        {
            get { return this.refNFP; }
            set { this.refNFP = value; }
        }

        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(AutorizacaoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return AutorizacaoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return AutorizacaoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
