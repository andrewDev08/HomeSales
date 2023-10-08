using System;
//20231008_AndrewHorton_Exercise4.2
class Program {
  public static void Main (string[] args) {
    char initialValue = 'a';
    int saleValue;
    int dTotalSales = 0;
    int eTotalSales = 0;
    int fTotalSales = 0;
    int goodValue = 0;
    int grandTotal = 0;
        
    while ((initialValue != 'Z') && (initialValue != 'z'))
    {
      Console.WriteLine("salesperson:");
      var initialInput = Console.ReadLine();
      
      if (char.TryParse(initialInput, out initialValue))
      {
          goodValue = 0; 
          switch(initialValue)
          {
            case 'D':
            case 'd':
              goodValue = 1; 
              //Console.WriteLine("D");
              break;
            case 'E':
            case 'e':
              goodValue = 1; 
              //Console.WriteLine("E");
              break;
            case 'F':
            case 'f':
              goodValue = 1; 
              //Console.WriteLine("f");
              break;
            case 'z':
            case 'Z':
              //Console.WriteLine("z");
              break;
            default:
              Console.WriteLine("Error, invalid salesperson selected, please try again");
              break;
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
  
        switch(initialValue)
        {
          case 'D':
            dTotalSales = dTotalSales + saleValue;
            break;
          case 'd':
            dTotalSales = dTotalSales + saleValue;
            break;
          case 'E':
            eTotalSales = eTotalSales + saleValue;
            break;
          case 'e':
            eTotalSales = eTotalSales + saleValue;
            break;
          case 'f':
            fTotalSales = fTotalSales + saleValue;
            break;
          case 'F':
            fTotalSales = fTotalSales + saleValue;
            break;
        }
      }  
    }
    grandTotal = dTotalSales + eTotalSales + fTotalSales;
    if(dTotalSales > eTotalSales && dTotalSales > fTotalSales)
    {  
      Console.WriteLine("salesperson D: {0}", dTotalSales);
      Console.WriteLine("salesperson E: {0}", eTotalSales);
      Console.WriteLine("salesperson F: {0}", fTotalSales);
      Console.WriteLine("Grand Total: {0}", grandTotal);
      Console.WriteLine("Highest Sale: D");
    }
    if(eTotalSales > dTotalSales && eTotalSales > fTotalSales)
    {
      Console.WriteLine("salesperson D: {0}", dTotalSales);
      Console.WriteLine("salesperson E: {0}", eTotalSales);
      Console.WriteLine("salesperson F: {0}", fTotalSales);
      Console.WriteLine("Grand Total: {0}", grandTotal);
      Console.WriteLine("Highest Sale: E");
    }
    if(fTotalSales > eTotalSales && fTotalSales > dTotalSales)
    {
      Console.WriteLine("salesperson D: {0}", dTotalSales);
      Console.WriteLine("salesperson E: {0}", eTotalSales);
      Console.WriteLine("salesperson F: {0}", fTotalSales);
      Console.WriteLine("Grand Total: {0}", grandTotal);
      Console.WriteLine("Highest Sale: F");
    }
  }
}