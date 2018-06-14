using Simplify.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simplify.Negocio.Persistencia;

namespace Simplify.Negocio
{
    public class Gerenciador
    {
        private Banco banco = new Banco();

        // ADICIONAR CLIENTE //
        public Validacao AdicionarCliente(Cliente clienteAdicionado)
        {
            Validacao validacao = new Validacao();

            // -- CAMPO NOME OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Nome_dados))
            {
                validacao.Mensagens.Add("Nome_dados", "Campo nome é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }

            // -- CAMPO INDICAÇÃO OBRIGATÓRIO -- //
            /*if (String.IsNullOrEmpty(clienteAdicionado.Indicacao_dados))
            {
                validacao.Mensagens.Add("Indicacao_dados", "Campo indicação é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }*/

            // -- CAMPO NASCIMENTO OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Nascimento_dados))
            {
                validacao.Mensagens.Add("Nascimento_dados", "Campo nascimento é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }

            // -- CAMPO CPF OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.CPF_dados))
            {
                validacao.Mensagens.Add("CPF_dados", "Campo CPF é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }

            // -- CAMPO RG OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.RG_dados))
            {
                validacao.Mensagens.Add("RG_dados", "Campo RG obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }

            // -- CAMPO PROFISSÃO OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Profissao_dados))
            {
                validacao.Mensagens.Add("Profissao_dados", "Campo profissão é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }

            // -- CAMPO SEXO OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Sexo_dados))
            {
                validacao.Mensagens.Add("Sexo_dados", "Campo sexo é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }

            // -- CAMPO ESTADO CIVIL OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.EstadoCivil_dados))
            {
                validacao.Mensagens.Add("EstadoCivil_dados", "Campo estado civil é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }

            // -- CAMPO ENDEREÇO1 OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Endereco_endereco1))
            {
                validacao.Mensagens.Add("Endereco_endereco1", "Campo endereço é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }

            // -- CAMPO RUA1 OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Rua_endereco1))
            {
                validacao.Mensagens.Add("Rua_endereco1", "Campo rua é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }

            // -- CAMPO NUMERO1 OBRIGATÓRIO -- //
            /*if (String.IsNullOrEmpty(Convert.ToString(clienteAdicionado.Num_endereco1)))
            {
                validacao.Mensagens.Add("Num_endereco1", "Campo número é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }*/

            // -- CAMPO COMPLEMENTO1 OBRIGATÓRIO -- //
            /*if (String.IsNullOrEmpty(clienteAdicionado.Complemento_endereco1))
            {
                validacao.Mensagens.Add("Complemento_endereco1", "Campo complemento é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }*/

            // -- CAMPO CEP1 OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.CEP_endereco1))
            {
                validacao.Mensagens.Add("CEP_endereco1", "Campo CEP é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }

            // -- CAMPO BAIRRO1 OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Bairro_endereco1))
            {
                validacao.Mensagens.Add("Bairro_endereco1", "Campo bairro é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }

            // -- CAMPO CIDADE1 OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Cidade_endereco1))
            {
                validacao.Mensagens.Add("Cidade_endereco1", "Campo cidade é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }

            return validacao;
        }

        // ALTERAR CLIENTE //
        public Validacao AlterarCliente(Cliente clienteAlterado)
        {
            Validacao validacao = new Validacao();

            return validacao;
        }

        // REMOVER CLIENTE//
        public Validacao RemoverCliente(Cliente cliente)
        {
            Validacao validacao = new Validacao();
            banco.Clientes.Remove(cliente);
            banco.SaveChanges();

            return validacao;
        }

        public Validacao AdicionarUsuario(Usuario UsuarioAdicionado)
        {
            Validacao validacao = new Validacao();

            
            if (String.IsNullOrEmpty(UsuarioAdicionado.Nome_usuario))
            {
                validacao.Mensagens.Add("Nome_usuario", "Campo nome é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Usuarios.Add(UsuarioAdicionado);
                this.banco.SaveChanges();
            }

            return validacao;
        }

        public Validacao RemoverUsuario(Usuario usuario)
        {
            Validacao validacao = new Validacao();
            banco.Usuarios.Remove(usuario);
            banco.SaveChanges();
            return validacao;
        }

        public Validacao AlterarUsuario(Usuario usuarioAlterado)
        {
            Validacao validacao = new Validacao();
            Usuario usuarioBanco = BuscaUsuarioPorId(usuarioAlterado.Id);
            usuarioBanco.Nome_usuario = usuarioAlterado.Nome_usuario;
            usuarioBanco.Email_usuario = usuarioAlterado.Email_usuario;
            usuarioBanco.Login_usuario = usuarioAlterado.Login_usuario;
            usuarioBanco.Password_usuario = usuarioAlterado.Password_usuario;
            usuarioBanco.Administrador_usuario = usuarioAlterado.Administrador_usuario;
            this.banco.SaveChanges();
            return validacao;
        }

        public Usuario BuscaUsuarioPorId(long id)
        {
            return this.banco.Usuarios.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Usuario> TodosOsUsuarios()
        {
            return this.banco.Usuarios.ToList();
        }
    }
}
