using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OLNG.Bibliotecas.NFeLib.Base
{
    public enum TipoCampoXml : int { Atributo, Elemento, ElementoEscolha, Grupo, GrupoEscolha };
    public enum TipoDadoXml : int { Nenhum, String, Numerico, Data };

    public class CampoNo : ICloneable
    {
        #region Campos
        protected String nomeNo;
        protected String nomeCampo;
        protected int tamanhoEntrada;
        protected TipoDadoXml tipoDado;
        protected TipoCampoXml tipoCampo;
        protected short ocorrenciaMinima;
        protected short ocorrenciaMaxima;
        #endregion Campos


        #region Construtor
        public CampoNo(String nomeNo, String nomeCampo, int tamanhoEntrada, TipoDadoXml tipoDado, short ocorrenciaMinima, short ocorrenciaMaxima, TipoCampoXml tipoCampo)
        {
            this.nomeNo = nomeNo;
            this.nomeCampo = nomeCampo;
            this.tamanhoEntrada = tamanhoEntrada;
            this.tipoDado = tipoDado;
            this.tipoCampo = tipoCampo;
            this.ocorrenciaMinima = ocorrenciaMinima;
            this.ocorrenciaMaxima = ocorrenciaMaxima;
        }
        #endregion Construtor


        #region Propriedades

        public string NomeNo { get { return this.nomeNo; } }
        public string Nome { get { return this.nomeCampo; } }
        public TipoDadoXml TipoDado { get { return this.tipoDado; } }
        public int TamanhoEntrada { get { return this.tamanhoEntrada; } }
        public TipoCampoXml TipoCampo { get { return this.tipoCampo; } }
        public short OcorrenciaMinima { get { return this.ocorrenciaMinima; } }
        public short OcorrenciaMaxima { get { return this.ocorrenciaMaxima; } }

        #endregion Propriedades


        #region Métodos Públicos

        #region ObterValorCampo
        public object ObterValorCampo(XmlNode elemento)
        {
            object valor;
            if (this.TipoCampo == TipoCampoXml.Atributo)
            {
                if (elemento.Attributes[this.Nome] == null)
                    throw new Exception("Atributo " + this.NomeNo + " não encontrado no XML.");

                valor = elemento.Attributes[this.Nome].Value;
            }
            else if (this.TipoCampo == TipoCampoXml.Elemento || this.TipoCampo == TipoCampoXml.ElementoEscolha)
            {
                if (this.ocorrenciaMaxima <= 1)
                {
                    if (elemento[this.Nome] != null)
                        valor = elemento[this.Nome].InnerText;
                    else
                        valor = "";
                }
                else
                {
                    List<String> list = new List<String>();
                    foreach (XmlNode no in elemento.ChildNodes)
                    {
                        if(no.Name.Equals(this.Nome))
                            list.Add(no.InnerText);
                    }

                    valor = list;
                }
            }
            else valor = null;

            return valor;
        }
        #endregion ObterValorCampo

        #endregion Métodos Públicos


        #region Clone
        /// <summary>
        /// Clone.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            //return new TableField(this.fieldName, this.tableName, this.dataType, this.inputSize, this.fieldType);
            return this.MemberwiseClone();
        }
        #endregion Clone
    }
}
