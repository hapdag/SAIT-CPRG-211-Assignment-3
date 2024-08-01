using Assignment3;
namespace LinkedListTest
{
    public class Tests
    {
        [Test]
        public void Test_IsEmpty()
        {
            SLL testSLL = new SLL();
            Assert.IsTrue(testSLL.IsEmpty());
            testSLL.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            Assert.IsFalse(testSLL.IsEmpty());
        }
        [Test]
        public void Test_Prepend()
        {
            SLL testSLL = new SLL();
            testSLL.AddFirst(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            Assert.That(testSLL.GetValue(0).Id, Is.EqualTo(1));
            testSLL.AddFirst(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            Assert.That(testSLL.GetValue(0).Id, Is.EqualTo(2));
        }
    }
}