using LinqTutorials;
using Newtonsoft.Json; 

// ReSharper disable InconsistentNaming

namespace TestProject1;

[TestFixture]
public class Tests {
    [Test]
    public void Test1() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task1(), Formatting.Indented));
    }

    [Test]
    public void Test2() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task2(), Formatting.Indented));
    }

    [Test]
    public void Test3() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task3(), Formatting.Indented));
    }

    [Test]
    public void Test4() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task4(), Formatting.Indented));
    }

    [Test]
    public void Test5() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task5(), Formatting.Indented));
    }

    [Test]
    public void Test6() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task6(), Formatting.Indented));
    }

    [Test]
    public void Test7() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task7(), Formatting.Indented));
    }

    [Test]
    public void Test8() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task8(), Formatting.Indented));
    }

    [Test]
    public void Test9() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task9(), Formatting.Indented));
    }

    [Test]
    public void Test10() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task10(), Formatting.Indented));
    }

    [Test]
    public void Test11() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task11(), Formatting.Indented));
    }

    [Test]
    public void Test12() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task12(), Formatting.Indented));
    }

    [TestCase(new int[] { 1, 1,1, 1, 1, 1, 1, 10, 1, 1, 1 })]
    [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 10, 10, 1, 1 ,2})]
    [TestCase(new int[] { 11, 11, 1, 1, 1, 1, 1, 1, 1 })]
    public void Test13(int[] ints) {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task13(ints), Formatting.Indented));
    }

    [Test]
    public void Test14() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task14(), Formatting.Indented));
    }

    [Test]
    public void Test15() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task15(), Formatting.Indented));
    }

    [Test]
    public void Test16() {
        TestContext.WriteLine(JsonConvert.SerializeObject(LinqTasks.Task16(), Formatting.Indented));
    }
}