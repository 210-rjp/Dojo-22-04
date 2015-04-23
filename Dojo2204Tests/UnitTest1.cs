using System;
using System.Collections.Generic;
using Dojo2204;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dojo2204Tests
{
    [TestClass]
    public class UnitTest1
    {
        private FizzBuzz fb;
        private IEnumerable<IRule> rules;
        
        [TestInitialize]
        public void Setup()
        {
            rules = new List<IRule>
            {
                new MultipleDe3Rule(),
                new MultipleDe5Rule(),
                new MultipleDe7Rule(),
                new EgalA69Rule(), 
                new EgalA42Rule()
            };

            fb = new FizzBuzz(rules);
        }


        [TestMethod]
        public void CanCreateFizzBuzzTest()
        {
            //arrange


            //act

            //assert
            Assert.IsNotNull(fb);
        }

        [TestMethod]
        public void CanSayOne()
        {
            //arrange


            //act
            var results = fb.say(1);
            //assert
            Assert.AreEqual("1", results);
        }

        [TestMethod]
        public void CanSayTwo()
        {
            //arrange


            //act
            var results = fb.say(2);
            //assert
            Assert.AreEqual("2", results);
        }

        [TestMethod]
        public void CanSayFizz()
        {
            //arrange


            //act
            var results = fb.say(3);
            //assert
            Assert.AreEqual("FIZZ", results);
        }

        [TestMethod]
        public void CanSayBuzz()
        {
            //arrange


            //act
            var results = fb.say(5);
            //assert
            Assert.AreEqual("BUZZ", results);
        }

        [TestMethod]
        public void CanSayFizzBuzz()
        {
            //arrange


            //act
            var results = fb.say(15);
            //assert
            Assert.AreEqual("FIZZBUZZ", results);
        }

        [TestMethod]
        public void CanSayBang()
        {
            //arrange


            //act
            var results = fb.say(14);
            //assert
            Assert.AreEqual("BANG", results);
        }

        [TestMethod]
        public void CanSayBuzzFor105()
        {
            //arrange


            //act
            var results = fb.say(105);
            //assert
            Assert.AreEqual("FIZZBUZZBANG", results);
        }

        [TestMethod]
        public void CanSayBuzzFor21()
        {
            //arrange


            //act
            var results = fb.say(21);
            //assert
            Assert.AreEqual("FIZZBANG", results);
        }

        [TestMethod]
        public void CanSayWOOOOOPI()
        {
            //arrange


            //act
            var results = fb.say(69);
            //assert
            Assert.AreEqual("WOOOOOPI", results);
        }

        [TestMethod]
        public void CanSayLaReponseAToutFor42()
        {
            //arrange

            //act
            var results = fb.say(42);

            Assert.AreEqual("la réponse à tout", results);
        }
    }
}
