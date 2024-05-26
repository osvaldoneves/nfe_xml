using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;
using OLNG.Bibliotecas.NFeLib.Base;


namespace OLNG.Bibliotecas.NFeLib.XML
{
    public abstract class BaseXML<T> where T : class
    {
        #region Campos
        protected ControleXml<T> controleXml = null;
        #endregion Campos

        #region Construtor
        public BaseXML()
        {
            controleXml = new ControleXml<T>();
        }
        #endregion Contrutor

        public abstract T ObterEntidade(XmlNode elemento);
        public abstract XmlNode ObterElementoXML(T entidade);

        /*
        #region PreencherCampo
        public void PreencherCampo(T entidade, String campo, String valor)
        {
            FieldInfo field = entidade.GetType().GetField(campo, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            if (field == null)
            {
                throw new Exception("Campo " + campo + "não encontrado na classe " + entidade.GetType().Name);
            }
            field.SetValue(entidade, valor);
        }
        #endregion PreencherCampo        
        */
    }
}
