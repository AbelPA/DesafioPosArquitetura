# Estrutura do projeto

Este projeto é uma aplicação de exemplo para demonstrar a estrutura de um projeto .NET Core com arquitetura DDD. Aplicando conceitos de TDD, SOLID e Clean Code.

## Estrutura de pastas
- src 

### Detalhamento da estrutura de pastas
- src: contém o código fonte da aplicação.
  - Application: Contém os casos de uso da aplicação.
  - Domain
	- Entities: São as entidades do domínio.
	- Interfaces: São as interfaces que definem os repositórios e casos de uso.
  - Infra
	- Repositories: Implementações dos repositórios. Nessa versão não há integração com o banco de dados, tudo está sendo feito em memória.
  - WebApi
	- Controllers: Controllers que permitem a interação com a aplicação.
  - CrossCutting: Contém classes que são compartilhadas por toda a aplicação
	- IOC: Mantém o mecanismo de injeção de dependência.
- test: contém os testes aplicação
	- UnitTests: testes de unidade da aplicação
	- Collection com as requisições para testes de contrato ou integração. Para usar o Postman, basta importar o arquivo `Teste de contrato.postman_collection.json` e configurar se necessário o endereço da url base de onde está executando a aplicação.

#### Dependências do projeto
- .NET Core 8.0
- Mock para testes unitários

#### Execução do projeto
Para executar o projeto, basta rodar o comando `dotnet run` na pasta raiz do projeto.


#### Estrutura de do domínio
O domínio está dividido em três subdomínios: `Produto`, `Pedido`, e `Pessoa`.

#### `PessoaEntidade`
Representa o cliente que faz um pedido. A classe `PessoaFisicaEntidade` possui propriedades para ID, nome, contato e endereço.

#### `PedidoEntidade`
Representa um pedido feito por um cliente. A classe `Pedido` possui propriedades para data da compra, status, dodos do cliente além das informações do produto.

#### `ProdutoEntidade`
É a classe que representa um produto. Possui propriedades para ID, nome, descrição, preço e quantidade em estoque.

