using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;

namespace OLNG.Bibliotecas.NFeLib.Base
{
    public class ControleXml<T> where T : class
    {
        #region ObterElementoXML
        public XmlNode ObterElementoXML(T entidade, Grupo grupo)
        {
            XmlDocument doc = new XmlDocument();

            XmlElement ret = doc.CreateElement(grupo.Nome);
            

            foreach (KeyValuePair<string, CampoNo> entrada in grupo.CamposNo)
            { 
                if (entrada.Value.TipoCampo == TipoCampoXml.Atributo)
                {
                    ret.SetAttribute(entrada.Value.Nome, this.ObterValorCampo(entidade, entrada.Key));
                    
                }
                else if(entrada.Value.TipoCampo == TipoCampoXml.Elemento || entrada.Value.TipoCampo == TipoCampoXml.ElementoEscolha)
                {
                    if (entrada.Value.OcorrenciaMaxima <= 1)
                    {
                        XmlElement elemento = doc.CreateElement(entrada.Value.Nome);
                        elemento.InnerText = this.ObterValorCampo(entidade, entrada.Key);
                        ret.AppendChild(elemento);
                    }
                    else
                    {
                        List<String> valores = this.ObterValoresCampo(entidade, entrada.Key);
                        foreach (String valor in valores)
                        {
                            XmlElement elemento = doc.CreateElement(entrada.Value.Nome);
                            elemento.InnerText = valor;
                            ret.AppendChild(elemento);
                        }
                    }
                }
            }
        
            return ret;
        }
        #endregion ObterElementoXML


        #region ObterFilhosGrupo
        public List<String> ObterGruposFilhos(XmlNode elemento, Dictionary<string, CampoNo> nos)
        {
            List<String> nosGrupo = new List<string>();

            foreach (CampoNo campo in nos.Values)
            {
                if (campo.TipoCampo == TipoCampoXml.Grupo || campo.TipoCampo == TipoCampoXml.GrupoEscolha)
                {
                    if (elemento[campo.Nome] != null)
                        nosGrupo.Add(campo.Nome);
                }
            }

            return nosGrupo;
        }
        #endregion obterFilhosGrupo


        #region ObterEntidade
        public T ObterEntidade(XmlNode elemento, Dictionary<string, CampoNo> campos)
        {
            T novaEntidade = (T)Activator.CreateInstance(typeof(T));

            //Propriedades do VO não encontradas no Mapeamento (CamposMapeados)
            List<string> publicPropertiesNotFound = new List<string>();

            //elemento.
            foreach (KeyValuePair<string, CampoNo> entrada in campos)
            {
                CampoNo campo = entrada.Value;

                if (campo.TipoCampo == TipoCampoXml.Atributo 
                    || campo.TipoCampo == TipoCampoXml.Elemento 
                    || campo.TipoCampo == TipoCampoXml.ElementoEscolha)
                {
                    FieldInfo field = novaEntidade.GetType().GetField(entrada.Key, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                    if (field == null)
                    {
                        throw new Exception("Campo " + entrada.Key + " não encontrado na classe " + novaEntidade.GetType().Name);
                    }

                    field.SetValue(novaEntidade, campo.ObterValorCampo(elemento));                   
                }
            }

            return novaEntidade;
        }
        #endregion ObterEntidade


        #region ApendarFilho
        public XmlNode ApendarFilho(XmlNode pai, XmlNode filho)
        {
            pai.AppendChild(filho);
            return pai;
        }
        #endregion ApendarFilho


        #region  ObterValorCampo
        protected String ObterValorCampo(T entidade, String nomeCampo)
        {
            try
            {
                return (string)entidade.GetType().GetField(nomeCampo, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).GetValue(entidade);
            }
            catch (Exception ex)
            {
                throw new Exception("Campo " + nomeCampo + " não encontrado na classe " + entidade.GetType().Name);
            }
        }
        #endregion ObterValorCampo


        #region  ObterValoresCampo
        protected List<String> ObterValoresCampo(T entidade, String nomeCampo)
        {
            try
            {
                return (List<String>)entidade.GetType().GetField(nomeCampo, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).GetValue(entidade);
            }
            catch (Exception ex)
            {
                throw new Exception("Campo " + nomeCampo + " não encontrado na classe " + entidade.GetType().Name);
            }
        }
        #endregion ObterValorCampo
    }
}
