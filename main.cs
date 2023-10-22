using System;
//20231022_AndrewHorton_Exercise5.1
class Program {
  public static void Main (string[] args) {
    char initialValue = 'a';
    int saleValue;
    int goodValue = 0;
    double grandTotal = 0;

    string[] salesPersonNames = new string[3] { "Danielle", "Edward", "Francis"};
    char[] allowedInitials = new char[6] {'D','d','E','e','F','f'};
    double[] accumulatedSalesValues = new double[3] { 0, 0, 0};
        
    while ((initialValue != 'Z') && (initialValue != 'z'))
    {
      Console.WriteLine("salesperson:");
      var initialInput = Console.ReadLine();
      
      if (char.TryParse(initialInput, out initialValue))
      {
          goodValue = 0; 
          if((initialValue == allowedInitials[0])||(initialValue == allowedInitials[1]))
          {  
              goodValue = 1; 
          }
          else if((initialValue == allowedInitials[2])||(initialValue == allowedInitials[3]))
          {
            goodValue = 1; 

          }
          else if((initialValue == allowedInitials[4])||(initialValue == allowedInitials[5]))
          {
            goodValue = 1; 
          }
          else if((initialValue == 'z')||(initialValue == 'Z')) 
          {
          }
          else
          {
            Console.WriteLine("Error, invalid salesperson selected, please try again" );
          }
      }
      else 
      {
        Console.WriteLine("Error, invalid salesperson selected, please try again" );
      } 
      
    
      if (goodValue != 0)
      {
        Console.WriteLine("sale:");
        var saleInput = Console.ReadLine();
    
        if (int.TryParse(saleInput, out saleValue)){}
        else {
          Console.WriteLine("Error Please enter a number" );
        }

        if((initialValue == allowedInitials[0])||(initialValue == allowedInitials[1]))
        {
          accumulatedSalesValues[0] = accumulatedSalesValues[0] + saleValue;
        }
        if((initialValue == allowedInitials[2])||(initialValue == allowedInitials[3]))
        {
          accumulatedSalesValues[1] = accumulatedSalesValues[1] + saleValue;
        }
        if((initialValue == allowedInitials[4])||(initialValue == allowedInitials[5]))
        {
          accumulatedSalesValues[2] = accumulatedSalesValues[2] + saleValue;
        }
      }  
    }
    grandTotal = accumulatedSalesValues[0] + accumulatedSalesValues[1] + accumulatedSalesValues[2];
    if(accumulatedSalesValues[0] > accumulatedSalesValues[1] && accumulatedSalesValues[0] > accumulatedSalesValues[2])
    {  
      Console.WriteLine("{0}: {1}", salesPersonNames[0], accumulatedSalesValues[0]);
      Console.WriteLine("{0}: {1}", salesPersonNames[1], accumulatedSalesValues[1]);
      Console.WriteLine("{0}: {1}", salesPersonNames[2], accumulatedSalesValues[2]);
      Console.WriteLine("Grand Total: {0}", grandTotal);
      Console.WriteLine("Highest Sale: D");
    }
    if(accumulatedSalesValues[1] > accumulatedSalesValues[0] && accumulatedSalesValues[1] > accumulatedSalesValues[2])
    {
      Console.WriteLine("{0}: {1}", salesPersonNames[0], accumulatedSalesValues[0]);
      Console.WriteLine("{0}: {1}", salesPersonNames[1], accumulatedSalesValues[1]);
      Console.WriteLine("{0}: {1}", salesPersonNames[2], accumulatedSalesValues[2]);
      Console.WriteLine("Grand Total: {0}", grandTotal);
      Console.WriteLine("Highest Sale: E");
    }
    if(accumulatedSalesValues[2] > accumulatedSalesValues[1] && accumulatedSalesValues[2] > accumulatedSalesValues[0])
    {
      Console.WriteLine("{0}: {1}", salesPersonNames[0], accumulatedSalesValues[0]);
      Console.WriteLine("{0}: {1}", salesPersonNames[1], accumulatedSalesValues[1]);
      Console.WriteLine("{0}: {1}", salesPersonNames[2], accumulatedSalesValues[2]);
      Console.WriteLine("Grand Total: {0}", grandTotal);
      Console.WriteLine("Highest Sale: F");
    }
  }
}