# UF3: FUNDAMENTOS DE GESTIÓN DE FICHEROS

<p align="center">
  <img src="https://img.shields.io/badge/Proyecto%20-Finalizado-brightgreen"/>
</p>

<br>

## Index
  - [Clases y objetos](#clases-y-objetos)

<br>
<br>

## Librerías: System.io - Clases

  - **File**: Proporciona métodos estáticos para crear, copiar, eliminar, mover, abrir un solo archivo. **Contribuye a la creación de objetos FileStream.** Métodos estáticos se refiere a que símplemente con llamar a la clase podemos ejecutar el método, sin necesidad de instanciar ningún objeto.
  - **FileStream**: Proporciona un stream para un archivo, lo que **permite operaciones de lectura y escritura síncrona y asíncrona.**
  - **StreamReader**: Es una clase que el programa va a usar para guardar la información de un **fichero que se abre por extracción de datos** (Lectura, Read). Lectura de datos en archivo secuencial (habrá un error si el archivo no existe).
  - **StreamWriter**: Es una clase que el programa va a usar para guardar la información de un **fichero que se abre para escritura** (Write, escribir).

<br>
<br>

## FileStream

  - La clase FileStream proporciona un Stream (flujo) para un archivo, lo que permite operaciones de lectura y escritura.
  - El modo en el que vamos a abrir el fichero (FileMode)
    - **Open**: Abre un fichero existente. Si el fichero no existe, lanzará un error.
    - **Append**: Abre un fichero para añadir datos al final del mismo si existe, o crea un fichero nuevo si no existe.
    - **Create**: Crea un nuevo fichero. Si el fichero existe será sobrescrito.
    - **Delete**: Borra un fichero (no se especifica FileAccess).
  - El modo en el que accedemos al fichero (FileAccess):
    - **Read**: Acceso para leer el archivo.
    - **Write**: Acceso de escritura al archivo.
    - **ReadWrite**: acceso de lectura y escritura al archivo.
  - Ejemplo: ```FileStream ficheroOrigen = new FileStream("fondo.jpg", FileMode.Open, FileAccess.Read);```



<br>
<br>

## Stream vs Buffer

  - La diferencia en pocas palabras entre un búffer y una Stream es que una Stream es una secuencia que transfiere información desde o hacia una fuente específica, mientras que un búfer es una secuencia de bytes que se almacena en la memoria. Ejemplo de Stream: ```FileStream stream = new FileStream("filepath.txt", FileMode.OpenOrCreate);```

  - Ejemplo de Búfer: ```byte[] fileContents = File.ReadAllBytes("filepath.txt")```. Lee todos los bytes de un archivo en la memoria. Esto es útil para cuando necesita manipular todo el archivo a la vez, o mantener una "copia local" para que su programa la guarde para que el archivo pueda estar libre para otros usos. Sin embargo, dependiendo del tamaño de la fuente y la cantidad de memoria disponible, un búfer que contiene el archivo completo podría no ser una opción.

<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf2/images/FileStream.png?raw=true" width= "99%" alt="filestream">
</p>

<br>
<br>

## Ejercicio opcional PT.1
  - Importar la librería System.IO
  - Crear método 1: preguntar al usuario si quiere añadir algún alumno al fichero alumnos.txt o leer el fichero.
  - Crear método 2: si el usuario decide leer el fichero, muestra el contenido de alumnos.txt.
  - Crear método 3: si el usuario decide añadir algún alumno, preguntar su nombre y añadirlo a alumnos.txt.
  - En el método MAIN(): ejecutar los método anteriores.

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf3/code/01_EjercicioOpcionalPT1.cs)











<br>
<br>

## Ejemplo de programación modular

Vamos a realizar una calculadora utilizando varios módulos (suma, resta, etc).

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/01_EjemploProgramacionModular.cs)

<br>
<br>

## Paso por valor y paso por referencia

<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf2/images/PasosValorReferencia.png?raw=true" width= "100%" alt="pasos de variables">
</p>

#### Por valor
Cuando ejecutamos una función que tiene parámetros pasados por vaor, se realiza una copia del parámetro que se ha pasado, es decir, que todas las modificaciones y/o cambios que se realicen se están haciendo en esta copia que se ha creado. El original no se modifica, de manera que no se altera su valor en la función.

<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf2/images/PasoPorValor.png?raw=true" width= "85%" alt="paso por valor">
</p>

<br>

#### Paso por referencia
Sin embargo, cuando ejecutamos una función que tiene parámetros pasados por referencia, todas aquellas modificaciones que se realicen en la función van a afectar a sus parámetros, ya que se trabaja con los originales.

<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf2/images/PasoPorReferencia.png?raw=true" width= "100%" alt="paso por referencia">
</p>

<br>
<br>

## Diferencias entre Arrays y Variables
La página web de Microsoft dice que el paso de vectores por valor se hace mediante la palabra **params**, pero eso no impide que se pueda modificar su valor. Por lo tanto, el hecho de llamar a una función con la palabra **params** o sin ella, es funcionalmente idéntico.

En cuanto a las variable individuales:
  - El paso por valor no necesita ningún tipo de palabra clave.
  - El paso por referencia necesita de una palabra clave, que puede ser:
    - **ref** (como hemos visto) o también **out** (da igual, funciona igual) con la intención de modificar el valor de la variable original.
    - **in** para pasar la variable por referencia, pero protegida en modo solo lectura (si se intenta modificar, el compilador arrojará un error).

Ejemplos:

<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf2/images/EjemplosValorReferencia.png?raw=true" width= "95%" alt="ejemplos">
</p>

<br>
<br>

## Ejercicio opcional PT.1
Escribir un programa con los siguiente módulos:

  - Subprograma para generar números aleatorios entre 0 y 50 ambos inclusive y guardarlos en un vector de tamaño 10 creado en el MAIN.
  - Subprograma para imprimir el vector resultante.


[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/02_EjercicioOpcionalPT1.cs)

<br>
<br>

## Ejemplo de recursividad
  - Calcular el factorial de un número usando un método no recursivo y recursivo.
  - Fórmula para calcular el factorial de un número: (n! = n * (n - 1)!)

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/03_EjemploRecursividad.cs)

<br>
<br>

## UF3: FUNDAMENTOS DE GESTIÓN DE FICHEROS
Acceder a la siguiente UF: [enlace](https://github.com/juancumbeq/daw-m03a-programming/tree/main/uf3)

<br>
<br>

## Autor

Este proyecto fue desarrollado por Juan Cumbe. Si tienes alguna pregunta o sugerencia sobre el proyecto, no dudes en contactarme a través de [e-mail](mailto:hello@juancumbe.com) o mi perfil de [Linkedin](https://www.linkedin.com/in/juancumbeq/). 😊