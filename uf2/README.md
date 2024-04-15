# UF1: PROGRAMACIÓN MODULAR

<p align="center">
  <img src="https://img.shields.io/badge/Proyecto%20-Finalizado-brightgreen"/>
</p>

<br>

## Index
  - [Obetivos](#objetivos)
  - [Variables en C#. Operaciones con variables.](#variables-en-c-operaciones-con-variables)
  - [Variables numéricas](#variables-numéricas)
  - [Variables textuales](#variables-textuales)
  - [Variables booleanas](#variables-booleanas)
  - [Conversión de variables en C#](#conversión-de-variables-en-c)
  - [Intrucciones de control condicional: IF / SWITCH](#instrucciones-de-control-condicional-ifswitch)
  - [Intrucciones de control iterativas: WHILE / FOR](#instrucciones-de-control-iterativas-whilefor)
  - [Diagrama de flujo](#diagrama-de-flujo)
  - [Pensamiento computacional](#pensamiento-computacional)
  - [C#: Tratamiento de cadenas](#c-tratamientos-de-cadenas)
  - [Extras videotutorías](#extras-videotutorías)
  - [Ejercicios voluntarios PT.1](#ejercicios-voluntarios-pt1)
  - [Tipos de datos simples](#tipos-de-datos-simples)
  - [Tipos de datos compuestos](#tipos-de-datos-compuestos)
  - [Matrices](#matrices)
  - [Ejercicios voluntarios PT.2](#ejercicios-voluntarios-pt2)
  - [PAC de desarrollo](#pac-de-desarrollo)
  - [Ejercicios voluntarios PT.3](#ejercicios-voluntarios-pt3)
  - [Depuración y debug](#depuración-y-debug)



<br>
<br>

## Objetivos

<br>
<br>

## Clases y objetos

#### ¿Qué es una clase?

  - Plantilla oara la creación de objetos de datos según un modelo predefinido
  - Se utilizan para representar entidades o conceptos, como los sustantivos en el lenguaje.
  - Cada clase tiene sus propias variables (llamadas **atributos**) que indican su estado.
  - Cada clase tiene sus propios **métodos** (funciones o procedimientos) para manipular esos atributos.
```
class Coche
{
  string marca;
  int velocidad;
  string color;

  public satic bool Marcha(){
    return(this.velocidad > 0);
  }
}
```

<br>

#### ¿Qué es un objeto?

  - Cada entidad basada en una clase y creada a partir de ella es un objeto.
  - Al proceso de crear objetos a partir de clases se le llama **instanciar**, y se dice que cada objeto es una **instancia** de la clase.
  - Todas las instancias de una clase tendrán los mismos atributos (pero con valores distintos) y funcionarán con los mismos métodos.
```
var focus = new Coche();
focus.marca = "Ford";
focus.velocidad = 120;

if(focus.Marcha() == true)
{
  Console.WriteLine("El coche de la marca {0} está en movimiento", focus.marca);
}
```

<br>
<br>

## Definición de programación modular
#### Concepto

- La programación modular consiste en dividir el problema original en diversos subproblemas, que se pueden resolver por separado, para, después, recomponer los resultados y obtener la solución al problema.
- Un subproblema se denomina módulo (función o procedimiento), y es una parte del problema que se puede resolver de manera independiente.

<br>

#### Ventajas

- Facilita el mantenimiento, de modificación y la documentación.
- Facilita las pruebas (**Testing**).
- Reutilización de módulos.
- Independencia de fallos.

<br>

#### Desventajas

- No se dispone de algoritmos formales de modularidad, por lo que a veces los programadores no tiene claras las ideas de los módulos -> experiencia

<br>
<br>

## Procedimientos VS Funciones
#### Procedimiento

Ámbito de la declaración tipo Función
```
Nombre_funcion(parámetros){
  // declaración de variables
  // instrucciones
  // retorno de tipo return
}
```
Cuando la función llega a su fin, retornará un valor del mismo tipo de la función con la directiva return.


<br>

#### Función
Ámbito de la declaración **void**
```
Nombre_procedimiento{
  // instrucciones
}
```
Un procedimiento no devueve un valor y por tanto **no incluye la directiva return**.


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

<br>

#### Asignación:
```
i = 0;
cadena = "Hola";
num = 8/3;
```

<br>

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

<br>

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

<br>

##### Conversiones implícitas

```
long b = a;
Console.WriteLine(b);
```

<br>

##### Conversiones explícitas
```
float b = 8/3;
Console.WriteLine((int)b);

int.Parse("100");
```

<br>
<br>

## Instrucciones de control condicional: IF/SWITCH.

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

<br>

#### while
```
for (int i = 0; i < 3; i++)
{
  Console.WriteLine(i);
  // Las llaves se pueden omitir cuando solo hay una única instrucción.
}
```

<br>

#### do..while
```
int i = 0;
while (i < 3) {
  Console.WriteLine(i);
  i++;
}
```

<br>

#### for
```
int i = 0;
do {
  Console.WriteLine(i);
  i++;
} while (i < 3);
```

<br>

#### Instrucción de salto en bucles: Break

La instrucción break finaliza la ejecución del bucle más próximo.
El control se pasa al instrucción que hay a continuación de la instrucción finalizada, si existe.
También sirve dentro de condicionales.

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/05_Break.cs)


<br>

#### Instrucción de salto en bucles: Continue

La instrucción "continue" transfiere el control a la siguiente iteración de ls instrucción envolvente (while, for...)
También sirve dentro de condicionales.

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/06_Continue.cs)

<br>
<br>

## Diagrama de flujo

Un diagrama de flujo es una representación gráfica de los pasos lógicos y secuenciales que sigue un proceso o algoritmo. En programación, un diagrama de flujo es una herramienta visual utilizada para planificar, comprender y comunicar la lógica de un programa o algoritmo antes de comenzar a escribir el código.

En un diagrama de flujo, los pasos se representan mediante símbolos gráficos que están interconectados por flechas que indican la dirección del flujo de ejecución. Algunos de los símbolos más comunes en un diagrama de flujo son:

- Inicio/Fin: Representado por un óvalo, indica el punto de inicio o finalización del proceso.
- Proceso: Representado por un rectángulo, indica una acción o conjunto de acciones que se deben realizar.
- Decisión: Representado por un rombo, indica un punto en el flujo donde se toma una decisión basada en una condición.
- Conector: Representado por un círculo, se utiliza para conectar diferentes partes del diagrama de flujo.
- Entrada/Salida: Representado por un paralelogramo, indica la entrada o salida de datos del proceso.

El objetivo de un diagrama de flujo en programación es proporcionar una representación visual clara y concisa del algoritmo o proceso, lo que facilita su comprensión, análisis y depuración. Es una herramienta útil tanto para programadores que están diseñando un algoritmo como para aquellos que necesitan entender el funcionamiento de un código existente.

<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/DiagramaDeFlujo.png?raw=true" width= "50%" alt="Diagrama de Flujo">
</p>

<br>

## Pensamiento computacional

El pensamiento computacional es un enfoque para resolver problemas y diseñar sistemas que se basa en conceptos fundamentales de la informática. Implica descomponer problemas complejos en partes más simples, identificar patrones y abstracciones, y diseñar algoritmos eficientes para resolverlos.

En programación, el pensamiento computacional implica pensar de manera estructurada y lógica, dividiendo un problema en pasos lógicos y secuenciales que pueden ser traducidos a un código informático. Esto incluye habilidades como la identificación de patrones repetitivos, la creación de algoritmos para automatizar tareas y la capacidad de resolver problemas de manera eficiente utilizando recursos computacionales.

El pensamiento computacional no se limita solo a programadores; es una habilidad cognitiva fundamental que puede ser útil en una amplia variedad de campos, desde la resolución de problemas matemáticos hasta la toma de decisiones en negocios y ciencia. En resumen, el pensamiento computacional es una forma de pensar críticamente y resolver problemas utilizando los principios de la informática y la programación.

<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/PensamientoComputacional.png?raw=true" width= "50%" alt="pesamiento computacional">
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

<br>

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
<br>

## Extras Videotutorías

#### Declaración e inicialización múltiple:

```
int num1 = 5, num2 = 8;
```

<br>

#### Main(string[] args):
Recoge argumentos de línea de comandos.

<br>

#### TryParse():
Devuelve tre o false en caso de que sea o no posible la transformación.

<br>

#### return VS break VS continue:

- return(num): devuelve el valor entre paréntesis. Siempre debe se accesible en una función.

- break: finaliza la ejecución del bucle.

- continue: finaliza la ejecución de la iteración y continúa con la siguiente del bucle.

<br>
<br>

## Ejercicios voluntarios PT.1
#### Ejemplo 1: ¿Cómo te llamas?

Crea un programa que muestre la pregunta "¿Cómo te llamas? Y a continuación espere a que el usuario teclee su nombre, guardando la entrada de teclado en una variable. Por último, debe mostrar el saludo !Hola, **nombre**!

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/07_Ejemplo1_EntradaDeTexto.cs)

<br>

#### Ejemplo 2: Operaciones con 2 números

Crea un programa que guarde dos números (los que tú quieras), y a continuación muestre por pantalla las cinco operaciones aritméticas: suma, resta, multiplicación, división y resto.

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/08_Ejemplo2_OperacionesCon2Numeros.cs)

<br>

#### Ejemplo 3: Operaciones con 2 números (II)

Sin borrar el ejercicio anterior, ahora los valores numéricos de las variables deben ser introducidos por el usuario. Debe pedirse por pantalla de forma: "Escribe el operando 1: " y espere a que el usuario introduzca un número, y "Escribe el operando 2: " y espere a que el usuario introduzca el segundo número.

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/09_Ejemplo3_OperacionesCon2Numeros.cs)

<br>

#### Ejemplo 4: Operaciones con 2 números (III)

Sin borrar el ejercicio anterior, ahora después de que el usuario introduzca los dos operandos, el programa debe preguntar al usuario qué operación quiere realizar. Dependiendo de lo que el usuario introduzca por teclado, el programa solo debe mostrar por pantalla la operación seleccionada.

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/10_Ejemplo4_OperacionesCon2Numeros.cs)

<br>

#### Ejemplo 5: Operaciones con 2 números (IV)

Sin borrar el ejercicio anterior, añade una posibilidad a las operaciones que sea finalizar. Cuando el usuario escribe finalizar, el programa terminará, pero si el usuario escribe cualquier otra operación, después de mostrar el resultado, el programa debe pedir de nuevo al usuario dos operandos y una operación.

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/11_Ejemplo5_OperacionesCon2Numeros.cs)


<br>
<br>

## Tipos de datos simples

En programación, los tipos de datos simples son tipos de datos que no se pueden dividir o descomponer en datos más pequeños.

Cumplen tres características:
- Son indivisibles
- Tiene existencia propia
- Permiten operaciones relacionales

Los tipos simples predefinidos son los tipos de datos numéricos (int, short, decimal, double, etc...), los tipos de datos textuales (char) y tipos de datos lógicos (bool). 

<br>

#### Enum
El tipo de dato enumerado (enum) es un tipo de dato ambiguo. Se considera simple, pero algunos lo definen como compuesto. Está definido por el usuario, es decir, no está predefinido por el sistema.
```
enum DiasSemana {lunes, martes, miercoles, jueves, viernes, sabado, domingo};
enum Jugadores {RuiSilva = 13, LuisFelipe = 19, Edgar = 3};
```
Es un conjunto de constantes que se debe crear al ser declarado. Para definir un tipo de enumeración, utilizamos la palabra clave **enum** y especificamos los nombres de componentes de la enumeración. Las constantes son de tipo **int** por defecto, pero se puede especificar otro tipo de dato para ellas:
```
enum Respuestas: short {no, si, tal_vez};
```


<br>
<br>

## Tipos de datos compuestos

En programación, los tipos de datos compuestos son tipos de datos que se crean mediante la unión de varios tipos (simples o compuestos).

Se llaman tradicionalmente **arrays**, y pueden tener varias dimensiones:
- Vectores: arrays unidimensionales, es decir, de una dimensión.
- Multidimensionales
  - Matrices: arrays bidimensionales, es decir, de dos dimensiones.
  - Arrays de tres o más dimensiones.

En C# la longitud de los arrays y matrices es inmutable. No pueden crecer más allá del tamaño especificado en la declaración del mismo.

<br>
<br>

## Vectores

Se trata de una lista de variables con el mismo nombre pero distinto índice. El índice hace referencia a su posición en la lista o array, siempre empezando por 0.
```
int[] v = new int[10]; // El vector se llena de ceros
char[] ac = new char[]{'a', 'b', 'c', 'd', 'e'};
int[] impares = {1, 3, 5, 7, 9, 11, 13, 15, 17, 19};
```

El primer valor guardado en la lista tiene índice 0, y se incrementa de 1 en 1:
```
Console.WriteLine(impares[5]); // Mostrará el 6º valor, 11 
```
Al ser variables, pueden cambiar su valor (no como el tipo de datos enum)
```
impares[5] = 21; // Ahora el vector es {1, 3, 5, 7, 9, 21, 13, 15, 17, 19}
```

La declaración de un array es:
```
<tipo>[] <nombre> = new <tipo>[<tamaño>];
```

<br>

#### Tipo de dato String como un Vector

Los tipos de datos String son en esencia un array de caracteres (char), es por ello que podemos ejecutar los siguientes métodos:
```
static void Main(string[] args)
{
  String nombre = "Ilerna";

  Console.WriteLine(nombre.Length);
  Console.WriteLine(nombre.Trim());
  Console.WriteLine(nombre.Contains("a"));
  Console.WriteLine(nombre.Substring(2));
  Console.WriteLine(nombre[4]); // Usamos un índice para acceder al caracter indicado.
  Console.WriteLine(nombre.ToUpper());
}
```

<br>

#### Recorrer un Vector: Bucles For y Foreach
```
int[] numPrimos = new int[5] {1, 2, 3, 5, 7};
for(int i = 0; i < 5; i++)
{
  Console.WriteLine("El siguiente número primo es {0}", numPrimos[i]);
}
```
```
int[] numPrimos = new int[5] {1, 2, 3, 5, 7};
foreach(int primo in numPrimos)
{
  Console.WriteLine("El siguiente número primo es {0}", primo);
}
```
<br>
<br>

## Matrices

Se trata de un tabla de variables con el mismo nombre pero con distinta posición de fila y columna. Esa relación fila-columna indica su posición en la tabla, y ambas empienzan siempre por 0.
```
bool[,] matriz = new bool[2,3];
int[,] array2D = new int[,] {{1, 2}, {3, 4}, {5, 6}, {7, 8}};
int[,] miMatriz = new int[4,2] {{1, 2}, {3, 4}, {5, 6}, {7, 8}};
```
El primer valor guardado en la tabla se ubica en la fila 0, columna 0.
```
Console.WriteLine(array2D[1,0]); // Mostrará el valor de la 2ª fila, 1ª columna, 3.
```
Al ser variables, pueden cambiar su valor.
```
miMatriz[1,1] = 21; // Ahora la matriz es {{1, 2}, {3, 21}, {5, 6}, {7, 8}}.
```
La declaración de una matriz es:
```
<tipo>[,] <nombre> = new <tipo>[<fila>, <columnas>];
```
Representación gráfica de matrices:
<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/Matrices.png?raw=true" width= "100%" alt="matrices">
</p>

<br>

#### Recorrer una Matriz: Bucles For
```
int[,] tabla = new int[3,3] {{1, 3, 4}, {8, 5, 0}, {5, 99, 18}};
for(int i = 0; i < 3; i++)
{
  for(int j = 0; j < 3; j++)
  {
    Console.Write(tabla[i,j] + "\t");
  }
  Console.Write("\n");
}
```

<br>
<br>

## Ejercicios voluntarios PT.2
#### Ejercicio voluntario 1:

Desarrolla un algoritmo que permita determinar a partir de un númera de días ingresado por pantalla (teclado), cuántos años, meses, semanas, y días son. Supón que todos los meses son de 30 días.
```
using System;

namespace daw_m03a_programming
{
    class ExVoluntario1
    {
        static void Main(string[] args)
        {
            int years;
            int months;
            int weeks;
            int days;
            
            Console.Write("Introduce un número de días: ");
            int num = int.Parse(Console.ReadLine());
            
            years = num / 365;
            months = (num % 365) / 30;
            weeks = ((num % 365) % 30) / 7;
            days = (((num % 365) % 30) % 7);
            
            if (years > 0)
            {
                Console.WriteLine($"AÑOS: {years}");
            }
            if(months > 0)
            {
                Console.WriteLine($"MESES: {months}");
            }
            if(weeks > 0)
            {
                Console.WriteLine($"SEMANAS: {weeks}");
            }
            if (days > 0){
                Console.WriteLine($"DIAS: {days}");
            }
        }
    }
}

// OUTPUT
// Introduce un número de días: 391
// AÑOS: 1
// SEMANAS: 3
// DIAS: 5
```
[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/12_EjercicioVoluntario1.cs)

<br>

#### Ejercicio voluntario 2:

Escribe un programa que declare un vector de números enteros tamaño 10, que pida los valores por teclado y que cuente los números pares que tiene.
```
// Escribe un programa que declare un vector de números enteros tamaño 10, que pida los valores por teclado y que cuente los números pares que tiene.

using System;

namespace daw_m03a_programming
{
    class ExVoluntario2
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Introduzca un número: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Los números pares del array son: ");

            for (int j = 0; j < vector.Length; j++)
            {

                if ((vector[j] % 2 == 0))
                {
                    Console.Write($" {vector[j]} ");
                }
            }
        }
    }
}


// OUTPUT
// Introduzca un número: 2
// Introduzca un número: 3
// Introduzca un número: 4
// Introduzca un número: 5
// Introduzca un número: 6
// Introduzca un número: 7
// Introduzca un número: 8
// Introduzca un número: 9
// Introduzca un número: 10
// Los números pares del array son:  2  4  6  8  10
```
[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/13_EjercicioVoluntario2.cs)

<br>
<br>

## PAC de desarrollo

El programa consiste en trabajar con una variable que contendrá una frase que se leerá por teclado.

Se pide:
- Imprimir por consola la variable en **minúsculas sin espacios**.
- Imprimir por consola el total de consonantes de la variable.
- Imprimir por consola la suma de todas las cifras numéricas que tiene la frase (cada cifra por separado)
- Imprimir por consola solo las consonantes, en mayúsculas, y en el orden que las va encontrando en la misma línea. 

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/Pac_Desarrollo.cs)

<br>
<br>

## Ejercicios voluntarios PT.3
#### Ejercicio en vivo 1:

Realiza un programa que permite ingresar los nombres de 5 empleados y sus sueldos respectivos. El programa debe mostrar el sueldo mayor y el nombre del empleado al que pertenece.

A tener en cuenta:
 - Los sueldos son de tipo double.
 - Los nombres deben ser de tipo String.
 - Ninguno puede tener sueldo 0.


[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/14_EjercicioEnVivo1.cs)

<br>

#### Ejercicio en vivo 2:
Realiza un programa que rellene aleatoriamente un matriz de 2x3 (2 filas y 3 columnas). El programa debe mostrarla en forma de tabla después de que se haya rellenado.

A tener en cuenta:
 - Los números deben ser de tipo int.
 - Tendrás que utilizar la clase Random.

Funcionalidad extra: muestra junto a cada fila y columna el resultado de la suma de todos los números que la componen.

[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/15_EjercicioEnVivo2.cs)

<br>
<br>

## Depuración y debug
#### Ejecución paso a paso

Con F11 podemos iniciar la ejecución del programa pero esta se detendrá en cada una de las instrucciones. Será necesario seguir pulsando F11.

<br>

#### Iniciar sin depuración

Mediante CMD + F5 podemos iniciar la ejecución de nuestro programa sin pasar por la depuración.

<br>

#### Iniciar con depuración

Para ello es necesario tener marcado al menos un break point en el margen lateral izquierdo del editor. Se inicia con F5

<br>
<br>

## UF2: PROGRAMACIÓN MODULAR

Acceder a la siguiente UF: [enlace](https://github.com/juancumbeq/daw-m03a-programming/tree/main/uf2)


<br>
<br>

## Autor

Este proyecto fue desarrollado por Juan Cumbe. Si tienes alguna pregunta o sugerencia sobre el proyecto, no dudes en contactarme a través de [e-mail](mailto:hello@juancumbe.com) o mi perfil de [Linkedin](https://www.linkedin.com/in/juancumbeq/). 😊