# Gerenciamento de Livros

Este projeto é um sistema de gerenciamento de livros, desenvolvido com .NET Core para o backend e Angular para o frontend.

## Índice
1. [Requisitos](#requisitos)
2. [Configuração do Backend](#configuração-do-backend)
3. [Configuração do Frontend](#configuração-do-frontend)
4. [Como Rodar o Projeto](#como-rodar-o-projeto)

## Requisitos

Antes de começar, verifique se você possui as seguintes ferramentas instaladas:

- Git
- .NET Core SDK 6 ou 8
- Node.js e npm
- Visual Studio Code

## Configuração do Backend

1. Navegue para o diretório do backend:

    ```bash
    cd GerenciamentoLivros/GerenciamentoLivros.API
    ```

2. Instale as dependências:

    ```bash
    dotnet restore
    ```

3. Execute o backend:

    ```bash
    dotnet run
    ```

   O backend estará disponível em [http://localhost:5098](http://localhost:5098).

## Configuração do Frontend

1. Navegue para o diretório do frontend:

    ```bash
    cd gerenciamento-livros-frontend
    ```

2. Instale as dependências:

    ```bash
    npm install
    ```

3. Execute o frontend:

    ```bash
    ng serve
    ```

   O frontend estará disponível em [http://localhost:4200](http://localhost:4200).

## Como Rodar o Projeto

1. Inicie o Backend:

   Navegue para o diretório do backend (GerenciamentoLivros/GerenciamentoLivros.API) e execute o comando `dotnet run`. Certifique-se de que o backend está rodando e acessível em [http://localhost:5098](http://localhost:5098).

2. Inicie o Frontend:

   Navegue para o diretório do frontend frontend (gerenciamento-livros-frontend) e execute o comando `ng serve`. O frontend estará acessível em [http://localhost:4200](http://localhost:4200).

