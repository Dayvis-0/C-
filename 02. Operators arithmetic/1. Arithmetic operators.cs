using System;
/* Operador de incremento ++
El operador de incremento unario ++ incremente su operando en 1. El operando debe ser
una variable, un acceso a una propiedad o un acceso a un indexador.*/

/* Operador de incremento postfijo
El resultado de x++ es el valor de x antes de la operación:*/

int i = 3;

Console.WriteLine("i -> " + i);
Console.WriteLine("i++ -> " + i++);
Console.WriteLine("i -> " + i);

/* Operador de incremento prefijo
El resultado de ++x es el valor de x despues de la operación:*/

double a = 1.5;

Console.WriteLine("\na -> "+ a);
Console.WriteLine("++a -> "+ ++a);
Console.WriteLine("a -> "+ a);

/* Operador de decremento --
El operador de decremento unario -- decrementa su operando en 1. El operando
debe ser una variable, un acceso a una propiedad o un acceso a un indexador.*/

/* Operador de decremento postfijo
El resultado de y-- is el valor de y antes de la operación: */

int y = 1;

Console.WriteLine("\ny -> " + i);
Console.WriteLine("y-- -> " + i--);
Console.WriteLine("y -> " + i);

/* Operador de decremento prefijo
El resultado de --y is el valor de y despues de la operacion:*/

double b = 1.5;

Console.WriteLine("\nb -> " + b);
Console.WriteLine("b-- -> " + --b);
Console.WriteLine("b -> " + b);

/*Operadores unarios de suma y resta
El operador unario + devuelve el valor de su operando. El operador unario
- calcula la negación numérica de su operando.*/

Console.WriteLine("\n" + (+4));
Console.WriteLine(-4);
Console.WriteLine(-(-4));

uint c = 5;
var d = -c;

Console.WriteLine(d);
Console.WriteLine(d.GetType());

Console.WriteLine(-double.NaN);

/* Operador de multiplicación *
El operador de multiplicación * calcula el producto de sus operandos:*/

Console.WriteLine("\n(5 * 2) -> " + (5 * 2));
Console.WriteLine("(0.5 * 2.5) -> " + 0.5 * 2.5);
Console.WriteLine("(0.1m * 23.4m) -> " + 0.1m * 23.4m);

/* Operador de división / 
El operador de division / divide su operando izquierdo entre su operando
derecho.*/

/* Division entera
Para los operandos de tipo entero, el resultado del operador / es de tipo
entero y es igual al cociente de los dos operandos redondeado hacia cero:*/

Console.WriteLine("\n(13 / 5) -> " + (13 / 5));
Console.WriteLine("(-13 / 5) -> " + (-13 / 5));
Console.WriteLine("(13 / -5) -> " + (13 / -5));
Console.WriteLine("(-13 / -5) -> " + (-13 / -5));

// Para obtener el cociente de los dos operandos como número de punto 
// flotante, utilice el tipo float, double o decimal

Console.WriteLine("\n(13 / 5.0) -> " + (13 / 5.0));

int e = 13;
int f = 5;

Console.WriteLine((double)e / f);

/* Division de punto flotante
Para los tipos float, double y decimal, el operador / devuelve el cociente
de los operandos:*/

Console.WriteLine("\n(16f / 4.1f) -> " + (16f / 4.1f));
Console.WriteLine("(16.8d / 4.1d) -> " + (16.8d / 4.1d));
Console.WriteLine("(16.8m / 4.1m) -> " + (16.8m / 4.1m));

/* Operador de resto %
El operador de resto % calcula el resto despues de dividir su operando 
izquierdo entre su operando derecho.*/

/* Resto entero
Para operandos de tipo entero, el resultado de a % b es el valor 
producido por a - a / b * b. El signo del resto distinto de cero
coincide con el signo del operando izquierdo: */

Console.WriteLine("\n(5 % 4) -> " + (5 % 4));  
Console.WriteLine("(5 % -4) -> " + (5 % -4)); 
Console.WriteLine("(-5 % 4) -> " + (-5 % 4)); 
Console.WriteLine("(-5 % -4) -> " + (-5 % -4));

/* Resto de punto flotante
Para los operandos float y double, el resultado de x % y para los 
valores finitos de x e y es el valor z tal que:
- El signo de z, si es distinto de cero, coincide con el signo de x.
- El valor absoluto de z se obtiene del cálculo |x| - n x |y|, donde 
n es el mayor entero menor o igual que |x/y| . Aquí, |x| e |y| representan 
los valores absolutos de x e y, respectivamente.*/

Console.WriteLine("\n" + (-5.2f % 2.0f));
Console.WriteLine(5.9 % 3.1);   
Console.WriteLine(5.9m % 3.1m); 

/* Operador de suma +
El operador de suma + calcula la suma de sus operandos:*/

Console.WriteLine("\n" + (5 + 4));       
Console.WriteLine(5 + 4.3);     
Console.WriteLine(5.1m + 4.2m); 

/* Operador de resta -
El operador de resta - resta el operando de la derecha del operando de 
la izquierda.*/

Console.WriteLine("\n" + (47 - 3));      // output: 44
Console.WriteLine(5 - 4.3);     // output: 0.7
Console.WriteLine(7.5m - 2.3m); // output: 5.2

/* Asignacion compuesta*/
int a1 = 5;
a1 += 9;
Console.WriteLine("\n" + a1);  

a1 -= 4;
Console.WriteLine(a1);  

a1 *= 2;
Console.WriteLine(a1);  

a1 /= 4;
Console.WriteLine(a1);  

a1 %= 3;
Console.WriteLine(a1);  

/* Precedencia y asociatividad de los operadores
- Operadores (primarios): operadores de incremento posfijo x++ y decremento x--. 
- Operadores (unarios): operadores de incremento prefijo ++x y 
decremento --x, y operadores unarios + y -. 
- Operadores (multiplicativos): operadores *, / y %. 
- Operadores (aditivos): operadores binarios + y -.

Utilice paréntesis, (), para cambiar el orden de evaluación impuesto 
por la precedencia y la asociatividad de los operadores.*/