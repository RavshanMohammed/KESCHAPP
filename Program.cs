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
System.Console.WriteLine($"You are older than KESCHA {age > keschaAge}");
System.Console.WriteLine($"You are older or equal than KESCHA {age >= keschaAge}");
System.Console.WriteLine($"You are younger than KESCHA {age < keschaAge}");
System.Console.WriteLine($"You are younger or equal than KESCHA {age <= keschaAge}");
System.Console.WriteLine($"You are equal than KESCHA {age == keschaAge}");
System.Console.WriteLine($"You are equal or unequal than KESCHA {age != keschaAge}");









