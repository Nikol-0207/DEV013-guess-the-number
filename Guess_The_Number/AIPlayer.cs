public class AIPlayer : Player{
    private Random AINumberGuess;
     public AIPlayer(string name) : base(name) {
        AINumberGuess= new Random();
     }
     
     private int AIGuess(){
        return AINumberGuess.Next(1,100);
     }
    public override void MakeGuess()
    {
        int guessAI= AIGuess();
        Console.WriteLine("--Round: Computer Player---");
        Console.WriteLine("Escribe un número:"+guessAI);
    }
}