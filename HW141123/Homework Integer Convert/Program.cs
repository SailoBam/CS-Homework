using System.Runtime.InteropServices;

String input;
int i;

while (true) {
    Console.WriteLine("Entry an integer");
    input = Console.ReadLine();
    if(input=="exit") break;
        try {
        i = Convert.ToInt16(input);
        Console.WriteLine("You entered "+ i);
        } catch (Exception myExp) {
            Console.WriteLine("Could not convert the input to an integer");
        } 
}

Console.WriteLine("Done");