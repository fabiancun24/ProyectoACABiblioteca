# ACA -- Programación Avanzada

# Sistema de Gestión de Biblioteca

------------------------------------------------------------------------

## PORTADA

**\[CORPORACION UNIFICADA DE EDUCACION SUPERIOR\]**

**\[INGENIERIA DE SISTEMAS / 54465\]**

### ACA -- Programación Avanzada

### Sistema de Gestión de Biblioteca

**Presentado por:**\
\[FABIAN STIVEN ORTIZ RAMIREZ\]

**Docente:**\
\[VERONICA CASTRO\]

**Fecha:**\
\[BOGOTA, 02/11/2026\]

------------------------------------------------------------------------
## CONTRAPORTADA

**\[Documento tecnico de arquitectura y diseño de sistema de gestion de biblioteca\]**

**\[Documento normativo y descriptivo para el diseño, desarrollo, pruebas
  e implementación del software de gestión bibliotecaria basado en C#,
  Windows Forms, Arquitectura en 3 Capas y Microsoft SQL Server\]**

### ACA -- Programación Avanzada

### Sistema de Gestión de Biblioteca

**Presentado por:**\
\[FABIAN STIVEN ORTIZ RAMIREZ\]

**Docente:**\
\[VERONICA CASTRO\]

**Fecha:**\
\[BOGOTA, 02/11/2026\]

--------------------------

# TABLA DE CONTENIDO

1.  Introducción
2.  Objetivos
    -   2.1 Objetivo general
    -   2.2 Objetivos específicos
3.  Planteamiento del problema
4.  Análisis de requerimientos
5.  Casos de uso
6.  Diagrama de clases
7.  Modelo entidad-relación
8.  Diccionario de datos
9.  Arquitectura del sistema
10. Explicación de los módulos desarrollados
11. Capturas de pantalla del sistema
12. Pruebas de funcionamiento
13. Conclusiones
14. Recomendaciones
15. Referencias bibliográficas

------------------------------------------------------------------------

# 1. INTRODUCCIÓN

## INTRODUCCION

**\[El presente proyecto tiene como finalidad, entender la problematica del constante crecimiento del flujo de informacion y la necesidad de optimizar los recursos dentro de las instituciones educativas, asi mismo dar solucion presentando un proyecto de sistema de gestion de biblioteca, atravez del desarrollo del lenguaje de programacion c#, mediante el marco de trabajo con windows form, e integracion de base de datos con SQL server.\]**

-------------------------
# 2. OBJETIVOS

## 2.1 Objetivo general

\[Desarrollar una aplicación de escritorio integral para la gestión de biblioteca mediante C#, Windows Forms y SQL Server, que garantice la administración efectiva de libros, autores, editoriales, usuarios, préstamos y devoluciones, asegurando la coherencia e integridad de la información.\]


## 2.2 Objetivos específicos

-  Aplicar los fundamentos avanzados de la POO (Encapsulamiento, Abstracción, Herencia, Polimorfismo).
-   Diseñar e implementar un esquema de base de datos relacional normalizado en SQL Server con restricciones de unicidad e integridad referencial.
-   Desarrollar una arquitectura de software organizada por capas (Presentación, Lógica de Negocio, Acceso a Datos y Base de Datos).
-   Implementar operaciones de creación, lectura, actualización y eliminación (CRUD) parametrizadas para prevenir vulnerabilidades como inyección SQL.
-   Establecer mecanismos robustos de validación de entradas de usuario y manejo estructurado de excepciones.
-   Utilizar Git y GitHub como sistema de control de versiones y publicar la documentación técnica bajo normatividad académica.
-   Utilizar Git y GitHub para el control de versiones.
-   Documentar técnica y funcionalmente el proyecto.

-----------------------------------------------------


# 3. PLANTEAMIENTO DEL PROBLEMA

La biblioteca actualmente presenta dificultades para administrar de
manera organizada la información relacionada con los libros, autores,
usuarios y préstamos. El manejo manual de esta información puede generar
errores, pérdida de información y dificultades para conocer la
disponibilidad de los libros.

Por esta razón, se propone desarrollar una aplicación que permita
centralizar y administrar la información de la biblioteca de manera
organizada y eficiente.

-----------------------------------------------------
# 4. ANALISIS DE REQUERIMINTOS

## Requerimientos funcionales


RF01

Libros

El sistema debe permitir registrar, consultar, editar, eliminar y filtrar libros por código/ISBN, título y autor. Debe relacionar cada libro con un autor y editorial existentes.

RF02

Autores

El sistema permitirá el CRUD completo de autores (ID, Nombre, Apellido), bloqueando la eliminación si el autor tiene libros asociados.

RF03

Editoriales

Permite administrar editoriales respetando las restricciones de integridad relacional.

RF04

Usuarios

Permite registrar y gestionar usuarios de la biblioteca (Documento, Nombre, Apellido, Teléfono, Correo). El documento debe ser único

RF05

Préstamos

Registra el préstamo asociando un usuario registrado y un libro disponible. Asigna automáticamente la fecha del préstamo y estado "Prestado".

RF06

Devoluciones

Permite modificar el estado de un préstamo activo a "Devuelto", registrar la fecha de recepción y reincorporar la disponibilidad del libro.

RF07

Reportes

Módulo para generar consultas consolidadas: préstamos activos, historial por usuario, libros más prestados e inventario general.

RF08

Navegación

Menú principal que permite acceder dinámicamente a todos los subsistemas.
  -----------------------------------------------------------------------


## 4.4 Requerimientos no funcionales

  -----------------------------------------------------------------------
RNF01 (Usabilidad): Interfaz limpia en Windows Forms con controles nativos estructurados por paneles y menús legibles.

RNF02 (Seguridad/Integridad): Uso estricto de consultas parametrizadas (SqlParameter) en C# para mitigar ataques de inyección SQL.

RNF03 (Mantenibilidad): Código organizado en tres capas desacopladas (Presentación, BLL, DAL) utilizando nombres descriptivos de clases y métodos en convención PascalCase/camelCase.

RNF04 (Robustez): Bloques try-catch-finally en las operaciones de conexión a datos para ofrecer retroalimentación de error al usuario mediante MessageBox.

----------------------------------
