
/*This program is going to tell us the average of the numbers who user 
introduce until user enters "end".*/


using System;

public class Average {

	public static void Main() {
		double total = 0, mark, counter = 0, average;
		string userTyping;
		
		Console.Write("Insert a mark: ");
		userTyping = Console.ReadLine();	
	
		while (userTyping != "end") {  
			mark = Convert.ToDouble(userTyping);
			counter++;   
			total += mark;  
			Console.Write("Insert a mark: ");
			userTyping = Console.ReadLine();
		}
		
		if (counter != 0) {
			average = total / counter;  
			Console.WriteLine("The average is {0}.",average);
		}
	}
}
