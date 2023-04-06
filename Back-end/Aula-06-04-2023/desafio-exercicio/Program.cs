// somar o último número com o número anterior --> fibonacci
// Realizar até o valor ser maior que 500
/*
0, 1, 1(esse + anterior), 2(esse + anterior), 3

salvar o anterior e salvar com o atual
*/

int numero = 0;
int numB = 0;
int numC = 1;

do
{
    numero = numB + numC; // x = 0 + 1
    numB = numC; // numB = 1
    numC = numero; // numc = 1
    
    Console.WriteLine(numero);
} while (numero <= 500);