
public class Game{
    public int secretNumber{get; set;}
    private Random _random= new Random();
    private Player _humanPlayer{get; set;}
    private Player _AIPlayer{get; set;}
    
    private int RandomNumberGenerator( ){
       return _random.Next(1,100);
    }
    public Game (string nameplayer){
       secretNumber= RandomNumberGenerator(); 
       _humanPlayer= new HumanPlayer(nameplayer);
       _AIPlayer= new AIPlayer("IA");
    }
    public bool CheckGuess(int guess,int targetNumber){
       if (guess==targetNumber){
            return true;
       }
       if (guess<targetNumber){
            Console.WriteLine("El número que ingresaste es menor al número que estoy pensando");
        }else if (guess>targetNumber) {
            Console.WriteLine("El número que ingresaste es mayor al número que estoy pensando");
        }
      return false;
    }
    public  void start_game(){
        int numberIntent=1;
        bool finish=false;
        bool semaforo=true;
       Console.WriteLine("Bienvenida "+_humanPlayer.nameGame+" adivina el número que estoy pensando...entre 1 y 100");
        while (!finish){
            if (semaforo){
                _humanPlayer.MakeGuess();
                if (CheckGuess(_humanPlayer.GetLastGuess(),secretNumber)){
                  finish=true;
                }
                semaforo=false;
            }else{
                _AIPlayer.MakeGuess();
                if (CheckGuess(_AIPlayer.GetLastAIGuess(),secretNumber)){
                   finish=true;
                }
                semaforo=true;
            }
          numberIntent++;
        }
    }
    public void winnerGame(){
        if (CheckGuess(_humanPlayer.GetLastGuess(),secretNumber)){
            Console.WriteLine("██╗░░░██╗░█████╗░██╗░░░██╗  ░██╗░░░░░░░██╗██╗███╗░░██╗");
            Console.WriteLine("╚██╗░██╔╝██╔══██╗██║░░░██║  ░██║░░██╗░░██║██║████╗░██║");
            Console.WriteLine("░╚████╔╝░██║░░██║██║░░░██║  ░╚██╗████╗██╔╝██║██╔██╗██║");
            Console.WriteLine("░░╚██╔╝░░██║░░██║██║░░░██║  ░░████╔═████║░██║██║╚████║");
            Console.WriteLine("░░░██║░░░╚█████╔╝╚██████╔╝  ░░╚██╔╝░╚██╔╝░██║██║░╚███║");
            Console.WriteLine("░░░╚═╝░░░░╚════╝░░╚═════╝░  ░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝");
            Console.WriteLine();
            Console.WriteLine();
            
        }else if (CheckGuess(_AIPlayer.GetLastAIGuess(),secretNumber)){
            Console.WriteLine("░██████╗░░█████╗░███╗░░░███╗███████╗  ░█████╗░██╗░░░██╗███████╗██████╗░");
            Console.WriteLine("██╔════╝░██╔══██╗████╗░████║██╔════╝  ██╔══██╗██║░░░██║██╔════╝██╔══██╗");
            Console.WriteLine("██║░░██╗░███████║██╔████╔██║█████╗░░  ██║░░██║╚██╗░██╔╝█████╗░░██████╔╝");
            Console.WriteLine("██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░  ██║░░██║░╚████╔╝░██╔══╝░░██╔══██╗");
            Console.WriteLine("╚██████╔╝██║░░██║██║░╚═╝░██║███████╗  ╚█████╔╝░░╚██╔╝░░███████╗██║░░██║");
            Console.WriteLine("░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝  ░╚════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝");
      
        }

     
    }
}
