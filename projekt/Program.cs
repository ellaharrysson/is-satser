Console.WriteLine("Är det fint väder?");
string s = Console.ReadLine();
bool svar = s == "ja";
bool svar1 = s =="Ja";
bool svar2 = s =="nej";
bool svar3 = s =="Nej";

if(svar)
{
    Console.WriteLine("VI går på picknick!");
}
else if(svar1)
{
    Console.WriteLine("Vi går på picknick!");
}
else if(svar2)
{
    Console.WriteLine("Vi stannar inne och läser.");
}
else if(svar3)
{
    Console.WriteLine("Vi stannar inne och läser.");
}
else
{
    Console.WriteLine("Jag föstår inte.");
}












