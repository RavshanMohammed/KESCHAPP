System.Console.WriteLine("Enter your name: ");

string name = Console.ReadLine();
string greeting = $"Hello {name} my name is Kescha(:";

System.Console.WriteLine(greeting);

System.Console.WriteLine("Enter your age: ");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Converting . . . ");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Successfully converted! {age}");
int keschaAge = 13;
int difference = age - keschaAge;
System.Console.WriteLine($"The gap is {difference}");









