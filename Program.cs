// See https://aka.ms/new-console-template for more information
class Program{
    static void Main(string[] args)
    {
        caucularRank();
    }

    static void caucularRank()
    {
        Console.WriteLine("Insira o numero de vitorias");
        int vitorias = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira o numero de derrotas");
        int derrotas = Convert.ToInt32(Console.ReadLine());
        int saldo = vitorias - derrotas;
        string rank = "";

//define o rank baseado no valor do rank
       if (saldo < 10)
       {    
            rank = "Ferro";
       }
            else if(saldo >= 11 && saldo <= 20)
            {
                rank = "Bronze";
            }
                else if(saldo >= 21 && saldo <= 50)
                {
                    rank = "Prata";
                }
                    else if (saldo >= 51 && saldo <= 80)
                    {
                        rank = "ouro";
                    }
                        else if(saldo >= 81 && saldo <= 90)
                        {
                            rank = "Diamante";
                        }
                            else if(saldo >= 91 && saldo <= 100)
                            {
                                    rank = "Lendario";
                            } 
                                else if (saldo > 100)
                                {
                                    rank = "imortal";
                                } 
        Console.WriteLine("O Herói tem saldo de "+ vitorias + " vitorias e está no nível de "+ rank); 
    }
}





