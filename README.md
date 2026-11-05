# Sistema de Gestión de Biblioteca

## Descripción

Sistema de escritorio desarrollado en C# con Windows Forms y SQL Server, diseñado para facilitar la administración de una biblioteca mediante el registro y consulta de libros, usuarios, autores, editoriales y préstamos.

## Tecnologías utilizadas

- C#
- Windows Forms
- .NET Framework 4.8
- SQL Server
- ADO.NET
- Visual Studio

## Funcionalidades

- Consulta y administración de libros.
- Consulta y administración de usuarios.
- Gestión de autores y editoriales.
- Registro y consulta de préstamos.
- Actualización del estado de los préstamos.
- Registro de la fecha de devolución.
- Panel principal con indicadores.
- Cinco reportes de información:
  1. Libros registrados.
  2. Usuarios registrados.
  3. Todos los préstamos.
  4. Préstamos devueltos.
  5. Préstamos pendientes.

## Arquitectura del proyecto

El sistema está organizado en tres capas principales:

- **Presentación:** formularios de Windows Forms e interacción con el usuario.
- **Negocio:** lógica y operaciones del sistema.
- **Datos:** consultas y conexión con SQL Server.

## Base de datos

La base de datos se llama `BibliotecaDB` y está compuesta por cinco tablas:

- Autores
- Editoriales
- Libros
- Usuarios
- Prestamos

El proyecto incluye el archivo `BibliotecaDB_Completo.sql`, que contiene el script de creación y preparación de la base de datos.

## Instalación y ejecución

1. Instalar Visual Studio y SQL Server.
2. Abrir el archivo `BibliotecaApp.sln`.
3. Ejecutar el script `BibliotecaDB_Completo.sql` en SQL Server Management Studio.
4. Revisar la cadena de conexión en el archivo de conexión del proyecto y ajustarla al nombre de la instancia local de SQL Server.
5. Compilar la solución.
6. Ejecutar el proyecto desde Visual Studio.

## Autor

**Dylan Stive Velandia Arias**

Técnico Profesional en Sistemas e Informática  
Corporación Unificada Nacional de Educación Superior (CUN)  
Bogotá D.C., Colombia

## Estado del proyecto

Proyecto académico desarrollado como parte de la asignatura Programación Avanzada.
