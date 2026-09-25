/*Las sentencias if, if-else y switch seleccionan las instrucciones que se
ejecutarán entre varias rutas posibles en función del valor de una expresión.

La instrucción if

- Una sentencia if con una parte else selecciona una de las dos sentencias
que se ejecutarán en función del valor de una expresión booleana:*/
DisplayWeatherReport(15.0); 
DisplayWeatherReport(24.0); 

void DisplayWeatherReport(double tempInCelsius)
{
    if (tempInCelsius < 20.0)
    {
        Console.WriteLine("Cold.");
    }
    else
    {
        Console.WriteLine("Perfect!");
    }
}
/*
- Una sentencia if sin una parte else ejecuta su cuerpo solo si una expresión
booleana se evalúa como verdadera:*/
Console.WriteLine("\n");

DisplayMeasurement(45);  
DisplayMeasurement(-3);  
void DisplayMeasurement(double value)
{
    if (value < 0 || value > 100)
    {
        Console.Write("Warning: not acceptable value! ");
    }

    Console.WriteLine($"The measurement value is {value}");
}
/*
- Se puede anidar sentencias if para comprobar varias condiciones:*/
Console.WriteLine("\n");

DisplayCharacter('f');  
DisplayCharacter('R');  
DisplayCharacter('8'); 
DisplayCharacter(',');  

void DisplayCharacter(char ch)
{
    if (char.IsUpper(ch))
    {
        Console.WriteLine($"An uppercase letter: {ch}");
    }
    else if (char.IsLower(ch))
    {
        Console.WriteLine($"A lowercase letter: {ch}");
    }
    else if (char.IsDigit(ch))
    {
        Console.WriteLine($"A digit: {ch}");
    }
    else
    {
        Console.WriteLine($"Not alphanumeric character: {ch}");
    }
}
/*
La instrucción switch
Selecciona una serie de instrucciones para ejecutar en función de una coincidencia
de patrón con una expresión de coincidencia:*/
Console.WriteLine("");

DisplayMeasurementSwitch(-4);  
DisplayMeasurementSwitch(5);  
DisplayMeasurementSwitch(30);  
DisplayMeasurementSwitch(double.NaN);  

void DisplayMeasurementSwitch(double measurement)
{
    switch (measurement)
    {
        case < 0.0:
            Console.WriteLine($"Measured value is {measurement}; too low.");
            break;

        case > 15.0:
            Console.WriteLine($"Measured value is {measurement}; too high.");
            break;

        case double.NaN:
            Console.WriteLine("Failed measurement.");
            break;

        default:
            Console.WriteLine($"Measured value is {measurement}.");
            break;
    }
}