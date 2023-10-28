using XclParser;
using XclParser.Reflection;

string input = @"
TestClass1: ""Parameter""
{
    TestField1 = ""Test Value""
    TestField2 = True
    TestField3 = TestOption3
}
";

Context context = new();
context.TypeMap.RegisterEnum(typeof(TestEnum1));
context.TypeMap.RegisterClass(typeof(TestClass1));
var doc = await context.ParseDocumentAsync(new StringReader(input));
Console.WriteLine(doc.Instances[0].Value);

[XclType]
enum TestEnum1
{
    TestOption1,
    TestOption2,
    TestOption3,
    TestOption4,
}

[XclType]
record class TestClass1
{
    [XclConstructor]
    public TestClass1(string parameter)
    {
        Parameter = parameter;
    }

    [XclParameter]
    public string Parameter { get; }

    [XclField]
    public string? TestField1 { get; set; }

    [XclField]
    public bool TestField2 { get; set; }

    [XclField]
    public TestEnum1 TestField3 { get; set; }
}