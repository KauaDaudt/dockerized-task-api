# 🐳 DockerizedTaskAPI

![.NET](https://img.shields.io/badge/.NET-8.0-blue?logo=dotnet)
![Docker](https://img.shields.io/badge/Docker-Containerized-blue?logo=docker)
![MySQL](https://img.shields.io/badge/MySQL-8.0-orange?logo=mysql)
![Swagger](https://img.shields.io/badge/Swagger-API-green?logo=swagger)

API REST desenvolvida em **C# com .NET 8**, utilizando **MySQL** como banco de dados e ambiente totalmente containerizado com **Docker**.

---

## 🚀 Funcionalidades

* CRUD completo de tarefas
* Integração com banco MySQL
* Migrations com Entity Framework Core
* Documentação automática com Swagger
* Execução via Docker Compose

---

## 🧱 Tecnologias

* C#
* .NET 8
* ASP.NET Core Web API
* Entity Framework Core
* MySQL
* Docker
* Docker Compose

---

## 🐳 Como rodar o projeto

```bash
git clone https://github.com/KauaDaudt/dockerized-task-api.git
cd dockerized-task-api/DockerizedTaskAPI
docker compose up -d
dotnet ef database update
dotnet run
```

Acesse:

```txt
http://localhost:5289/swagger
```

---

## 📌 Endpoints

| Método | Rota            | Descrição    |
| ------ | --------------- | ------------ |
| GET    | /api/Tasks      | Lista todas  |
| GET    | /api/Tasks/{id} | Busca por ID |
| POST   | /api/Tasks      | Cria         |
| PUT    | /api/Tasks/{id} | Atualiza     |
| DELETE | /api/Tasks/{id} | Remove       |

---

## 🎯 Objetivo

Projeto criado para demonstrar conhecimentos em:

* Desenvolvimento de APIs REST
* Persistência de dados
* Containerização com Docker
* Boas práticas de backend

---

## 👨‍💻 Autor

**Kauã Daudt Gomes**

🔗 https://www.linkedin.com/in/kau%C3%A3-daudt-848548345/
