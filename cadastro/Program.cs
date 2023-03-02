string[,] cadastro = new string[5, 3];
string pesquisar;
int linha = 0;
int coluna = 0;
int opcao = 0;
int idade = 0;
string voltar = "S";
string continuarpesquisa = "S";


while (voltar == "S" || voltar == "s")
{
    Console.Clear(); Console.WriteLine("Qual opção deseja?");
    Console.WriteLine("1 - Cadastrar pessoas");
    Console.WriteLine("2 - Pesquisar pessoas");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:  // CADASTRAR PESSOAS

            for (linha = 0; linha <= 4; linha++)
            {
                Console.Clear();

                Console.WriteLine("Nome da " + (linha + 1) + "º pessoa");
                cadastro[linha, coluna++] = Console.ReadLine();
                Console.WriteLine("Sobrenome da " + (linha + 1) + "º pessoa:");
                cadastro[linha, coluna++] = Console.ReadLine();
                Console.WriteLine("Ano do nascimento da " + (linha + 1) + "º pessoa:");
                cadastro[linha, coluna++] = Console.ReadLine();

                coluna = 0;
            }

            for (linha = 0; linha <= 4; linha++)
            {
                for (coluna = 0; coluna <= 2; coluna++)
                {
                    Console.Write(" -- " + cadastro[linha, coluna] + " -- ");
                }
                Console.WriteLine("");
            }

            break;

        case 2:  //PESQUISAR PESSOAS
            while (continuarpesquisa == "S" || continuarpesquisa == "s")
            {

                Console.Clear();

                for (linha = 0; linha <= 4; linha++)
                {
                    for (coluna = 0; coluna <= 2; coluna++)
                    {
                        Console.Write(" -- " + cadastro[linha, coluna] + " -- ");
                    }
                    Console.WriteLine("");
                }

                Console.WriteLine("\n Nome que deseja pesquisar?");
                pesquisar = Console.ReadLine();

                Console.WriteLine("");

                for (linha = 0; linha <= 4; linha++)
                {
                    if (cadastro[linha, 0] == pesquisar)
                    {
                        idade = 2023 - int.Parse(cadastro[linha, 2]);
                        Console.WriteLine(" -- " + cadastro[linha, 0] + " -- " + cadastro[linha, 1] + " -- " + idade);
                    }
                }
                Console.WriteLine("");

                Console.WriteLine("Deseja continuar a pesquisa? S/N");
                continuarpesquisa = Console.ReadLine();
            }
            break;
    }


    Console.WriteLine("Voce deseja voltar ao menu? S/N");
    voltar = Console.ReadLine();
}