/* Operador de negación lógica
El operador de prefijo unario ! calcula la negación lógica de su operando. Produce
verdadero si el operando se evalúa como falso, y falso si se evalúa como verdadero.*/
bool passed = false;

Console.WriteLine(!passed);
Console.WriteLine(!true);

/* Operador lógico AND &
El operador & realiza la operación lógica AND  entre sus operandos. El resultado de 
x & y es verdadero si tanto x como y son verdaderos. En caso contrario, el 
resultado es falso.*/
Console.WriteLine();

bool SecondOperand()
{
    Console.WriteLine("Second operand is evaluated.");
    return true;
}

bool a = false & SecondOperand();
Console.WriteLine(a);

bool b = true & SecondOperand();
Console.WriteLine(b);

/* Operador lógico OR |
El operador | realiza la operación lógica OR entre sus operandos. El resultado de 
x | y es verdadero si x o y son verdaderos. En caso contrario, el resultado es falso.*/
Console.WriteLine();

bool ThirdOperand()
{
    Console.WriteLine("Third operand is evaluated.");
    return true;
}

bool c = true | ThirdOperand();
Console.WriteLine(c);

bool d = false | ThirdOperand();
Console.WriteLine(d);

/* Operador lógico AND condicional && 
El operador lógico AND condicional &&, también conocido como operador lógico AND
de "cortocircuito", calcula el AND lógico de sus operandos. El resultado de x && y
es verdadero si tanto x como y se evalúan como verdaderos. De lo contrario, el 
resultado es falso. Si x se evalúa como falso, y no se evalúa.*/
Console.WriteLine();

bool FourthOperand()
{
    Console.WriteLine("Fourth operand is evaluated.");
    return true;
}

bool e = false && FourthOperand();
Console.WriteLine(e);

bool f = true && FourthOperand();
Console.WriteLine(f);

/* Operador lógico OR condicional ||
El operador lógico OR condicional ||, también conocido como operador lógico OR de
"cortocircuito", calcula el OR lógico de sus operandos. El resultado de x || y es 
verdadero si x o y se evalúan como verdaderos. De lo contrario, el resultado es 
falso. Si x se evalúa como verdadero, y no se evalúa.*/
Console.WriteLine();

bool FifthOperand()
{
    Console.WriteLine("Fifth operand is evaluated.");
    return true;
}

bool g = true || FifthOperand();
Console.WriteLine(g);

bool h = false || FifthOperand();
Console.WriteLine(h);

/* Asignación compuesta
Los operadores &, | y ^ admiten la asignación compuesta, como muestra el 
siguiente ejemplo:*/
Console.WriteLine();

bool test = true;
test &= false;
Console.WriteLine(test);  // output: False

test |= true;
Console.WriteLine(test);  // output: True

test ^= false;
Console.WriteLine(test);  // output: True