using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codewars_deadAnts
{
    [TestClass]
    public class DeadAntsTest
    {
        [TestMethod]
        public void Input_a_shouldReturn_one()
        {
            Assert.AreEqual(1, GetDeadAnts("a"));
        }

        private int GetDeadAnts(string deadRound)
        {
            var kata = new Kata();
            int deadAnts = kata.Accum(deadRound);
            return deadAnts;
        }

        [TestMethod]
        public void Input_ant_shouldReturn_zero()
        {
            Assert.AreEqual(0, GetDeadAnts("ant"));
        }

        [TestMethod]
        public void Input_aa_shouldReturn_two()
        {
            Assert.AreEqual(2, GetDeadAnts("aa"));
        }

        [TestMethod]
        public void InputNull_ShouldReturn_Zero()
        {
            Assert.AreEqual(0, GetDeadAnts(null));
        }
    }
}
