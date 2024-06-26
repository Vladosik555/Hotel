using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NLog;
using NLog.Config;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Hotel
{
    public partial class MyHotel : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private int ID = 0;
        public MyHotel()
        {

            InitializeComponent();
            SearchLine.ForeColor = Color.Gray;
            Time.ForeColor = Color.Gray;
            logger.Info("�������������");
        }
        /// <summary>
        /// �����, ������� ���������� ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void startTime()
        {
            Timer.Start();
            Time.ForeColor = Color.Black;
            logger.Info("������ �������");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            startTime();
        }
        /// <summary>
        /// �����, ������� ���������� ������� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public string RealTimeOutput()
        {
            string time = DateTime.Now.ToLongTimeString();
            return time;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Time.Text = RealTimeOutput();
            logger.Info("������ ��������� ������� � ����");
        }

        /// <summary>
        /// ��� ������� ��������� ������, ������� ������ ���������
        /// <summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ErasesTheSearchBar()
        {
            if (SearchLine.Text.Equals("�����..."))
            {
                SearchLine.Text = string.Empty;
                SearchLine.ForeColor = Color.Black;
            }
            else
            {
                logger.Warn("�� �������� ���������");
            }
            logger.Info("��������� ��������� ������");
        }
        private void SearchLine_Enter(object sender, EventArgs e)
        {
            ErasesTheSearchBar();
        }
        /// <summary>
        /// ��� ������� ������ ������ � ��������� ������ ���������� ������� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddsASearchString()
        {
            if (SearchLine.Text.Equals(string.Empty))
            {
                SearchLine.ForeColor = Color.Gray;
                SearchLine.Text = "�����...";
            }
            else
            {
                logger.Warn("�� �������� ���������");
            }
            logger.Info("��������� ��������� ������");
        }
        private void SearchLine_Leave(object sender, EventArgs e)
        {
            AddsASearchString();
        }
        /// <summary>
        /// ��� ������ ������� "������", ����� ������������ ������������ ������ � ���� �������� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public List<Room> BusyStatusDetection()
        {
            try
            {
                using (var context = new SqliteContext())
                {
                    var rooms = context.Rooms.Where(r => r.Statuc.Equals("������"));
                    List<Room> roomsList = new List<Room>();
                    foreach (var room in rooms)
                    {
                        roomsList.Add(room);
                    }
                    return roomsList;
                }
            }
            catch (Exception ex)
            {
                logger.Fatal($"�� ������� ����������� � ���� ������, ������: {ex}");
                return null;
            }
        }
        private void BusyButton_CheckedChanged(object sender, EventArgs e)
        {
            Tabel.DataSource = BusyStatusDetection();
            Tabel.Columns["Picture"].Visible = false;
            logger.Debug("��������� ��� ������������� � ������� �� �������� '������'");
        }
        /// <summary>
        /// ��� ������ ������� "���������������", ����� ������������ ������������ ������ � ���� �������� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public List<Room> DetectingTheStatusReserved()
        {
            try
            {
                using (var context = new SqliteContext())
                {
                    var rooms = context.Rooms.Where(r => r.Statuc.Equals("���������������"));
                    List<Room> roomsList = new List<Room>();
                    foreach (var room in rooms)
                    {
                        roomsList.Add(room);
                    }
                    return roomsList;
                }
            }
            catch (Exception ex)
            {
                logger.Fatal($"�� ������� ����������� � ���� ������, ������: {ex}");
                return null;
            }
        }
        private void ReservedButton_CheckedChanged(object sender, EventArgs e)
        {
            Tabel.DataSource = DetectingTheStatusReserved();
            Tabel.Columns["Picture"].Visible = false;
            logger.Debug("��������� ��� ������������� � ������� �� �������� '���������������'");
        }
        /// <summary>
        /// ��� ������ ������� "���������", ����� ������������ ������������ ������ � ���� �������� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public List<Room> IdentificationFfStatusAvailable()
        {
            try
            {
                using (var context = new SqliteContext())
                {
                    var rooms = context.Rooms.Where(r => r.Statuc.Equals("���������"));
                    List<Room> roomsList = new List<Room>();
                    foreach (var room in rooms)
                    {
                        roomsList.Add(room);
                    }
                    return roomsList;
                }
            }
            catch (Exception ex)
            {
                logger.Fatal($"�� ������� ����������� � ���� ������, ������: {ex}");
                return null;
            }
        }
        private void FreeButton_CheckedChanged(object sender, EventArgs e)
        {
            Tabel.DataSource = IdentificationFfStatusAvailable();
            Tabel.Columns["Picture"].Visible = false;
            logger.Debug("��������� ��� ������������� � ������� �� �������� '���������'");
        }
        /// <summary>
        /// ��� ������ ������� "������������", ����� ������������ ������������ ������ � ���� �������� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public List<Room> IdentificationFfStatusDischarged()
        {
            try
            {
                using (var context = new SqliteContext())
                {
                    var rooms = context.Rooms.Where(r => r.Statuc.Equals("������������"));
                    if(rooms != null)
                    {

                    }
                    List<Room> roomsList = new List<Room>();
                    foreach (var room in rooms)
                    {
                        roomsList.Add(room);
                    }
                    return roomsList;
                }
            }
            catch(Exception ex) 
            {
                logger.Fatal($"�� ������� ����������� � ���� ������, ������: {ex}");
                return null;
            }
        }
        private void DischargedButton_CheckedChanged(object sender, EventArgs e)
        {
            Tabel.DataSource = IdentificationFfStatusDischarged();
            Tabel.Columns["Picture"].Visible = false;
            logger.Debug("��������� ��� ������������� � ������� �� �������� '���������'");
        }
        /// <summary>
        /// ��� ������� ������, ����� ������������ ���������� � ������������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tabel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // ��������, �������� �� ������� ������
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = Tabel.Rows[e.RowIndex];
                if (selectedRow.Cells["Statuc"].Value.ToString().Equals("���������������") || selectedRow.Cells["Statuc"].Value.ToString().Equals("������������")
                    || selectedRow.Cells["Statuc"].Value.ToString().Equals("������"))
                {
                    //GuestCard guestCard = new GuestCard();
                    string status = selectedRow.Cells["Statuc"].Value.ToString();
                    string fullName = selectedRow.Cells["FullName"].Value.ToString();
                    string arrivaldate = selectedRow.Cells["AarrivalDate"].Value.ToString();
                    string datedeparture = selectedRow.Cells["DaateOfdeparture"].Value.ToString();
                    ID = (int)selectedRow.Cells["ID"].Value;
                    SelectStatus.Text = status;
                    FullName.Text = fullName;
                    arrivalDate.Text = arrivaldate;
                    dateDeparture.Text = datedeparture;
                    byte[] imageBytes1 = null;
                    if (selectedRow.Cells["Picture"] != null && selectedRow.Cells["Picture"].Value != DBNull.Value)
                    {
                        imageBytes1 = (byte[])selectedRow.Cells["Picture"].Value;
                    }
                    else
                    {
                        logger.Error("���������� ������������� ���������� � ������ ������");
                    }
                    if (imageBytes1 != null)
                    {
                        MemoryStream memoryStream = new MemoryStream(imageBytes1);
                        PictureUser.Image = Image.FromStream(memoryStream);
                    }
                    else
                    {
                        logger.Warn("���������� ������� ����������");
                    }
                    ViewButton.Visible = true;
                }
                else
                {
                    PictureUser.Image = null;
                    SelectStatus.Text = "������";
                    FullName.Text = "���";
                    arrivalDate.Text = "���� �������";
                    dateDeparture.Text = "���� ������";
                    ViewButton.Visible = false;
                }
            }
        }
        /// <summary>
        /// ������ ��� ������ �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new SqliteContext())
                {
                    string value = SearchLine.Text;
                    var rooms = context.Rooms.Where(r => r.FullName.Equals(value));
                    List<Room> roomList = new List<Room>();
                    foreach (var room in rooms)
                    {
                        roomList.Add(room);
                    }
                    Tabel.DataSource = roomList;
                    Tabel.Columns["Picture"].Visible = false;
                }
            } 
            catch (Exception ex)
            {
                logger.Fatal($"���������� ����������� � ���� ������, ������: {ex}");
            }
        }
        /// <summary>
        /// �������, ������� ���������� �������� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestCard guestCard = new GuestCard();
            guestCard.Show();
            logger.Debug("�������� �������� �����");
            try
            {
                using (var context = new SqliteContext())
                {
                    var persons = context.Rooms.Where(r => r.Id == ID);
                    List<Room> list = new List<Room>();
                    foreach (var room in persons)
                    {
                        list.Add(room);
                    }
                    if (list != null)
                    {

                    }
                    Room person = list[0];
                    guestCard.FullNameCard.Text = person.FullName;
                    guestCard.DateOfBirth.Text = person.Birthday.ToString();
                    guestCard.Payment.Text = person.Defrayment.ToString();
                    guestCard.numericDays.Value = person.Days.Value;
                    if (person.Animal == 1)
                    {
                        guestCard.checkAnimal.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        guestCard.checkAnimal.CheckState = CheckState.Unchecked;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Fatal($"���������� ����������� � ���� ������, ������: {ex}");
            }
        }
        /// <summary>
        /// ����� ��� ������ �� ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            logger.Debug("����� �� ����������");
        }
        /// <summary>
        /// ����� ��� ������������ ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            logger.Debug("������������ ����������");
        }
        /// <summary>
        /// ���������� ����� ������� ��� �������� ��� ������������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchLine_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new SqliteContext())
                {
                    string personName = SearchLine.Text;
                    var roomsPerson = context.Rooms.Where(r => r.Statuc != "���������");
                    List<Room> rooms = new List<Room>();
                    List<string> names = new List<string>();
                    List<Room> foundGuests = new List<Room>();
                    foreach (var room in roomsPerson)
                    {
                        names.Add(room.FullName);
                        rooms.Add(room);
                    }
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].StartsWith(personName) && personName != string.Empty)
                        {
                            foundGuests.Add(rooms[i]);
                        }
                    }
                    Tabel.DataSource = foundGuests;
                }
            }
            catch(Exception ex)
            {
                logger.Error($"���������� ����������� � ���� ������, ������: {ex}");
            }
        }
        
    }
        
}
