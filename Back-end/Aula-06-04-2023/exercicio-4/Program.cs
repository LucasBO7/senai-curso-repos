// Receber sexo do entrevistado
// Receber sua resposta se gostaram do produto (sim ou não)
/* Imprimir: 
A.O número de pessoas que responderam SIM.
B.O número de pessoas que responderam NÃO;
C.O número de mulheres que responderam SIM;
D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.
*/

// Inicialização de variáveis
// Recebe valores
string sexoEntrevistado;
string feedbackProduto;
// Quantidade c/ cada característica
int qntdSexoMasculino = 0;
int qntdSexoFeminino = 0;

int qntdGostaramProduto = 0;
int qntdNaoGostaramProduto = 0;

int qntdHomensNaoGostaram = 0;
int qntdMulheresGostaram = 0;

// "Formulário"
for (int x = 0; x <= 2; x++)
{
    Console.Write($"Insira seu sexo: ");
    sexoEntrevistado = Console.ReadLine().ToLower();

    Console.Write($"Você gostou do produto mostrado?(sim/não): ");
    feedbackProduto = Console.ReadLine().ToLower();

    switch (sexoEntrevistado)
    {
        case "masculino":
            qntdSexoMasculino += 1;
            // Se gostou do produto / se não gostou do produto
            if (feedbackProduto == "sim")
            {
                qntdGostaramProduto += 1; // Pessoas que gostaram
            }
            else
            {
                qntdHomensNaoGostaram += 1; // Homens que não gostara
                qntdNaoGostaramProduto += 1; // Pessoas que não gostaram
            }
            break;

        case "feminino":
            qntdSexoFeminino += 1;
            if (feedbackProduto == "sim")
            {
                qntdGostaramProduto += 1; // Pessoas que gostaram
                qntdMulheresGostaram += 1; // Mulheres que gostaram
            }
            else
            {
                qntdNaoGostaramProduto += 1; // Pessoas que não gostaram
            }
            break;
        default:
            Console.WriteLine($"Sexo inexistente.");
            break;
    }


    Console.WriteLine(); // Pula linha
}

float HomensNaoGostaramPorcentagem = (qntdHomensNaoGostaram * 100) / qntdSexoMasculino;
string mulheresResponderamText = qntdMulheresGostaram == 0 ? "Nenhuma mulher respondeu que gostou do produto" : $"{qntdMulheresGostaram} mulheres responderam que gostaram do produto";

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{qntdGostaramProduto} pessoas responderam que gostaram do produto");
Console.WriteLine($"{qntdNaoGostaramProduto} pessoas responderam que não gostaram do produto");
Console.WriteLine(mulheresResponderamText);
Console.WriteLine($"{HomensNaoGostaramPorcentagem}% dos homens entrevistados responderam que não gostaram do produto");
Console.ResetColor();