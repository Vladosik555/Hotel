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
        /// ��������� ��������� �������� ��������� ������
        /// </summary>
        [Test]
        public void CheckingTheDefaultSearchStringEntry()
        {
            MyHotel hotel = new MyHotel();
            Assert.AreEqual(hotel.SearchLine.Text, "�����...");
        }
        /// <summary>
        /// ��� ������� �� ������� �� �������� ������ � ������� ���������� ��� ������� �� �������� ������
        /// </summary>
        [Test]
        public void WhenYouClickOnATableWithAnOccupiedStatusAllRoomsWithAnOccupiedStatusAppearInTheTable()
        {
            MyHotel hotel = new MyHotel();
            List<Room> rooms = hotel.BusyStatusDetection();
            foreach (Room room in rooms)
            {
                Assert.AreEqual(room.Statuc, "������");
            }
        }
        /// <summary>
        /// ��� ������� �� ������� �� �������� ��������������� � ������� ���������� ��� ������� �� �������� ���������������
        /// </summary>
        [Test]
        public void WhenYouClickOnATableWithTheReservedStatusAllRoomsWithTheReservedStatusAppearInTheTable()
        {
            MyHotel hotel = new MyHotel();
            List<Room> rooms = hotel.DetectingTheStatusReserved();
            foreach (Room room in rooms)
            {
                Assert.AreEqual(room.Statuc, "���������������");
            }
        }
        /// <summary>
        /// ��� ������� �� ������� �� �������� ��������� � ������� ���������� ��� ������� �� �������� ���������
        /// </summary>
        [Test]
        public void WhenYouClickOnATableWithTheStatusVacantAllRoomsWithTheStatusVacantAppearInTheTable()
        {
            MyHotel hotel = new MyHotel();
            List<Room> rooms = hotel.IdentificationFfStatusAvailable();
            foreach (Room room in rooms)
            {
                Assert.AreEqual(room.Statuc, "���������");
            }
        }
        /// <summary>
        /// ��� ������� �� ������� �� �������� ������������ � ������� ���������� ��� ������� �� �������� ������������
        /// </summary>
        [Test]
        public void WhenYouclickOnATableWithTheStatusCheckingOutAllRoomsWithTheStatusCheckingOutAppearInTheTable()
        {
            MyHotel hotel = new MyHotel();
            List<Room> rooms = hotel.IdentificationFfStatusDischarged();
            foreach (Room room in rooms)
            {
                Assert.AreEqual(room.Statuc, "������������");
            }
        }
    }
}