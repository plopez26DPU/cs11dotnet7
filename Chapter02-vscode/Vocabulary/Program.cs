using System.Reflection;

System.Data.DataSet ds;
HttpClient client;

Assembly? myApp = Assembly.GetEntryAssembly();
if (myApp == null) return; //quit the app

//loop through each assembly that my app references
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);

    int count = 0;

    foreach (TypeInfo t in a.DefinedTypes)
    {
        count += t.GetMethods().Count();
    }

    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: count,
        arg2: name.Name);
}