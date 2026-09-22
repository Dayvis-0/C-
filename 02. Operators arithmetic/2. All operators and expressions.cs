// Aqui hay tipos de expresiones que proporciona C#

/* Expresiones de cadena interpoladas que proporcionan una sintaxis conveniente para
crear cadenas formateadas: */

var r = 2.3;
var message = $"The area of a circle with radius {r} is {Math.PI * r * r:F3}.";

Console.WriteLine(message);

/* Expresiones lambda que permiten crear funciones anónimas: */
int[]numbers = { 2, 3, 4, 5};
var maximumSquare = numbers.Max(x => x * x);

Console.WriteLine(maximumSquare);

/* Expresiones de consulta que permiten utilizar las funcionalidades de consulta
directamente en C#:*/
int[] scores = { 90, 97, 78, 68, 85};
IEnumerable<int> highScoreQuery = 
    from score in scores 
    where score > 80 
    orderby score descending
    select score;
Console.WriteLine(string.Join(" ", highScoreQuery));

/* Operador de precedencia 
En una expresión con múltiples operadores, los operadores con mayor precedencia se 
evalúan antes que los de menor precedencia. Los operadores de la misma precedencia 
se evalúan en orden léxico.*/
var a = 2 + 2 * 2;
Console.WriteLine("\n" + a); 

// Utilice paréntesis para cambiar el orden de evaluación impuesto por la 
// precedencia de operadores:
var a = (2 + 2) * 2;
Console.WriteLine(a); 

/* Asociatividad de operadores
Cuando los operadores tienen la misma precedencia, la asociatividad de los operadores
determina el orden en que se realizan las operaciones:

- Los operadores asociativos por la izquierda se evalúan en orden de izquierda 
a derecha. Excepto los operadores de asignación y los operadores de fusión de 
nulos, todos los operadores binarios son asociativos por la izquierda.
Por ejemplo, a + b - c se evalúa como (a + b) - c.

- Los operadores asociativos derechos se evalúan de derecha a izquierda. Los 
operadores de asignación, los operadores de fusión de nulos, las lambdas y el 
operador condicional ?: son asociativos derechos. 
Por ejemplo, x = y = z se evalúa como x = (y = z).

Utilice paréntesis para cambiar el orden de evaluación impuesto por la 
asociatividad de operadores:*/

int a = 13 / 5 / 2;
int b = 13 / (5 / 2);
Console.WriteLine($"a = {a}, b = {b}");