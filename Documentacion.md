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
----------------------------------
## 5 Diagrama de Casos de Uso

### CU01 - Gestionar Libros

Permite registrar, editar, listar y consultar libros en la base de datos.

### CU02 - Gestionar Autores y Editoriales

Administra la información de los autores y casas editoriales asociadas.

### CU03 - Registrar Préstamos

Asigna libros a usuarios registrados especificando fecha de préstamo y devolución.

### CU04 - Registrar Devoluciones

Procesa la entrega del material bibliográfico y actualiza el estado del libro.

### CU05 - Consultar Reportes

Genera consolidados estadísticos sobre el uso de la biblioteca.

----------------------------------------------------------------------------------------------

# 6. DIAGRAMA DE DATOS

![Diagrama de Base de Datos](./diagrama.png)

-----------------------------------------------
-----------------------------------------------

# 7. MODELO DE ENTIDAD RELACIONAL

Usuario ($\underline{\text{id\_usuario}}$, nombre, documento, telefono, correo)

Autor ($\underline{\text{id\_autor}}$, nombre_autor, nacionalidad)

Editorial ($\underline{\text{id\_editorial}}$, nombre_editorial)

Libro ($\underline{\text{id\_libro}}$, titulo, isbn, id_autor, id_editorial, estado)

FK: id_autor $\rightarrow$ Autor(id_autor)

FK: id_editorial $\rightarrow$ Editorial(id_editorial)

Prestamo ($\underline{\text{id\_prestamo}}$, fecha_prestamo, fecha_devolucion, id_usuario, id_libro)

FK: id_usuario $\rightarrow$ Usuario(id_usuario)

FK: id_libro $\rightarrow$ Libro(id_libro)

-----------------------------------------------
-----------------------------------------------

# 8. DICCIONARIO DE DATOS

Libro--id_libro--INT--NO--PRIMARY KEY AUTO--Identificador único del libro.

Libro--titulo--VARCHAR(150)--NO--Ninguna--Nombre del libro almacenado.   

Libro--isbn--VARCHAR(20)--NO--UNIQUE--Código ISBN internacional.

Libro--id_autor--INT--NO--FOREIGN KEY--Referencia a la tabla Autor.

Prestamo--id_prestamo--INT--NO--PRIMARY KEY AUTO--Código secuencial del préstamo.

-----------------------------------------------
-----------------------------------------------

# 9. ARQUITECTURA DEL SISTEMA

La solución ProyectoACAbiblioteca implementa una arquitectura en 2 Capas (Presentación y Datos) basada en Windows Forms y SQL Server:

   Capa de Presentación (ProyectoACAbiblioteca): Formularios de interfaz de usuario (FRMPRINCIPAL, frmLIBROS, frmPRESTAMOS, etc.) encargados de capturar las acciones del usuario e incorporar navegación dinámica mediante un panel de contenido (PNLCONTENIDO).   
   
   Capa de Acceso a Datos (ProyectoACAbiblioteca.DATOS): Clase de infraestructura Conexion.cs dedicada a instanciar y gestionar las conexiones físicas hacia SQL Server utilizando la librería Microsoft.Data.SqlClient.

----------------------------------------------------------------------------------------------

# 10. EXPLICACION DE LOS MODULOS DE DESARROLLO

Explicación de los Módulos DesarrolladosMódulo Principal (FRMPRINCIPAL.cs): Contenedor MDI maestro que inicializa los componentes de interfaz, verifica la disponibilidad de la base de datos en su constructor y administra la conmutación entre pantallas mediante el método AbrirFormulario().  

Módulo de Libros (frmLIBROS.cs): Permite el mantenimiento CRUD del catálogo bibliográfico.   

Módulos de Soporte (frmAUTORES, frmEDITORIALES, frmUSUARIOS): Paneles para la gestión de entidades maestras.   

Módulo Transaccional (frmPRESTAMOS, frmDEVOLUCIONES): Administra el flujo de circulación del material y registro de fechas.   

Módulo de Reportes (frmREPORTES): Genera vistas consolidadas e indicadores de uso.

----------------------------------------------------------------------------------------------

# 11. CONECXION CON SQL

La comunicación del sistema con el motor de base de datos se realiza a través de la clase Conexion en el namespace ProyectoACAbiblioteca.DATOS.

Utiliza LocalDB / SQL Server Express mediante la cadena de conexión:
private string cadenaConexion = @"Server=(localdb)\MSSQLLocalDB;Database=ProyectoACAbiblioteca;Integrated Security=true;TrustServerCertificate=true;";

El método ObtenerConexion() retorna un objeto SqlConnection configurado, En el inicio de la aplicación se implementa un bloque using con manejo de excepciones try-catch para verificar la conectividad antes de habilitar la interfaz al usuario: 
using (var conn = conexion.ObtenerConexion())
{
    conn.Open();
    // Confirmación de enlace exitoso con el servidor SQL
}

----------------------------------------------------------------------------------------------