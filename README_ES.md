<p align="right">
	<a href="README_ES.md">Haga clic aquí para versión en español</a>
</p>


# [M03A: Programación A](https://www.ilerna.es/es/ciclo-grado-superior-desarrollo-aplicaciones-web-72) 🚀


El objetivo general de este módulo consiste en aprender los fundamentos de la programación y las diferentes estructuras de control que están al alcance de los programadores tales como variables, bucles, condicionales o arrays. También nos centraremos en la estructuración y reutilización del código a través de la creación y el uso de métodos, y se tratará la persistencia a través del trabajo con ficheros.

La programación incluye aspectos tales como:
- Reconocer la estructura de un programa informático, identificando y relacionando los elementos propios del lenguaje de programación usado.
- Utilizar correctamente tipos de datos simples y compuestos utilizando las estructuras de control adecuadas.
- Escribe y prueba programas sencillos reconociendo y aplicando los fundamentos de la programación modular.
- Diseña, prueba y documenta programas que realizan diferentes operaciones sobre ficheros, documentando el programa y las pruebas realizadas.


En este módulo, de 3 Unidades Formativas, enseñaremos cómo empezar a programar, viendo la estructura de un bloque, uso de variables y tipos y los operadores del lenguaje de programación.

Veremos los dos tipos de programación: estructurada y modular, analizando las llamadas a funciones y métodos y recursividad. Trabajaremos con ficheros y haremos operaciones con ellos.

<br>

<p align="center">
  <img src="https://img.shields.io/badge/Project%20En-Progreso-yellow"/>
</p>

<br>

## Index

  - [UF1: Programación estructurada](#uf1)
  - [UF2: Diseño modular](#uf2)
  - [UF3: Fundamentos de gestión de ficheros](#uf3)

<br>


<a name="uf1"></a>

<hr>

## UF1: Programación estructurada

- Reconocer la estructura de un programa informático, identificando y relacionando los elementos propios del lenguaje de programación utilizado.
- Utilizar correctamente tipos de datos simples y compuestos utilizando las estructuras de control adecuadas.


### Variables en C#. Operaciones con variables.

Una variable es una estructura de datos que ocupa un espacio en memoria y puede variar a lo largo de un programa.

- Variables Globales: declaradas fuera de la función. Ámbito de existencia de todo el programa.
- Variables Locales: declaradas dentro de la función. Ámbito de exsitencia de la propia función pero no fuera de ella.

```
class Program
{
  GLOBALES
  const int num = 1;
  int numero2 = 8;

  static void Main(string[] args)
  {
    LOCALES
    int numero = 10;
    Double num2 = 3.4;
    char letra = 'a';
    string cadena = "Esto es una cadena";
  }
}
```

#### Variables numéricas
- int: entero con signo = 32 bits (-2K mill a 2K mill)
- long: entero con signo = 64 bits (-9K trill a 9K trill)
- short: entero con signo = 16 bits (-32K a 32K)
- float: punto flotante (decimales) = 4B (hasta 7 decimales)
- double: punto flotante (decimales) = 8B (hasta 14 decimales)
- long: decimal de alta precisión = 16B (hasta 29 decimales)

#### Operaciones
int suma = num1 + num2;
int resta =  num1 + num2;
int multiplicación = num1 * num2;
float division = num1 / num2;
int modulo = num1 % num2;


#### Casos Especiales
Incrementar en 1: num++;
Decrementar en 1: num--:
Operar y actualizar variable: 
num3 += 5;
num4 *=6;

#### Variables textuales
String: cadena de caracteres = tamaño ilimitado
char: un solo carácter = 1 Byte (1 carácter de texto)

#### Operaciones con String
- Length(): obtiene el número de caracteres del string correspondiente.
- Trim(): quita todos los caracteres de espacio en blanco del principio y el final de la cadena actual.
- Contains(): devuelve el valor que indica si una cadena especificada aparece dentro de otra cadena.
- Substring(): recupera una subcadena de la instancia.
- ToLower(): devuelve una copia de la cadena convertidda en minúsculas.
- ToUpper(): devuelve una copia de la cadena convertida en un mayúsculas.

#### Uso [ver archivo](www.github)

```
using System;

namespace dawm03a_programming
{
    class StringOperations
    {
        static void Main(string[] args)
        {
            String nombre = "Programación";
            Console.WriteLine(nombre.Trim());
            Console.WriteLine("La longitud es de " + nombre.Length);
            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombre.Substring(2, 4));
            if (nombre.Contains("ogra"))
            {
                Console.WriteLine("true");
            };
        }
    }
}

OUTPUT:
La longitud es de 12
PROGRAMACIÓN
ogra
true
```

#### Caracteres especiales
- Comilla simple: \'
- Comilla doble: \"
- Comilla nulo: \0
- Retroceso: \b
- Salto de página: \f
- Nueva línea: \n
- Retorno de carro: \r
- Tabulación horizontal: \t
- Tabulación vertical: \v

















### Métodos Básicos
Clase Console
- Write()
- WriteLine()
- ReadLine()
- Read()
- ReadKey()



### Instrucciones de control condicionales: IF/SWITCH.
### Instrucciones de control iterativas: WHILE/FOR.
### Solución al ejercicio opcional anterior.
### Propuesta de ejercicio opcional.






<br>

<a name="uf2"></a>

## UF2: Diseño modular

- Escribir y probar programas sencillos reconociendo y aplicando los fundamentos de la programación modular.


<br>

<a name="uf3"></a>

## UF3: Fundamentos de gestión de ficheros

- Diseña, prueba y documenta programas que realizan diferentes operaciones sobre ficheros, documentando el programa y las pruebas realizadas.

<br>



<a name="installation"></a>

## Installation

If you want to use this website as a template to create your own version, following the next steps:

- 🖥️ Open yor favorite terminal.
- 📂 Navigate to the folder where you want to clone this repository.
- 📋 Copy and paste the following text: ```git@github.com:juancumbeq/juancumbe-site.git <insert a name for the project folder>```.
- 📝 Open the project with your favorite IDE o text editor.
- 🛠️ Start building your own version! Enjoy it! 😊

<br>

<a name="technologies-used"></a>

## Technologies Used

This website represents the first versión of my portfolio. As such, I chose not to apply complex concepts or the most modern architectures. That's why this website was built using:
<p align="center">
  <img src="https://img.shields.io/badge/html5-%2523?style=for-the-badge&logo=html5&logoColor=black&color=E9ECEF" alt="html5" class='lang'>
  <img src="https://img.shields.io/badge/css3-%2523?style=for-the-badge&logo=css3&logoColor=black&color=E9ECEF" alt="css3" class='lang'>
  <img src="https://img.shields.io/badge/javascript-%2523?style=for-the-badge&logo=javascript&logoColor=black&color=E9ECEF" alt="javascript" class='lang'>
  <img src="https://img.shields.io/badge/bootstrap-%2523?style=for-the-badge&logo=bootstrap&logoColor=black&color=E9ECEF" alt="bootstrap" class='lang'>
</p>

<br>

<a name="file-structure"></a>


## File Structure 

Representation of the proyect's file structure:

```
juancumbe-site
├─ LICENSE
│
├─ assets
│  ├─ download
│  │  └─ JuanCumbe_CV_ENG_NoPhone.pdf
│  └─ img
│     ├─ favicon-132x132.png
│     ├─ favicon-40xx40.png
│     ├─ juancumbe.png
│     ├─ taskteam.png
│     └─ webinar-manager.png
│
├─ css
│  └─ styles.css
│
├─ js
│   └─ scripts.js
│
└─ index.html

```

<br>

<a name="screenshots"></a>

## Screenshots

<p align="center">
  <img src="https://github.com/juancumbeq/juancumbe-site/blob/main/assets/readme/juancumbe.png?raw=true" width= "90%" title="screenshot">
  <img src="https://github.com/juancumbeq/juancumbe-site/blob/main/assets/readme/aboutme.png?raw=true" width= "90%" title="screenshot">
</p>

<p align="center">
  <img src="https://github.com/juancumbeq/juancumbe-site/blob/main/assets/readme/portfolio.png?raw=true" width= "90%" title="screenshot">
  <img src="https://github.com/juancumbeq/juancumbe-site/blob/main/assets/readme/education.png?raw=true" width= "90%" title="screenshot">
</p>

<p align="center">
  <img src="https://github.com/juancumbeq/juancumbe-site/blob/main/assets/readme/skills.png?raw=true" width= "90%" title="screenshot">
  <img src="https://github.com/juancumbeq/juancumbe-site/blob/main/assets/readme/hitmeup.png?raw=true" width= "90%" title="screenshot">
</p>

<br>

<a name="license"></a>

## License

This project is licensed under the MIT License. For more details, see the [LICENSE](LICENSE) file.

<br>

<a name="author"></a>

## Author

This project was implemented by Juan Cumbe. If you have any questions or suggestions about the project, feel free to contact me via [e-mail](mailto:hello@juancumbe.com) or my [Linkedin](https://www.linkedin.com/in/juancumbeq/) profile. 😊











PACs:
- Introducción a la programación 
- Variables, literales y constantes
- Operadores y conversiones
- Diseño de algoritmos
- Tipos de datos simples y compuestos
- Estructuras de repetición y salto (I)
- Estructuras de repetición y salto (II)
- Depuración de errores


- Programación modular
- Diseño descendente
- Diseño de funciones
- Recursividad
- Librerías


- Ficheros
- Operaciones sobre ficheros