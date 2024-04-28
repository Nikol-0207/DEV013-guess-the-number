class Program
{
    static void Main()
    {
        Console.WriteLine("ʕ•́ᴥ•̀ʔっ");
        Console.Write("Ingresa tu nombre: ");
        string? name = Console.ReadLine();
        
        if (string.IsNullOrEmpty(name)){
           Console.WriteLine("Escribe correctamente el nombre del jugador");
        }else{
          Game Game= new Game(name);
          Game.start_game(); 
          Game.winnerGame(); 
        }
      
    }
   
}