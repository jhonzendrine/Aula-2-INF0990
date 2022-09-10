
public class ItemMap
{
   protected int x;
   protected int y;
}

public class Empty : ItemMap
{
    public override string ToString()
    {
        return "-- ";
    }
}

public class Robo : ItemMap
{

    public int x {get; set;}
    public int y {get; set;}
    
    public Robo(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public (int, int) MoveSouth()
    {
        
        int y_old = y;
        y = y+1;

        return (y_old, y);
    }

    public override string ToString()
    {
        return "ME ";
    }
}

public class Jewel : ItemMap
{
 
}

public class JewelRed : Jewel
{


    public override string ToString()
    {
        return "JR ";
    }

}

public class JewelGreen : Jewel
{
 
}

// JewelBlue


public class Obstacle : ItemMap
{
 
}


public class Tree : Obstacle
{
 
}

// Water








public class Map
{

    private ItemMap[,] matrix = new ItemMap[10,10];
    private Robo robo = new Robo(0, 0);

    public Map()
    {

        for(int i = 0; i < matrix.GetLength(0); i++){
            for(int j = 0; j < matrix.GetLength(1); j++){
                matrix[i,j] = new Empty();
            }

        }

        matrix[robo.x, robo.y] = robo;

        JewelRed jr1 = new JewelRed();
        matrix[1, 9] = jr1;

        // repete para todos os outros itens

    }

    public void Print()
    {
         for(int i = 0; i < matrix.GetLength(0); i++){
            for(int j = 0; j < matrix.GetLength(1); j++){
                Console.Write(matrix[i,j]);
            }
            Console.Write("\n");
        }
    }


    public void MoveSouth()
    {
        
        (int y_old, int y) = robo.MoveSouth();

        matrix[robo.x, y_old] = new Empty();
        matrix[robo.x, y] = robo;

    }

}