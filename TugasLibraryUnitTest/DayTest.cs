using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    class DayTest
    {
        private Day day;
        private String[] nameDay;
        [SetUp]
        public void Init()
        {
            day = new Day();
            nameDay = new String[7] { "Senin", "Selasa", "Rabu", "Kamis", "Jum'at", "Sabtu", "Minggu" };
        }
        [Test]
        public void NameOfDayTest()
        {
            for (int i = 0; i < 7; i++) Assert.AreEqual(nameDay[i], day.NameOfDay(i + 1));
            Assert.AreEqual("", day.NameOfDay(8));
        }
    }
}
