/*Este ejemplo declara una cantidad, la muestra y luego utiliza una instrucción 
condicional para decidir si se debe reabastecer:*/

int quantity = 5;
Console.WriteLine($"Quantity: {quantity}"); 

if (quantity < 10)
{
    quantity = 10;
    Console.WriteLine("Restocked"); 
}

Console.WriteLine($"Quantity: {quantity}"); 

/*Las afirmaciones suelen contener expresiones.
Las sentencias suelen contener expresiones, que son fragmentos de código que 
producen valores. En el ejemplo anterior, toda la estructura if es una sentencia.

Una declaración introduce una variable local o constante. Una expresión de 
inicialización puede proporcionar su primer valor:*/
int quantity = 5;

