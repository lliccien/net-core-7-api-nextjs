# Products Applicaction

Este es un proyecto donde se aplicac el aprendizaje de .Net Core 7, Entity Framework con PostgreSQL, ReactJs y NextJs.

## Requisitos Previos

Asegúrate de tener instalados los siguientes elementos:

- .NET Core 7: [Descargar](https://dotnet.microsoft.com/download)
- Node.js: [Descargar](https://nodejs.org)
- npm (Viene con Node.js)
- Docker

## Configuración del Proyecto

1. Clona el repositorio: `git clone https://github.com/lliccien/net-core-7-api-nextjs.git`
2. Navega al directorio del proyecto: `cd net-core-7-api-nextjs`
3. Restaura las dependencias del servidor: `dotnet restore`
4. Restaura las dependencias del cliente: `cd ClientApp && npm install`
5. Vuelve al directorio principal: `cd ..`
6. Configura la base de datos:
   - Abre `appsettings.json` y actualiza la cadena de conexión de la base de datos según tus necesidades.
   - Ejecuta las migraciones: `dotnet ef database update`
7. Ejecuta la base de datos en postgreSql con el comando `docker-composer up -d`
8. Inicia la aplicación: `dotnet run`

## Estructura del Proyecto

Explica brevemente la estructura de tu proyecto. A continuación, se muestra un ejemplo de una estructura de carpetas común:

├── ClientApp/ # Carpeta del cliente (Next.js)
├── Controllers/ # Controladores de la API
├── Models/ # Modelos de datos
├── Migrations/ # Migraciones de la base de datos
├── Services/ # Lógica de negocio
├── appsettings.json # Configuración de la aplicación
└── Program.cs # Punto de entrada del servidor


## Tecnologías Utilizadas

- .NET Core 7
- Entity Framework con PostgreSQL
- Next.js
- React.js

## Contribución

Las contribuciones son bienvenidas. Si tienes alguna idea, problema o mejora, por favor, abre un "issue" o envía una solicitud de extracción.

## Licencia

Este proyecto está bajo la Licencia [Nombre de la Licencia]. Para más detalles, consulta el archivo [LICENSE](./LICENSE).

