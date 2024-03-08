# API de MilesCarRental

Esta es la API backend para la aplicación MilesCarRental, un sistema de alquiler de vehículos.

## Descripción

MilesCarRental es un sistema de alquiler de vehículos que permite a los usuarios buscar y alquilar vehículos según su ubicación, fechas de recogida y devolución, y preferencias de vehículos.

## Tecnologías Utilizadas

- .NET 6
- C#
- Entity Framework Core
- ASP.NET Core Web API
- SQL Server

## Empezando

Para comenzar con la API de MilesCarRental, sigue estos pasos:

1. Clona este repositorio en tu máquina local.
2. Abre el archivo de solución `API_MilesCarRental.sln` en Visual Studio.
3. Actualiza la cadena de conexión en el archivo `appsettings.json` con tu cadena de conexión de SQL Server.
4. Compila la solución.
5. Ejecuta la aplicación.

## Endpoints

### Localidades

- `GET /api/localidades`: Obtiene todas las localidades.
- `GET /api/localidades/{id}`: Obtiene una localidad por su ID.
- `POST /api/localidades`: Crea una nueva localidad.
- `PUT /api/localidades/{id}`: Actualiza una localidad existente.
- `DELETE /api/localidades/{id}`: Elimina una localidad.

### Vehículos

- `GET /api/vehiculos`: Obtiene todos los vehículos.
- `GET /api/vehiculos/{id}`: Obtiene un vehículo por su ID.
- `POST /api/vehiculos`: Crea un nuevo vehículo.
- `PUT /api/vehiculos/{id}`: Actualiza un vehículo existente.
- `DELETE /api/vehiculos/{id}`: Elimina un vehículo.

### Reservas

- `GET /api/reservas`: Obtiene todas las reservas.
- `GET /api/reservas/{id}`: Obtiene una reserva por su ID.
- `POST /api/reservas`: Crea una nueva reserva.
- `PUT /api/reservas/{id}`: Actualiza una reserva existente.
- `DELETE /api/reservas/{id}`: Elimina una reserva.

## Contribución

¡Las contribuciones son bienvenidas! Si encuentras algún error o quieres agregar nuevas características, siéntete libre de abrir un issue o enviar un pull request.

## Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo [LICENSE](LICENSE) para más detalles.

## ¿Por qué Arquitectura Hexagonal?

Se eligió la arquitectura hexagonal (también conocida como puertos y adaptadores) debido a su capacidad para aislar la lógica de negocio del resto de la aplicación. Esto facilita la prueba unitaria y la adaptación de la aplicación a cambios en la tecnología o en los requisitos del negocio sin modificar su lógica interna.
