float frequenciaMinima = 0.75f;
float mediaMinima = 7f;


// Valores inseridos
Console.Write("Insira a frequência do aluno (em porcentagem em número): ");
float frequenciaAluno = float.Parse(Console.ReadLine());

Console.Write("Insira a média do aluno: ");
float mediaAluno = float.Parse(Console.ReadLine());



if (frequenciaAluno < 0.75)
{
    Console.WriteLine("ALUNO REPROVADO");
}
// Testa se está aprovado (frequencia e media minima)
else if (frequenciaAluno >= 0.75 && mediaAluno >= 7.0)
{
    Console.WriteLine("ALUNO APROVADO");
}
// Frequencia maior/igual à frequencia minima e media > 3 e < 7
else if ((frequenciaAluno >= 0.75) && (mediaAluno > 3) && (mediaAluno < 7))
{
    Console.WriteLine("ALUNO EM RECUPERAÇÃO");
}
else
{
    Console.WriteLine("ALUNO REPROVADO");
}



// if (frequenciaAluno >= 0.75 && mediaAluno >= 7.0)
// {
//     Console.WriteLine("ALUNO APROVADO");
// }
// // Frequencia maior/igual à frequencia minima e media > 3 e < 7
// else if ((frequenciaAluno >= 0.75) && (mediaAluno > 3) && (mediaAluno < 7))
// {
//     Console.WriteLine("ALUNO EM RECUPERAÇÃO");
// }
// else
// {

// }