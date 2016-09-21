One challenge with TDD is the use of static classes, properties, and methods, for example:
- File.Open()
- Console.WriteLine()
- HttpContext.Current

The problem is these classes cannot be mocked, so it is not possible to write unit tests 
to verify that your classes are interacting as expected with these classes/methods.

One way to work around this and improve test coverage is to implement wrappers for the 
problematic classes, and have your classes use these in place of the .NET Framework classes.

Because these wrappers are 'pure' (i.e. they do not add or change any behavior), they are 
considered exempt from TDD - you would not normally write tests for a framework wrapper.