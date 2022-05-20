using System;

namespace session1
{
    class Program
    {
        static void Main(string[] args)
        {
          
  Console.WriteLine("your number");
  int m=Convert.ToInt32(Console.ReadLine());
  if(m%2==0)
{ Console.WriteLine("your number is even");
}
else{
    Console.WriteLine("is odd");
}
    DateTime localDate = DateTime.Now;
    Console.WriteLine(localDate.ToString());
    string TestStr = localDate.ToString().Substring(18,2);
    Console.WriteLine(TestStr);
if (TestStr=="PM")

{
    Console.WriteLine("shab bkheir");
}
else

{
    Console.WriteLine("rooz bkheir");
}
    
   
        }
    }
}