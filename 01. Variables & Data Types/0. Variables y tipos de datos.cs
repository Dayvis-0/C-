using System;

/*Para declarar una variable local, especifique su tipo y proporcione su nombre.
Puede declarar varias variable del mismo tipo en una instrucción.*/

int x;
int a, b, c;

// En instrucción de declaración, tambien puede inicializar una variable con su valor inicial

x = 1000;
a = 10;
int z = x + a;
int age = 20;

Console.WriteLine(x);
Console.WriteLine("Your age is " + age);

// Tipos numéricos

int population = 76; // Almacena de 32 bits
long distance = 384_000_00L; // Almacena 64 bits
short temperature = -40; // Valor mas pequeño
byte red = 255; // Valor mas pequeño

double pi = 3.141592653589793; // Matematicas generales de punto flotante
float gravity = 9.81f; // Cuando se restringe la memoria
decimal price = 19.99m; // Cuando se necesita precisión decimal exacta

/*Se el sufijo f para los literales float y m para los decimales.
Sin un sufijo, el compilador trata un número con punto decimal como double.*/

// Tipos de signo

/*Cada tipo entero con signo tiene un homólogo sin signo que almacena solo
valores no negativos con dos veces el intervalo positivo.*/
uint fileSize = 4_123_123_121;
ulong totalBytes = 18_121_122_122_134_657_345;
ushort port = 443;

// Enteros de tamaño nativo

/*Los nint tipos y nuint representan enteros cuyo tamaño coincide con el tamaño del
puntero nativo de la plataforma 32 o 64 depende de la plataforma*/ 

// bool, char y string

// Almacena true o false
bool isValid = true;

// Almacena un único carácter Unicode, entre comillas simples.
char grade = 'A';

// Almacena una secuencia de caracteres, entre comillas dobles. Las cadenas son inmutables
string greeting = "Hello, world"; 