# API de Login

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
   ```

2. Configure o banco de dados:
  - Crie um banco de dados no SQL Server.
  - Atualize a string de conexão no arquivo `appsettings.json`:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=SEU_SERVIDOR;Database=NOME_DO_BANCO;Trusted_Connection=True;"
     }
   }
   ```

3. Aplique as migrações para criar as tabelas no banco de dados:
   ```bash
   dotnet ef database update
   ```

4. Configure a chave secreta do JWT:
  - No ambiente de desenvolvimento, use o Secret Manager:
   ```bash
   dotnet user-secrets set "Jwt:Key" "SUA_CHAVE_SECRETA_AQUI"
   dotnet user-secrets set "Jwt:Issuer" "SuaAPI"
   dotnet user-secrets set "Jwt:Audience" "SeuCliente"
   ```

### Executando o Projeto

Execute o projeto:
```bash
   dotnet run
```

Acesse a API no navegador ou via Swagger:

- **Swagger UI**: [https://localhost:5001/swagger](https://localhost:5001/swagger)
- **Endpoint base**: `https://localhost:5001/api/usuario`

## Estrutura do Projeto

- **Controllers**: Contém os controladores da API.
- **Models**: Define as entidades do banco de dados.
- **Data**: Contém o contexto do banco de dados e configurações do Entity Framework.
- **Services**: Contém a lógica de negócio da aplicação.
- **Extensions**: Contém métodos de extensão para configurações globais.

## Contribuindo

1. Faça um fork do projeto.
2. Crie uma branch para sua feature:
   ```bash
   git checkout -b feature/nova-feature
   ```
3. Commit suas mudanças:
   ```bash
   git commit -m 'Adiciona nova feature'
   ```
4. Faça push para a branch:
   ```bash
   git push origin feature/nova-feature
   ```
5. Abra um pull request.

## Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

Desenvolvido com ❤️ por Fabricio Brizolla.
