# **Projeto API CRUD em .NET**  

Este projeto é um desafio para aprender a construir uma API REST utilizando **.NET** com **Entity Framework Core** e **Swagger**.  

## **Tecnologias Utilizadas**  

- .NET 8.0  
- ASP.NET Core Web API  
- Entity Framework Core
- SQLite  
- Swagger

## **Pré-requisitos**  

Antes de começar, certifique-se de ter instalado:  

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (versão 8.0)  
- [Git](https://git-scm.com/downloads)  
- Um editor de código, como [Visual Studio Code](https://code.visualstudio.com/)  

## **Repositórios que usei de apoio**  

```bash
git clone https://github.com/digitalinnovationone/trilha-net-api-desafio.git
cd trilha-net-api-desafio
```

ou  

```bash
git clone https://github.com/LucasBS8/treino_Api_CSharp.git
cd treino_Api_CSharp
```

## **Criando o Projeto API**  

Se estiver usando .NET 8.0:  

```bash
dotnet new webapi --use-controllers
```

Se estiver usando .NET 9.0:  

```bash
dotnet new webapi --use-controllers --framework net8.0
```

## **Instalando o Entity Framework Core**  

Instale a ferramenta do EF Core:  

```bash
dotnet tool install --global dotnet-ef
```

Adicione os pacotes necessários ao projeto:  

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Swashbuckle.AspNetCore
```

## **Configurando o Banco de Dados**  

Crie as migrations:  

```bash
dotnet ef migrations add InitialCreate
```

Atualize o banco de dados:  

```bash
dotnet ef database update
```

## **Executando a API**  

Para rodar a API e acompanhar as mudanças em tempo real:  

```bash
dotnet watch run
```

A API estará disponível em:  

```
http://localhost:5000
```

## **Testando a API com Swagger**  

Após rodar a API, acesse o Swagger para testar os endpoints:  

```
http://localhost:5000/swagger
```

## **Endpoints da API**  

A API permite operações CRUD (Create, Read, Update, Delete).  

### **Criar uma nova tarefa (POST)**  
```http
POST /api/tarefa
```
#### **Body (JSON):**  
```json
{
  "titulo": "Nova Tarefa",
  "descricao": "Descrição da tarefa",
  "data": "2025-02-18T00:00:00Z",
  "status": "Pendente"
}
```
---

### **Listar todas as tarefas (GET)**  
```http
GET /api/tarefa
```
---

### **Buscar uma tarefa pelo ID (GET)**  
```http
GET /api/tarefa/{id}
```
#### **Parâmetros:**  
- `id` (int) – Identificador da tarefa.  

---

### **Buscar tarefas por título (GET)**  
```http
GET /api/tarefa/ObterPorTitulo
```
#### **Parâmetros:**  
- `titulo` (string) – Título parcial ou completo da tarefa.  

---

### **Buscar tarefas por data (GET)**  
```http
GET /api/tarefa/ObterPorData
```
#### **Parâmetros:**  
- `data` (DateTime) – Data no formato `YYYY-MM-DD`.  
---

### **Buscar tarefas por status (GET)**  
```http
GET /api/tarefa/ObterPorStatus
```
#### **Parâmetros:**  
- `status` (string) – Status da tarefa (exemplo: `Pendente`, `Concluída`).  
---

### **Atualizar uma tarefa (PUT)**  
```http
PUT /api/tarefa/{id}
```
#### **Parâmetros:**  
- `id` (int) – Identificador da tarefa.  
#### **Body (JSON):**  
```json
{
  "titulo": "Tarefa Atualizada",
  "descricao": "Nova descrição",
  "data": "2025-02-19T00:00:00Z",
  "status": "Concluída"
}
```
---

### **Excluir uma tarefa (DELETE)**  
```http
DELETE /api/tarefa/{id}
```
#### **Parâmetros:**  
- `id` (int) – Identificador da tarefa.  

