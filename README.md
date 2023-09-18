# dotnetcore-rest-api-angular-project-001

DotNet core web api with angular frontend , ecommerce application

## Layered Architecture

Layerd Projets, Seperation of concern , seperating Controllers,Models, Services

## Repository Pattern

## Dependency Injection

### Using Add Transient

Transient lifetime services are created each time they are requested. This lifetime works best for lightweight, stateless services.

### Using Add Scoped

Scoped lifetime services are created once per request.

### Using Add Singleton

Singleton lifetime services are created the first time they are requested (or when ConfigureServices is run if you specify an instance there) and then every subsequent request will use the same instance.
