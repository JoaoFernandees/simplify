﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplify.Negocio.Models
{
    public class Cliente
    {
        /*Dados Pessoais*/
        public long Id { get; set; }
        public String Nome_dados { get; set; }
        public String Indicacao_dados { get; set; }
        public String Nascimento_dados { get; set; }
        public String CPF_dados { get; set; }
        public String RG_dados { get; set; }
        public String Profissao_dados { get; set; }
        public String Sexo_dados { get; set; }
        public String EstadoCivil_dados { get; set; }
        //Endereço1
        public String Endereco_endereco1 { get; set; }
        public String Rua_endereco1 { get; set; }
        public Int32 Num_endereco1 { get; set; }
        public String Complemento_endereco1 { get; set; }
        public String CEP_endereco1 { get; set; }
        public String Bairro_endereco1 { get; set; }
        public String Cidade_endereco1 { get; set; }
        //Endereço2
        public String Endereco_endereco2 { get; set; }
        public String Rua_endereco2 { get; set; }
        public Int32 Num_endereco2 { get; set; }
        public String Complemento_endereco2 { get; set; }
        public String CEP_endereco2 { get; set; }
        public String Bairro_endereco2 { get; set; }
        public String Cidade_endereco2 { get; set; }
        //Contato
        public Double Residencial_contato { get; set; }
        public Double Celular1_contato { get; set; }
        public Double Celular2_contato { get; set; }
        public Double TelTrabalho_contato { get; set; }
        public String Email_contato { get; set; }
        public String Facebook_contato { get; set; }
        public String NomeRecado_contato { get; set; }
        public Double TelefoneRecado_contato { get; set; }
        //Ocorrencia
        public String Data_ocorrencia { get; set; }
        public String Local_ocorrencia { get; set; }
        public String Veiculo_ocorrencia { get; set; }
        public String Tipo_ocorrencia { get; set; }
        public String INSS_ocorrencia { get; set; }
        public String Horario_ocorrencia { get; set; }
        public String Lesao_ocorrencia { get; set; }
        public String Socorrista_ocorrencia { get; set; }
        public String Hospital_ocorrencia { get; set; }
        public String Observacao_ocorrencia { get; set; }
        //Observaçoes

        public String Observacao_observacao { get; set; }
        /*fim*/

        /*Dados Pessoais
        public long Id { get; set; }
        public String Nome_dados { get; set; }
        public String Indicacao_dados { get; set; }
        public String Nascimento_dados { get; set; }
        public String CPF_dados { get; set; }
        public String RG_dados { get; set; }
        public String Profissao_dados { get; set; }
        public String Sexo_dados { get; set; }
        public String EstadoCivil_dados { get; set; }
        //Endereço1
        public String Endereco_endereco1 { get; set; }
        public String Rua_endereco1 { get; set; }
        public String Num_endereco1 { get; set; }
        public String Complemento_endereco1 { get; set; }
        public String CEP_endereco1 { get; set; }
        public String Bairro_endereco1 { get; set; }
        public String Cidade_endereco1 { get; set; }
        //Endereço2
        public String Endereco_endereco2 { get; set; }
        public String Rua_endereco2 { get; set; }
        public String Num_endereco2 { get; set; }
        public String Complemento_endereco2 { get; set; }
        public String CEP_endereco2 { get; set; }
        public String Bairro_endereco2 { get; set; }
        public String Cidade_endereco2 { get; set; }
        //Contato
        public String Residencial_contato { get; set; }
        public String Celular1_contato { get; set; }
        public String Celular2_contato { get; set; }
        public String TelTrabalho_contato { get; set; }
        public String Email_contato { get; set; }
        public String Facebook_contato { get; set; }
        public String NomeRecado_contato { get; set; }
        public String TelefoneRecado_contato { get; set; }
        //Ocorrencia
        public String Data_ocorrencia { get; set; }
        public String Local_ocorrencia { get; set; }
        public String Veiculo_ocorrencia { get; set; }
        public String Tipo_ocorrencia { get; set; }
        public String INSS_ocorrencia { get; set; }
        public String Horario_ocorrencia { get; set; }
        public String Lesao_ocorrencia { get; set; }
        public String Socorrista_ocorrencia { get; set; }
        public String Hospital_ocorrencia { get; set; }
        public String Observacao_ocorrencia { get; set; }
        //Observaçoes
        public String Observacao_observacao { get; set; }
        /*Fim*/
    }

}
