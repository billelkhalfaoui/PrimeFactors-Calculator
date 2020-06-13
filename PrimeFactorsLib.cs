using System;
using static System.Console;


namespace Packte
{
 public class CalculatorPrimeFactors
  {
    string Factors;
    public string GetPrimeFactor(int number )
  {
      if(number%2==0)
      {
        Factors =$"2,{GetPrimeFactor(number/2)}";
      }
      else if(number%3==0)
      {
        Factors =$"3,{GetPrimeFactor(number/3)}";
      }
      else if(number%5==0)
      {
        Factors =$"5,{GetPrimeFactor(number/5)}";
      }else if(number%7==0)
      {
        Factors =$"7,{GetPrimeFactor(number/7)}";
      }
      else if(number%11==0)
      {
        Factors =$"11,{GetPrimeFactor(number/11)}";
      }
      else if(number%13==0)
      {
        Factors =$"13,{GetPrimeFactor(number/13)}";
      }
      else if(number%17==0)
      {
        Factors =$"17,{GetPrimeFactor(number/17)}";
        }
      else if(number%19==0)
      {
        Factors =$"19,{GetPrimeFactor(number/19)}";
      }
      else if(number%23==0)
      {
        Factors =$"23,{GetPrimeFactor(number/23)}";
      }
      else if(number%29==0)
      {
        Factors =$"29,{GetPrimeFactor(number/29)}";
      }else if (number ==1)
      {
        Factors= "";
      }
      else 
      {
        Factors =($"{number}");
      }
    return Factors;
  }
      
  public void RunGetPrimeFactors()
  { 
    bool IsNumber;
    do{
    WriteLine("Enter a number betwen 0 and 1000");
    int Num;
    IsNumber = int.TryParse(ReadLine(),out Num);
    if (IsNumber)
    {
      WriteLine ($"Prime Factors of {Num} = ({ GetPrimeFactor(Num)})");
    }else{
      WriteLine("yor did not enter a valid number");
    }}while (IsNumber);
  }
  }
} 