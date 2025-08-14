# 🖥️ Backend API - .NET 8

API desenvolvida com **.NET 8** seguindo boas práticas de arquitetura e padrões de projeto.  
Utiliza **Repository Pattern**, **DTOs**, **Entity Framework Core** e **SQL Server** como banco de dados.

---

## 🚀 Tecnologias Utilizadas

- **.NET 8** (C#)
- **Entity Framework Core**
- **Repository Pattern**
- **DTOs (Data Transfer Objects)**
- **SQL Server**
- **Dependency Injection**
- **Swagger** para documentação de endpoints
---

## 📂 Estrutura do Projeto

```plaintext
src/
├── Application/       # Lógica de aplicação, DTOs e casos de uso
├── Domain/            # Entidades e interfaces
├── Infrastructure/    # Acesso a dados, contextos e repositórios
├── Categorias/               # Controllers e endpoints

⚙️ Configuração do Ambiente
1️⃣ Pré-requisitos
.NET 8 SDK
SQL Server
Visual Studio

2️⃣ Clonar o repositório
git clone https://github.com/seu-usuario/seu-projeto.git
cd seu-projeto


3️⃣ Configurar o appsettings.json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=MinhaAPI;User Id=sa;Password=SuaSenha;"
  }
}
4️⃣ Executar as migrations
dotnet ef database update

5️⃣ Rodar o projeto
dotnet run --project APIcoloca tudo em markdown


## ⚙️ Configuração do Ambiente

### 1️⃣ Pré-requisitos
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/sql-server)
- [Visual Studio](https://visualstudio.microsoft.com/)

---

### 2️⃣ Clonar o repositório
```bash
git clone https://github.com/seu-usuario/seu-projeto.git
cd seu-projeto


3️⃣ Configurar o appsettings.json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=MinhaAPI;User Id=sa;Password=SuaSenha;"
  }
}
4️⃣ Executar as migrations
dotnet ef database update

5️⃣ Rodar o projeto
dotnet run --project API
    Application --> Domain[Domain Layer]
    Application --> Infrastructure[Infrastructure Layer]
    Infrastructure --> DB[(SQL Server)]
