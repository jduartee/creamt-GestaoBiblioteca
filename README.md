# creamt-GestaoBiblioteca

#
App para gestão de biblioteca

  - Cadastro de Usuários.
  - Cadastro de Acervo.
  - Cadastro de Pessoas.
  - Cadastro de Movimentação.
  - Devolução de Acervo.

# Tecnologias  e Ferramentas Utilizados!

  - .NET Core 3.2
  - Entity Framework Core 3.1.11
  - Entity Framework Identity 3.1.11
  - Auto Mapper
  - Mediatr 
  - Select2js
  - BootstrapTable
  - Bootstrap
  - Visual Studio 2019
  
  
# Requisitos para executar o Projeto

  - Altere a ConnectionStrings do Banco de Dados nos arquivos appsettings.json e appsettings.Development.json 
  - Execute um Clean e um Rebuild no Projeto para baixar o pacotes
  - Não é necessario gerar um novo migrations para cria o banco e as tabelas
  - No Statup.cs possui um InitializeDatabase que ao executar o projeto irá criar o banco e as tabelas se a ConnectionStrings estiver correta
