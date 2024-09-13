using exVector;

Console.Write("How many rooms will be rented? ");
Console.WriteLine();

int n = int.Parse(Console.ReadLine());

Rent[] vector  = new Rent[10];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Rent #" + (i+1) + ": ");
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Room: ");
    int room = int.Parse(Console.ReadLine());
    Console.WriteLine();

    vector[room] = new Rent{Name = name, Email = email, Room = room};
}

Console.WriteLine("Busy rooms: ");

for(int i = 0; i < 10; i++)
{
    if (vector[i] != null)
    {
        Console.WriteLine(vector[i]);
    }
}