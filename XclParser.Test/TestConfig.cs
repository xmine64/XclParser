using XclParser.Reflection;

namespace XclParser.Test
{
    [XclType]
    enum TestEnum1
    {
        TestOption1,
        TestOption2,
        TestOption3,
        TestOption4,
    }

    [XclType]
    class TestClass1
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
}