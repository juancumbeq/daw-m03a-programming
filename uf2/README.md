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
#### Función

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

#### Procedimiento
Ámbito de la declaración **void**
```
Nombre_procedimiento{
  // instrucciones
}
```
Un procedimiento no devueve un valor y por tanto **no incluye la directiva return**.

Ejemplo:
```
using System;

namespace daw_m03a_programming
{
    class Ejercicio
    {

        // Procedimiento
        static void muestraPrompt()
        {
            Console.Write("Introduce un número: ");
        }

        // Función
        static int leerNumero()
        {
            int num = 0;
            num = int.Parse(Console.ReadLine());
            return num;
        }

        static void Main(string[] args)
        {
            int suma = 0;

            Console.WriteLine("Vamos a empezar: ");
            for (int i = 0; i < 3; i++)
            {
                muestraPrompt();
                suma = suma + leerNumero();
            }
            Console.WriteLine("La suma es {0}", suma);
        }
    }
}


// OUTPUT
// Vamos a empezar:
// Introduce un número: 1
// Introduce un número: 2
// Introduce un número: 3
// La suma es 6
```
<br>

#### Diferencias entre funciones y procedimiento
<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf2/images/ProcedimientosFunciones.png?raw=true" width= "90%" alt="procedimientovs función">
</p>


<br>
<br>















[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/01_StringOperations.cs)


<br>
<br>



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



<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/DiagramaDeFlujo.png?raw=true" width= "50%" alt="Diagrama de Flujo">
</p>

<br>


<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/PensamientoComputacional.png?raw=true" width= "50%" alt="pesamiento computacional">
</p>

<br>
<br>



<br>
<br>


<br>
<br>




<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/images/Matrices.png?raw=true" width= "100%" alt="matrices">
</p>

<br>



<br>
<br>

## UF3: 

Acceder a la siguiente UF: [enlace](https://github.com/juancumbeq/daw-m03a-programming/tree/main/uf3)


<br>
<br>

## Autor

Este proyecto fue desarrollado por Juan Cumbe. Si tienes alguna pregunta o sugerencia sobre el proyecto, no dudes en contactarme a través de [e-mail](mailto:hello@juancumbe.com) o mi perfil de [Linkedin](https://www.linkedin.com/in/juancumbeq/). 😊