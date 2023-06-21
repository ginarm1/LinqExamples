using LinqExample;

List<Person> people = new()
{
    new Person() { Id = 1, FirstName = "Jonas", LastName = "Jonaitis", Birthday = Convert.ToDateTime("1989-01-02") },
    new Person() { Id = 2, FirstName = "Darius", LastName = "Daraitis", Birthday = Convert.ToDateTime("1999-02-03") },
    new Person() { Id = 3, FirstName = "Lukas", LastName = "Lukaitis", Birthday = Convert.ToDateTime("2002-11-06") },
    new Person() { Id = 4, FirstName = "Liepa", LastName = "Liepaitė", Birthday = Convert.ToDateTime("1995-03-03") },
    new Person() { Id = 5, FirstName = "Gustė", LastName = "Gustaitė", Birthday = Convert.ToDateTime("2002-11-06") },
    new Person() { Id = 5, FirstName = "Dalia", LastName = "Dalaitė", Birthday = Convert.ToDateTime("1999-10-10") },
};

foreach (var person in people)
{
    Console.WriteLine($"{ person.FullName }  ({person.Birthday.ToShortDateString()})");
}


// LINQ Foreach ->
// ----------------------

//Console.WriteLine("\n-------------");
//Console.WriteLine("LINQ Foreach:");
//Console.WriteLine("-------------\n");

//people.ForEach(person => Console.WriteLine($"{person.FullName}  ({person.Birthday.ToShortDateString()})"));

//Console.ReadLine();


// LINQ Add and order by ->
// ----------------------

//Console.WriteLine("-------------\n");
//Console.WriteLine("LINQ Add:");
//Console.WriteLine("-------------\n");

//Person newPerson = new() { Id = 6, FirstName = "Simas", LastName = "Simaitis", Birthday = Convert.ToDateTime("1970-01-02") };

//people.Add(newPerson);

//people.ForEach(person => Console.WriteLine($"{person.FullName}  ({person.Birthday.ToShortDateString()})"));

//Console.WriteLine("-------------\n");

//Console.ReadLine();

//people.OrderBy(person => person.Birthday).ThenBy(p => p.FullName)
//    .ToList()
//    .ForEach(person => Console.WriteLine($"{person.FullName}  ({person.Birthday.ToShortDateString()})"));

//Console.WriteLine("-------------\n");
//Console.WriteLine("LINQ Order descending:");
//Console.WriteLine("-------------\n");

//people.OrderByDescending(person => person.Birthday).ThenBy(p => p.FullName)
//    .ToList()
//    .ForEach(person => Console.WriteLine($"{person.FullName}  ({person.Birthday.ToShortDateString()})"));

//Console.ReadLine();

// LINQ Where ->

Console.WriteLine("-------------\n");
Console.WriteLine("LINQ Where:");
Console.WriteLine("-------------\n");

people.Where(x => x.Id > 2 && x.FirstName.ToLower().StartsWith("l") ).ToList()
    .ForEach(person => Console.WriteLine($"{person.FullName}  ({person.Birthday.ToShortDateString()})"));


Console.WriteLine("-------------\n");
Console.WriteLine("LINQ First or default:");
Console.WriteLine("-------------\n");

var person2 = people.First(x => x.Id > 2 && x.FirstName.ToLower().StartsWith("l"));
Console.WriteLine($"{person2.FullName}  ({person2.Birthday.ToShortDateString()})");

Console.WriteLine("-------------\n");

var person3 = people.FirstOrDefault(x => x.Id > 2 && x.FirstName.ToLower().StartsWith("l"));
Console.WriteLine($"{person3?.FullName}  ({person3?.Birthday.ToShortDateString()})");

Console.ReadLine();


// LINQ Sum ->
// ----------------------

//Console.WriteLine("-------------\n");
//Console.WriteLine("LINQ Sum:");
//Console.WriteLine("-------------\nTotal ID's:");

//int idTotal = people.Sum(x => x.Id);
//Console.WriteLine(idTotal);


// BONUS
// ---------------
// from .NET 6 Chunck

//Console.WriteLine("-------------\n");
//Console.WriteLine("LINQ Chunk:");
//Console.WriteLine("-------------\n");

//var names = new[] { "Nick", "Mike", "John", "Leyla", "Maironis" };

//foreach (var chunckedNames in names.Chunk(3))
//{
//    foreach (var name in chunckedNames)
//    {
//        Console.WriteLine(name);
//    }
//    Console.WriteLine("------------");
//}


// from .NET 7 Three way zipping

//Console.WriteLine("\n3 way zipping:");
//Console.WriteLine("-------------\n");

var firstNames = new[] { "Jonas", "Darius", "Gustė", "Dalia"};

var lastNames = new[] { "Jonaitis", "Daraitis", "Gustaitė", "Dalaitė" };

var yearsOfExperience = new[] { 5, 2, 1, 6 };

//IEnumerable<(string, string, int)> zippedList = firstNames.Zip(lastNames, yearsOfExperience);

//foreach (var person in zippedList)
//{
//    Console.WriteLine("Person: " + person + " | only name: " + person.Item1);
//}

//Console.WriteLine("-------------\n");


// from .NET 7 MaxBy, MinBy
// ----------------------

//var oldWayHighestId = people.OrderByDescending(x => x.Id).FirstOrDefault()?.Id;
//var highestId = people.MaxBy(x => x.Id)?.Id;

//Console.WriteLine("Old way| Highest ID: " + oldWayHighestId);
//Console.WriteLine("Highest ID: " + highestId);

//Console.WriteLine("-------------\n");

//var oldWayLowestId = people.OrderBy(x => x.Id).FirstOrDefault()?.Id;
//var lowestId = people.MinBy(x => x.Id)?.Id;

//Console.WriteLine("Old way| Lowest ID: " + oldWayLowestId);
//Console.WriteLine("Lowest ID: " + lowestId);


// from .NET 7  ElementAt from the end of the list

//Console.WriteLine("Third person: " + firstNames.ElementAt(3));
//Console.WriteLine("Third person from the end: " + firstNames.ElementAt(^3));
