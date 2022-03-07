using DataAccessLayerExample.BU;

Console.WriteLine("Data access layer example");

// Create data

List<Party> parties = new List<Party>();
parties = new List<Party>();

Party party = new Party("Rob's homewarming", "20-03-2022 20:00", "20-03-2022 23:00", 250);
party.AddGuest(new Guest("Rob", "01-01-1980"));
party.AddGuest(new Guest("Miel", "01-01-1980"));
party.AddGuest(new Guest("Bob", "01-01-1980"));

parties.Add(party);


// Show data

foreach (var p in parties)
{
    Console.WriteLine($"--------------------------");
    Console.WriteLine($"Party: {p.Name} (Budget: {p.Budget})");
    foreach (var g in p.Guests)
    {
        Console.WriteLine($"  Guest: {g.Name} {g.BirthDate}");
    }
    Console.WriteLine($"--------------------------");
}




