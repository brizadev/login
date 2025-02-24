# brizollaAPI

Esta é uma API RESTful desenvolvida em .NET 8.0 com autenticação JWT. Ela permite gerenciar usuários, incluindo operações CRUD (Create, Read, Update, Delete).

## Funcionalidades

- **Autenticação JWT**: Protege os endpoints da API.
- **Gerenciamento de Usuários**:
    - Listar todos os usuários.
    - Obter um usuário por ID.
    - Criar um novo usuário.
    - Atualizar um usuário existente.
    - Excluir um usuário.

## Tecnologias Utilizadas

- **.NET 8.0**: Framework para desenvolvimento da API.
- **Entity Framework Core**: ORM para acesso ao banco de dados.
- **SQL Server**: Banco de dados relacional.
- **JWT (JSON Web Tokens)**: Autenticação e autorização.
- **Swagger**: Documentação interativa da API.

## Como Executar

### Pré-requisitos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) ou outro banco de dados compatível com Entity Framework Core.
- [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/).

### Configuração do Ambiente

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/brizollaAPI.git
   cd brizollaAPI/backend
Configure o banco de dados:

Crie um banco de dados no SQL Server.

Atualize a string de conexão no arquivo appsettings.json:

json
Copy
{
"ConnectionStrings": {
"DefaultConnection": "Server=SEU_SERVIDOR;Database=NOME_DO_BANCO;Trusted_Connection=True;"
}
}
Aplique as migrações para criar as tabelas no banco de dados:

bash
Copy
dotnet ef database update
Configure a chave secreta do JWT:

No ambiente de desenvolvimento, use o Secret Manager:

bash
Copy
dotnet user-secrets set "Jwt:Key" "SUA_CHAVE_SECRETA_AQUI"
dotnet user-secrets set "Jwt:Issuer" "SuaAPI"
dotnet user-secrets set "Jwt:Audience" "SeuCliente"
Em produção, use variáveis de ambiente.

Executando o Projeto
Execute o projeto:

bash
Copy
dotnet run
Acesse a API no navegador ou via Swagger:

Swagger UI: https://localhost:5001/swagger

Endpoint base: https://localhost:5001/api/usuario

Testando a API
Autenticação
Faça uma requisição POST para /api/auth/login com o corpo:

json
Copy
{
"email": "usuario@example.com",
"senha": "senha123"
}
Use o token JWT retornado para acessar os endpoints protegidos.

Endpoints de Usuários
GET /api/usuario: Lista todos os usuários.

GET /api/usuario/{id}: Obtém um usuário por ID.

POST /api/usuario: Cria um novo usuário.

PUT /api/usuario/{id}: Atualiza um usuário existente.

DELETE /api/usuario/{id}: Exclui um usuário.

Estrutura do Projeto
Controllers: Contém os controladores da API.

Models: Define as entidades do banco de dados.

Data: Contém o contexto do banco de dados e configurações do Entity Framework.

Services: Contém a lógica de negócio da aplicação.

Extensions: Contém métodos de extensão para configurações globais.

Contribuindo
Faça um fork do projeto.

Crie uma branch para sua feature (git checkout -b feature/nova-feature).

Commit suas mudanças (git commit -m 'Adiciona nova feature').

Faça push para a branch (git push origin feature/nova-feature).

Abra um pull request.

Licença
Este projeto está licenciado sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

Desenvolvido com ❤️ por Fabricio brizolla.#   l o g i n  
 