using System;

/*C# es un lenguaje fuertemente tipado. Cada variable, constante y expresión tiene un tipo.*/
int a = 5;
int b = a + 2;

bool test = true;

/* Declarar variables con tipos
Cuando declaras una variable, especificas su tipo explícitamente o usas 'var' para que el
compilador infiera el tipo a partir del valor asignado.*/

// Tipo explicito
int count = 10;
double temperature = 36.6;

// Tipo inferido por el compilador
var name = "C#";
var items = new List<string> {"one", "two", "three"};