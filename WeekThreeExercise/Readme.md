1. Create a new console app (don’t forget to give it a descriptive name!)
2.	Add a class to the project.  It can be anything you want.  For my examples, we will be using a Phone object.
a.	Right click on the project > add > class
b.	Make sure it is a public class
3.	Add some properties to the class.
a.	Make at least one of type string.
b.	Make at least one of type int.
c.	Make at least one of type double.
d.	Remember the four parts of a property:  Access modifier, type, name, getters and setters
4.	Instantiate an instance of your class in the Main method of the Program class.
a.	The three parts of this are: type name = new type();
5.	Start populating your classes properties using Console.ReadLine()
a.	Do the string property first.
b.	Your int and double properties will require conversion.
i.	Use int.Parse() for your int property
ii.	Use double.Parse() for your double property.
iii.	You can do this several ways:
1.	Use a variable to store your input
2.	Put your Console.Read() directly inside of the parse method.
3.	Do what makes most sense to you.
6.	Go back to your class and create a new method called “OutputToFile”
a.	The four parts of a method are: access modifier, type, name, arguments/parameters
7.	In your method, add a using statement
a.	Using() { }
8.	Inside of the using parenthesis create a new StremWriter object
a.	StreamWriter writer = new StreamWriter();
b.	Inside of the stremWriter’s constructure, add a path to your new file that you will create (it shouldn’t exist yet).
i.	It is a string value
ii.	An example would be “Phone.txt”
9.	In the using block, write your properties to the file
a.	Using the writers Write and WriteLine methods.  
b.	You can access the properties directly.
10.	Go back to the main method and call your new method right after you populate the last property.
11.	After you call your method, output a message to the console saying that the file has been created.
12.	Run the program
a.	Make sure to put the correct types in.  Don’t put a word for a number value etc…
13.	Now check your bin/debug folder for your file
a.	Right click on your project > open in file explorer
b.	Example file contents could look like: 
apple iPhone
=========================
Screen Size: 4.5
Internal Storage Size: 4.5

14.	Now run your program again.  Put wrong values for each input.  Put a word for a number.
a.	You should get an error.  Go and see if you file updated.
15.	Your file should not have been updated because the flow of your program was interrupted by an exception. 
BONUS
See if you can get your program to finish even if you input bad data
