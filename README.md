# .NET web API all automated

This repository provides a fully working example of a .NET web API with all needed automation.

## Design

### Projects

Name | Technology stack | Role
---- | ---------------- | ----
`WebApi` | ASP.NET 5.0 | Web application providing the REST API
`WebApi.Dto` | .NET 5.0 | Library providing definitions for Data Transfer Objects (DTO)

### Open topics

* InMemory database (with associated integration testing) and switch to async actions
* OpenTelemetry
* Tekton
* Keptn
* Argo
* MongoDB

## Quickstart

* Make sure all requirements are met: [setup guide](./docs/setup-guide.md)

## Development

### How to build

* From the command line

```bash
dotnet build
```

### How to test

* From the command line

```bash
dotnet test
```

### How to run

* From the command line

```bash
dotnet run --project src/WebApi
```

* Check application's health

```bash
curl -k https://localhost:5001/health
```

### How to package
