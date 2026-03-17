# 🚀 .NET Fullstack Studies — Blazor | APIs | EF Core

Repositório dedicado aos meus estudos para uma vaga de Desenvolvedor .NET Júnior, com foco em Backend (ASP.NET Core + EF Core + Minimal APIs) e Frontend (Blazor).

Os projetos e exercícios aqui seguem um guia estruturado cobrindo desde fundamentos até construção de aplicações completas.

---

## 🎯 Objetivo

Consolidar conhecimentos essenciais para atuar como desenvolvedor .NET Fullstack, incluindo:

* Programação Orientada a Objetos (POO)
* Arquitetura de APIs REST
* Banco de dados SQL
* Entity Framework Core
* Minimal APIs e Controllers
* Blazor (Server, WASM e Auto Interactive)
* Componentização e comunicação entre componentes
* Git e fluxo de trabalho profissional

---

## 🧠 Mapa de Prioridades (Vaga .NET Júnior)

### 🔴 ESSENCIAL — Sem isso não passa

* Fundamentos de POO
* Injeção de Dependência (DI)
* EF Core (ORM)
* Minimal APIs
* Blazor (Server / WASM / Auto)
* Componentes e comunicação Pai ↔ Filho
* HTTP e API REST
* Banco de dados SQL básico
* Git e Git Flow

### 🟡 IMPORTANTE — Te destaca

* Controllers (MVC)
* Arquitetura em camadas
* Gerenciamento de estado global
* Templates / RenderFragment
* Comunicação entre componentes complexos

### 🟢 DIFERENCIAL — Bônus

* GraphQL (conceito)

---

## 📚 Conteúdos Estudados

### 🧩 Fundamentos da Linguagem C#

* Variáveis e tipos (int, string, double, bool, var)
* Estruturas condicionais (if, else, switch, ternário)
* Laços de repetição (for, while, foreach)
* Manipulação de strings
* Interpolação de texto

---

### 🧱 Programação Orientada a Objetos (POO)

* Classes e objetos
* Encapsulamento
* Herança
* Polimorfismo
* Abstração
* Interfaces

Exemplo de modelagem:

```
Animal → Cachorro / Gato
Veiculo → Carro / Moto
```

---

### 🏗️ Arquitetura Backend .NET

* Injeção de Dependência (DI)
* Arquitetura em camadas:

  * Controllers / Endpoints
  * Services (regras de negócio)
  * Repositories (dados)
  * Models / Entidades

---

### 🌐 HTTP e APIs REST

* Estrutura de Request e Response
* Headers, Body e parâmetros
* Verbos HTTP:

```
GET     → Buscar
POST    → Criar
PUT     → Atualizar completo
PATCH   → Atualizar parcial
DELETE  → Remover
```

* Status Codes:

```
2xx → Sucesso
4xx → Erro do cliente
5xx → Erro do servidor
```

---

### ⚡ Minimal APIs e Controllers

* Criação de endpoints no Program.cs
* Uso de DI em endpoints
* CRUD completo
* Comparação entre Minimal APIs e MVC Controllers

---

### 🗄️ Banco de Dados e SQL

* SELECT, INSERT, UPDATE, DELETE
* JOINs e relacionamentos
* GROUP BY e agregações
* Modelagem relacional (PK, FK)
* PostgreSQL / SQLite

---

### 🧮 ORM — Entity Framework Core

* DbContext e DbSet
* Migrations
* CRUD com LINQ
* Tracking vs No Tracking
* Relacionamentos entre entidades

---

### 🎨 Frontend com Blazor

#### Modos de renderização

* Blazor Server
* Blazor WebAssembly (WASM)
* Blazor Auto Interactive (.NET 8+)

---

### 🧩 Componentização

* Criação de componentes reutilizáveis (.razor)
* Parameters (props)
* EventCallback (eventos)
* Comunicação Pai → Filho
* Comunicação Filho → Pai
* Two-way binding (@bind)
* RenderFragment (slots)

---

### 🔄 Estado Global

* Serviços Scoped/Singleton como AppState
* Compartilhamento de dados entre componentes
* CascadingValue

---

### 🧪 Middlewares

* Pipeline de requisição
* Autenticação e autorização
* Logging e manipulação de requests/responses

---

### 🗂️ API REST Completa

* Controllers vs Minimal APIs
* Versionamento
* Stateless architecture
* Serialização JSON

---

### 🔀 Git e Fluxo de Trabalho

* Commits organizados
* Branches de feature
* Pull Requests
* Merge e resolução de conflitos
* Git Flow (main, develop, feature/*, hotfix/*)

---

## 🧪 Projeto Integrador (Em desenvolvimento)

Sistema completo de gerenciamento de tarefas (To-Do):

### Backend

* ASP.NET Core + Minimal APIs
* Arquitetura em camadas
* EF Core + Banco relacional
* CRUD completo
* Injeção de Dependência

### Frontend

* Blazor Web App (Auto Interactive)
* Componentes reutilizáveis
* Filtros e ordenação
* Comunicação entre componentes
* Estado global

---

## ▶️ Como executar os projetos

1. Clone o repositório:

```
git clone https://github.com/joaoramosw/csharp.git
```

2. Entre na pasta do projeto desejado:

```
cd nome-do-projeto
```

3. Execute:

```
dotnet run
```

---

## 📌 Checklist de Progresso

* [ ] Dominar os pilares da POO
* [ ] Criar APIs com Minimal APIs
* [ ] Trabalhar com EF Core e Migrations
* [ ] Construir interface com Blazor
* [ ] Integrar frontend e backend
* [ ] Aplicar arquitetura em camadas
* [ ] Utilizar Git de forma profissional

---

## 👨‍💻 Autor

João Victor Ramos
Desenvolvedor de Software

---

⭐ Repositório em constante evolução conforme avanço nos estudos.
