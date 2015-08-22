# EpicU_JoeAlcala

Cheat Sheet
----------------------------------------------------------------------------------------------------------------------------------
Data Types (CS-ASP_007)
----------------------------------------------------------------------------------------------------------------------------------
Comments: // Single line ... /* Multiline 8?

String => alphanumeric ( defaults to "")
int => 2 billion to - 2 billion ( defaults to 0)
double => fractional value (defaults to 0.0)
bool => true or false (defaults to false)

More: http://is.gd/data_types

Data Type Conversion (CS-ASP_008)
--------------------------------------------------------------------------------------------------------------------------------
Implicit conversions - smaller type to larger type without data loss, "upcasting"

Explicit conversions - require developer intervention, possibility of data loss, "downcasting", either in the form of cast or using a helper method.

Casting numbers:
int myInteger = (int)myDouble;

Numbers to strings:
string myString = myInteger.ToString();

String to Numbers:
int myInteger = int.Parse(myString);

More: http://is.gd/datatype_conversion

arithmetic operators (CS-ASP_009)
----------------------------------------------------------------------------------------------------------------------------
= NOT equality, it's assignment

Math Operators: + - * /

Addition Assignment
total = total + 5;
total +=5;

Increment Operator: i++;
Decrement Operator: i--;

Beware of order of precedence (use parenthesis)
Beware of down casting (you'll lose precision)
Beware of Overflow (use bigger types)

to make overflow throw an exception:

checked
{
// some arithmetic operation
// that could potentially overflow
}

http://is.gd/operators

C# Syntax (CS-ASP_010)
--------------------------------------------
Operands - variable names, object / server control names, literals - "nouns" (you name these)

Operators - "verbs ... they act on operands.

http://is.gd/operators

Expressions- one or more operands and zero or more operators that evaluate to a single value

http://is.gd/expressions

Statements - a complete instruction - assignment of an expression to a variable, an increment/ decrement , etc.

http://is.gd.statement

Statements must end in a semi- colon ;
Whitespace is ignored (use for humans)

Conditional if ... else if ... else Statement (CS-ASP_011)
-----------------------------------------------------------
= Assignment
== Equality

if (a ==b)
{
//execute when the expression is true
}
else
{
//executes when the expression is false
}
... or ... evaluate other mutually exclusively options:

if (a++b) {//some code}
else if (a == c ) {// some code }
else if (a == d ) { //some code }
else {// catch all }


PIZZAPOS
---------------------------------------------------------------------------
http://319.vm.epicservers.com/pizzapos/

(CS-ASP_012)
-----------------------------------------------------------------------------

Comparison and logical Operator (CS-ASP_013)
----------------------------------------------------------------------
Comparison Operators
used for conditional statements
==
!=
< >
<= >=
!someBooleanValue - means NOT is True

Logical Operators
used to combine multiple expressions / evaluation

&& - AND
|| - OR

Combine with parenthesis () for order of precedence

Radio Button Challenge
------------------------------------------------------------------------------
http://319.vm.epicservers.com/radiobutton/

working with Dates and Times (CS- ASP_014)
------------------------------------------------------------------------------
Creating new DateTime objects
DateTime myDateTime = DateTime.Now;
DateTime myDateTime = DateTime("02/26/1986");

formatting...many options:
myDateTime.To_____()

Retrieving Parts:
myDateTime.Year // int
myDateTime.Hour // int
myDateTime.DayOfWeek // "Monday"
myDateTime.DayOfYear // int 175

DateTime Math:
myDateTime.AddHour (3)
myDateTime.AddMinute (-5)

"Chaining" = using multiple helper methods
together with the dot. operator
myDateTime.AddHour(3).AddMinute(-5).ToString()

Working with Spans of Time (CS- ASP_015)
----------------------------------------------
Create and initiliaze new TimeSpans

// Days.Hours:Minutes:Seconds.MIlliseconds
TimeSpan myTimeSpan = TimeSpan.Parse("1.2:3:30.5");

DateTime myBirthday = DateTime.Parse("12/7/1969");
TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

More info at http://is.gd/timespan

Get individual parts
myAge.Hours
myAge.Seconds

....or get Total elapsed time
as a double representing both
the number of days / hours/ etc/
AND Fractional values representing
"left overs".

myTimeSpan.TotalDays // double
myTimeSpan.TotalHours // double 

http://is.gd./pagelifecycle

Formatting Strings (CS-ASP_019)
========================================================
Concenate Strings
+ +=

String.Format("Hello {0}. You are from {1}",  "Joe", "Dallas")

Format Number
String.Format (Reference Code: {0:000_000-0}" , 1234567)
123_456-7

Formatting Dates
http://is.gd.formattingdates
String.Format("Reference Date: {0:ddd - d,MM,YYYY}", someDate)
Tue - 5,07,2014

Fomrattng Currency
http://is.gd.formattingcurrency
String.Format ("Total: {0:C}", totalAmount);
$50,000.00

single Dimensional Arrays (CS-ASP_021)
============================================
Indexes vs. Elements
Accessor vs. Stored Values
Indexes are zero based

Declaring Arrays
string[] myArray = new string [3];

Declaring and initializing Arrays
string[] myArray = new string [3] {"Moe", "Larry", "Curly"};

Setting / Getting Values
string myString = myArray [1];// retrieve the second element
myArray [0] = myString; // sets first element

Multi- Dimensional Arrays (CS-ASP_022)
==================================================================
Same as single dimensional...just requires
more indexes (in dimensions) to get to the element

double[,] myArray = new double [2,3]; //contains 6 elements
int [,,] rubicscube = new int [3,3,3] // contains 27 elements

rubicsCube [0,1,2]= 42;
myInteger = rubicsCube [0,1,2];

http://319.vm.epicservers.com/EpicSpies/

Changing the Length of an Array (CS-ASP_023)
=======================================================================
Arrays are immutable = cannot be changed in memory
HOWEVER .NET Framework providers helper methods to resize an array ... creates a new array and copies 
the old values into it.

Array.Resize (ref myArray, myArray.Lenght + 1);

// Get the highest index:
int highestIndex = myArray.GetUpperBound(0);
// 0 = dimension we want to retreive the
// upper boundary for

//Arrays have other helper methods
myArray.Sum()
myArray.Min()
myArray.Max()
myArray.Average()
Array.Sort(myArray)
Array.Reverse(myArray)

Looping with the for iteration statement (CS-ASP_026)
===================================================

Snippet: for [tab] [tab]
then you can tab through the replaceable bits, hit enter to start writing code in the code block body.

for (int i= 0; i <10; i ++)
{
 //your code here
 }
 
 i - Any variable name
 
 1st part - counter declaration, can be initialized to any number
 2nd part - condition, can be any expression that equates to a bool
 3rd part - increment i++ / decrement i --, can step more than 1 using +",
 
 string[] names = new string [] {"Wolverine", "Cyclops", "Professor X", "Phoenix"};
 
 for (int i = 0; i <names.Length; i ++)
 {
 //Cna search for a specific value
 if (names[i] == "Professor X")
 {
 //do something here
 // can break out of additinal iterations if you need to 
 break;
  
  }
}  

Looping with the while and do ...while Iteration Statements (CS-ASP_027)
======================================================================
Random random = new Random ();
// random.Next(lowerBounds, upperBounds)
random.Next(1,100); // returns a value between 1 and 100

// is someExpression is already false, this will never execute
while (someExpression) {
// Code that would never affect whether
// someExpression is true or false
}
//if someExpression is already false, this will run AT LEAST ONCE
do{
//Code that would affect wether
//someExpression is true or false
}while (someExpression)



Creating Overloaded Methods - (CS-ASP_031)
=============================================
Different METHOD SIGNATURE , but same basic function. 
METHOD SIGNTATURE ..the number and type of parameters
can have different return types.

Creating optional parameters - (CS-ASP_032)
================================================
Optional parameters provide default values when you define
the method. So, if you dont supply a value, the default will be used.

private void myMethod(string myRequiredParam,
                     int myOptionalParam -1,
                     int myOtherOPtionalParam =5);
                     
// Can be called....

myMethod("Hello Required Param!");

// or ...

myMethod("Hello Required Param!",100); 
// or...
myMethod("Hello Required Param!",100,500);
// you cannot skip an optional parameter:
myMethod("Hello Required Param!",,500);//ERROR

Passing Named Arguments INto Input Parameters (CS-ASP_033)
=======================================================
allow us to send in parameter argument OUT OF ORDER!
we just prefix the input parameter argument with the name 
of the parameter we're passing in. a colon, the the value:

myMethod (myOtherOptionalParam:500,
         myRequiredParam: "Hello Required Param",
         MyOptionalParam:100);
         
//You still have to pass in REQUIRED parameters.

Creating Methods with Output Parameters - (CS-ASP_034)
=======================================================
Allows you to return a value the normal way AND return a value via a method parameter:

private bool myMethod(string myRequiredParam,
                      out int myOptionalParam){}
                      
int myValue =0;
if (myMethod ("Some required text, out myValue)) return "hello World!":


http://319.vm.epicservers.com/MegaCasino/

Manipultating Strings Lesson (CS-ASP_035)
================================================
// Escape Double Quotes
string myString = "This is a double quote:\ ".";

//Accessing a specific character:
myString[2]

//StartsWith(),EndsWith(), Contains()
//Check to see if a given string has a set o f
// characters beginning. end or somewhere inside.
//Return true/ false

//IndexOf()
//Find the index for one string inside of 
// another string.
int myINdex = myString.IndexOf("howdy");

//Index(),Remove()
//INserts adds characters starting ata given index
// Remove removes characters starting at a given
//index, and all the way through th elength you
//input.

//Substring()
//Retrieve Characters beginning ata given index
//all the way through the length you input.

//Trim(), TrimStart(), TrimEnd()
//Remove space character both, or just the start
// or the end of the string.

//PadLeft(), PadRight()
//Allow you to specify a length for a string
//and a character o pad the string with if its
//length is less than the specified length.
myString - someValue.PadLeft(10,'#');
//Notice that we're inputting a char, not a sting
// Therefore we have to use a single code quote ' not
// a double quote.

//ToUpper(), ToLower()
// Important! Compare two strings regardless of
//the case, because in C#, two strings with
//different cases are NOT equal/

//Replace()
//Replace every ocurance of one string with
//some other string.
myString.Replace("$$$", myValue);

//Split()
// Take a string and split it into many strings
// and store them in a string array.
string[] names = myString.Split(',');

//Concatenating strings, immutability
//StringBuilder - memeory effiecient way of concatinating strings.

Intro to Classes and Objects (CS_ASP-036)
===============================================
Class is a code block that defines a data type.
an Object is an instance of a class.
Metaphors:
Blueprint vs Houses
Recipe vs Cupcakes
Patter vs Suit
Cookie Cutter vs Cookies

Classes have members, like properties and Methods.

Properties define the attributes that are set on 
an instance of the class/ represent the "State"
of the object. Yo cant set (assign) and get
(retrieve) properties values on an object.

Methods define actions an instance of a class
can perfomr, usually on th eobject instance itself.

You can create an instance of a class using the 
new keyword. Think: "factory".

You can access the members of an object by using
the member access operator, the dot(.)

Conceptually, classes are delegated a responsibility
in the system or represent some domain concept
in the system.

Classes are ultimately custom data types, more complex
that the simple datatypes we've worked with
Therefore you can use them anywhere you use other
data types (like as input parameters or return
values from a methos.)

class Car {
}

Autop Implemented Properties - simple properties
prop [tab] [tab] [enter] [enter]

this keyword - Access a member of the current instance
of the class.

public void myMethod()
{
this.Year =1976
}


Understanding Object references and Object Lifetime (CS-ASP_038)
========================================================================
An object reference variable holds a reference to an instantiated object 
in the computers memory.

MyClass myobject;

the new keyword creates an instance of the class and returns the address of the object in memory to the reference variable.

myObject = new myClass();

More than one object reference variable can hold an address to the object in memory

myClass myOtherObjectReference = myObject;

each time a new reference is added , the reference count increases by one. Each time an object reference variable goes out of scope or is set to nulkl, the reference count decrease by one

if the reference count is zero the .NET framework Runtime's Garbage Collector removes the object from memory at an indeterminate point in time in the future. You can take control of the finalization process and even handle events just before the object is removed. See: "deterministic finalization"

UNderstanding the .NET Framework and Compilation (CS-ASP_039)
=============================================================
The .NET Framework consists of:

- Runtime (Common language runtime, CLR) "protective bubble", managesa memory, protects the users machine, etc.
- .NET Framework Class Lilbrary (FCL, Base Class Library, BCL) - thousands of classes built by Microsoft for every imaginable purpose.

- Compilers( C# compiler

http://v.gd/unicode

UNderstanding namespaces and the using directive (CS-ASP_040)
==============================================================================
Namespaces disambiguate class names inside of class libraries or applications.

You must reference class names by thier full name:

System.Text.StringBuilder sb = new System.TextStringBuilder();

...or , you can employ a using directive at the top of the code file to instruct the complier to look in those namespaces to find the class that is referenced.

Using System.Text;
...
StringBuilder sb = new StringBuilder();

You must always do this if the code you're writinbg is outside of the namespace of the class you want to use, even if its in the same project

Defauylt Namespace defined in Project Porperties (right clicking on Project Nmae in Solution Explorer, select properties ...)
Creating Class Libraries and adding reference to assemblies (CS-ASP_041)
====================================================================
Add info here to get caught up

Accessibility Modifiers , Fields and properties (CS-ASP_042)
==========================================================
Add info here to get caught up

http://v.gd/access

Public - 


creating constructor methods (CS-ASP_043)
====================================================
constructors are called at the moment of instantiation.
Used to put the new instance of the class into a valid state.
public class Foo
{
 public Foo()
 {
 ...
 }
}
whether you define it or not, there's a default constructor.You can override the default (no input parameters) or overload the constructor to allow the user to set the new instance to a valid stgate.

Naming Conventions for Identifiers (CS-ASP_044)
=======================================
PascalCase - public
camelCase - private, protected

Public lasses, methods and properties - PascalCase
Private helper methods, input parameters - camelCase
locally scoped variables - camelCase
Private field - camelCase prefixed w/ underscore: _firstName

choose long, memorable , understandable names
that convey meaning/intent.

Static Versus Instance Members (CS-ASP_045)
===========================================================
Static members - no instance of the class required to call method

INstance member- must create a instance w/ new keyword to call methods and properties

can mix both in the same class, but cant reference instance
members from inside of static members

Classes can be decorated w/ static keyword - all members must be static, cant create an instance of the class

System.Math

http://v.gd/static

}

Working with the list collection(CS-ASP_046)
=========================================================
Use Generic collections to work with items in a strongly typed fashion.

Better than arrays:
Know the type of the item for a certainty, no casting/ converting
better performance inserting/ removing/ updating
collections provide more flexible options to access items in the collection,
Allows for LINQ extension methods

Many different types of collections - specialties

"Generic Collections"
List<T>
Dictionary <TKey,TValue>
T => data type you need
"You make a generic specific by providing a data type"

List<string> - only store strings (strong typed)
List <Car> - only styore Cars in that collection

//Assume i have three objects: car1, car2, car3
List<Car> cars = new List<Car> ();
cars.Add(car1);
cars.Add(car2);
caRS.ADD(car3);

int numberOfCars = cars.Count;
Car myCar = cars.ElementAt(1); //Return 2nd car in the collection

//Terminology: You access a member of a collection

//LINQ queries

Object Initializers (CS-ASP_047)
===============================
Concise way to intiaialize a new object (or collection)with values.

//Didnt talk about this form:

Car car1 = new Car() {Make = "BMW", Model = "528i", Year = 2010, Color = "Black"};

//No local variable name for the new Car instance needed!
cars.ADD (newCar() {Make = "BMW", Model = "528i", Year = 2010, Color = "Black"};

Collection INitializers (CS-ASP_048)
====================================================
Shortcut to creat new instance of a generic collection and initialize it by Immediately adding new instances of a given type.

List<Car> cars = new LIst <Car>(){
 new Car {Make = "BMW", Model = "528i", Year = 2010, Color = "Black"},
 new Car {Make = "BMW", Model = "745Li", Year = 2008, Color = "Black"};
 new Car Make = "Ford", Model = "Escape", Year = 2005, Color = "White"};
 };
 
 Working with the Dictionary<TKey, TValue> Collection (CS-ASP_049)
 =============================================================================
 Dictionary allows you to use a key to access a member of the collection.
 Think ; Webster's dictionary.. the word (key) , then the definition (insatce of a given type)
 Key is anything meaningful in YOUR system.
 Key must be unique.
 
 TKey => type of the key
 TValue 
 
 
 
 //Better way to access Dictionary...
 Car v2;
 if (cars.TryGetValue("V234", out v2))
 {
  result += v2.Year;
 }
 
 //Remove
 if(cars.Remove("V345")){
  result += "Successfully removed car.";
  }
  
  Looping with the foreach Iteration Statement(CS-ASP_050)
  =================================================
  More elegant way of iterating through collections
  
  Code Snippet: foreach [tab] [tab]
  
  
