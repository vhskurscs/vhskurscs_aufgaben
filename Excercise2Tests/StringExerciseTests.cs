using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excercise2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2.Tests
{
    [TestClass()]
    public class StringExerciseTests
    {
        [DataTestMethod()]
        [DataRow("aahabe ich bin sein Abend du er sie esAa", 4)]
        [DataRow("haben habe haben habe haben", 5)]
        [DataRow("aaaaaaaaaa", 10)]
        [DataRow("", 0)]
        [DataRow("a", 1)]
        [DataRow("AAAAAAAAAAAAAAAAhjgjzhgjhhrnbfkrfmoiurnjgnlknrgjktr   gtjghjkthgjkrt    ", 0)]
        public void CountAsTest(string s, int expected)
        {
            int actual = StringExercise.CountAs(s);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        [DataRow("Puroguramingu wa subarashii! Semento...c", 7)]
        [DataRow("", 0)]
        [DataRow("a", 1)]
        [DataRow("e", 1)]
        [DataRow("c", 1)]
        [DataRow("ae", 2)]
        [DataRow("ac", 2)]
        [DataRow("aec", 3)]
        [DataRow("aec eca cae eac", 12)]
        public void CountAsEsCsTest(string s, int expected)
        {
            int actual = StringExercise.CountAsEsCs(s);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        [DataRow("ab ich habe einen schönen abend ababbaab", true)]
        [DataRow("ab", true)]
        [DataRow("ab ab", true)]
        [DataRow("enemenemuundrausbistdu", false)]
        [DataRow("", false)]
        [DataRow("a", false)]
        [DataRow("b", false)]
        [DataRow("a b", false)]
        [DataRow("ba", false)]
        public void IsABInStringTest(string s, bool expected)
        {
            bool actual = StringExercise.IsABInString(s);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        [DataRow("HalloCSharp", "prahSCollaH")]
        [DataRow("", "")]
        [DataRow("a", "a")]
        [DataRow("ab", "ba")]
        [DataRow("abc", "cba")]
        [DataRow("abc cba", "abc cba")]
        public void ReverseTest(string s, string expected)
        {
            string actual = StringExercise.Reverse(s);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        [DataRow("Ich bin i9ein 18String 19", 19, true)]
        [DataRow("Ich bin i9ein 18String 18", 18, true)]
        [DataRow("Ich bin i9ein 18String 19", 9, true)]
        [DataRow("0", 0, true)]
        [DataRow("Ich bin i9ein 18String 19", 11, false)]
        [DataRow("1 1", 11, false)]
        [DataRow("101", 11, false)]
        public void IsNumInStringTest(string s, int num, bool expected)
        {
            bool actual = StringExercise.IsNumInString(s, num);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        [DataRow("CutInHalf", true, "CutIn")]
        [DataRow("CutInHalf", false, "Half")]
        [DataRow("Maoam", true, "Mao")]
        [DataRow("Maoam", false, "am")]
        [DataRow("", false, "")]
        [DataRow("", true, "")]
        public void CutInHalfTest(string s, bool rf, string expected)
        {
            string actual = StringExercise.CutInHalf(s, rf);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        [DataRow("ich habe bereits viel über c# gelernt. ichichich bin ich bin super!ich", "ich", 6)]
        [DataRow("", "", 1)]
        [DataRow("aaa aaa", "a", 6)]
        [DataRow("aaa", "bbbbbb", 0)]
        [DataRow("", "bbbbbb", 0)]
        [DataRow("aaa ic", "ich", 0)]
        [DataRow("ich ic", "ich", 1)]
        [DataRow("aaa ich i", "ich", 1)]
        public void CountStringInStringTest(string s, string word, int expected)
        {
            int actual = StringExercise.CountStringInString(s, word);
            Assert.AreEqual(expected, actual);
        }
    }
}