using NetFive._1Records;
using NetFive._5PerformanceAndInterop;
using System;


//1.Records

// *** Creating New Record Instances ***
//Records record = new Records();
//Console.WriteLine(record.personGA);

//Console.WriteLine(record.personGA2);

//Console.WriteLine(record.personGA3);

//record.personGA3.FirstName = "Gökhan2";
//record.personGA3.LastName = "Atay2";
//Console.WriteLine(record.personGA3);

//*** Record Value Equality ***

//var record1 = new Person("Serdar", "Atay");
//var record2 = new Person("Serdar", "Atay");
//Console.WriteLine(record1 == record2);

//var record3 = new Person("Serdar", "Atay");
//var record4 = new Person("Gökhan", "Atay");
//Console.WriteLine(record3 == record4);

//var record5 = new Person("Serdar", "Atay");
//var record6 = new Person2 { FirstName = "Serdar", LastName = "Atay" };
//Console.WriteLine(record5 == record6); //error


//*** Nondestructive Mutation  ***

//var record7 = new Person("Kerim", "Atay");
//var record8 = record7 with { FirstName = "Ayşe" };
//Console.WriteLine(record7.Equals(record8));
//Console.WriteLine(ReferenceEquals(record7, record8));

//var record9 = new Person("Gökhan", "Atay");
//var record10 = record9 with { };
//Console.WriteLine(record9.Equals(record10));
//Console.WriteLine(ReferenceEquals(record9, record10));

//*** Built-in Formatting for Display ***

//var record11 = new Person5 { FirstName = "Gökhan", LastName = "Atay", IdentityNumber = new string[] { "123", "456" } };
//Console.WriteLine(record11);

//*** Inheritance ***
//var record12 = new Developer("Gökhan", "Atay", "Senior Software Developer");
//var record13 = new Manager("Gökhan", "Atay", 50000);
//Console.WriteLine(record12 == record13);


//2.Init Only Setters

//InitOnlySetters setters = new() { ReadOnlyProperty = "value", Property = "value" };



//4.PatternMachingEnhancements Examples
/*PatternMachingEnhancements pmClass = new PatternMachingEnhancements();
var result = pmClass.IsLetter('d');
var result2 = pmClass.IsLetter('d');
var result3 = pmClass.IsLetter('d');
var result4 = pmClass.IsLetter('d');
Console.WriteLine($"result: {result} - result2: {result2} - result3: {result3} - result4: {result4}"); */


//5.PerformanceAndInterop

//5.1.Native-Sized Integers
//_1NativeSizedIntegers nativeInt = new();
//Console.WriteLine($"{nativeInt.x} - {nativeInt.y} - {nativeInt.z}");

//Console.WriteLine($"size of nint = {sizeof(nativeInt.x)}"); 
//Console.WriteLine($"size of nuint = {sizeof(nativeInt.y)}"); //To get the size of a native-sized integer at run time, you can use sizeof(). However, the code must be compiled in an unsafe context.

//Console.WriteLine($"nint.MinValue = {nint.MinValue}");
//Console.WriteLine($"nint.MaxValue = {nint.MaxValue}");
//Console.WriteLine($"nuint.MinValue = {nuint.MinValue}");
//Console.WriteLine($"nuint.MaxValue = {nuint.MaxValue}");


//6. 6FitAndFinishFeatures

//var status = true;
//FitAndFinishFeatures.Print((short)(status ? 1 : 2));

