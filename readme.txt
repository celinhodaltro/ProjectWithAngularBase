# Projeto Base

Este repositório contém o código-fonte do projeto base, o intuito do mesmo é facilitar a criação de projetos .net com angular, é uma aplicação web desenvolvida com tecnologias .NET Core 8, SQL Server 2019 para o back-end e Angular 13 para o front-end.

## Tecnologias Utilizadas

### Back-End

- **.NET Core 8**: Framework utilizado para o desenvolvimento do back-end da aplicação.
- **SQL Server 2019**: Sistema de gerenciamento de banco de dados utilizado para armazenamento de dados.

### Front-End

- **Angular 13**: Framework utilizado para o desenvolvimento do front-end da aplicação.

## Estrutura do Projeto

O projeto está estruturado da seguinte forma:

- **App.BussinessRules**: Nesta pasta, são realizados todos os tratamentos de dados do projeto. Ela é dividida em duas partes:

  - **Interface**: Contém uma interface que define como as funções serão implementadas pela classe.
  - **BussinessRules**: Contém as funções que realizam o tratamento de dados.

- **App.Entities**: Aqui estão armazenadas todas as classes do projeto.

- **App.Server**: Este é o projeto responsável por rodar todo o back-end da aplicação, desenvolvido em C# com .NET Core.

- **App.Client**: Este é o projeto responsável por rodar todo o front-end da aplicação, desenvolvido em Angular.

## Como Contribuir

Se desejar contribuir para este projeto, siga estas etapas:

1. Faça um fork deste repositório.
2. Crie uma branch com sua feature: `git checkout -b minha-feature`.
3. Faça commit das suas alterações: `git commit -m 'Adicionando uma nova feature'`.
4. Faça push para a branch: `git push origin minha-feature`.
5. Envie um pull request.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
