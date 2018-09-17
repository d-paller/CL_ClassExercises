Read  all the instructions before beginning.

1. Create  a new console application. Name it something descriptive so you will know what  it is later down the road.
2. Create two classes by right-clicking on the project  (not the solution) and click "add". Choose class from the list of  options. One class will inherit from the other, so make it logical. 
    - Example names would be: Animal and Cat, Vehicle and truck, Food and Pizza, Plant and Flower.
3. Add at least one property to each. These should be  things that describe the object. 
    - Example properties could be: Food has a Calorie property and  Pizza has a SlicesOfPepperoni property.
    - Properties  generally go at the top of the class.
    - Every  property has four parts: `<Access modifier> <Type> <Name>  <getter and setter>`
    - Example:  `public int NumberOfEyes { get; set; }`
4. Add at least one method to each class. These should  be actions; things the object does. For example: Animal has a Eat() method and  Cat has a Pur() method.
    - Public  methods generally go in the middle of the class and private methods at the  bottom.
    - Methods  have four parts `<Access modifier> <return type> <name>  (<parameters/arguments>) { <What your method does goes in here>}`
    - Example  (no return value): `public void Bark() { Console.WriteLine(“WOOF!”); }`
    - Example  (string return type): `public string Bark() { return “WOOF!”; }`
5. Make a class inherit from the other. Again, make  sure it’s logical. Cat should inherit from Animal, not the other way around.
    - The  syntax for this is: Cat : Animal
    - After  that, Cat will have everything from Animal but Animal will not have anything  from Cat.
6. In your main method (in your program class),  instantiate (make a new object of) the child class (the class that is  inheriting from the other class).
    - Variables  have two parts: `<Type> <name>`
    - To  give your variable a value (instantiate it) you must set it equal to a new type  of your variable: `<Type> <name> = new <Type>();`
    - For  example: `Truck Silverado = new Truck();`
7. Set the object’s properties (give them values).
    - The  “Dot operator” allows you to access members of your class (methods and  properties).
    - To  set something, simply “navigate” to the property and set it equal to something.
    - For  example: `Truck.Engine = “V8 Gas”;`
8. Now output the objects property values in the  console.
    - Use  `Console.WriteLine();`
    - Hint:  the shortcut (code snippet) for that is cw + tab + tab
9. Execute the objects methods if they have a  console.writeLine() in them or output the method's return values if it returns  something.
    - For  example (this has methods that do not return anything): `Bark(); // Output will  be “WOOF!”`
    - Example:  (this method returns a string): `Console.WriteLine(Bark()); // Output will also  be “WOOF!”`
