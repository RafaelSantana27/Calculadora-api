# 🧮 Calculadora API

API REST desenvolvida em **C# com ASP.NET Core** como projeto prático de aprendizado e aplicação dos principais conceitos de desenvolvimento de APIs.

O projeto simula uma calculadora capaz de realizar operações matemáticas e manter um **histórico das operações realizadas**, utilizando uma estrutura organizada entre Controllers, Services, Models e persistência em JSON.

O objetivo principal foi praticar conceitos de desenvolvimento backend com **C# e ASP.NET Core**, buscando uma organização que facilite futuras evoluções do projeto.

---

## 🚀 Funcionalidades

A API disponibiliza operações matemáticas básicas:

* ➕ Soma
* ➖ Subtração
* ✖️ Multiplicação
* ➗ Divisão
* 📊 Média entre dois números
* 📝 Registro do histórico das operações
* 🕒 Registro da data e hora da operação
* ⚠️ Validação de entradas
* 🚫 Tratamento de divisão por zero

---

## 🏗️ Estrutura do projeto

O projeto foi organizado buscando separar as responsabilidades de cada componente:

```text
Calculadora-api/
│
├── Controllers/
│   └── CalculadoraController.cs
│
├── Model/
│   └── Historico.cs
│
├── Repository/
│   └── HistoricoCalculadora.json
│
├── Services/
│   ├── CalculadoraService.cs
│   └── HistoricoService.cs
│
├── Utils/
│   └── HelperNumero.cs
│
└── Program.cs
```

### Controllers

Responsáveis por receber as requisições HTTP e retornar as respostas da API.

### Services

Concentram as regras e operações da aplicação.

O `CalculadoraService` é responsável pelas operações matemáticas, enquanto o `HistoricoService` gerencia o registro das operações realizadas.

### Model

Contém as estruturas utilizadas pela aplicação.

O modelo `Historico` representa uma operação realizada na calculadora, armazenando os números utilizados, resultado, operação e data/hora.

### Repository

Responsável pelo armazenamento do histórico utilizado no projeto.

Nesta versão, foi utilizado **JSON como forma de persistência**, com o objetivo de praticar leitura, gravação e serialização de dados.

### Utils

Contém métodos auxiliares utilizados pela aplicação, como validações relacionadas aos números recebidos.

---

## 🔌 Endpoints

### Soma

```http
GET /api/calculadora/somar
```

Realiza a soma de dois números.

### Subtração

```http
GET /api/calculadora/subtrair
```

Realiza a subtração de dois números.

### Multiplicação

```http
GET /api/calculadora/multiplicar
```

Realiza a multiplicação de dois números.

### Divisão

```http
GET /api/calculadora/dividir
```

Realiza a divisão de dois números.

A API possui validação para impedir divisão por zero.

### Média

```http
GET /api/calculadora/media
```

Calcula a média entre dois números.

---

## 🛠️ Tecnologias utilizadas

* **C#**
* **ASP.NET Core**
* **.NET 10**
* **REST API**
* **JSON**
* **Git**
* **GitHub**

---

## 🧠 Conceitos praticados

Durante o desenvolvimento foram aplicados conceitos importantes do desenvolvimento backend com .NET:

* Arquitetura baseada em responsabilidades
* Controllers
* Services
* Injeção de Dependência (DI)
* HTTP e métodos GET
* Rotas
* `IActionResult`
* `Ok()` e `BadRequest()`
* Validação de dados
* Tratamento de exceções
* Serialização e desserialização JSON
* Manipulação de arquivos
* `List<T>`
* `decimal`
* `DateTime`
* Organização de código
* Git e GitHub

---

## 🎯 Objetivo do projeto

Este projeto foi desenvolvido como parte dos meus estudos em **C# e ASP.NET Core**, com o objetivo de transformar conceitos teóricos em uma aplicação funcional.

Além das operações matemáticas, a implementação do histórico foi utilizada para praticar conceitos de **serviços, injeção de dependência e persistência de dados**.

A proposta é continuar evoluindo a aplicação conforme novos conceitos de desenvolvimento com .NET forem aprendidos.

---

## 🔮 Possíveis evoluções

Algumas melhorias planejadas para futuras versões:

* [ ] Implementar interfaces para os Services
* [ ] Criar Repository com interface própria
* [ ] Melhorar a abstração da persistência
* [ ] Implementar tratamento global de exceções
* [ ] Criar DTOs para entrada e saída de dados
* [ ] Implementar testes unitários
* [ ] Melhorar os códigos HTTP retornados pela API
* [ ] Substituir a persistência em JSON por banco de dados
* [ ] Documentar a API com Swagger/OpenAPI
* [ ] Implementar operações utilizando `async/await`

---

## 📚 Sobre o projeto

Este projeto faz parte da minha jornada de aprendizado em **C# e desenvolvimento de APIs com ASP.NET Core**.

A proposta não é apenas criar uma calculadora, mas utilizar um projeto simples para praticar conceitos que podem ser aplicados posteriormente em sistemas e APIs maiores.

**Projeto desenvolvido para fins de estudo e portfólio.**

---

## 👨‍💻 Autor

**Rafael Santana**

Desenvolvedor em formação com experiência profissional em suporte, implantação e análise de sistemas, atualmente aprofundando os conhecimentos em **C#, .NET e desenvolvimento de APIs**.
