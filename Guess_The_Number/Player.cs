
 public class Player{
     public string nameGame {get ; private set; }
     private int numberIntent ;
    public Player(string nombre){
       nameGame=nombre;
       numberIntent=0;
    }
    public int GetLastGuess(){
      return numberIntent;
    }
    public void MakeGuess(){
      bool isValid= true; 
       while(isValid){
        Console.Write("Escribe un número: ");
        string? input= Console.ReadLine();
        if (int.TryParse(input, out int guess)){
         numberIntent=guess;
         isValid=false;
        }else{
         Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
         Console.WriteLine("████▌▄▌▄▐▐▌█████");
         Console.WriteLine("████▌▄▌▄▐▐▌▀████");
         Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
         Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
        }

       }
    }
}