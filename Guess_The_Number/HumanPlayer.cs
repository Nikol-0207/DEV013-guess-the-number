using System;
public class HumanPlayer : Player{
     public HumanPlayer(string name) : base(name) {}
    public override void MakeGuess()
    {
        bool isValid= true; 
        while(isValid){
        Console.WriteLine("--Round: Player1---");
        Console.Write("Escribe un número:");
        string? input= Console.ReadLine();
        if (int.TryParse(input, out int guess)){
         AddListGuess(guess);
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