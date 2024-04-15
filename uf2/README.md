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
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf2/images/ProcedimientosFunciones.png?raw=true" width= "95%" alt="procedimiento vs función">
</p>

<br>
<br>

## Partes de un subprograma

<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf2/images/PartesSubprograma.png?raw=true" width= "95%" alt="subprograma">
</p>

<br>
<br>

## Diseño descendente
  - El diseño descendente es una ténica que permite diseñar la solución de un problema con vase en la modularización segmentación, dándole un enfoque de arriba hacia abajo (top down).
  - Esta solución de divide en módulos que se estructuran e integran jerárquicamente.
  - Este diseño se vasa en el principio "divide y vencerás".

<p align="center">
  <img src="https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf2/images/DiseñoDescendente.png?raw=true" width= "95%" alt="diseño descendente">
</p>

<br>
<br>

## Ejemplo de programación modular

Vamos a realizar una calculadora utilizando varios módulos (suma, resta, etc)

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



[ver archivo](https://github.com/juancumbeq/daw-m03a-programming/blob/main/uf1/code/05_Break.cs)


















## UF3: 

Acceder a la siguiente UF: [enlace](https://github.com/juancumbeq/daw-m03a-programming/tree/main/uf3)


<br>
<br>

## Autor

Este proyecto fue desarrollado por Juan Cumbe. Si tienes alguna pregunta o sugerencia sobre el proyecto, no dudes en contactarme a través de [e-mail](mailto:hello@juancumbe.com) o mi perfil de [Linkedin](https://www.linkedin.com/in/juancumbeq/). 😊