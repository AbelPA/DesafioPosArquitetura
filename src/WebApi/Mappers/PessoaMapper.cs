using Domain.Entities.Cliente;
using Domain.Entities;
using WebApi.Model.Cliente;

namespace WebApi.Mappers
{
    public static class PessoaMapper
    {
        public static PessoaFisicaEntidade ToEntity(this PessoaModel model)
        {
            return new PessoaFisicaEntidade(
                model.Nome,
                new EnderecoEntidade(
                    0,
                    model.Endereco.Logradouro,
                    model.Endereco.Numero,
                    model.Endereco.Complemento,
                    model.Endereco.Bairro,
                    model.Endereco.Cidade,
                    model.Endereco.Estado,
                    model.Endereco.Cep
                ),
                new ContatoEntidade(
                    0,
                    model.Contato.Telefone,
                    model.Contato.Email
                ),
                model.DataNascimento
            );
        }
    }
}
