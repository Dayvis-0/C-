using System;

/*Dado que C# se escribe estáticamente en tiempo de compilación, después de
declarar una variable, no se puede declarar de nuevo ni asignar un valor de otro
tipo a menos que ese tipo se pueda convertir implícitamente en el tipo de la variable.*/

int i;

//i = "Hello";
// Error

/*Conversiones implícitas: no se requiere ninguna sintaxis especial porque la
conversión siempre se realiza correctamente y no se pierde ningún dato.

Desde       → En
─────────────────────────────────────────────────────────────
sbyte       → short, int, long, float, double, decimal, nint
byte        → short, ushort, int, uint, long, ulong, float, double, decimal, nint, nuint
short       → int, long, float, double, decimal, nint
ushort      → int, uint, long, ulong, float, double, decimal, nint, nuint
int         → long, float, double, decimal, nint
uint        → long, ulong, float, double, decimal, nuint
long        → float, double, decimal
ulong       → float, double, decimal
float       → double
nint        → long, float, double, decimal
nuint       → ulong, float, double, decimal
─────────────────────────────────────────────────────────────*/

int num = 2147323;
long bigNum = num;

/*Conversiones explícitas: las conversiones explícitas requieren una expresión cast.
El uso de un casting es necesario cuando se puede perder información durante la
conversión o cuando la conversión puede no realizarse con éxito por otras razones.

Desde       → En
─────────────────────────────────────────────────────────────
sbyte       → byte, ushort, uint, ulong, nuint
byte        → sbyte
short       → sbyte, byte, ushort, uint, ulong, nuint
ushort      → sbyte, byte, short
int         → sbyte, byte, short, ushort, uint, ulong, nuint
uint        → sbyte, byte, short, ushort, int, nint
long        → sbyte, byte, short, ushort, int, uint, ulong, nint, nuint
ulong       → sbyte, byte, short, ushort, int, uint, long, nint, nuint
float       → sbyte, byte, short, ushort, int, uint, long, ulong, decimal, nint, nuint
double      → sbyte, byte, short, ushort, int, uint, long, ulong, float, decimal, nint, nuint
decimal     → sbyte, byte, short, ushort, int, uint, long, ulong, float, double, nint, nuint
nint        → sbyte, byte, short, ushort, int, uint, ulong, nuint
nuint       → sbyte, byte, short, ushort, int, uint, long, nint
─────────────────────────────────────────────────────────────*/

double x = 1234.7;
int a;

a = (int)x;

Console.WriteLine(a);

/*Convert class
Convierte un tipo de datos base en otro tipo de datos base.

Método              Desde (Tipos de origen comunes)                         En (Tipo de destino)
─────────────────────────────────────────────────────────────────────────────────────────────────────
Convert.ToInt32()   string, double, float, decimal, long, bool, char       int (entero de 32 bits)
Convert.ToDouble()  string, int, long, float, decimal, bool                double (doble precisión)
Convert.ToString()  int, double, bool, DateTime, char, object              string (cadena de texto)
Convert.ToBoolean() string, int, long, double                              bool (true o false)
Convert.ToDateTime() string (con formato válido), object                   DateTime (fecha y hora)
─────────────────────────────────────────────────────────────────────────────────────────────────────*/

double dNumber = 23.15;
int iNumber = Convert.ToInt32(dNumber);

Console.WriteLine(iNumber);
