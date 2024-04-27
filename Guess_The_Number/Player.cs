 public abstract class Player{
     public string nameGame {get ; private set; }
     private List<int> guesses{get;set;}
     private List<int> AIGuesses{get;set;}
    protected Player(string nombre){
       nameGame=nombre;
       guesses= new List<int>();
       AIGuesses= new List<int>();
    }
    public int GetLastGuess(){
      int lastNumber= guesses.LastOrDefault();
      return lastNumber;
    }
    public void AddListGuess(int prediction){
      guesses.Add(prediction);
    }
    public int GetLastAIGuess(){
      return AIGuesses.LastOrDefault();
    }
    public void AddListAiGuess(int prediction){
      AIGuesses.Add(prediction);
    }
    public abstract void MakeGuess();
}