using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLNG.Bibliotecas.NFeLib.Base
{
    public class Grupo : ICloneable
    {
        #region Campos
        private String nome;
        private Dictionary<string, CampoNo> camposNo;
        #endregion Campos


        #region Propriedades
        public String Nome
        {
            get { return this.nome;  }
            set { this.nome = value; }
        }

        public Dictionary<string, CampoNo> CamposNo
        {
            get { return this.camposNo; }
            set { this.camposNo = value; }
        }
        #endregion Propriedades


        #region Construtor
        public Grupo(String nomeNo, Dictionary<string, CampoNo> camposNo) : this(nomeNo)
        {
            foreach (KeyValuePair<string, CampoNo> entrada in camposNo)
            {
                this.AdicionarCampo(entrada.Key, entrada.Value);
            }
        }

        public Grupo(String nome)
        {
            this.nome = nome;
        }
        #endregion Contrutor


        #region IClonable
        public object Clone()
        {
            Dictionary<string, CampoNo> camposMapeadosClone = CopiaCamposMapeados();

            Grupo grupoClone = new Grupo(this.nome, camposMapeadosClone);

            return grupoClone;
        }
        #endregion IClonable


        #region CopiaCamposMapeados
        private Dictionary<string, CampoNo> CopiaCamposMapeados()
        {
            Dictionary<string, CampoNo> camposNoClone = null;

            if (this.camposNo != null)
            {
                camposNoClone = new Dictionary<string, CampoNo>();
                foreach (KeyValuePair<string, CampoNo> keyValue in camposNo)
                {
                    camposNoClone.Add(keyValue.Key, (CampoNo)keyValue.Value.Clone());
                }
            }
            return camposNoClone;
        }

        #endregion CopiaCampoMapeado


        #region AdicionarCampo       
        public void AdicionarCampo(string chave, CampoNo campoNo)
        {
            if (camposNo == null)
                camposNo = new Dictionary<string, CampoNo>();

            CampoNo campoNoClone = (CampoNo)campoNo.Clone();

            camposNo.Add(chave, campoNoClone);

        }

        public void AdicionarCampo(CampoNo campoNo)
        {
            this.AdicionarCampo(campoNo.Nome, campoNo);
        }
        #endregion AdicionarCampo

        
    }
}
