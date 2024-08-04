using Assignment3;
namespace LinkedListTest
{
    public class Tests
    {
        [Test]
        public void Test_IsEmpty()
        {
            SLL testSLL = new SLL();
            // SLL is empty, IsEmpty shuld return true
            Assert.IsTrue(testSLL.IsEmpty());
            // SLL is not empty, IsEmpty shuld return false
            testSLL.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            Assert.IsFalse(testSLL.IsEmpty());
        }
        [Test]
        public void Test_Prepend()
        {
            SLL testSLL = new SLL();
            testSLL.AddFirst(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            // First item in testSLL should be user with ID 1
            Assert.That(testSLL.GetValue(0).Id, Is.EqualTo(1));
            testSLL.AddFirst(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            // First item is testSLL is replaced by user with ID 2
            Assert.That(testSLL.GetValue(0).Id, Is.EqualTo(2));
        }
        [Test]
        public void Test_Append()
        {
            SLL testSLL = new SLL();
            testSLL.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            // First item in testSLL should be user with ID 1
            Assert.That(testSLL.GetValue(0).Id.Equals(1));
            testSLL.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            // After appending a user to the end of list, first user should still be user with ID 1
            Assert.That(testSLL.GetValue(0).Id.Equals(1));
            Assert.That(testSLL.Count, Is.EqualTo(2));
        }

        [Test]
        public void Test_Insert()
        {
            SLL testSLL = new SLL();
            testSLL.AddFirst(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            testSLL.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            testSLL.Add(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"),1);
            Assert.That(testSLL.GetValue(1).Id.Equals(3));

        }
    }
}