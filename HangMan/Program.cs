Console.WriteLine("Welcome to HangMan Game");
Console.WriteLine("-----------------------");

//Console.WriteLine("Write a word and let other gissing it: ");
//char input = Console.ReadKey().KeyChar;


var trying = 5;

string[] vs = new string[] { "S", "i", "m", "o", "n" };

var input = Console.ReadLine();
string[] vs2 = new string[1];
vs2[0] = input;

for (int i = 0; i < vs.Length; i++)
{
    for (int j = 0; j < vs.Length ; j++)
    {
        
        if (vs2[i] == vs[j])
        {
            Console.Write(vs2[i]); 
        }
        else
        {
            Console.Write("_" + " ");
        **
    }
  
}



/*idea
//var input = Console.ReadLine().ToCharArray();
//var input2 = Console.ReadLine();
//var conv = input2.ToCharArray();

for (int i = trying; i > 0; i--)
{
    if (string.IsNullOrEmpty(input2)) ;
}

foreach (var item in input)
{
    Console.WriteLine(item);
}

Console.WriteLine("its time to guess\n");

if (input[0] == input2[0])
{
    Console.WriteLine(input[0]);
}

for (int i = 0; i < input.Length; i++)
{
    for (int j = 0; j < input2.Length; j++)
    {
        if (input[i] == input[j])
        {
            Console.WriteLine(input[i]);
        }
    }
}
end idea */

///extra code 
//for (int i = 0; i < input2.Length; i++)
//{
//    if (conv == input2)
//    {
//        Console.WriteLine("Do gissat ordet");
//    }
//}


//if (input2.Contains( test))
//{
//    Console.WriteLine("lets try");
//}


//for (int i = 0; i < wordList[0].Length; i++)
//{
//    Console.Write("_" + " ");

//}


//string[] vs = new string[] { "S", "i", "m", "o", "n" };

//Console.WriteLine("write a letter to guess");
//var input = Console.ReadLine();

//foreach (var item in vs)
//{
//    if (item == input)
//    {
//        Console.WriteLine(item);
//        break;
//    }
//    else
//    {
//        Console.WriteLine("it was wrong letter");
//    }
//}