/*La instrucción for
Ejecuta una instrucción o un bloque de instrucciones mientras una expresión
booleana especifica se evalúa como verdadera.*/
for (int i = 0; i < 3; i++)
{
    Console.Write(i + " ");
}

Console.WriteLine("\n");
int i;
int j = 3;
for (i = 0, Console.WriteLine($"Start: i={i}, j={j}"); i < j; i++, j--, Console.WriteLine($"Step: i={i}, j={j}"))
{
    //...
}
/*
La instrucción foreach
Ejecuta una instrucción o un bloque de instrucciones para cada elemento
en una instancia del tipo que implementa interfaz System.Collections.IEnumerable o 
System.Collections.Generic.IEnumerable<T>:*/
Console.WriteLine("\n");

List<int> fibNumbers = new() { 0, 1, 1, 2, 3, 5, 8, 13 };
foreach (int element in fibNumbers)
{
    Console.Write($"{element} ");
}
/*
Si la propiedad Current del enumerador devuelve un valor de referencia 
(ref T, donde T es el tipo de un elemento de colección), puede declarar 
una variable de iteración con el modificador ref o ref readonly*/
Console.WriteLine("\n");

{
    // Span<T> es un ref struct: solo puede existir como local de un método,
    // nunca como campo. Al declararlo dentro de un bloque se convierte en local.
    Span<int> storage = stackalloc int[10];
    int num = 0;

    foreach (ref int item in storage)
    {
        item = num++;
    }
    foreach (ref readonly var item in storage)
    {
        Console.Write($"{item} ");
    }
}
/*
await foreach
Utilice la instrucción await foreach para consumir un flujo de datos asincrono, 
es decir, un tipo de colección que implementa la interfaz IAsyncEnumerable<T>.*/
Console.WriteLine("\n");
await foreach (var item in GenerateSequenceAsync())
{
    Console.WriteLine(item);
}
 
async IAsyncEnumerable<int> GenerateSequenceAsync()
{
    for (int i = 0; i < 3; i++)
    {
        await Task.Delay(100);
        yield return i;
    }
}
/*
La declaración do
Ejecuta una instrucción o un bloque de instrucciones mientras una expresión 
booleana expecifica se evalua como verdadera. Debido a que el bucle evalúa 
esa expresión después de cada ejecución, un bucle do se ejecuta una o más 
veces:*/
Console.WriteLine("\n");

int n = 0;

do
{
    Console.Write(n);
    n++;
} while (n < 5);
/*
La declaración while
Ejecuta una instrucción o un bloque de instrucciones mientras una expresión 
booleana especifica se evalúa como verdadera. Debido a que el bucle evalúa 
esa expresión antes de cada ejecución, un bucle while se ejecuta cero o 
más veces.*/
Console.WriteLine("\n");

int nTwo = 0;
while (nTwo < 5)
{
    Console.Write(nTwo);
    nTwo++;
}
