// RECEBER - quantidade açúcar (em gramas -> g) se não inserido, (add 10 g)
// CLASSE
using exercicio_dois_elevador;

// Menu Cafés
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(
    @$"
*****************************************
*   Super CafeteiraTabajaras Plus++     *
*****************************************


| Bem vindo à nova cafeteira, para começar, selecione uma dos tipos de café que deseja.
| [1] Expresso
| [2] Capuccino
| [3] Com chantili
| [4] Macchiato
| [5] Duplo
| [6] Mocha
|
| [0] Cancelar/Sair
____________________________________________________________________________________________
-> "
);
Console.ResetColor();

char menuCafeSelecionado;
do
{
    menuCafeSelecionado = char.Parse(Console.ReadLine()!.ToLower());
} while (
    menuCafeSelecionado != '1'
    && menuCafeSelecionado != '2'
    && menuCafeSelecionado != '3'
    && menuCafeSelecionado != '4'
    && menuCafeSelecionado != '5'
    && menuCafeSelecionado != '6'
    && menuCafeSelecionado != '0'
);

// Menu quantidade de volume do copo
Console.Clear();

// Inicialização da variável com valores
MaquinaCafe maquina_cafe = new MaquinaCafe();
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(
    @$"
******************************
* Selecione a quantidade:    *
* [1] 120 ml                 *
* [2] 240 ml                 *
* [3] 480 ml                 *
* [4] 500 ml                 *
******************************
-> "
);
char menuVolumeSelecionado;
do
{
    menuVolumeSelecionado = char.Parse(Console.ReadLine()!.ToLower());
} while (
    menuVolumeSelecionado != '1'
    && menuVolumeSelecionado != '2'
    && menuVolumeSelecionado != '3'
    && menuVolumeSelecionado != '4'
    && menuVolumeSelecionado != '0'
);
Console.ResetColor();
switch (menuVolumeSelecionado)
{
    case '1':
        maquina_cafe.VolumeCopo = 120;
        break;

    case '2':
        maquina_cafe.VolumeCopo = 240;
        break;

    case '3':
        maquina_cafe.VolumeCopo = 480;
        break;

    case '4':
        maquina_cafe.VolumeCopo = 500;
        break;

    default:
        break;
}

switch (menuCafeSelecionado)
{
    case '1':
        maquina_cafe.TipoCafe = "Expresso";
        break;

    case '2':
        maquina_cafe.TipoCafe = "Cappuccino";
        break;

    case '3':
        maquina_cafe.TipoCafe = "Com chantili";
        break;

    case '4':
        maquina_cafe.TipoCafe = "Macchiato";
        break;

    case '5':
        maquina_cafe.TipoCafe = "Duplo";
        break;

    case '6':
        maquina_cafe.TipoCafe = "Mocha";
        break;

    default:
        break;
}

Console.Write($"| Insira a quantidade de açúcar em gramas(g): ");

float acucarInput = float.Parse(Console.ReadLine()!);
// float res;
// bool x = float.TryParse(acucar, out res);

maquina_cafe.FazerCafe(acucarInput);

Console.WriteLine(@$"Café {maquina_cafe.TipoCafe}, com {maquina_cafe.VolumeCopo}ml preparado com sucesso.");