# EstacionamentoHexagonal

Este � um projeto que implementa uma arquitetura hexagonal para um sistema de estacionamento.
![logo do projeto gerado pelo Windows Copilot]("./logo.png")
## Sobre o projeto

O objetivo deste projeto � demonstrar como aplicar os princ�pios da arquitetura hexagonal em um cen�rio pr�tico, usando dotnet core e ASP.NET. A arquitetura hexagonal � um padr�o de design que visa separar a l�gica de neg�cio da infraestrutura, facilitando a manuten��o, a testabilidade e a adaptabilidade do c�digo.

O sistema de estacionamento consiste em um dom�nio que representa os ve�culos, a perman�ncia e as regras de cobran�a. O dom�nio interage com portas e adaptadores que abstraem os detalhes de entrada e sa�da de dados, como interfaces de usu�rio, bancos de dados, servi�os externos, etc.

## Como executar

Para executar o projeto, voc� precisa ter o dotnet 8 ou superior instalado na sua m�quina. Depois, siga os seguintes passos:

- Clone o reposit�rio: `git clone https://github.com/willsantos/EstacionamentoHexagonal.git`
- Entre na pasta do projeto: `cd EstacionamentoHexagonal`
- Compile o c�digo: `dotnet build`
- Execute a aplica��o: `dotnet run --project EstacionamentoHexagonal.WebApi`
- Acesse a interface web: `http://localhost:5000`

## Como testar

Para testar o projeto, voc� pode usar os seguintes comandos:

- Para executar os testes unit�rios: `dotnet test`
- Para executar os testes de integra��o: `dotnet test --filter Category=Integration`
- Para gerar o relat�rio de cobertura: `dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover`

## Como contribuir

Esse � um projeto pessoal de estudo, por isso n�o est� aberto para contribui��es, mas pode se sentir livre para fazer um fork e aplicar nos seus estudos.

## Licen�a

Este projeto est� licenciado sob a licen�a MIT. Veja o arquivo [LICENSE] para mais detalhes.
