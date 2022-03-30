Console.WriteLine("vad heter du?");
string name = Console.ReadLine();

Console.WriteLine("Hur gammal är du");
int age = int.Parse(Console.ReadLine());


Console.WriteLine("har du ett husdjur?");
string animal = Console.ReadLine();



if (animal  == "ja") 
{
    Console.WriteLine("hur gammal är den?");
    int animal_age = int.Parse(Console.ReadLine());
    int different_age = age - animal_age;

    Console.WriteLine("Vad heter den?");
    string animal_name = Console.ReadLine();
    Console.WriteLine($"{name} du var alltså {different_age} år gammal när ditt husdjur {animal_name} föddes.");
        }
else
{
    Console.WriteLine($"vad synd {name}!");
}

