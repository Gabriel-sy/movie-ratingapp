# Movie RatingApp

## Descrição

Movie RatingApp é um site que tem como função adicionar, avaliar e gerenciar seus filmes e séries favoritos. Os usuários podem buscar por qualquer filme/série, e avaliar esse filme/série, adicionando ele ao seu perfil pessoal. Na página inicial, os filmes e séries adicionados são exibidos com a avaliação do usuário, nome, data e poster, e é possível editar ou remover essas avaliações, além de filtrar os itens por nome e avaliação.

## Funcionalidades

- **Busca por filmes/séries**: Busca por qualquer filme ou série pelo nome.
- **Adicionar filmes/séries**: Adicione filmes e séries ao seu perfil pessoal.
- **Avaliação**: Avalie os filmes e séries adicionados.
- **Edição de avaliações**: Edite as notas de avaliação atribuídas aos filmes e séries.
- **Remoção de avaliações**: Remova filmes e séries da sua lista.
- **Filtragem**: Filtre filmes e séries por nome e avaliação na página inicial.

## Tecnologias Utilizadas

- Angular
- Spring
- PostgreSQL

## Instalação

### Pré-requisitos

- Node.js
- Angular CLI
- Java 11+
- Maven
- PostgreSQL

### Passo a Passo

1. **Clone o repositório**

    ```bash
    git clone https://github.com/Gabriel-sy/movie-ratingapp.git
    cd movie-ratingapp
    ```

2. **Configuração do Banco de Dados**

    Crie um banco de dados PostgreSQL e configure o arquivo `application.properties`:

    ```properties
    spring.datasource.url=jdbc:postgresql://localhost:5432/seu_banco_de_dados
    spring.datasource.username=seu_usuario
    spring.datasource.password=sua_senha
    ```

3. **Backend**

    Navegue até o diretório do backend e inicie o servidor Spring:

    ```bash
    cd backend
    ./mvnw spring-boot:run
    ```

4. **Frontend**

    Navegue até o diretório do frontend, instale as dependências e inicie o servidor Angular:

    ```bash
    cd frontend
    npm install
    ng serve
    ```

5. **Acesso**

    Abra o navegador e acesse `http://localhost:4200` para usar a aplicação.
