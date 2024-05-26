using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public class EntregaVO
    {
        #region Campos
        private String cnpj = "";   //CNPJ do emitente
        private String cpf = "";    //CPF do emitente
        private String xLgr = "";
        private String nro = "";
        private String xCpl = "";
        private String xBairro = "";
        private String cMun = "";
        private String xMun = "";
        private String uf = "";
        #endregion Campos


        /// <summary>
        /// CNPJ
        /// Informar CNPJ ou CPF. Preencher os zeros não significativos
        /// Tamanho: 0 ou 14
        /// </summary>
        public String CNPJ
        {
            get { return this.cnpj; }
            set { this.cnpj = value; }
        }

        /// <summary>
        /// CPF.
        /// Informar CNPJ ou CPF. Preencher os zeros não significativos.
        /// Tamanho: 11
        /// </summary>
        public String CPF
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }

        /// <summary>
        /// Logradouro
        /// Tamanho: 2-60
        /// </summary>
        public String Logradouro
        {
            get { return this.xLgr; }
            set { this.xLgr = value; }
        }

        /// <summary>
        /// Número
        /// Tamanho: 1-60
        /// </summary>
        public String Numero
        {
            get { return this.nro; }
            set { this.nro = value; }
        }

        /// <summary>
        /// Complemento
        /// Tamanho: 1-60
        /// </summary>
        public String Complemento
        {
            get { return this.xCpl; }
            set { this.xCpl = value; }
        }

        /// <summary>
        /// Bairro
        /// Tamanho: 2-60
        /// </summary>
        public String Bairro
        {
            get { return this.xBairro; }
            set { this.xBairro = value; }
        }

        /// <summary>
        /// Código do município.
        /// Utilizar a Tabela do IBGE (Anexo IX - Tabela de UF, Município e País). Informar ‘9999999 ‘para operações com o exterior.
        /// Tamanho: 7
        /// </summary>
        public String CodigoMunicipio
        {
            get { return this.cMun; }
            set { this.cMun = value; }
        }

        /// <summary>
        /// Nome do município.
        /// Informar ‘EXTERIOR ‘para operações com o exterior. 
        /// Tamanho: 2-60 
        /// </summary>
        public String NomeMunicipio
        {
            get { return this.xMun; }
            set { this.xMun = value; }
        }

        /// <summary>
        /// Sigla da UF.
        /// Informar ‘EX’ para operações com o exterior.
        /// Tamanho: 2
        /// </summary>
        public String UF
        {
            get { return this.uf; }
            set { this.uf = value; }
        }
    }
}
