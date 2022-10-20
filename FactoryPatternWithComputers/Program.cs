using FactoryPatternWithComputers;

Console.WriteLine("What type of computer do you prefer?");
var response = (Console.ReadLine());

IComputer computer = ComputerFactory.GetComputer(response);

computer.Compute();