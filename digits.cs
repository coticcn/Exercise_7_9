
/* The program will group the numbers entered by the user by number of 
 * digits and will say how many of each there are. It ends when the user 
 * writes "end".*/
 
 
using System;

class digits
{
		static void Main()
		{
			
			int oneDigit = 0, twoDigit = 0, threeDigit = 0, 
			moreThanThreeDigit = 0;
			string userTyping;											
			
			Console.WriteLine("Insert a number: ");
			userTyping = Console.ReadLine();
	
    		while(userTyping!="end"){
				int input = Convert.ToInt32(userTyping);
				if ( input != 0 )
				{
						if (input / 10 == 0)
						oneDigit ++;  
						else if (input / 100 == 0)
						twoDigit ++;  
						else if (input / 1000 == 0)
						threeDigit ++;  
						else
						moreThanThreeDigit++;  
				}
				Console.WriteLine("Insert another number: ");
				userTyping = Console.ReadLine();
			}

			Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", 
			oneDigit, twoDigit, threeDigit, moreThanThreeDigit); 


		}
}
