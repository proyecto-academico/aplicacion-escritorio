# aplicacion-escritorio


# Para que funcione el login del escritorio 
se debe de executar el archivo sql en MySql
y aparte cambiar el udl al correspondiente y poner en el codigo la coneccion



## Documentación de la Aplicación PRUEAS

La aplicación PRUEAS es una aplicación de escritorio desarrollada en C# utilizando Windows Forms. A continuación, se presenta una descripción de las clases y formularios clave que componen la aplicación:

### Clase `Acceso_Querys`

La clase `Acceso_Querys` es una clase que proporciona métodos para acceder y consultar una base de datos. Esta clase se utiliza para interactuar con la base de datos y realizar operaciones como guardar datos de personas, materias, notas y faltas, así como recuperar información de la base de datos.

### Clase `ClasePersonas`

La clase `ClasePersonas` representa a una persona y contiene propiedades como `_dni`, `Name`, `Surname` y `mail`, que almacenan información sobre la persona. Esta clase se utiliza para crear objetos que representan personas en la aplicación.

### Clase `Clasenotas`

La clase `Clasenotas` representa las notas de una persona y contiene propiedades como `_dni`, `Materia`, `Nota1`, `Nota2` y `Nota3`. Esta clase se utiliza para almacenar y gestionar las notas de las personas.

### Clase `ClaseFaltas`

La clase `ClaseFaltas` representa las faltas de una persona y contiene propiedades como `_dni`, `Fecha`, `Tipo` y `Justificado`. Esta clase se utiliza para almacenar y gestionar las faltas de las personas.

### Clase `Clase_ClaseMateria`

La clase `Clase_ClaseMateria` representa una clase de materia y contiene propiedades como `ClaseID` y `Nombre`. Esta clase se utiliza para representar las materias y clases asociadas a ellas.

### Clase `ClaseDivisiones`

La clase `ClaseDivisiones` representa una división y contiene propiedades como `DivisionID` y `Nombre`. Esta clase se utiliza para representar las divisiones a las que pertenecen las personas.

### Form `FormInicioSesion`

El form `FormInicioSesion` es un formulario de inicio de sesión que permite a los usuarios ingresar a la aplicación. Los usuarios deben ingresar una contraseña para acceder a la aplicación.

### Form `FormMenuPrincipal`

El form `FormMenuPrincipal` es el formulario principal de la aplicación y proporciona acceso a diferentes funcionalidades, como ver personas, materias, divisiones, evaluaciones y faltas.

### Form `FormGuardarPersonas`

El form `FormGuardarPersonas` es un formulario para agregar o editar información de personas. Los usuarios pueden ingresar datos como nombre, apellido, DNI y tipo de persona (alumno o profesor).

### Form `FormVerPersonas`

El form `FormVerPersonas` es un formulario que muestra una lista de personas y permite buscar, agregar, editar y eliminar personas. Los usuarios pueden filtrar la lista por tipo de persona y realizar acciones como ver notas y faltas.

### Form `FormGuardarNotas`

El form `FormGuardarNotas` es un formulario para agregar o editar notas de una persona. Los usuarios pueden ingresar notas para diferentes materias.

### Form `FormVerNotas`

El form `FormVerNotas` es un formulario que muestra las notas de una persona y permite agregar nuevas notas. Los usuarios pueden ver y gestionar las notas de una persona.

### Form `FormGuardarFaltas`

El form `FormGuardarFaltas` es un formulario para agregar faltas de una persona. Los usuarios pueden ingresar la fecha, tipo y justificación de la falta.

### Form `FormVerFaltas`

El form `FormVerFaltas` es un formulario que muestra las faltas de una persona y permite agregar nuevas faltas. Los usuarios pueden ver y gestionar las faltas de una persona.

### Form `FormVerMateria`

El form `FormVerMateria` es un formulario que muestra una lista de materias y clases asociadas. Los usuarios pueden ver la información de las materias y acceder a las evaluaciones asociadas.

### Form `FormVerEvaluaciones`

El form `FormVerEvaluaciones` es un formulario que muestra las evaluaciones y permite agregar nuevas evaluaciones. Los usuarios pueden ver y gestionar las evaluaciones de una persona.

### Form `FormVerDivisiones`

El form `FormVerDivisiones` es un formulario que muestra una lista de divisiones. Los usuarios pueden ver la información de las divisiones.

## Documentación de la Clase `DB_Querys`

Métodos y funciones de la clase `DB_Querys`:

### Método `DeletePersona`

El método `DeletePersona` se utiliza para eliminar una persona de la base de datos. Toma un objeto de la clase `ClasePersonas` como argumento, que contiene el DNI de la persona que se eliminará. La función ejecuta una consulta SQL para eliminar la persona de la tabla "persona" en la base de datos.

### Método `GetClaseClaseMaterias`

Este método se utiliza para obtener una lista de clases de materias junto con información sobre la división, el profesor, la fecha de inicio, la fecha de finalización y el nombre de la materia. La información se recupera mediante una consulta SQL que se une a varias tablas relacionadas.

### Método `GetDivisiones`

El método `GetDivisiones` se utiliza para obtener una lista de divisiones de clases. Devuelve el ID de la división, el turno y el nombre de la división en formato "Año° División°". La información se obtiene mediante una consulta SQL simple.

### Método `GetMaterias`

Este método se utiliza para obtener una lista de materias. Toma un parámetro `persona_` que se utiliza en una consulta SQL para recuperar información sobre las materias asociadas a una persona específica.

### Método `GetClasenotas`

El método `GetClasenotas` se utiliza para obtener una lista de notas de los alumnos. Toma un parámetro `persona_` que se utiliza en una consulta SQL para recuperar información sobre las notas de un alumno específico. La información incluye el ID de la nota, el DNI del alumno, el nombre del alumno, la nota, el nombre de la clase y la fecha de la evaluación.

### Método `GetEvaluaciones`

El método `GetEvaluaciones` se utiliza para obtener una lista de evaluaciones realizadas en las clases. Devuelve información sobre el ID de la evaluación, el nombre de la clase, el ID de la clase, la fecha de la evaluación, los detalles y el promedio de notas de la evaluación. La información se recupera mediante una consulta SQL que se une a varias tablas relacionadas.

### Método `GetFaltas`

El método `GetFaltas` se utiliza para obtener una lista de faltas de un alumno específico. Toma un parámetro `persona_` que se utiliza en una consulta SQL para recuperar información sobre las faltas de un alumno, incluyendo el ID de la falta, la fecha, el tipo y si está justificada o no.

### Método `NumGetFaltas` y `NumGetFaltasJust`

Estos métodos se utilizan para obtener el número total de faltas y el número de faltas justificadas de un alumno específico. Toman un parámetro `persona_` y ejecutan consultas SQL para calcular estas cifras.

### Métodos `BuscarPersona`

Estos métodos se utilizan para buscar personas en la base de datos según su nivel y un término de búsqueda. Pueden buscar personas por nombre, apellido o correo electrónico que coincidan con el término de búsqueda. Los resultados se almacenan en una lista de objetos `ClasePersonas`.

