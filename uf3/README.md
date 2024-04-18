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

## Ficheros de binarios: uso del Buffer - LECTURA
```
// Lectura binaria

FileStream fichero = new FileStream("C:/fichero/pelota.jpg", FileMode.Open, FileAccess.Read);

byte[] buffer = new byte[fichero.Length] // un entero de 8 bits sin signo
fichero.Read(buffer, 0, buffer.Length);

for(int i = 0; i < buffer.Length; i++)
{
  Console.WriteLine(buffer[i])
}
fichero.Close();
```

Este código en C# está diseñado para abrir un archivo de imagen (en este caso, "pelota.jpg") ubicado en la ruta **"C:/fichero/"** y luego imprimir el contenido del archivo en la consola en forma de bytes.

Aquí está el desglose del código:

1. Se crea un objeto FileStream llamado fichero que apunta al archivo "pelota.jpg" utilizando la ruta especificada. Se abre en modo de lectura (FileMode.Open) y se establece el acceso para lectura (FileAccess.Read). 

```
FileStream fichero = new FileStream("C:/fichero/pelota.jpg", FileMode.Open, FileAccess.Read);
```

2. Se crea un array de bytes llamado buffer que tiene el mismo tamaño que el archivo. Esto asegura que haya suficiente espacio para almacenar todo el contenido del archivo.
```
byte[] buffer = new byte[fichero.Length];
```

3. Se lee el contenido del archivo en el array de bytes utilizando el método Read del objeto FileStream. Los parámetros buffer, 0 y buffer.Length indican que se debe leer desde el principio del array de bytes (buffer), comenzando desde el primer byte (0), y se debe leer hasta el final del array (buffer.Length).
```
fichero.Read(buffer, 0, buffer.Length);
```

4. Se recorre el array de bytes utilizando un bucle for para imprimir cada byte en la consola. Esto imprime el valor numérico de cada byte en una línea separada. 
```
for(int i = 0; i < buffer.Length; i++)
{
  Console.WriteLine(buffer[i]);
}
```

5. Se cierra el objeto FileStream para liberar los recursos del sistema asociados con él.
```
fichero.Close();
```

En resumen, este código lee un archivo de imagen byte por byte y luego imprime el valor numérico de cada byte en la consola. Esto puede ser útil para visualizar cómo está estructurado un archivo binario, como una imagen, en términos de sus bytes individuales.

<br>

#### fichero.Read(buffer, 0, buffer.Length); 
La línea **fichero.Read(buffer, 0, buffer.Length);** es una llamada al método **Read** del objeto FileStream. Este método se utiliza para leer bytes desde el archivo asociado al FileStream y almacenarlos en un array de bytes, que en este caso es buffer.

Aquí está el desglose de los parámetros utilizados en esta llamada:

  - **buffer**: Este es el array de bytes en el que se almacenarán los datos leídos del archivo.
  - **0**: Este es el índice en el array buffer donde comenzará a almacenarse la lectura. En este caso, se especifica 0, lo que significa que la lectura comenzará desde el primer byte del array.
  - **buffer.Length**: Este es el número máximo de bytes que se leerán del archivo. buffer.Length especifica que se leerán tantos bytes como sea posible hasta llenar completamente el array buffer.
Entonces, la línea fichero.Read(buffer, 0, buffer.Length); básicamente dice: "Lee tantos bytes como sea posible del archivo asociado a fichero y almacénalos en el array buffer, comenzando desde el primer byte del array".

Después de esta línea, el array buffer contendrá los bytes del archivo "pelota.jpg", listos para ser procesados o manipulados según sea necesario.


## Ficheros de binarios: uso del Buffer - ESCRITURA
```
// Escritura binaria
FileStream fichero = new FileStream("C:/fichero/pelota.jpg", FileMode.Create, FileAccess.Write);

byte[] buffer = new byte[fichero.Length] // un entero de 8 bits sin signo
fichero.Write(buffer, 0, buffer.Length);

for(int i = 1000; i < 2000; i++)
{
  buffer[i] = 0;
}

FileStream fichero2 = new FileStream("C:/fichero/pelota.jpg", FileMode.Create, FileAccess.Write);
fichero2.Write(buffer, 0, buffer.Length);

fichero.Close();
fichero2.Close();
```

<br>
<br>

## Manejo de ficheros
  - Todo lo que llevamos visto hasta aquí ha sido mediante variables, estructuras de datos, y hemos manipulado la información de la que disponíamos.
  - Esta información, una vez que finaliza la ejecución del software, desaparece de memoria, ya que ha estado 
















<br>
<br>

## UF3: FUNDAMENTOS DE GESTIÓN DE FICHEROS
Acceder a la siguiente UF: [enlace](https://github.com/juancumbeq/daw-m03a-programming/tree/main/uf3)

<br>
<br>

## Autor

Este proyecto fue desarrollado por Juan Cumbe. Si tienes alguna pregunta o sugerencia sobre el proyecto, no dudes en contactarme a través de [e-mail](mailto:hello@juancumbe.com) o mi perfil de [Linkedin](https://www.linkedin.com/in/juancumbeq/). 😊