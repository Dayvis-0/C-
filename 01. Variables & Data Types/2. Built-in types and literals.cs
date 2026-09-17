using System;

/*C# proporciona un conjunto de tipos integrados que se pueden usar en cualquier programa
sin necesidad de referencias adicionales.*/

// Tipos numéricos

int population = 67_000_000;
long distance = 384_400_000L;
short temperature = -40;
byte red = 255;

double pi1 = 3.141592653589793;
float gravity1 = 9.81f;
decimal price1 = 19.99m;

/* Tipos sin signo
Cada tipo de entero con signo tiene una contraparte sin signo que almacena solo valores
no negativos con el doble de rango positivo:*/

uint fileSize = 4_294_967_295;
ulong totalBytes = 18_446_744_073_709_551_615;
ushort port = 443;

/* Numeros enteros de tamaño nativo
Los tipos nint y nuint representan enteros cuyo tamaño coincide con el tamaño del 
puntero nativo de la plataforma: 32 bits en una plataforma de 32 bits, 64 bits en 
una plataforma de 64 bits:*/

nint bufferSize = 1024;
nuint elementCount = 256;

// bool, char and string

bool isValid = true;
char grade = 'A';
string greeting = "Hello, world!";

/* Sintaxis literal
Un literal es un valor que se describe directamente en el código:*/

// Literales enteros

int decimal_num  = 42;           // decimal normal
int hex_num      = 0x2A;         // hexadecimal (0x al inicio)
int bin_num      = 0b_0010_1010; // binario (0b al inicio)
long big_num     = 1_000_000_000L; // L = long, _ mejora legibilidad
uint positive    = 4_294_967_295U; // U = uint (sin negativos)
ulong very_big   = 18_000_000_000UL; // UL = ulong

// Literales flotantes

double pi        = 3.14159;      // double por defecto
float gravity    = 9.81f;        // f = float
decimal price    = 19.99m;       // m = decimal (para dinero)
double science   = 1.5e6;        // notación científica = 1,500,000

// Literales de caracteres

char letter      = 'A';          // carácter normal
char newline     = '\n';         // escape: salto de línea
char tab         = '\t';         // escape: tabulador
char unicode     = '\u0041';     // unicode: equivale a 'A'

// Literales de cadena

string normal    = "Hola mundo";                    // string normal
string interp    = $"Tengo {42} años";              // interpolado con $
string path      = @"C:\Users\docs\archivo.txt";    // verbatim con @ (ignora \)
string json      = """
    { "nombre": "Carlos", "edad": 25 }
""";                                            // raw string con """
string raw_interp = $"""
    El resultado es {1 + 1} items en "{path}"
""";                                            // raw + interpolado

// Literales booleanos

bool activo      = true;
bool inactivo    = false;

// Literales nulos

// string? nombre   = null;         // null para tipos referencia
// int?    edad     = null;         // null para value types nullable

/* Expresion default
La expresión default produce el valor predeterminado para un tipo: 0 para tipos 
numéricos, falso para booleanos y nulo para tipos de referencia.*/

int defaultInt = default;          // 0
bool defaultBool = default;        // false
// string? defaultString = default;   // null

// Use default in a conditional:
// string args = "Hello";
// var limit = (args.Length > 0) ? int.Parse(args[0]) : default(int);

/* Variables de tipo implicita con var
La palabra clave 'var' le indica al compilador que infiera el tipo de una variable
local a partir de su inicializador:*/

var count = 10;              // compiler infers int
var name = "C#";             // compiler infers string
var items = new List<int>(); // compiler infers List<int>

// var requiere un inicializador: el compilador necesita un valor para inferir el tipo
// La siguiente linea no compilaba:
// var unknown;

/* Expresiones con tipo de destino new
Cuando ya se conoce el tipo de destino a partir del contexto, como por ejemplo la 
declaración de una variable o un parámetro de un método, se puede omitir el nombre
del tipo en la nueva expresión:*/

List<string> names = new() { "Alice", "Bob", "Charlie" };
Dictionary<string, int> scores = new()
{
    ["Alice"] = 95,
    ["Bob"] = 87
};

/* El tipo dinamic 
El tipo dinamic omite la comprobación de tipos en tiempo de compilación. En su
lugar, el compilador resuelve las operaciones sobre una variable dinámica en tiempo
de ejecución.*/

dynamic value = 42;
Console.WriteLine(value.GetType()); // System.Int32

value = "Now I'm a string";
Console.WriteLine(value.GetType()); // System.String

// The compiler doesn't check operations on dynamic at compile time.
// Errors surface at run time instead.