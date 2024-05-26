using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using OLNG.Bibliotecas.NFeLib.XML;
using OLNG.Bibliotecas.NFeLib.Base;

namespace OLNG.Bibliotecas.NFeLib.VO
{
    public class VeiculoVO  : BaseVO
    {
        #region Campos
        private String tpOp = "";
        private String chassi = "";
        private String cCor = "";
        private String xCor = "";
        private String pot = "";
        private String cilin = "";
        private String pesoL = "";
        private String pesoB = "";
        private String nSerie = "";
        private String tpComb = "";
        private String nMotor = "";
        private String cmt = "";
        private String dist = "";
        private String anoMod = "";
        private String anoFab = "";
        private String tpPint = "";
        private String tpVeic = "";
        private String espVeic = "";
        private String VIN = "";
        private String condVeic = "";
        private String cMod = "";
        private String cCorDENATRAN = "";
        private String lota = "";
        private String tpRest = "";
        #endregion Campos


        #region Propriedades
        /// <summary>
        /// Tipo da operação
        /// 1=Venda concessionária; 
        /// 2=Faturamento direto para consumidor final; 
        /// 3=Venda direta para grandes consumidores (frotista, governo, ...); 
        /// 0=Outros
        /// </summary>
        public String TipoOperacao
        {
            get { return this.tpOp; }
            set { this.tpOp = value; }
        }

        /// <summary>
        /// Chassi do veículo
        /// VIN (código-identificação-veículo) 
        /// </summary>
        public String ChassiVeiculo
        {
            get { return this.chassi; }
            set { this.chassi = value; }
        }

        /// <summary>
        /// Cor - Código de cada montadora 
        /// </summary>
        public String CodigoCorMontadora
        {
            get { return this.cCor; }
            set { this.cCor = value; }
        }

        /// <summary>
        /// Descrição da Cor - Tamanho=40
        /// </summary>
        public String DescricaoCor
        {
            get { return this.xCor; }
            set { this.xCor = value; }
        }

        /// <summary>
        /// Potência Motor (CV)
        /// Capacidade voluntária do motor expressa em centímetros cúbicos (CC). (cilindradas) (v2.0) 
        /// </summary>
        public String Potencia
        {
            get { return this.pot; }
            set { this.pot = value; }
        }

        /// <summary>
        /// Cilindradas
        /// Capacidade voluntária do motor expressa em centímetros cúbicos (CC). (cilindradas) (v2.0)
        /// </summary>
        public String Cilindradas
        {
            get { return this.cilin; }
            set { this.cilin = value; }
        }

        /// <summary>
        /// Peso Líquido
        /// Em toneladas - 4 casas decimais 
        /// </summary>
        public String PesoLiquido
        {
            get { return this.pesoL; }
            set { this.pesoL = value; }
        }

        /// <summary>
        /// Peso Bruto
        /// Peso Bruto Total - em tonelada - 4 casas decimais
        /// </summary>
        public String PesoBruto
        {
            get { return this.pesoB; }
            set { this.pesoB = value; } }

        /// <summary>
        /// Serial (série)
        /// </summary>
        public String Serie
        {
            get { return this.nSerie; }
            set { this.nSerie = value; }
        }

        /// <summary>
        /// Tipo de combustível
        /// Utilizar Tabela RENAVAM (v2.0) 
        /// 01=Álcool, 02=Gasolina, 03=Diesel, (...); 16=Álcool/Gasolina; 17=Gasolina/Álcool/GNV 18=Gasolina/Elétrico
        /// </summary>
        public String TipoCombustivel
        {
            get { return this.tpComb; }
            set { this.tpComb = value; }
        }

        /// <summary>
        /// Número do motor
        /// </summary>
        public String NumeroMotor
        {
            get { return this.nMotor; }
            set { this.nMotor = value; }
        }

        /// <summary>
        /// Capacidade Máxima de Tração - em Toneladas 4 casas decimais (v2.0)
        /// Tamanho: 9
        /// </summary>
        public String CMT
        {
            get { return this.cmt; }
            set { this.cmt = value; }
        }

        /// <summary>
        /// Distância entre eixos - Em metros (4 casas decimais).
        /// </summary>
        public String DistanciaEntreEixos
        {
            get { return this.dist; }
            set { this.dist = value; }
        }

        /// <summary>
        /// Ano Modelo de Fabricação - YYYY
        /// </summary>
        public String AnoModelo
        {
            get { return this.anoMod; }
            set { this.anoMod = value; }
        }

        /// <summary>
        /// Ano de Fabricação - YYYY
        /// </summary>
        public String AnoFabricacao
        {
            get { return this.anoFab; }
            set { this.anoFab = value; }
        }

        /// <summary>
        /// Tipo de Pintura
        /// S=Solida; M=Metálica; P=Perolizada 
        /// </summary>
        public String TipoPintura
        {
            get { return this.tpPint; }
            set { this.tpPint = value; }
        }

        /// <summary>
        /// Tipo de Veículo
        /// Utilizar Tabela RENAVAM, conforme exemplos abaixo: 02=CICLOMOTO; 03=MOTONETA; 04=MOTOCICLO; 05=TRICICLO; 06=AUTOMÓVEL; 07=MICROÔNIBUS; 08=ÔNIBUS; 10=REBOQUE; 11=SEMIRREBOQUE; 13=CAMINHONETA; 14=CAMINHÃO; 17=C. TRATOR; 22=ESP / ÔNIBUS; 23=MISTO / CAM; 24=CARGA/CAM; ... 
        /// </summary>
        public String TipoVeiculo
        {
            get { return this.tpVeic; }
            set { this.tpVeic = value; }
        }

        /// <summary>
        /// Espécie de Veículo
        /// Utilizar Tabela RENAVAM 1=PASSAGEIRO; 2=CARGA; 3=MISTO; 4=CORRIDA; 5=TRAÇÃO; 6=ESPECIAL
        /// </summary>
        public String EspecieVeiculo
        {
            get { return this.espVeic; }
            set { this.espVeic = value; }
        }

        /// <summary>
        /// Condição do VIN
        /// Informa-se o veículo tem VIN (chassi) remarcado. R=Remarcado; N=Normal
        /// </summary>
        public String CondicaoVIN
        {
            get { return this.VIN; }
            set { this.VIN = value; }
        }

        /// <summary>
        /// Condição do Veículo
        /// 1=Acabado; 2=Inacabado; 3=Semiacabado 
        /// </summary>
        public String CondicaoVeiculo
        {
            get { return this.condVeic; }
            set { this.condVeic = value; }
        }

        /// <summary>
        /// Código Marca Modelo
        /// Utilizar Tabela RENAVAM
        /// </summary>
        public String CodigoMarcaModelo
        {
            get { return this.cMod; }
            set { this.cMod = value; }
        }

        /// <summary>
        /// Código da Cor
        /// 01=AMARELO, 02=AZUL, 03=BEGE, 04=BRANCA, 05=CINZA, 06=DOURADA, 07=GRENÁ, 08=LARANJA, 09=MARROM, 10=PRATA, 11=PRETA, 12=ROSA, 13=ROXA, 14=VERDE, 15=VERMELHA, 16=FANTASIA 
        /// </summary>
        public String CodigoCor
        {
            get { return this.cCorDENATRAN; }
            set { this.cCorDENATRAN = value; }
        }

        /// <summary>
        /// Quantidade máxima permitida de passageiros sentados, inclusive o motorista.
        /// Tamanho: 3
        /// </summary>
        public String CapacidadeMaximaLotacao
        {
            get { return this.lota; }
            set { this.lota = value; }
        }

        /// <summary>
        /// Restrição
        /// 0=Não há; 
        /// 1=Alienação Fiduciária; 
        /// 2=Arrendamento Mercantil; 
        /// 3=Reserva de Domínio; 
        /// 4=Penhor de Veículos; 
        /// 9=Outras. 
        /// </summary>
        public String Restricao
        {
            get { return this.tpRest; }
            set { this.tpRest = value; }
        }
        #endregion Propriedades


        #region Implementacao de Métodos Abstratos

        #region ObterListaCamposMapeados
        public override List<String> ObterListaCamposMapeados()
        {
            return new List<string>(VeiculoXML.grupo.CamposNo.Keys);
        }
        #endregion ObterListaCamposMapeados

        #region ObterTamanhoCampo
        public override int ObterTamanhoCampo(String nomeCampo)
        {
            return VeiculoXML.grupo.CamposNo[nomeCampo].TamanhoEntrada;
        }
        #endregion ObterTamanhoCampo

        #region ObterTipoCampo
        public override TipoDadoXml ObterTipoDado(String nomeCampo)
        {
            return VeiculoXML.grupo.CamposNo[nomeCampo].TipoDado;
        }
        #endregion ObterTipoCampo

        #endregion Implementacao de Métodos Abstratos
    }
}
