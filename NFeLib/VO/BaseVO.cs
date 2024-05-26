using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using OLNG.Bibliotecas.NFeLib.Base;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public abstract class BaseVO : ICloneable
    {
        #region Atributos

        private List<string> erros = new List<string>();
        private List<string> notificacoes = new List<string>();
        private List<string> avisos = new List<string>();

        #endregion Atributos

        #region Métodos Privados
        #region  ObterValorCampo
        private Object ObterValorCampo(String nomeCampo)
        {
            try
            {
                return this.GetType().GetField(nomeCampo, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).GetValue(this);
            }
            catch (Exception ex)
            {
                throw new Exception("Campo " + nomeCampo + " não encontrado na classe " + this.GetType().Name);
            }
        }
        #endregion ObterValorCampo
        #endregion Métodos Privados

        #region Métodos Abstratos

        public abstract List<String> ObterListaCamposMapeados();
        public abstract int ObterTamanhoCampo(String nomeCampo);
        public abstract TipoDadoXml ObterTipoDado(String nomeCampo);
        

        #endregion Métodos Abstratos

        #region Serializar
        public String Serializar()
        {
            StringBuilder ret = new StringBuilder();

            foreach (String campo in ObterListaCamposMapeados())
            {
                ret.Append(campo);
                ret.Append("=");
                ret.Append(ObterValorCampo(campo));
                ret.Append(";");
            }

            ret.Remove(ret.Length - 1, 1);

            return ret.ToString();
        }
        #endregion Serializar


        #region Clone

        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion Clone
    }
}
