// See https://aka.ms/new-console-template for more information
/*
public class Map {
      
    public static void MapGame() {

  for (int i = 0; i < 10; i++) {

    for (int j = 0; j < 10; j++) {
      if ((i==1 && j==9)||(i==8 && j==8)){
        Console.Write("JR ");
      }
      else if((i==9 && j==1)||(i==7 && j==6)){
        Console.Write("JG ");
      }
      else if((i==0 && j==0)||(i==0 && j==0)){
        Console.Write("ME ");
      }
       else if((i==3 && j==4)||(i==2 && j==1)){
        Console.Write("JB ");
      }
      else if((i==5 && j==9)||(i==3 && j==9)||(i==8 && j==3)||(i==2 && j==5)||(i==1 && j==4)){
        Console.Write("$$ ");
      }
      else if((i==5 && j==0)||(i==5 && j==1)||(i==5 && j==2)||(i==5 && j==3)||(i==5 && j==4)||(i==5 && j==5)||(i==5 && j==6)){
        Console.Write("## ");
      }
      else
      Console.Write ("-- ");

    }
    Console.Write("\n");
  }

}
}*/

public class JewelCollector {

  public static void Main() {

      Map map = new Map();
  
      bool running = true;

      do {

          map.Print();
  
          Console.WriteLine("Enter the command: ");
          string command = Console.ReadLine();
  
          if (command.Equals("quit")) {
              running = false;
          } else if (command.Equals("w")) {
              
          } else if (command.Equals("a")) {
              
          } else if (command.Equals("s")) {
                map.MoveSouth();
          } else if (command.Equals("d")) {
          
          } else if (command.Equals("g")) {
              
          }
      } while (running);
  }
}
