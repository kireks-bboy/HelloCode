Console.Write("What's your name?: ");
string username = Console.ReadLine();

if(username.ToLower() == "kirill")
{
  Console.WriteLine("Hi Bro! Nice to meet you!");
}
else
{
  Console.Write("Hello! What do you want? ");
  Console.WriteLine(username);
  }
