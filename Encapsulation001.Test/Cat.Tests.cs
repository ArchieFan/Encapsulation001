using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation001.Test
{
    [TestFixture]
    public class CatTests
    {
        // Cat initial -> Mood=100, Hungry=100, Energy=100, Meow()
        // Cat can sleep -> Energy++ Hungry++
        // Cat can play -> Mood++ Energy-- Meow()
        // Cat can Feed -> Hungry-- Mood++ Meow()

        [Test]
        public void Initial_Cat()
        {
            
            // Rarrage
            
            // Act
            Cat cat = new Cat();
            int Mood = cat.Mood;
            int Hungry = cat.Hungry;
            int Energy = cat.Energy;

            // Assert
            Assert.AreEqual(100, Mood);
            Assert.AreEqual(100, Hungry);
            Assert.AreEqual(100, Energy);

        }

        [Test]
        public void Cat_sleep()
        {
            // Act
            Cat cat = new Cat();
            var meow = cat.sleep();
            // Assert
            Assert.AreEqual(110, cat.Energy);
            Assert.AreEqual(110, cat.Hungry);
            Assert.AreEqual("", meow);
        }

        [Test]
        public void Cat_play()
        {
            // Act
            Cat cat = new Cat();
            var meow = cat.play();
            // Assert
            Assert.AreEqual(110, cat.Mood);
            Assert.AreEqual(90, cat.Energy);
            Assert.AreEqual("Meow~", meow);

        }


        [Test]
        public void Cat_feed()
        {
            // Act
            Cat cat = new Cat();
            var meow = cat.feed();
            // Assert
            Assert.AreEqual(90, cat.Hungry);
            Assert.AreEqual(110, cat.Mood);
            Assert.AreEqual("Meow~", meow);
        }


        [Test]
        public void Cat_play2_feed1_sleep1()
        {
            Cat cat = new Cat();
            cat.play();
            cat.play();
            cat.feed();
            cat.sleep();

            Assert.AreEqual(90, cat.Energy);
            Assert.AreEqual(130, cat.Mood);
            Assert.AreEqual(100, cat.Hungry);

        }

    }
}
