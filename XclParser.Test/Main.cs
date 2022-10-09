using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using XclParser.Primitives;
using XclParser.Reflection;

namespace XclParser.Test
{
    [TestClass]
    public class Main
    {
        [TestMethod(displayName:"A - Register Types")]
        public void RegisterTypes()
        {
            var context = new Context();
            context.TypeMap.RegisterEnum(typeof(TestEnum1));
            context.TypeMap.RegisterClass(typeof(TestClass1));
            
            var enum1 = context.TypeMap.GetXclType(typeof(TestEnum1));
            Assert.IsInstanceOfType(enum1, typeof(XclEnumType));
            Assert.IsTrue(enum1.Name == nameof(TestEnum1));
            
            var class1 = context.TypeMap.GetXclType(typeof(TestClass1));
            Assert.IsInstanceOfType(class1, typeof(XclClass));
            Assert.IsTrue(class1.Name == nameof(TestClass1));
        }

        [TestMethod(displayName: "B - Parse Document")]
        public async Task Parse()
        {
            await using var file = File.OpenRead("test.xcl");
            using var reader = new StreamReader(file!);

            var context = new Context();
            context.TypeMap.RegisterEnum(typeof(TestEnum1));
            context.TypeMap.RegisterClass(typeof(TestClass1));
            
            var document = await context!.ParseDocumentAsync(reader);

            Assert.IsTrue(document.Instances.Count == 1);
            Assert.IsTrue(document.Instances[0].Type == context.TypeMap.GetXclType(typeof(TestClass1)));
            Assert.IsInstanceOfType(document.Instances[0].Value, typeof(TestClass1));

            var value = (TestClass1)document.Instances[0].Value;
            Assert.IsTrue(value.Parameter == "test parameter");
            Assert.IsTrue(value.TestField1 == "Test Value");
            Assert.IsTrue(value.TestField2 == true);
            Assert.IsTrue(value.TestField3 == TestEnum1.TestOption3);
        }
    }
}