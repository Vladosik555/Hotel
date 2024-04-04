using Hotel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace TestsHotel
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// Проверяет дефолтное значение поисковой строки
        /// </summary>
        [Test]
        public void CheckingTheDefaultSearchStringEntry()
        {
            MyHotel hotel = new MyHotel();
            Assert.AreEqual(hotel.SearchLine.Text, "Поиск...");
        }
        /// <summary>
        /// При нажатии на таблицу со статусом занято в таблице появляются все комнаты со статусом занято
        /// </summary>
        [Test]
        public void WhenYouClickOnATableWithAnOccupiedStatusAllRoomsWithAnOccupiedStatusAppearInTheTable()
        {
            MyHotel hotel = new MyHotel();
            List<Room> rooms = hotel.BusyStatusDetection();
            foreach (Room room in rooms)
            {
                Assert.AreEqual(room.Statuc, "Занято");
            }
        }
        /// <summary>
        /// При нажатии на таблицу со статусом Зарезервировано в таблице появляются все комнаты со статусом Зарезервировано
        /// </summary>
        [Test]
        public void WhenYouClickOnATableWithTheReservedStatusAllRoomsWithTheReservedStatusAppearInTheTable()
        {
            MyHotel hotel = new MyHotel();
            List<Room> rooms = hotel.DetectingTheStatusReserved();
            foreach (Room room in rooms)
            {
                Assert.AreEqual(room.Statuc, "Зарезервировано");
            }
        }
        /// <summary>
        /// При нажатии на таблицу со статусом свободные в таблице появляются все комнаты со статусом свободные
        /// </summary>
        [Test]
        public void WhenYouClickOnATableWithTheStatusVacantAllRoomsWithTheStatusVacantAppearInTheTable()
        {
            MyHotel hotel = new MyHotel();
            List<Room> rooms = hotel.IdentificationFfStatusAvailable();
            foreach (Room room in rooms)
            {
                Assert.AreEqual(room.Statuc, "Свободные");
            }
        }
        /// <summary>
        /// При нажатии на таблицу со статусом Выписываются в таблице появляются все комнаты со статусом Выписываются
        /// </summary>
        [Test]
        public void WhenYouclickOnATableWithTheStatusCheckingOutAllRoomsWithTheStatusCheckingOutAppearInTheTable()
        {
            MyHotel hotel = new MyHotel();
            List<Room> rooms = hotel.IdentificationFfStatusDischarged();
            foreach (Room room in rooms)
            {
                Assert.AreEqual(room.Statuc, "Выписываются");
            }
        }
    }
}