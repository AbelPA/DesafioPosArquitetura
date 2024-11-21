# Estrutura do projeto

Este projeto � uma aplica��o de exemplo para demonstrar a estrutura de um projeto .NET Core com arquitetura DDD. Aplicando conceitos de TDD, SOLID e Clean Code.

## Estrutura de pastas
- src 

### Detalhamento da estrutura de pastas
- src: cont�m o c�digo fonte da aplica��o.
  - Application: Cont�m os casos de uso da aplica��o.
  - Domain
	- Entities: S�o as entidades do dom�nio.
	- Interfaces: S�o as interfaces que definem os reposit�rios e casos de uso.
  - Infra
	- Repositories: Implementa��es dos reposit�rios. Nessa vers�o n�o h� integra��o com o banco de dados, tudo est� sendo feito em mem�ria.
  - WebApi
	- Controllers: Controllers que permitem a intera��o com a aplica��o.
  - CrossCutting: Cont�m classes que s�o compartilhadas por toda a aplica��o
	- IOC: Mant�m o mecanismo de inje��o de depend�ncia.
- test: cont�m os testes aplica��o
	- UnitTests: testes de unidade da aplica��o
	- Collection com as requisi��es para testes de contrato ou integra��o. Para usar o Postman, basta importar o arquivo `Teste de contrato.postman_collection.json` e configurar se necess�rio o endere�o da url base de onde est� executando a aplica��o.

#### Depend�ncias do projeto
- .NET Core 8.0
- Mock para testes unit�rios

#### Execu��o do projeto
Para executar o projeto, basta rodar o comando `dotnet run` na pasta raiz do projeto.


#### Estrutura de do dom�nio
O dom�nio est� dividido em tr�s subdom�nios: `Produto`, `Pedido`, e `Pessoa`.

#### `PessoaEntidade`
Representa o cliente que faz um pedido. A classe `PessoaFisicaEntidade` possui propriedades para ID, nome, contato e endere�o.

#### `PedidoEntidade`
Representa um pedido feito por um cliente. A classe `Pedido` possui propriedades para data da compra, status, dodos do cliente al�m das informa��es do produto.

#### `ProdutoEntidade`
� a classe que representa um produto. Possui propriedades para ID, nome, descri��o, pre�o e quantidade em estoque.

