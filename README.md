Gerenciamento de Livros
Este projeto é um sistema de gerenciamento de livros, desenvolvido com .NET Core para o backend e Angular para o frontend.

1. Índice
1.1. Requisitos
1.2. Configuração do Backend
1.3. Configuração do Frontend
1.4. Como Rodar o Projeto
1.5. Testes
1.6. Contribuição

2. Requisitos
Antes de começar, verifique se você possui as seguintes ferramentas instaladas:

Git
.NET Core SDK 6 ou 8
Node.js e npm
Visual Studio Code
3. Configuração do Backend
3.1. Navegue para o diretório do backend
bash
Copiar código
cd GerenciamentoLivros/GerenciamentoLivros.API
3.2. Instale as dependências
bash
Copiar código
dotnet restore
3.3. Execute o backend
bash
Copiar código
dotnet run
O backend estará disponível em http://localhost:5000.

4. Configuração do Frontend
4.1. Navegue para o diretório do frontend
bash
Copiar código
cd gerenciamento-livros-frontend
4.2. Instale as dependências
bash
Copiar código
npm install

4.3. Execute o frontend
bash
Copiar código
ng serve
O frontend estará disponível em http://localhost:4200.

6. Como Rodar o Projeto
Inicie o Backend:

Navegue para o diretório do backend e execute o comando dotnet run. Certifique-se de que o backend está rodando e acessível em http://localhost:5000.
Inicie o Frontend:

Navegue para o diretório do frontend e execute o comando ng serve. O frontend estará acessível em http://localhost:4200.

6. Testes
Para o Backend:

Execute os testes unitários com o comando:
bash
Copiar código
dotnet test
Para o Frontend:

Execute os testes unitários com o comando:
bash
Copiar código
ng test

7. Contribuição
Sinta-se à vontade para contribuir com o projeto! Se você encontrar algum problema ou tiver uma ideia para melhorias, abra um issue ou envie um pull request.

