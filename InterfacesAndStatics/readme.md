Exercise
==================
Interfaces
-------
1. Create a new console app project (.NET Framework, not core)
	- Don't forget to give it a meaningful name
2. Create a class
	- right click on projeect (not solution) > add > class
	- Give it a meaningful name
3. Now add an interface
	- right click on project > add > new item > select interface from options
	- Give it the same name as your class but add a captial 'i' infront of it.  
	- Example- class name: <code>Dog</code>; interface name: <code>IDog</code>
4. An interface is a contract.  It details what a class must have.  The sytanx to add methods to an 
interface is different than a class.  A method in an interface has no access modifier (public,
private, etc...) and no body (code that is actually run).  The class has the *implimentation* for
the interface.
	- Method in a class: <code>public string GetName(int id) { return "Billy Joe"; } </code>
	- Method in an interface: <code>string GetName(int id); </code>
5. Add a method to your interface
   - Something simple like if it's animal, make a run or eat method, something all animals do.
   - An interface could look something like this:
```
	 public interface IDog 
		{
			void Run(int speed);
			void Bark();
		}
```
6. Now, have your class *impliment* the interface.  You do this using the colon operator.  
This would look like <code>public class Dog : IDog </code>
7. You are going to get a build error because the class doesn't impliment the interface.  C# is
designed this way.
8. Now add the method to your *class*.  It needs to have the same method *signature* 
   and return type as the interface.
   - A method signature is the the name of the method and the number and type of 
	 paramaters it takes.
9. In your main program, create a new instance of your object.
	- Example: <code>Dog puppy = new Dog();</code>
10.  Since your class impliments the interface, that object is now a type of that object.
	 - In the dog example, Dog is a type of IDog.  
	 - To break this down even further, we could make a GoldenRetriever class that impliments
	 IDog, so GoldenRetriever is a type of IDog.
11. To show this, we can change the type of your object to your interface.
	- Example: <code>Dog puppy = new Dog();</code> can be changed to <code>IDog puppy = new Dog();</code>

Static Keyword
------
1. Create a new class.  It doesn't have to be related to the previous section at all.
2. Add the static keyword before 'class'
3. Give it at least one property and one method.
4. Now go to your main method and create a new instance of your class.
   - You should get an error.
   - This is because all static classes are created at runtime and cannot be instantiated. 
   There is only one instance of the class from the start of the program until it stops.
5. To use the static class, simply use the class name.
	- Example:
```
public static class Car { 
	public static int NumberOfDoors { get; set; }
	public static void Drive()
	{
		Console.Write("Car is driving");
	}
}

public Main() {
	Car.NumberOfDoors = 4;
	Car.Drive();
	Car mustang = new Car(); // This will error
}
```
