# .NET web API all automated

This repository provides a fully working example of a .NET web API with all needed automation.

## Design

### Projects

Name | Technology stack | Role
---- | ---------------- | ----
`WebApi` | ASP.NET 5.0 | Web application providing the REST API
`WebApi.Dto` | .NET 5.0 | Library providing definitions for Data Transfer Objects (DTO)

### Open topics

* Health check in docker compose definition
* Kubernetes definition (with Helm chart)
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

* Use Swagger web UI: open [localhost:5001/swagger](https://localhost:5001/swagger) in a browser

### How to run containers

* Edit manually the host file of the system (on Windows: `C:\Windows\System32\drivers\etc\hosts`) to add the following line

```ini
127.0.0.1 webapi.localhost
```

* From the command line

```bash
# create image
docker-compose -f docker-compose.dev.yml build

# create containers
docker-compose -f docker-compose.dev.yml up -d

# scale up or down
docker-compose -f docker-compose.dev.yml up -d --scale webapi=3

# shutdown
docker-compose -f docker-compose.dev.yml down
```

* Open [webapi.localhost:8000/swagger](http://webapi.localhost:8000/swagger) in the browser

## operation

### How to create Docker images

* From the command line (replace `devprofr` with the container registry name)

```bash
docker build . -t devprofr/allautomateddotnetwebapi -f src/WebApi/Dockerfile --no-cache
```

### How to setup an environment

* Review `docker-compose.yml` to match your need (container registry, ASP.NET configuration from environment variables, reverse proxy)

* Edit manually the host file of the system to add the following line

```ini
127.0.0.1 webapi.localhost
```

* From the command line

```bash
# create containers
docker-compose up -d

# scale up or down
docker-compose up -d --scale webapi=3

# shutdown
docker-compose down
```

* Open [webapi.localhost:8000/health](http://webapi.localhost:8000/health) in the browser
