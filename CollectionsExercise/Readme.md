# Description 
The purpose of this exercise is to give experience using arrays.  Most real-world applications will not require this level of sophistication as all of these functions are already implimented for you.
If you need a list, use the built in Collections List<>.

# Exercise 
1. Create a new console app.
2. Add a class to your project called "MyList".
	- Right click on your project > add > class
3. In your class, create a **private** variable of type string array
	- An array type looks like Type[].  So a string array would be string[]
	- Call it data and since it's a private class-wide variable, make sure it has an underscore in front of the name
4. Add a constructor to your class and have it take one integer parameter called 'listSize'
	- Remember: a constructor is like a method except that it _must_ be the name of your class.
5. In the constructor, insantiate your array using the integer that was passed into the constructor.
	- Remember: to instantiate something you need to use the 'new' keyword.
	- With an array, to designate the size of it, you put an integer value in the brackets after the type of array
6. Create a new public method in your class.  Call it "Add".
	- It will return a boolean (so type: bool) and it will take one string parameter.
7. In this method, we will need to iterate over the array to find the first free spot to add our value to
	- Create a while loop inside of the method.
		- **All** loops have three parts. Memorize these!  
			- Initial condition
			- Test in condition
			- Change in condition
		- So first: create and integer called "i" and set it to 0.  This is the Initial Condition
		- Create a while loop and add this inside: `string.IsNullOrWhiteSpace(_data[i])`  This is the Test in Condition
			- This is checking to see if the string is empty ("") or if it has the value of null.  If it meets those requirements, it will return true.
			- So we want to find the first element that _is null_, so we will need to flip that boolean value.  Add a `!` in front of the string.IsNul....
			- That will now read "while the array slot is not null or empty".  That means we will break out of the loop when the slot is empty.
		- Inside of the loop, simply increment the counter variable: `i++` or `i = i + 1`.  This is the change in Condition
		- We have to do one more thing before we move on.  What will happen if the list is full?
			- The loop will try to index something that doesn't exist which will cause a runtime error.
			- Add an additional condition to the while loop: `&& i < _data.Length`
			- Now the loop will stop when we reach an empty space or when we reach the end of the list.
		- Finally, we will add an if else statement.  The condition will be if the counter variable _is not_ the same number as the data.length.
			- Add that condition to the if statement
			- Inside of the if block, we can finally add the value to the array.  `_data[i] = value;`
			- After adding the value, return true.
			- In the else, return false.  That will mean the item was not added to the list.
8. The next method will be easier.  We will add a Get Method.
	- Make it return a string.
	- Make it take an integer called i
	- Inside of the method, we will check to make sure the i isn't out of bounds (not larger than the list)
		- `if (i < _data.Length)`
		- Inside of that if, return the string at the location requested: `return _data[i]`
		- Add an else statment and make it return false
9. Finally we are going to _override_ the ToString method of our list class.
	- Add an override method called ToString().  This will return a string and take no arguments
	- To override a method put the word `override` in between the access modifier and the return type.
	- Create a local variable of type string.  This will be the string that you will store your list in.
	- After the variable, add a while loop.
		- Remember to add all three parts!
		- The test in condition here will be the same as before: the item at that point in the array is not null and you haven't reached the end of the array
	- Inside of the while loop, before the change in condition, add the item from the array to the string variable.
	- After the loop, return the string value.
10.  Finally test your List out
	- In your main method, create a new instance of your list.
	- Add some strings to your list
	- Print out one item from the list.
	- Print out everything from your list using the ToString method
	- Run your program.  You may have errors, so don't worry!
		- If your check for `i < _data.Length` came after your null check, you will get an 'out of bounds exception'.
		- To fix this, simply reverse the order of the conditions in the while loop; the `i < _data.Length` should come _before_ the null check.
		- Run again and you should be good to go!


# Bonus

Add a contains method.
	- Here is the method stub (There *are things missing*): 
	`
	public int Contains(string value) 
	{ 
		bool found = false;
		// Loop through the list until the end or the value is found
		while ()
		{
			// If equal, set found to true

			// Otherwise, increment the counter

		}

		// If found, return the location it was found

		// If not, return a negative number
					
	}
	`

There are countless other things to add: Remove, Resize, Clear, AddRange, and Length just to name a few!
