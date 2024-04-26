 public abstract class Player{
     public string nameGame {get ; private set; }
     public int numberIntent ;
     private List<int> guesses{get;set;}
    protected Player(string nombre){
       nameGame=nombre;
       numberIntent=0;
       guesses= new List<int>();
    }
    public int GetLastGuess(){
      int lastNumber= guesses.LastOrDefault();
      return lastNumber;
    }
    public void AddListGuess(int prediction){
      guesses.Add(prediction);
    }
    public abstract void MakeGuess();
}