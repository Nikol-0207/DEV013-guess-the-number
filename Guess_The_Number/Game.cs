class Game{
    private int secretNumber{get; set;}
    private Random _random= new Random();
    private Player Player{get; set;}
    private Player IAPlayer{get; set;}
    
    private int RandomNumberGenerator( ){
       return _random.Next(1,100);
    }
    public Game (string nameplayer){
       secretNumber= RandomNumberGenerator(); 
       Player= new HumanPlayer(nameplayer);
       IAPlayer= new AIPlayer("IA");
    }
    private void CheckGuess(int guess,int targetNumber){
       if (guess==targetNumber){
            Console.WriteLine("██╗░░░██╗░█████╗░██╗░░░██╗  ░██╗░░░░░░░██╗██╗███╗░░██╗");
            Console.WriteLine("╚██╗░██╔╝██╔══██╗██║░░░██║  ░██║░░██╗░░██║██║████╗░██║");
            Console.WriteLine("░╚████╔╝░██║░░██║██║░░░██║  ░╚██╗████╗██╔╝██║██╔██╗██║");
            Console.WriteLine("░░╚██╔╝░░██║░░██║██║░░░██║  ░░████╔═████║░██║██║╚████║");
            Console.WriteLine("░░░██║░░░╚█████╔╝╚██████╔╝  ░░╚██╔╝░╚██╔╝░██║██║░╚███║");
            Console.WriteLine("░░░╚═╝░░░░╚════╝░░╚═════╝░  ░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝");
            Console.WriteLine("....");
            Console.WriteLine("...");
            Console.WriteLine("..");
            Console.WriteLine();
       }
       if (guess<targetNumber){
            Console.WriteLine("El número que ingresaste es menor al número que estoy pensando");
        }else if (guess>targetNumber) {
            Console.WriteLine("El número que ingresaste es mayor al número que estoy pensando");
        }
    }
    public  void start_game(){
        int numberIntent=1;
        bool finish=false; 
       Console.WriteLine("Bienvenida "+Player.nameGame+" adivina el número que estoy pensando...entre 1 y 100");
        while (!finish){
           Player.MakeGuess();
           IAPlayer.MakeGuess();
           CheckGuess(Player.GetLastGuess(),secretNumber);
           if (Player.GetLastGuess()==secretNumber){
            finish=true;
           }
          numberIntent++;
        }
    }
}