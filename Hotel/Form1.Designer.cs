namespace Hotel
{
    partial class MyHotel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyHotel));
            label2 = new Label();
            label1 = new Label();
            panel_3 = new Panel();
            FullName = new Label();
            ViewButton = new Button();
            dateDeparture = new Label();
            arrivalDate = new Label();
            dateDepartureText = new Label();
            arrivalDateText = new Label();
            SelectStatus = new ComboBox();
            TextStatus_2 = new Label();
            PictureUser = new PictureBox();
            TextNumber = new Label();
            panel_2 = new Panel();
            Tabel = new DataGridView();
            TextGuest = new Label();
            panel_1 = new Panel();
            DischargedButton = new RadioButton();
            BusyButton = new RadioButton();
            FreeButton = new RadioButton();
            ReservedButton = new RadioButton();
            TextStatus = new Label();
            SearchButton = new PictureBox();
            SearchLine = new TextBox();
            WatchPicture = new PictureBox();
            Time = new Label();
            Menu = new PictureBox();
            Timer = new System.Windows.Forms.Timer(components);
            CloseButton = new Button();
            CollapseButton = new Button();
            panel_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureUser).BeginInit();
            panel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabel).BeginInit();
            panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WatchPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Menu).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.RoyalBlue;
            label2.Location = new Point(243, 64);
            label2.Name = "label2";
            label2.Size = new Size(10, 426);
            label2.TabIndex = 19;
            // 
            // label1
            // 
            label1.BackColor = Color.RoyalBlue;
            label1.Location = new Point(747, 64);
            label1.Name = "label1";
            label1.Size = new Size(10, 429);
            label1.TabIndex = 18;
            // 
            // panel_3
            // 
            panel_3.Controls.Add(FullName);
            panel_3.Controls.Add(ViewButton);
            panel_3.Controls.Add(dateDeparture);
            panel_3.Controls.Add(arrivalDate);
            panel_3.Controls.Add(dateDepartureText);
            panel_3.Controls.Add(arrivalDateText);
            panel_3.Controls.Add(SelectStatus);
            panel_3.Controls.Add(TextStatus_2);
            panel_3.Controls.Add(PictureUser);
            panel_3.Controls.Add(TextNumber);
            panel_3.Location = new Point(763, 80);
            panel_3.Name = "panel_3";
            panel_3.Size = new Size(294, 413);
            panel_3.TabIndex = 17;
            // 
            // FullName
            // 
            FullName.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullName.Location = new Point(3, 224);
            FullName.Name = "FullName";
            FullName.Size = new Size(270, 28);
            FullName.TabIndex = 11;
            FullName.Text = "ФИО";
            // 
            // ViewButton
            // 
            ViewButton.Location = new Point(142, 361);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(131, 30);
            ViewButton.TabIndex = 10;
            ViewButton.Text = "Просмотр карточки";
            ViewButton.UseVisualStyleBackColor = true;
            ViewButton.Visible = false;
            ViewButton.Click += ViewButton_Click;
            // 
            // dateDeparture
            // 
            dateDeparture.AutoSize = true;
            dateDeparture.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateDeparture.Location = new Point(162, 304);
            dateDeparture.Name = "dateDeparture";
            dateDeparture.Size = new Size(92, 21);
            dateDeparture.TabIndex = 9;
            dateDeparture.Text = "31.03.2024";
            // 
            // arrivalDate
            // 
            arrivalDate.AutoSize = true;
            arrivalDate.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            arrivalDate.Location = new Point(162, 265);
            arrivalDate.Name = "arrivalDate";
            arrivalDate.Size = new Size(92, 21);
            arrivalDate.TabIndex = 8;
            arrivalDate.Text = "30.03.2024";
            // 
            // dateDepartureText
            // 
            dateDepartureText.AutoSize = true;
            dateDepartureText.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateDepartureText.Location = new Point(3, 304);
            dateDepartureText.Name = "dateDepartureText";
            dateDepartureText.Size = new Size(108, 21);
            dateDepartureText.TabIndex = 7;
            dateDepartureText.Text = "Дата выезда";
            // 
            // arrivalDateText
            // 
            arrivalDateText.AutoSize = true;
            arrivalDateText.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            arrivalDateText.Location = new Point(3, 265);
            arrivalDateText.Name = "arrivalDateText";
            arrivalDateText.Size = new Size(102, 21);
            arrivalDateText.TabIndex = 6;
            arrivalDateText.Text = "Дата заезда";
            // 
            // SelectStatus
            // 
            SelectStatus.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SelectStatus.FormattingEnabled = true;
            SelectStatus.Location = new Point(86, 181);
            SelectStatus.Name = "SelectStatus";
            SelectStatus.Size = new Size(196, 29);
            SelectStatus.TabIndex = 4;
            SelectStatus.Text = "Статус";
            // 
            // TextStatus_2
            // 
            TextStatus_2.AutoSize = true;
            TextStatus_2.BackColor = SystemColors.ControlLight;
            TextStatus_2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextStatus_2.Location = new Point(12, 184);
            TextStatus_2.Name = "TextStatus_2";
            TextStatus_2.Size = new Size(68, 23);
            TextStatus_2.TabIndex = 3;
            TextStatus_2.Text = "Статус";
            // 
            // PictureUser
            // 
            PictureUser.Image = (Image)resources.GetObject("PictureUser.Image");
            PictureUser.Location = new Point(64, 38);
            PictureUser.Name = "PictureUser";
            PictureUser.Size = new Size(176, 129);
            PictureUser.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureUser.TabIndex = 2;
            PictureUser.TabStop = false;
            // 
            // TextNumber
            // 
            TextNumber.BackColor = Color.FromArgb(255, 224, 192);
            TextNumber.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextNumber.ForeColor = Color.Cyan;
            TextNumber.Location = new Point(3, 0);
            TextNumber.Name = "TextNumber";
            TextNumber.Size = new Size(286, 34);
            TextNumber.TabIndex = 1;
            TextNumber.Text = "Номер №";
            TextNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_2
            // 
            panel_2.Controls.Add(Tabel);
            panel_2.Controls.Add(TextGuest);
            panel_2.Location = new Point(256, 80);
            panel_2.Name = "panel_2";
            panel_2.Size = new Size(485, 413);
            panel_2.TabIndex = 16;
            // 
            // Tabel
            // 
            Tabel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabel.Location = new Point(3, 38);
            Tabel.Name = "Tabel";
            Tabel.Size = new Size(479, 372);
            Tabel.TabIndex = 2;
            Tabel.CellDoubleClick += Tabel_CellDoubleClick;
            // 
            // TextGuest
            // 
            TextGuest.BackColor = Color.FromArgb(255, 224, 192);
            TextGuest.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextGuest.ForeColor = Color.Cyan;
            TextGuest.Location = new Point(3, 0);
            TextGuest.Name = "TextGuest";
            TextGuest.Size = new Size(481, 34);
            TextGuest.TabIndex = 1;
            TextGuest.Text = "Списки гостей";
            TextGuest.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_1
            // 
            panel_1.Controls.Add(DischargedButton);
            panel_1.Controls.Add(BusyButton);
            panel_1.Controls.Add(FreeButton);
            panel_1.Controls.Add(ReservedButton);
            panel_1.Controls.Add(TextStatus);
            panel_1.Location = new Point(4, 80);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(233, 410);
            panel_1.TabIndex = 15;
            // 
            // DischargedButton
            // 
            DischargedButton.AutoSize = true;
            DischargedButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DischargedButton.Location = new Point(10, 180);
            DischargedButton.Name = "DischargedButton";
            DischargedButton.Size = new Size(164, 27);
            DischargedButton.TabIndex = 10;
            DischargedButton.TabStop = true;
            DischargedButton.Text = "Выписываются";
            DischargedButton.UseVisualStyleBackColor = true;
            DischargedButton.CheckedChanged += DischargedButton_CheckedChanged;
            // 
            // BusyButton
            // 
            BusyButton.AutoSize = true;
            BusyButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BusyButton.Location = new Point(10, 144);
            BusyButton.Name = "BusyButton";
            BusyButton.Size = new Size(101, 27);
            BusyButton.TabIndex = 9;
            BusyButton.TabStop = true;
            BusyButton.Text = "Занятые";
            BusyButton.UseVisualStyleBackColor = true;
            BusyButton.CheckedChanged += BusyButton_CheckedChanged;
            // 
            // FreeButton
            // 
            FreeButton.AutoSize = true;
            FreeButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FreeButton.Location = new Point(10, 111);
            FreeButton.Name = "FreeButton";
            FreeButton.Size = new Size(129, 27);
            FreeButton.TabIndex = 8;
            FreeButton.TabStop = true;
            FreeButton.Text = "Свободные";
            FreeButton.UseVisualStyleBackColor = true;
            FreeButton.CheckedChanged += FreeButton_CheckedChanged;
            // 
            // ReservedButton
            // 
            ReservedButton.AutoSize = true;
            ReservedButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ReservedButton.Location = new Point(10, 78);
            ReservedButton.Name = "ReservedButton";
            ReservedButton.Size = new Size(177, 27);
            ReservedButton.TabIndex = 1;
            ReservedButton.TabStop = true;
            ReservedButton.Text = "Зарезервировано";
            ReservedButton.UseVisualStyleBackColor = true;
            ReservedButton.CheckedChanged += ReservedButton_CheckedChanged;
            // 
            // TextStatus
            // 
            TextStatus.BackColor = Color.FromArgb(255, 224, 192);
            TextStatus.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextStatus.ForeColor = Color.Cyan;
            TextStatus.Location = new Point(3, 0);
            TextStatus.Name = "TextStatus";
            TextStatus.Size = new Size(227, 34);
            TextStatus.TabIndex = 0;
            TextStatus.Text = "Статус";
            TextStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchButton
            // 
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.Location = new Point(873, 17);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(43, 42);
            SearchButton.SizeMode = PictureBoxSizeMode.StretchImage;
            SearchButton.TabIndex = 14;
            SearchButton.TabStop = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchLine
            // 
            SearchLine.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchLine.Location = new Point(304, 22);
            SearchLine.Name = "SearchLine";
            SearchLine.Size = new Size(563, 26);
            SearchLine.TabIndex = 13;
            SearchLine.Text = "Поиск...";
            SearchLine.TextChanged += SearchLine_TextChanged;
            SearchLine.Enter += SearchLine_Enter;
            SearchLine.Leave += SearchLine_Leave;
            // 
            // WatchPicture
            // 
            WatchPicture.Image = (Image)resources.GetObject("WatchPicture.Image");
            WatchPicture.Location = new Point(256, 17);
            WatchPicture.Name = "WatchPicture";
            WatchPicture.Size = new Size(36, 31);
            WatchPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            WatchPicture.TabIndex = 12;
            WatchPicture.TabStop = false;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.BackColor = SystemColors.ControlLightLight;
            Time.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Time.ForeColor = SystemColors.ActiveCaptionText;
            Time.Location = new Point(77, 17);
            Time.Name = "Time";
            Time.Size = new Size(173, 31);
            Time.TabIndex = 11;
            Time.Text = "00:00:00 A.M.";
            // 
            // Menu
            // 
            Menu.Image = (Image)resources.GetObject("Menu.Image");
            Menu.Location = new Point(12, 12);
            Menu.Name = "Menu";
            Menu.Size = new Size(57, 48);
            Menu.SizeMode = PictureBoxSizeMode.StretchImage;
            Menu.TabIndex = 10;
            Menu.TabStop = false;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Red;
            CloseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(1022, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 23);
            CloseButton.TabIndex = 20;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // CollapseButton
            // 
            CollapseButton.Anchor = AnchorStyles.Bottom;
            CollapseButton.BackColor = Color.FromArgb(128, 128, 255);
            CollapseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CollapseButton.ForeColor = Color.White;
            CollapseButton.Location = new Point(987, 0);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(35, 23);
            CollapseButton.TabIndex = 22;
            CollapseButton.Text = "—";
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Click += CollapseButton_Click;
            // 
            // MyHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 495);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel_3);
            Controls.Add(panel_2);
            Controls.Add(panel_1);
            Controls.Add(SearchButton);
            Controls.Add(SearchLine);
            Controls.Add(WatchPicture);
            Controls.Add(Time);
            Controls.Add(Menu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyHotel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel_3.ResumeLayout(false);
            panel_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureUser).EndInit();
            panel_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Tabel).EndInit();
            panel_1.ResumeLayout(false);
            panel_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)WatchPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel_3;
        private Label FullName;
        private Button ViewButton;
        private Label dateDeparture;
        private Label arrivalDate;
        private Label dateDepartureText;
        private Label arrivalDateText;
        private ComboBox SelectStatus;
        private Label TextStatus_2;
        private PictureBox PictureUser;
        private Label TextNumber;
        private Panel panel_2;
        private DataGridView Tabel;
        private Label TextGuest;
        private Panel panel_1;
        private RadioButton DischargedButton;
        private RadioButton BusyButton;
        private RadioButton FreeButton;
        private RadioButton ReservedButton;
        private Label TextStatus;
        private PictureBox SearchButton;
        private TextBox SearchLine;
        private PictureBox WatchPicture;
        private Label Time;
        private PictureBox Menu;
        private System.Windows.Forms.Timer Timer;
        private Button CloseButton;
        private Button CollapseButton;
    }
}
