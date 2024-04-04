namespace Hotel
{
    partial class GuestCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DateOfBirth = new Label();
            FullNameCard = new Label();
            numericDays = new NumericUpDown();
            checkAnimal = new CheckBox();
            DaysText = new Label();
            Payment = new ComboBox();
            Card = new Label();
            CloseButton = new Button();
            CollapseButton = new Button();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericDays).BeginInit();
            SuspendLayout();
            // 
            // DateOfBirth
            // 
            DateOfBirth.BackColor = Color.White;
            DateOfBirth.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DateOfBirth.Location = new Point(87, 187);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(313, 32);
            DateOfBirth.TabIndex = 22;
            DateOfBirth.Text = "Дата рождения";
            // 
            // FullNameCard
            // 
            FullNameCard.BackColor = Color.White;
            FullNameCard.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameCard.Location = new Point(87, 115);
            FullNameCard.Name = "FullNameCard";
            FullNameCard.Size = new Size(313, 29);
            FullNameCard.TabIndex = 21;
            FullNameCard.Text = "ФИО";
            // 
            // numericDays
            // 
            numericDays.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericDays.Location = new Point(70, 346);
            numericDays.Name = "numericDays";
            numericDays.Size = new Size(120, 29);
            numericDays.TabIndex = 20;
            // 
            // checkAnimal
            // 
            checkAnimal.AutoSize = true;
            checkAnimal.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkAnimal.Location = new Point(44, 398);
            checkAnimal.Name = "checkAnimal";
            checkAnimal.Size = new Size(181, 19);
            checkAnimal.TabIndex = 19;
            checkAnimal.Text = "Путешествую с животными";
            checkAnimal.UseVisualStyleBackColor = true;
            // 
            // DaysText
            // 
            DaysText.AutoSize = true;
            DaysText.BackColor = SystemColors.Window;
            DaysText.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DaysText.ForeColor = Color.Red;
            DaysText.Location = new Point(260, 346);
            DaysText.Name = "DaysText";
            DaysText.Size = new Size(210, 31);
            DaysText.TabIndex = 18;
            DaysText.Text = "Количество дней";
            // 
            // Payment
            // 
            Payment.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Payment.FormattingEnabled = true;
            Payment.Location = new Point(87, 267);
            Payment.Name = "Payment";
            Payment.Size = new Size(313, 31);
            Payment.TabIndex = 17;
            Payment.Text = "Оплата";
            // 
            // Card
            // 
            Card.AutoSize = true;
            Card.BackColor = SystemColors.Window;
            Card.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Card.ForeColor = Color.Red;
            Card.Location = new Point(135, 34);
            Card.Name = "Card";
            Card.Size = new Size(201, 33);
            Card.TabIndex = 16;
            Card.Text = "Карточка Гостя";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Red;
            CloseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(463, 2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 23);
            CloseButton.TabIndex = 23;
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
            CollapseButton.Location = new Point(429, 2);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(35, 23);
            CollapseButton.TabIndex = 24;
            CollapseButton.Text = "—";
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Click += CollapseButton_Click;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(1, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(66, 36);
            BackButton.TabIndex = 25;
            BackButton.Text = "Назад";
            BackButton.TextAlign = ContentAlignment.TopLeft;
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // GuestCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 450);
            Controls.Add(BackButton);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(DateOfBirth);
            Controls.Add(FullNameCard);
            Controls.Add(numericDays);
            Controls.Add(checkAnimal);
            Controls.Add(DaysText);
            Controls.Add(Payment);
            Controls.Add(Card);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GuestCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuestCard";
            Load += GuestCard_Load;
            ((System.ComponentModel.ISupportInitialize)numericDays).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label DaysText;
        private Label Card;
        private Button CloseButton;
        private Button CollapseButton;
        private Button BackButton;
        public Label DateOfBirth;
        public Label FullNameCard;
        public NumericUpDown numericDays;
        public CheckBox checkAnimal;
        public ComboBox Payment;
    }
}