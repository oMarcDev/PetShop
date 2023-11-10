//Array ourAnimals vai armazenar essas string:
string especieAnimal = "";
string idadeAnimal = "";
string descricaoFisicaAnimal = "";
string descricaoPersonalidadeAnimal = "";
string nomeAnimal = "";

//Variáveis para entrada de dados

int maxPets = 8;
string? readResult;
string menuSelection = "";

//Array usada para armazenar os dados
string[,] ourAnimals = new string[maxPets, 6];

for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            especieAnimal = "Cachorro";
            idadeAnimal = "2";
            descricaoFisicaAnimal = "tamanho medio Femea Golden retriever";
            descricaoPersonalidadeAnimal = "Ama que esfreguem sua barriga, gosta de mexer o rabo 10kg";
            nomeAnimal = "Lola";
            break;
        case 1:
            especieAnimal = "Cachorro";
            idadeAnimal = "9";
            descricaoFisicaAnimal = "Tamanho grande Macho Golden retriever 20kg";
            descricaoPersonalidadeAnimal = "Ama quando esfregam sua orelha, gosta de abraços";
            nomeAnimal = "Gus";
            break;
        case 2:
            break;
        default:
            especieAnimal = "";
            idadeAnimal = "";
            descricaoFisicaAnimal = "";
            descricaoPersonalidadeAnimal = "";
            nomeAnimal = "";
            break;
    }

    ourAnimals[i, 0] = "Espécie: " + especieAnimal;
    ourAnimals[i, 1] = "Idade: " + idadeAnimal;
    ourAnimals[i, 2] = "Nome: " + nomeAnimal;
    ourAnimals[i, 3] = "Descricao Fisica: " + descricaoFisicaAnimal;
    ourAnimals[i, 4] = "Personalidade: " + descricaoPersonalidadeAnimal;
}
//Mostrar as opcoes do menu
do
{
    Console.Clear();

    Console.WriteLine("Bem-vindo ao aplicativo do PetShop. suas opcoes sao: ");
    Console.WriteLine("1. Liste todas nossas informacoes de pets");
    Console.WriteLine("2. Exibir todos os caes com caracteristicas especificas");
    Console.WriteLine("Digite o número que voce quer (ou digite exit para sair do aplicativo)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower().Trim();
    }

    switch (menuSelection)
    {
        case "1":
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\r Pressione Enter para continuar");
            readResult = Console.ReadLine();
            break;
    }
} while (menuSelection != "exit");