## UF1: PROGRAMACIÓN ESTRUCTURADA
<br>
<br>

# Index

  - [UF1: Programación estructurada](#uf1)
  - [UF2: Diseño modular](#uf2)
  - [UF3: Fundamentos de gestión de ficheros](#uf3)

<br>
<br>


## Objetivos

- Reconocer la estructura de un programa informático, identificando y relacionando los elementos propios del lenguaje de programación utilizado.
- Utilizar correctamente tipos de datos simples y compuestos utilizando las estructuras de control adecuadas.

<br>
<br>

## Variables en C#. Operaciones con variables.

Una variable es una estructura de datos que ocupa un espacio en memoria y puede variar a lo largo de un programa.

- **Variables Globales**: declaradas fuera de la función. Ámbito de existencia de todo el programa.
- **Variables Locales**: declaradas dentro de la función. Ámbito de exsitencia de la propia función pero no fuera de ella.

```
class Program
{
  // VARIABLES GLOBALES
  const int num = 1;
  int numero2 = 8;

  static void Main(string[] args)
  {
    // VARIABLES LOCALES
    int numero = 10;
    Double num2 = 3.4;
    char letra = 'a';
    string cadena = "Esto es una cadena";
  }
}
```

#### Declaración:
```
int i;
string cadena;
double num;
```

#### Asignación:
```
i = 0;
cadena = "Hola";
num = 8/3;
```

#### Declaración y asignación:
```
int i = 0;
string cadena = "Hola";
double num = 8/3;
```

<br>
<br>

## Variables numéricas

- **int**: entero con signo = **32 bits** (-2K mill a 2K mill)
- **long**: entero con signo = **64 bits** (-9K trill a 9K trill)
- **short**: entero con signo = **16 bits** (-32K a 32K)
- **float**: punto flotante (decimales) = **4B** (hasta 7 decimales)
- **double**: punto flotante (decimales) = **8B** (hasta 14 decimales)
- **long**: decimal de alta precisión = **16B** (hasta 29 decimales)

#### Tipos de operaciones:
```
int suma = num1 + num2;
int resta =  num1 + num2;
int multiplicación = num1 * num2;
float division = num1 / num2;
int modulo = num1 % num2;
```

#### Casos especiales:
```
Incrementar en 1: num++;
Decrementar en 1: num--:
Operar y actualizar variable: 
num3 += 5;
num4 *=6;
```

<br>
<br>

## Variables textuales

- **String**: cadena de caracteres = **tamaño ilimitado**
- **char**: un solo carácter = **1 Byte** (1 carácter de texto)

#### Operaciones con String:

- **Length**: obtiene el número de caracteres del string correspondiente. Es la única que en C# no lleva "( )".
- **Trim()**: quita todos los caracteres de espacio en blanco del principio y el final de la cadena actual.
- **Contains()**: devuelve el valor que indica si una cadena especificada aparece dentro de otra cadena.
- **Substring()**: recupera una subcadena de la instancia.
- **ToLower()**: devuelve una copia de la cadena convertidda en minúsculas.
- **ToUpper()**: devuelve una copia de la cadena convertida en un mayúsculas.

#### Uso:
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

// OUTPUT:
// La longitud es de 12
// PROGRAMACIÓN
// ogra
// true
```
[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/01_StringOperations.cs)

<br>

#### Caracteres especiales:
- Comilla simple: \'
- Comilla doble: \"
- Comilla nulo: \0
- Retroceso: \b
- Salto de página: \f
- Nueva línea: \n
- Retorno de carro: \r
- Tabulación horizontal: \t
- Tabulación vertical: \v

<br>
<br>

## Variables booleanas

#### Operadores de comparación:
- **'>'**: Mayor
- **'<'** Menor
- **'>='** Mayor o igual
- **'<='** Menor o igual
- **'=='** Igual
- **'!='** Desigualdad
- **'='** Asignación

#### Operadores booleanos:
- **& - AND lógico**. Evalúa ambos operandos.
- **&& - AND lógico**. Evalúa el operando derecho solo si es necesario.
- **| - OR lógico**. Evalúa ambos operandos.
- **|| - OR lógico**. Evalúa el operando derecho solo si es necesario.
- **^ - XOR lógico**.
- **! - Negación lógica**.

#### Funcionamiento:
**&& AND**
```
True - True = True
True - False = False
False - True = False
False - False = False
```
**|| OR**
```
True - True = True
True - False = True
False - True = True
False - False = False
```

**^ XOR**
```
True - True = False
True - False = True
False - True = True
False - False = False
```

<br>
<br>

## Conversión de variables en C#

 No se pueden realizar operaciones aritméticas con caracteres ni con cadenas de caracteres.

```
using System;

namespace daw_m03a_programming
{
    class Conversions1
    {
        static void Main(string[] args)
        {
            String num1 = "4";
            String num2 = "2";
            Console.WriteLine(num1 + num2);
        }
    }
}

// OUTPUT:
// 42
```
[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/02_Conversions1.cs)
```
using System;

namespace daw_m03a_programming
{
    class Conversions2
    {
        static void Main(string[] args)
        {
            String num1 = "4";
            int num2 = 2;
            Console.WriteLine(num1 + num2);
        }
    }
}


// OUTPUT:
// 42
```
[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/03_Conversions2.cs)

##### Conversiones implícitas

```
long b = a;
Console.WriteLine(b);
```
##### Conversiones explícitas
```
float b = 8/3;
Console.WriteLine((int)b);

int.Parse("100");
```

<br>
<br>

## Instrucciones de control condicionales: IF/SWITCH.

<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/If.png?raw=true" width= "19%" alt="if">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/If..else.png?raw=true" width= "22.5%" alt="if..else">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/If..else%20if..else.png?raw=true" width= "45.5%" alt="if..else if..else">
</p>


#### if
```
if(i < 2)
{
  Console.WriteLine(i);
}
```

#### if..else
```
if(i < 2)
{
  Console.WriteLine(i);
} else {
  i++;
}
```

#### if..else if..else
```
if(i < 2)
{
  Console.WriteLine(i);
} else if(i < 4 ){
  i++;
} else {
  i+=;
}
```

#### Switch
```
using System;

namespace daw_m03a_programming
{
    class Switch_Case
    {
        static void Main(string[] args)
        {
            int number = 1;
            
            switch(number)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                
                default:
                    Console.WriteLine("Deafult Case");
                    break;
            }
        }
    }
}

// OUTPUT
// Case 1
```
[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/04_Switch-Case.cs)

<br>
<br>

## Instrucciones de control iterativas: WHILE/FOR.

<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/While.png?raw=true" width= "33%" alt="if">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/Do..While.png?raw=true" width= "33%" alt="if..else">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/For.png?raw=true" width= "33%" alt="if..else if..else">
</p>


#### while
```
for (int i = 0; i < 3; i++)
{
  Console.WriteLine(i);
  // Las llaves se pueden omitir cuando solo hay una única instrucción.
}
```

#### do..while
```
int i = 0;
while (i < 3) {
  Console.WriteLine(i);
  i++;
}
```

#### for
```
int i = 0;
do {
  Console.WriteLine(i);
  i++;
} while (i < 3);
```


#### Instrucción de salto en bucles: Break

La instrucción break finaliza la ejecución del bucle más próximo.
El control se pasa al instrucción que hay a continuación de la instrucción finalizada, si existe.
También sirve dentro de condicionales.

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/05_Break.cs)


#### Instrucción de salto en bucles: Continue

La instrucción "continue" transfiere el control a la siguiente iteración de ls instrucción envolvente (while, for...)
También sirve dentro de condicionales.

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/06_Continue.cs)



### Diagrama de flujo

Un diagrama de flujo es una representación gráfica de los pasos lógicos y secuenciales que sigue un proceso o algoritmo. En programación, un diagrama de flujo es una herramienta visual utilizada para planificar, comprender y comunicar la lógica de un programa o algoritmo antes de comenzar a escribir el código.

En un diagrama de flujo, los pasos se representan mediante símbolos gráficos que están interconectados por flechas que indican la dirección del flujo de ejecución. Algunos de los símbolos más comunes en un diagrama de flujo son:

- Inicio/Fin: Representado por un óvalo, indica el punto de inicio o finalización del proceso.
- Proceso: Representado por un rectángulo, indica una acción o conjunto de acciones que se deben realizar.
- Decisión: Representado por un rombo, indica un punto en el flujo donde se toma una decisión basada en una condición.
- Conector: Representado por un círculo, se utiliza para conectar diferentes partes del diagrama de flujo.
- Entrada/Salida: Representado por un paralelogramo, indica la entrada o salida de datos del proceso.

El objetivo de un diagrama de flujo en programación es proporcionar una representación visual clara y concisa del algoritmo o proceso, lo que facilita su comprensión, análisis y depuración. Es una herramienta útil tanto para programadores que están diseñando un algoritmo como para aquellos que necesitan entender el funcionamiento de un código existente.

<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/DiagramaDeFlujo.png?raw=true" width= "50%" alt="if..else if..else">
</p>

<br>

### Pensamiento computacional

El pensamiento computacional es un enfoque para resolver problemas y diseñar sistemas que se basa en conceptos fundamentales de la informática. Implica descomponer problemas complejos en partes más simples, identificar patrones y abstracciones, y diseñar algoritmos eficientes para resolverlos.

En programación, el pensamiento computacional implica pensar de manera estructurada y lógica, dividiendo un problema en pasos lógicos y secuenciales que pueden ser traducidos a un código informático. Esto incluye habilidades como la identificación de patrones repetitivos, la creación de algoritmos para automatizar tareas y la capacidad de resolver problemas de manera eficiente utilizando recursos computacionales.

El pensamiento computacional no se limita solo a programadores; es una habilidad cognitiva fundamental que puede ser útil en una amplia variedad de campos, desde la resolución de problemas matemáticos hasta la toma de decisiones en negocios y ciencia. En resumen, el pensamiento computacional es una forma de pensar críticamente y resolver problemas utilizando los principios de la informática y la programación.

<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/PensamientoComputacional.png?raw=true" width= "50%" alt="if..else if..else">
</p>

<br>
<br>

## C#: Tratamientos de cadenas

#### Entrada

Las instrucciones de entrada son las que aportan datos a nuestro programa. A lo largo del módulo vamos a ver dos formar de hacerlo: mediante el teclado y mediante ficheros (UF3).

En cuanto a la entrada por teclado, utilizaremos el método **"Console.ReadLine()"**. Es un método sin parámetros (paréntesis vacíos) que devuelve lo que se introduzca por teclado. Puede guardarse en un variable, utilizarse como valor en un condicional, constituir el parámetro de otra función, etc.

Ejemplos de uso:
```
String entrada = Console.ReadLine();
if(Console.ReadLine() == "SI);
Console.WriteLine("Lo escrito es {0}", Console.ReadLine());
int divisor = int.Parse(Console.ReadLine())
```

Existen otras instrucciones de entrada por teclado: **"Console.ReadKey()"** lee una pulsación, mientras **"Console.Read()"** devuelve el código ASCII del primer carácter de la frase que se introduzca por teclado, aunque espera a la pulsación del ENTER para reaccionar. Ninguno de los dos métodos lo utilizaremos en el módulo.



#### Salida

Las instrucciones de salida son las que muestran datos desde nuestro programa. A lo largo del módulo vamos a ver dos formas de hacerlo: mediante la impresión por pantalla y mediante ficheros (UF3).

En cuanto a la salida por pantalla, utilizaremos los métodos **"Console.Write()"** y **"Console.WriteLine()"**. Son métodos que necesitan un parámetro para funcionar correctamente: el texto a mostrar. Este texto puede ser un literal, puede contenerse en una variable, ser el resultado de una operación matemática o lógica, o el resultado de la ejecución de otra función, etc.

Ejemplos de uso:
```
Console.WriteLine(entrada);
Console.WriteLine("SI");
Console.WriteLine("Lo escrito es {0}", Console.ReadLine());
Console.WriteLine("3 más 2 es {0}", 3+2);
```

La diferencia entre ambas es que **"Console.WriteLine()"** finaliza con un salto de línea (lo siguiente que se muestre se hará en una nueva línea) mientras que **"Console.Write()"** termina con el cursor en el siguiente carácter, es decir, no pasa la siguiente línea y lo siguiente que se muestra se hará a continuación.



















<br>

<a name="uf2"></a>

## UF2: Diseño modular

- Escribir y probar programas sencillos reconociendo y aplicando los fundamentos de la programación modular.


<br>

<a name="uf3"></a>

## UF3: Fundamentos de gestión de ficheros

- Diseña, prueba y documenta programas que realizan diferentes operaciones sobre ficheros, documentando el programa y las pruebas realizadas.

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