# Exercise
1. Create a new project
	- Remember to give it a meaningful name
2. Add a class to your project called "FileParser".  This will act as your "data layer"
3. Add an interface to your project.  Call it IFileParser
	- Add a method signature to your interface and call it "Read".  It will return an array of strings and take one string parameter called "path"
4. Make your FileParser class impliment IFileParser (you will get errors if you do this properly)
	- Add the Read method to your class.
5. Inside of the read method add two local variable.  One will be an int called "arraySize", the other a string array called "array"
	- These don't have to be asigned to anthing right now, just declared.
6. After the variables, create a new StreamReader.
	- You will have to bring in the System.IO namespace for this.
	- The constructor takes the path varibale passed in
7. Next, you will use the readers "ReadLine" method to read in the size of the array and assign it to arraySize
	- The files first line is a number which is the number of cities in the file.
	- Since the ReadLine returns a string, you will need to convert that to a int using int.Parse()
8. Initialize your array with the arraySize
9. Create a for loop to iterate over the length of the array
10. Inside of the loop, use the readers ReadLine() method to add values to the array
	- Use the i variable to index your array
11. After the loop, close and dispose your reader in that order.
	- The reader has methods to do this for you.
12. Return the array.
13. In your program class, add a new variable of type IFileParser
14. New up your variable using FileParser.
	- You can't create a concrete instance of IFileParser because it is an interface.  But since FileParser is an IFileParser, you can have a variable of type IFileParser and use the concrete implimentation to create a concrete instance.
	- `IFileParser parser = new FileParser();`
15. Use the parsers Read method.
	- Since it returns an array, be sure to have a variable to 'catch' the value (assign it to something).
	- Pass in the path to your file.
		- You can give it a relative path: ../../../data.txt
		- The ../ means "up one folder"
16. Loop through the array and print out all of the values in the array
17. Run the program.
	- You may get an error if you don't input your path correctly.  Use the exception message it gives you to figure out where you need to navigate to.

# Bonus
- Add more files to your data file. Be sure to change the number at the top.
	- Does your parser still work and print everything out?

- See if you can add cities to the file from the command line.
	- You would need to use StreamWriter and figure out how to "append" instead of "overwrite"
	- You will need to add a new method to FileParser (which means you will need to add one to the interface as well)
