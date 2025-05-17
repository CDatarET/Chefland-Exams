using System;

public class Test
{
	public static void Main()
	{
		int cases = Convert.ToInt32(Console.ReadLine());
		for(int c = 0; c < cases; c++){
		    string[] inputs = Console.ReadLine().Split();
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            int z = int.Parse(inputs[2]);
            
            float tot = x*y;
            tot = (tot/10)*5;
            
            if(z > tot){
                Console.WriteLine("yes");
            }
            else{
                Console.WriteLine("no");
            }
		}
	}
}
