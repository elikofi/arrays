using System.Collections.Generic;

/* creating an array of type string */

//using System.Linq;

//string[] actors = { "Bran", "Tyrion", "Snow", "Arya", "Rob" };
//Array.Sort(actors);

//foreach (var item in actors)
//{

//    Console.WriteLine(item);
//}


//Console.ReadLine();  






/* second example */


//string[] movies = { "Lord of the Rings", "Endgame", "Titanic", "Avatar"};

//for (int i = 0; i < movies.Length; i++)
//{
//    //ranking them
//    int rank = i + 1;

//    Console.WriteLine(rank + ". " + movies[i]);
//}
//Console.ReadKey();







//string[] movies = new string[4];

//Console.WriteLine("Type in four movies.");

//for (int i = 0; i < movies.Length; i++)
//{
//    movies[i] = Console.ReadLine();
//}

////using array sort to sort through them alphabetically
//Array.Sort(movies);

//Console.WriteLine("\nHere are your movies:");
//for (int i = 0; i < movies.Length; i++)
//{
//    Console.WriteLine(movies[i]);
//}
////using find method to find a particular name in the movies
//string final = Array.Find(movies, x => x.StartsWith("T"));
//Console.WriteLine($"\n{final}");
//Console.ReadLine();







List<string> shopingList = new List<string>();

shopingList.Add("Drinks");
shopingList.Add("Milk");
shopingList.Add("Eggs");

shopingList.RemoveAt(0);

for (int i = 0; i < shopingList.Count; i++)
{
    Console.WriteLine(shopingList[i]);
}


Console.ReadLine();