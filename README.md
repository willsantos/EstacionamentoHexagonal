# EstacionamentoHexagonal
<div align="center">
  <img src=".github/logo.gif" alt="Logo da minha empresa" width="250" height="250">
</div>
Este é um projeto que implementa uma arquitetura hexagonal para um sistema de estacionamento.


## Sobre o projeto

O objetivo deste projeto é demonstrar como aplicar os princípios da arquitetura hexagonal em um cenário prático, usando dotnet core e ASP.NET. A arquitetura hexagonal é um padrão de design que visa separar a lógica de negócio da infraestrutura, facilitando a manutenção, a testabilidade e a adaptabilidade do código.

O sistema de estacionamento consiste em um domínio que representa os veículos, a permanência e as regras de cobrança. O domínio interage com portas e adaptadores que abstraem os detalhes de entrada e saída de dados, como interfaces de usuário, bancos de dados, serviços externos, etc.

## Como executar

Para executar o projeto, você precisa ter o dotnet 8 ou superior instalado na sua máquina. Depois, siga os seguintes passos:

- Clone o repositório: `git clone https://github.com/willsantos/EstacionamentoHexagonal.git`
- Entre na pasta do projeto: `cd EstacionamentoHexagonal`
- Compile o código: `dotnet build`
- Execute a aplicação: `dotnet run --project EstacionamentoHexagonal.WebApi`
- Acesse a interface web: `http://localhost:5000`

## Como testar

Para testar o projeto, você pode usar os seguintes comandos:

- Para executar os testes unitários: `dotnet test`
- Para executar os testes de integração: `dotnet test --filter Category=Integration`
- Para gerar o relatório de cobertura: `dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover`

## Como contribuir

Esse é um projeto pessoal de estudo, por isso não está aberto para contribuições, mas pode se sentir livre para fazer um fork e aplicar nos seus estudos.

## Licença
Este projeto está licenciado sob a licença [MIT](https://github.com/willsantos/EstacionamentoHexagonal/blob/main/LICENSE). Veja o arquivo LICENSE para mais detalhes.

