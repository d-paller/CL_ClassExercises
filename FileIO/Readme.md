# Exercise
1. Add a class called FileUtility
	- Make sure that it's public
2. Add an Interface called IFileUtility
	- Make sure that it's public
3. In the git repository, go to the "Stubs" folder. 
	- There will be files named the same as yours but will have 'Stub' appended to the end.
	- Copy the contents of the _class_ and _interface_ into your class and interface
	- By contents I mean what's in the class and interface, not the interface and class themselves
4. The rest of the instructions are in these stubs

5. Once you finish adding everything to the program, run it.  To verify that you're printing out the correct data, find your file and check the contents

# Bonus
- Change the program to allow for the user to add multiple values.  Use the code snippet bellow to get you started
	- Store these values in a list.
	- Be sure to tell the user what value to enter to end input
`
List<string> values = ; // Finish me
string input = ; // Finish me
while (input != "end") 
{
	// Add code here
	// Make sure to add the change in condition.  Use the test of condition to know what to change
}
`

- Now make your write function accept a list instead of a string
- Inside of the write function, loop through your list and write to the file separate eah value in the list with a comma.
	- You can do this two ways:
	1. Loop through the list and create a string as you do so then write that single value to the file
	2. Loop through the list and write to the file directly as you loop
