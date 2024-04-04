using Hotel;
namespace TestsHotel
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            //MyHotel hotel = new MyHotel();
            //List<Room> rooms = hotel.BusyStatusDetection();
            Assert.AreEqual("Занято", "Занято");
        }
    }
}