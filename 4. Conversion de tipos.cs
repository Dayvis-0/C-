/*Dado que C# se escribe estáticamente en tiempo de compilación, después de 
declarar una variable, no se puede declarar de nuevo ni asignar un valor de otro 
tipo a menos que ese tipo se pueda convertir implícitamente en el tipo de la variable.*/

int i;

//i = "Hello"
// Error

/*Conversiones implicitas: no se requiere ninguna sintaxis especial porque la 
conversión siempre se realiza correctamente y no se pierde ningún dato.
Se puede realizar una conversion implicita cuando el valor que se va a almacenar
puede caber en la variable sin truncarse ni redondearse.

Desde	En
sbyte	short, int, long, float, double, decimalo nint
byte	short, ushort, int, uint, long, ulong, floatdouble, , decimal, , nintonuint
short	int, long, float, double, decimalo nint
ushort	int, uint, long, ulong, float, double, decimal, ninto nuint
int	long, float, double, decimal o nint
uint	long, ulong, float, double, decimalo nuint
long	float, double o decimal
ulong	float, double o decimal
float	double
nint	long, float, doubleo decimal
nuint	ulong, float, doubleo decimal*/

int num = 2147323;
long bigNum = num;

/*Conversion explicita: las conversiones explícitas requieren una expresión Cast. 
El uso de un casting es necesario cuando se puede perder información durante la 
conversión o cuando la conversión puede no realizarse con éxito por otras razones. 
Para realizar una conversión, especifique el tipo de destino entre paréntesis 
antes de la expresión que desee convertir.

Desde	En
sbyte	byte, ushort, uint, ulong o nuint
de bytes	sbyte
breve	sbyte, byte, ushort, uint, ulongo nuint
de ushort	sbyte, byte o short
int	sbyte, byte, short, ushort, uint, ulongo nuint
uint	sbyte, byte, short, ushort, into nint
long	sbyte, byte, short, ushort, int, uint, ulong, ninto nuint
ulong	sbyte, byte, short, ushort, int, uint, long, ninto nuint
float	sbyte, byte, short, ushort, int, uint, longulong, , decimal, , nintonuint
double	sbyte, byte, short, ushort, int, uint, long, ulongfloat, , decimalnintonuint
decimal	sbyte, byte, short, ushort, int, uint, long, ulongfloat, , doublenintonuint
nint	sbyte, byte, short, ushort, int, uint, ulongo nuint
nuint	sbyte, byte, short, ushort, int, uint, longo nint*/

double x = 1234.7;
int a;

a = (int)x;

System.Console.WriteLine(a);

/*Convert Clase 
Convierte un tipo de datos base en otro tipo de datos base.

Método de Convert	Desde (Tipos de origen comunes)	                En (Tipo de destino resultante)
Convert.ToInt32()	string, double, float, decimal, long, bool, char	int (entero de 32 bits)
Convert.ToDouble()	string, int, long, float, decimal, bool	        double (decimal de doble precisión)
Convert.ToString()	int, double, bool, DateTime, char, object	    string (cadena de texto)
Convert.ToBoolean()	string, int, long, double	    bool (true o false)
Convert.ToDateTime()	string (con formato válido), object	    DateTime (fecha y hora)*/

double dNumber = 23.15;
int iNumber = Convert.ToInt32(dNumber);

System.Console.WriteLine(iNumber);