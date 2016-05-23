namespace ObsługaPrzesyłekKurierskichIPocztowych
{
    partial class MessageDesign
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
            this.saveButton = new System.Windows.Forms.Button();
            this.adressBox = new System.Windows.Forms.GroupBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.recipientBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.recipientName = new System.Windows.Forms.TextBox();
            this.recipientSurname = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.messangersBox = new System.Windows.Forms.ComboBox();
            this.dateReceive = new System.Windows.Forms.DateTimePicker();
            this.cost = new System.Windows.Forms.TextBox();
            this.dateSend = new System.Windows.Forms.DateTimePicker();
            this.size = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentLater = new System.Windows.Forms.CheckBox();
            this.priority = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.ComboBox();
            this.messangerWithFewerJobButton = new System.Windows.Forms.Button();
            this.messangerFound = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adressBox.SuspendLayout();
            this.recipientBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(255, 356);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 38);
            this.saveButton.TabIndex = 86;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // adressBox
            // 
            this.adressBox.Controls.Add(this.address);
            this.adressBox.Controls.Add(this.label11);
            this.adressBox.Location = new System.Drawing.Point(318, 119);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(274, 62);
            this.adressBox.TabIndex = 85;
            this.adressBox.TabStop = false;
            this.adressBox.Text = "Adres doręczenia";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(15, 27);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(244, 20);
            this.address.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 59;
            // 
            // recipientBox
            // 
            this.recipientBox.Controls.Add(this.label14);
            this.recipientBox.Controls.Add(this.label13);
            this.recipientBox.Controls.Add(this.recipientName);
            this.recipientBox.Controls.Add(this.recipientSurname);
            this.recipientBox.Location = new System.Drawing.Point(21, 119);
            this.recipientBox.Name = "recipientBox";
            this.recipientBox.Size = new System.Drawing.Size(273, 100);
            this.recipientBox.TabIndex = 83;
            this.recipientBox.TabStop = false;
            this.recipientBox.Text = "Odbiorca";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Imię";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Nazwisko";
            // 
            // recipientName
            // 
            this.recipientName.Location = new System.Drawing.Point(71, 35);
            this.recipientName.Name = "recipientName";
            this.recipientName.Size = new System.Drawing.Size(188, 20);
            this.recipientName.TabIndex = 50;
            // 
            // recipientSurname
            // 
            this.recipientSurname.Location = new System.Drawing.Point(71, 61);
            this.recipientSurname.Name = "recipientSurname";
            this.recipientSurname.Size = new System.Drawing.Size(188, 20);
            this.recipientSurname.TabIndex = 51;
            // 
            // status
            // 
            this.status.AutoCompleteCustomSource.AddRange(new string[] {
            "u kuriera",
            "dostarczona",
            "gotowa"});
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Gotowe",
            "U kuriera",
            "Dostarczono"});
            this.status.Location = new System.Drawing.Point(387, 240);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(213, 21);
            this.status.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Kurier";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(315, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 81;
            this.label16.Text = "Status";
            // 
            // messangersBox
            // 
            this.messangersBox.FormattingEnabled = true;
            this.messangersBox.Location = new System.Drawing.Point(76, 63);
            this.messangersBox.Name = "messangersBox";
            this.messangersBox.Size = new System.Drawing.Size(188, 21);
            this.messangersBox.TabIndex = 77;
            // 
            // dateReceive
            // 
            this.dateReceive.Location = new System.Drawing.Point(392, 305);
            this.dateReceive.Name = "dateReceive";
            this.dateReceive.Size = new System.Drawing.Size(208, 20);
            this.dateReceive.TabIndex = 80;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(86, 310);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(188, 20);
            this.cost.TabIndex = 79;
            // 
            // dateSend
            // 
            this.dateSend.Location = new System.Drawing.Point(389, 274);
            this.dateSend.Name = "dateSend";
            this.dateSend.Size = new System.Drawing.Size(211, 20);
            this.dateSend.TabIndex = 78;
            // 
            // size
            // 
            this.size.AutoCompleteCustomSource.AddRange(new string[] {
            "pocztówka",
            "list",
            "mała paczka",
            "średnia paczka",
            "duża paczka",
            "wielka paczka"});
            this.size.FormattingEnabled = true;
            this.size.Items.AddRange(new object[] {
            "Pocztówka",
            "List",
            "Mała paczka",
            "Średnia paczka",
            "Duża paczka",
            "Wielka paczka"});
            this.size.Location = new System.Drawing.Point(86, 243);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(188, 21);
            this.size.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Data odbioru";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Data nadania";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Należność";
            // 
            // paymentLater
            // 
            this.paymentLater.AutoSize = true;
            this.paymentLater.Location = new System.Drawing.Point(76, 293);
            this.paymentLater.Name = "paymentLater";
            this.paymentLater.Size = new System.Drawing.Size(91, 17);
            this.paymentLater.TabIndex = 71;
            this.paymentLater.Text = "Za pobraniem";
            this.paymentLater.UseVisualStyleBackColor = true;
            // 
            // priority
            // 
            this.priority.AutoSize = true;
            this.priority.Location = new System.Drawing.Point(76, 270);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(64, 17);
            this.priority.TabIndex = 70;
            this.priority.Text = "Priorytet";
            this.priority.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Rozmiar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(198, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Dodawanie/edycja przesyłki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Placówka";
            // 
            // city
            // 
            this.city.AutoCompleteCustomSource.AddRange(new string[] {
            "Wroclaw",
            "Warszawa"});
            this.city.FormattingEnabled = true;
            this.city.Location = new System.Drawing.Point(387, 186);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(213, 21);
            this.city.TabIndex = 89;
            // 
            // messangerWithFewerJobButton
            // 
            this.messangerWithFewerJobButton.Location = new System.Drawing.Point(351, 45);
            this.messangerWithFewerJobButton.Name = "messangerWithFewerJobButton";
            this.messangerWithFewerJobButton.Size = new System.Drawing.Size(192, 34);
            this.messangerWithFewerJobButton.TabIndex = 90;
            this.messangerWithFewerJobButton.Text = "Kurier z najmniejszą liczbą zleceń";
            this.messangerWithFewerJobButton.UseVisualStyleBackColor = true;
            this.messangerWithFewerJobButton.Click += new System.EventHandler(this.messangerWithFewerJobButton_Click);
            // 
            // messangerFound
            // 
            this.messangerFound.Location = new System.Drawing.Point(351, 85);
            this.messangerFound.Name = "messangerFound";
            this.messangerFound.Size = new System.Drawing.Size(192, 20);
            this.messangerFound.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "LUB";
            // 
            // MessageDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.messangerFound);
            this.Controls.Add(this.messangerWithFewerJobButton);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.adressBox);
            this.Controls.Add(this.recipientBox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.messangersBox);
            this.Controls.Add(this.dateReceive);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.dateSend);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paymentLater);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.label4);
            this.Name = "MessageDesign";
            this.Text = "MessageDesign";
            this.adressBox.ResumeLayout(false);
            this.adressBox.PerformLayout();
            this.recipientBox.ResumeLayout(false);
            this.recipientBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox adressBox;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox recipientBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox recipientName;
        private System.Windows.Forms.TextBox recipientSurname;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox messangersBox;
        private System.Windows.Forms.DateTimePicker dateReceive;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.DateTimePicker dateSend;
        private System.Windows.Forms.ComboBox size;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox paymentLater;
        private System.Windows.Forms.CheckBox priority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.Button messangerWithFewerJobButton;
        private System.Windows.Forms.TextBox messangerFound;
        private System.Windows.Forms.Label label3;
    }
}