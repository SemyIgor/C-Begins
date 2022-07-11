//                Variant I
// =======================================================
Console.Write("Введите первое число: ");
string? firstNumberStr = Console.ReadLine();

Console.Write("Введите второе число: ");
string? secondNumberStr = Console.ReadLine();

if((firstNumberStr != null) && (secondNumberStr != null))
{
   int firstNumber = int.Parse(firstNumberStr);
   int secondNumber = int.Parse(secondNumberStr);

   if(firstNumber < secondNumber)
   {
      Console.WriteLine("max = " + secondNumber);
   }
   else
   {
      Console.WriteLine("max = " + firstNumber);
      
   }
}
// -------------------------------------------------------
//                End Variant I

