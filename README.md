# Auth Server Identity

Um template de API de autenticação usando ASP.NET Core Identity, Entity Framework Core e PostgreSQL.

## Sobre o Projeto

Este projeto é uma API de autenticação que fornece endpoints para registro, login e gerenciamento de usuários usando o ASP.NET Core Identity. Inclui integração com Swagger para documentação e testes da API

## Tecnologias Utilizadas

- **ASP.NET Core 8.0** - Framework web
- **Entity Framework Core 8.0** - ORM para acesso a dados
- **PostgreSQL** - Banco de dados
- **ASP.NET Core Identity** - Sistema de autenticação e autorização
- **Swagger/OpenAPI** - Documentação da API
- **Npgsql** - Provider do PostgreSQL para .NET

## Configuração do Ambiente

### Pré-requisitos

- .NET 8.0 SDK
- PostgreSQL Server
- Visual Studio 2022 ou VS Code

2. **Execute as migrações** para criar o banco de dados:

```bash
dotnet ef database update
```

## 🏃‍♂️ Como Executar

1. **Clone o repositório**:
```bash
git clone <url-do-repositorio>
cd auth-server-identity
```

2. **Restaure as dependências**:
```bash
dotnet restore
```

3. **Configure a string de conexão** no `appsettings.json`

4. **Execute as migrações**:
```bash
dotnet ef database update
```

5. **Execute o projeto**:
```bash
dotnet run
```

## Endpoints da API

### Autenticação (Identity API)

O projeto utiliza os endpoints padrão do ASP.NET Core Identity:

- `POST /register` - Registrar novo usuário
- `POST /login` - Fazer login
- `POST /refresh` - Renovar token
- `POST /confirmEmail` - Confirmar email
- `POST /resendConfirmationEmail` - Reenviar email de confirmação
- `POST /forgotPassword` - Solicitar redefinição de senha
- `POST /resetPassword` - Redefinir senha
- `GET /manage/info` - Informações do usuário
- `POST /manage/info` - Atualizar informações do usuário

## Banco de Dados

O projeto utiliza PostgreSQL com as seguintes tabelas principais:
- AspNetUsers
- AspNetRoles
- AspNetUserRoles
- AspNetUserClaims
- AspNetUserLogins
- AspNetUserTokens
- AspNetRoleClaims

## Próximos Passos

- [ ] Implementar roles e claims personalizados
- [ ] Adicionar validações adicionais
- [ ] Implementar refresh tokens
- [ ] Adicionar logging
- [ ] Configurar CORS
- [ ] Implementar rate limiting
- [ ] Adicionar testes unitários
