=========== RAW CODE =============

namespace StringCalculatorTest
{
    public class Fibonacci
    {
        public int QuestionAnswer(int limit)
        {
            int previous = 0;
            int next = 1;
            int fibsum = 0;

            do
            {
                var fib = previous + next;
                previous = next;
                next = fib;

                if (fib % 2 == 0) fibsum += fib;

            } while (previous + next < limit);

            return fibsum;
        }
    }

    class FibonaciTest
    {
        //[Test]
        //public void ShouldReturn6WhenMaxTermsDoNotExceedFour()
        //{
        //    var fib = new Fibonacci();

        //    var result = fib.QuestionAnswer(4);

        //    Assert.That(result, Is.EqualTo(6));
        //}

        //[Test]
        //public void Should_Return32_When_MaxTermsDoNotExceed_14()
        //{
        //    var fib = new Fibonacci();

        //    var result = fib.QuestionAnswer(14);
            
        //    Assert.That(result, Is.EqualTo(32));
        //}

        //[Test]
        //public void Should_Return_Ten_When_MaxTermsDoNotExceed_14()
        //{
        //    var fib = new Fibonacci();

        //    var result = fib.QuestionAnswer(14);
            
        //    Assert.That(result, Is.EqualTo(10));
        //}

        //[Test]
        //public void Should_Return_44_When_MaxTermsDoNotExceed_45()
        //{
        //    var fib = new Fibonacci();

        //    var result = fib.QuestionAnswer(45);
            
        //    Assert.That(result, Is.EqualTo(44));
        //}

        [TestCase(14, 10)]
        [TestCase(45, 44)]
        [TestCase(4000000, 4613732)]
        public void Should_Return_44_When_MaxTermsDoNotExceed_45(int limit, int expectedResult)
        {
            var fib = new Fibonacci();

            var result = fib.QuestionAnswer(limit);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
