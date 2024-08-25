Gerenciamento de Livros
Este projeto é um sistema de gerenciamento de livros, desenvolvido com .NET Core para o backend e Angular para o frontend.

Índice
Requisitos
Configuração do Backend
Configuração do Frontend
Como Rodar o Projeto
Testes
Contribuição
Requisitos
Antes de começar, verifique se você possui as seguintes ferramentas instaladas:

Git
.NET Core SDK 6 ou 8
Node.js e npm
Visual Studio Code
Configuração do Backend
Navegue para o diretório do backend:
cd GerenciamentoLivros/GerenciamentoLivros.API

Instale as dependências:
dotnet restore

Execute o backend:
dotnet run
O backend estará disponível em http://localhost:5000.
Configuração do Frontend
Navegue para o diretório do frontend:
cd gerenciamento-livros-frontend

Instale as dependências:
npm install

Execute o frontend:
ng serve
O frontend estará disponível em http://localhost:4200.
Como Rodar o Projeto
Inicie o Backend:
Navegue para o diretório do backend e execute o comando dotnet run. Certifique-se de que o backend está rodando e acessível em http://localhost:5000.

Inicie o Frontend:
Navegue para o diretório do frontend e execute o comando ng serve. O frontend estará acessível em http://localhost:4200.

Testes
Para o Backend:
Execute os testes unitários com o comando:

dotnet test

Para o Frontend:
Execute os testes unitários com o comando:

ng test
