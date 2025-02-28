# API de Login com Frontend em Bootstrap

![API Login](https://www.bootstrapdash.com/wp-content/uploads/2017/08/ASP.NET-with-Core-Bootstrap-scaled.jpg)

Este projeto consiste em uma API RESTful desenvolvida em **.NET 8.0** com autenticação **JWT** e um frontend construído com **Bootstrap** para interação com a API. O sistema permite gerenciar usuários, incluindo operações **CRUD** (Create, Read, Update, Delete), além de autenticação e autorização via tokens JWT.

## 📌 Funcionalidades

### Backend (API)
✅ **Autenticação JWT**: Protege os endpoints da API.
✅ **Gerenciamento de Usuários:**
- Listar todos os usuários.
- Obter um usuário por ID.
- Criar um novo usuário.
- Atualizar um usuário existente.
- Excluir um usuário.

### Frontend (Bootstrap)
✅ **Página de Login**: Interface para autenticação de usuários.
✅ **Página de Cadastro**: Interface para criação de novos usuários.
✅ **Listagem de Usuários**: Exibe todos os usuários cadastrados.
✅ **Responsividade**: Layout adaptável para diferentes dispositivos (desktop, tablet, mobile).

## 🛠️ Tecnologias Utilizadas

### Backend
- **.NET 8.0**: Framework para desenvolvimento da API.
- **Entity Framework Core**: ORM para acesso ao banco de dados.
- **SQL Server**: Banco de dados relacional.
- **JWT (JSON Web Tokens)**: Autenticação e autorização.
- **Swagger**: Documentação interativa da API.

### Frontend
- **Bootstrap 5**: Framework CSS para criação de interfaces responsivas.
- **JavaScript**: Lógica de interação com a API.
- **Fetch API**: Para requisições HTTP (GET, POST, PUT, DELETE).

## 🚀 Como Executar

### Pré-requisitos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) ou outro banco de dados compatível com Entity Framework Core.
- [Node.js](https://nodejs.org/) (opcional, para rodar um servidor local do frontend).
- [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/).

### Configuração do Backend

1️⃣ Clone o repositório:
```bash
git clone https://github.com/seu-usuario/brizollaAPI.git
cd brizollaAPI/backend
```

2️⃣ Configure o banco de dados:
- Crie um banco de dados no SQL Server.
- Atualize a string de conexão no arquivo `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=NOME_DO_BANCO;Trusted_Connection=True;"
  }
}
```

3️⃣ Aplique as migrações para criar as tabelas no banco de dados:
```bash
dotnet ef database update
```

4️⃣ Configure a chave secreta do JWT:
```bash
dotnet user-secrets set "Jwt:Key" "SUA_CHAVE_SECRETA_AQUI"
dotnet user-secrets set "Jwt:Issuer" "SuaAPI"
dotnet user-secrets set "Jwt:Audience" "SeuCliente"
```

5️⃣ Execute o projeto:
```bash
dotnet run
```

6️⃣ Acesse a API no navegador ou via Swagger:
- **Swagger UI**: [https://localhost:5001/swagger](https://localhost:5001/swagger)
- **Endpoint base**: `https://localhost:5001/api/usuario`

### Configuração do Frontend

1️⃣ Navegue até a pasta do frontend:
```bash
cd brizollaAPI/frontend
```

2️⃣ Abra o arquivo `index.html` em um navegador ou use um servidor local (como o Live Server do VS Code).

3️⃣ Configure a URL da API no arquivo `API.js`:
```javascript
const API_URL = 'https://localhost:5001/api';
```

4️⃣ Interaja com a interface:
✅ **Login**: Autentique-se com um usuário existente.
✅ **Cadastro**: Crie um novo usuário.
✅ **Listagem de Usuários**: Visualize todos os usuários cadastrados.

## 📂 Estrutura do Projeto

### Backend
📁 **Controllers**: Contém os controladores da API.
📁 **Models**: Define as entidades do banco de dados.
📁 **Data**: Contém o contexto do banco de dados e configurações do Entity Framework.
📁 **Services**: Contém a lógica de negócio da aplicação.
📁 **Extensions**: Contém métodos de extensão para configurações globais.

### Frontend
📄 **index.html**: Página principal com formulários de login e cadastro.
📄 **usuarios.html**: Página para listagem de usuários.
📄 **styles.css**: Estilos personalizados complementares ao Bootstrap.
📄 **API.js**: Lógica de interação com a API (requisições HTTP).
📄 **Bootstrap**: Incluído via CDN no HTML.

## 📸 Screenshots

### Página de Login
![Tela de Login](![frontend.png](<https://media-hosting.imagekit.io//96289520d5c14c9d/frontend.png?Expires=1835319682&Key-Pair-Id=K2ZIVPTIP2VGHC&Signature=j5X02BHK~Lu1mvejx89o-akXltKCEE2ugUKNXd0Yf67yfUt9HSyt3h6fDOPAk6MQ2LvjYWpfioMisriuLM3xttzjz6xzid1J0n6Gy52oHDvM5K3pYkHG9H7uJ5VlXF-JE2x7WYoMsoT9bLtrfom4JkBdjLBkkfEK7ejGhkH-EL4788RLn3WmdF9KU54tkhFtUtKUPqUG5FnDlBShU4tFWC~e4ZHdE9RE9ztT-SbjWvHEviDPLAmT8QspaUxUvEFhVAJTM-bX7shO2Aqn9qeN04or~JsGSdrqfHFXPg7o94ovIsmSW6e0d5um-CaOJ28-YmNpcNRpvZer0PldWHd8~w__>))


### Listagem de Usuários
![Listagem de Usuários](https://via.placeholder.com/800x400?text=Listagem+de+Usuários)

## 🤝 Contribuindo

1️⃣ Faça um fork do projeto.
2️⃣ Crie uma branch para sua feature:
```bash
git checkout -b feature/nova-feature
```
3️⃣ Commit suas mudanças:
```bash
git commit -m 'Adiciona nova feature'
```
4️⃣ Faça push para a branch:
```bash
git push origin feature/nova-feature
```
5️⃣ Abra um pull request.



---

**Desenvolvido com ❤️ por Fabricio Brizolla.** 🚀
