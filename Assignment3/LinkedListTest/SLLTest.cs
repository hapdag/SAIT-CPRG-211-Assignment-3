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
        [Test]
        public void Test_Replace()
        {
            SLL testSLL = new SLL();
            testSLL.AddFirst(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            testSLL.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            testSLL.AddLast(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));
            testSLL.Replace(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"), 1);
            // Replace user information at testSLL index 1, new user should have ID of 3
            Assert.That(testSLL.GetValue(1).Id, Is.EqualTo(3));
        }
        [Test]
        public void Test_Remove_Start()
        {
            SLL testSLL = new SLL();
            testSLL.AddFirst(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            testSLL.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            testSLL.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            testSLL.RemoveFirst();
            Assert.That(testSLL.GetValue(0).Id.Equals(2));
        }
        [Test]
        public void Test_Remove_End()
        {
            SLL testSLL = new SLL();
            testSLL.AddFirst(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            testSLL.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            testSLL.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            testSLL.RemoveLast();
            Assert.That(testSLL.Count().Equals(2));
            Assert.That(testSLL.GetValue(1).Id.Equals(2));
        }
        
        [Test]
        public void Test_Remove_At_Index()
        {
            SLL testSLL = new SLL();
            testSLL.AddFirst(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            testSLL.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            testSLL.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            testSLL.Remove(1);
            Assert.That(testSLL.Count().Equals(2));
            Assert.That(testSLL.GetValue(1).Id.Equals(3));
        }
        [Test]
        public void Test_Get_Item_Index()
        {
            SLL testSLL = new SLL();
            User testUser = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            testSLL.AddFirst(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            testSLL.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            testSLL.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            Assert.That(testSLL.IndexOf(testUser).Equals(0));
        }
        [Test]
        public void Test_Get_Value_At_Index()
        {
            SLL testSLL = new SLL();
            User testUser = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            testSLL.AddFirst(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            testSLL.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            testSLL.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            Assert.That(testSLL.GetValue(0).Equals(testUser));
        }
    [Test]
    public void Test_SLL_Join()
        {
            SLL sll1 = new SLL();
            SLL sll2 = new SLL();
            sll1.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            sll1.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            sll2.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            sll2.AddLast(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));
            sll1.Join(sll2);
            Assert.That(sll1.Count().Equals(4));
            Assert.That(sll1.GetValue(3).Id.Equals(4));
        }
    }
}