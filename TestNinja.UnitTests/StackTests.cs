using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stack;

        [SetUp]
        public void SetUp() 
        {
            _stack = new Stack<string>();
        }

        //Count test
        [Test]
        public void Count_EmptySTack_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }


        //Push tests
        [Test]
        public void Push_ArgIsNull_ThrowsArgNullExcemption() 
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_Valid_AddTheObjectToTheStack()
        {
            _stack.Push("a");
            Assert.That(_stack.Count, Is.EqualTo(1));
        }


        //Pop tests
        [Test]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithAFewObject_ReturnsObjectOnTheTop()
        {
            _stack.Push("a");
            _stack.Push("b");
            var result = _stack.Pop();
            Assert.That(result, Is.EqualTo("b"));

        }

        [Test]
        public void Pop_StackWithAFewObject_RemoveObjectOnTheTop()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Pop();
            Assert.That(_stack.Count,Is.EqualTo(1));
        }

        //Peek tests
        [Test]
        public void Peek_EmptyStack_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithAFewObject_ReturnsObjectOnTheTop()
        {
            _stack.Push("a");
            _stack.Push("b");
            var result = _stack.Peek();
            Assert.That(result, Is.EqualTo("b"));

        }

        [Test]
        public void Peek_StackWithAFewObject_NotRemoveObjectOnTheTop()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Peek();
            Assert.That(_stack.Count, Is.EqualTo(2));
        }
    }
}
