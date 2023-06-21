// See https://aka.ms/new-console-template for more information
int num;
Console.WriteLine("Enter Number");
num=Convert.ToInt32(Console.ReadLine());

String result = (num >= 0) ? "Postive" : "Negative";
Console.WriteLine(result);
