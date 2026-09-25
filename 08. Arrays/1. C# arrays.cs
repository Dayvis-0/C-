/*
Puedes almacenar varias variables del mismo tipo en una estructura de datos 
de tipo array. Para declarar un array, debes especificar el tipo de sus 
elementos. Si quieres que el array almacene elementos de cualquier 
tipo, especifica `object` como su tipo.

Sintaxis
type[] arrayName;

Un array es un tipo de referencia, por lo que puede ser un tipo de referencia 
que admita valores nulos. Los tipos de los elementos también pueden ser 
tipos de referencia, así que se puede declarar un array para almacenar 
tipos de referencia que admitan valores nulos.

type?[] arrayName; // non nullable array of nullable element types.
type[]? arrayName; // nullable array of non-nullable element types.
type?[]? arrayName; // nullable array of nullable element types. */

/*Los elementos no inicializados de un array se establecen al valor 
predeterminado para ese tipo: */
int[] numbers = new int[10]; // All values are 0
string[] messages = new string[10]; // All values are null.

/* El siguiente ejemplo crea matrices unidimensionales, multidimensionales 
y dentadas:
Declare a single-dimensional array of 5 integers.*/
int[] array1 = new int[5];

// Declare and set array element values.
int[] array2 = [1, 2, 3, 4, 5, 6];

// Declare a two dimensional array.
int[,] multiDimensionalArray1 = new int[2, 3];

// Declare and set array element values.
int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

// Declare a jagged array.
int[][] jaggedArray = new int[6][];

// Set the values of the first array in the jagged array structure.
jaggedArray[0] = [1, 2, 3, 4];

/* ----------------------------------------------------------------------------
Matrices unidimensionales
Un array unidimensional es una secuencia de elementos iguales. Se accede a 
un elemento mediante su índice. El índice es la posición ordinal del elemento 
en la secuencia. El primer elemento del arreglo está en el índice 0.*/
int[] array = new int[5];
string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

Console.WriteLine(weekDays[0]);
Console.WriteLine(weekDays[1]);
Console.WriteLine(weekDays[2]);
Console.WriteLine(weekDays[3]);
Console.WriteLine(weekDays[4]);
Console.WriteLine(weekDays[5]);
Console.WriteLine(weekDays[6]);

/* ----------------------------------------------------------------------------
Matrices multidimensionales
Los arreglos pueden tener más de una dimensión. Por ejemplo, las siguientes 
declaraciones crean cuatro arreglos. Dos arreglos tienen dos dimensiones.*/
int[,] array2DDeclaration = new int[4, 2];

int[,,] array3DDeclaration = new int[4, 2, 3];

// Two-dimensional array.
int[,] array2DInitialization =  { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
// Three-dimensional array.
int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4,   5,  6 } },
                                { { 7, 8, 9 }, { 10, 11, 12 } } };

// Accessing array elements.
Console.WriteLine("\nArray 2D");
System.Console.WriteLine(array2DInitialization[0, 0]);
System.Console.WriteLine(array2DInitialization[0, 1]);
System.Console.WriteLine(array2DInitialization[1, 0]);
System.Console.WriteLine(array2DInitialization[1, 1]);

System.Console.WriteLine(array2DInitialization[3, 0]);
System.Console.WriteLine(array2DInitialization[3, 1]);

Console.WriteLine("\nArray 3D");
System.Console.WriteLine(array3D[1, 0, 1]);
System.Console.WriteLine(array3D[1, 1, 2]);

Console.WriteLine("\n");
// Getting the total count of elements or the length of a given dimension.
var allLength = array3D.Length;
var total = 1;
for (int i = 0; i < array3D.Rank; i++)
{
    total *= array3D.GetLength(i);
}
System.Console.WriteLine($"{allLength} equals {total}");