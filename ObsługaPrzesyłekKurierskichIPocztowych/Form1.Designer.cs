namespace ObsługaPrzesyłekKurierskichIPocztowych
{
    partial class Form1
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
            this.messageTableView = new System.Windows.Forms.DataGridView();
            this.postTab = new System.Windows.Forms.TabControl();
            this.messageTab = new System.Windows.Forms.TabPage();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addButton_message = new System.Windows.Forms.Button();
            this.deleteAllButton_message = new System.Windows.Forms.Button();
            this.deleteButton_message = new System.Windows.Forms.Button();
            this.editButton_message = new System.Windows.Forms.Button();
            this.messangerTab = new System.Windows.Forms.TabPage();
            this.addButton_messanger = new System.Windows.Forms.Button();
            this.deleteAllButton_messanger = new System.Windows.Forms.Button();
            this.messangerTableView = new System.Windows.Forms.DataGridView();
            this.deleteButton_messanger = new System.Windows.Forms.Button();
            this.editButton_messanger = new System.Windows.Forms.Button();
            this.carTab = new System.Windows.Forms.TabPage();
            this.addButton_vehicle = new System.Windows.Forms.Button();
            this.deleteAllButton_vehicle = new System.Windows.Forms.Button();
            this.vehicleTableView = new System.Windows.Forms.DataGridView();
            this.deleteButton_vehicle = new System.Windows.Forms.Button();
            this.editButton_vehicle = new System.Windows.Forms.Button();
            this.graphicTab = new System.Windows.Forms.TabPage();
            this.addButton_graphic = new System.Windows.Forms.Button();
            this.deleteAllButton_graphic = new System.Windows.Forms.Button();
            this.graphicTableView = new System.Windows.Forms.DataGridView();
            this.deleteButton_graphic = new System.Windows.Forms.Button();
            this.editButton_graphic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messageTableView)).BeginInit();
            this.postTab.SuspendLayout();
            this.messageTab.SuspendLayout();
            this.messangerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messangerTableView)).BeginInit();
            this.carTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTableView)).BeginInit();
            this.graphicTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // messageTableView
            // 
            this.messageTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageTableView.Location = new System.Drawing.Point(6, 6);
            this.messageTableView.Name = "messageTableView";
            this.messageTableView.Size = new System.Drawing.Size(659, 284);
            this.messageTableView.TabIndex = 3;
            // 
            // postTab
            // 
            this.postTab.Controls.Add(this.messageTab);
            this.postTab.Controls.Add(this.messangerTab);
            this.postTab.Controls.Add(this.carTab);
            this.postTab.Controls.Add(this.graphicTab);
            this.postTab.Location = new System.Drawing.Point(15, 66);
            this.postTab.Name = "postTab";
            this.postTab.SelectedIndex = 0;
            this.postTab.Size = new System.Drawing.Size(681, 432);
            this.postTab.TabIndex = 5;
            // 
            // messageTab
            // 
            this.messageTab.Controls.Add(this.refreshButton);
            this.messageTab.Controls.Add(this.addButton_message);
            this.messageTab.Controls.Add(this.deleteAllButton_message);
            this.messageTab.Controls.Add(this.messageTableView);
            this.messageTab.Controls.Add(this.deleteButton_message);
            this.messageTab.Controls.Add(this.editButton_message);
            this.messageTab.Location = new System.Drawing.Point(4, 22);
            this.messageTab.Name = "messageTab";
            this.messageTab.Padding = new System.Windows.Forms.Padding(3);
            this.messageTab.Size = new System.Drawing.Size(673, 406);
            this.messageTab.TabIndex = 0;
            this.messageTab.Text = "Przesyłka";
            this.messageTab.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(6, 347);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(112, 53);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Odśwież";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addButton_message
            // 
            this.addButton_message.Location = new System.Drawing.Point(280, 361);
            this.addButton_message.Name = "addButton_message";
            this.addButton_message.Size = new System.Drawing.Size(127, 39);
            this.addButton_message.TabIndex = 4;
            this.addButton_message.Text = "Dodaj";
            this.addButton_message.UseVisualStyleBackColor = true;
            this.addButton_message.Click += new System.EventHandler(this.addButton_message_Click);
            // 
            // deleteAllButton_message
            // 
            this.deleteAllButton_message.Location = new System.Drawing.Point(411, 296);
            this.deleteAllButton_message.Name = "deleteAllButton_message";
            this.deleteAllButton_message.Size = new System.Drawing.Size(140, 54);
            this.deleteAllButton_message.TabIndex = 3;
            this.deleteAllButton_message.Text = "Usuń wszystko";
            this.deleteAllButton_message.UseVisualStyleBackColor = true;
            // 
            // deleteButton_message
            // 
            this.deleteButton_message.Location = new System.Drawing.Point(148, 327);
            this.deleteButton_message.Name = "deleteButton_message";
            this.deleteButton_message.Size = new System.Drawing.Size(235, 23);
            this.deleteButton_message.TabIndex = 2;
            this.deleteButton_message.Text = "Usuń";
            this.deleteButton_message.UseVisualStyleBackColor = true;
            this.deleteButton_message.Click += new System.EventHandler(this.deleteButton_message_Click);
            // 
            // editButton_message
            // 
            this.editButton_message.Location = new System.Drawing.Point(148, 296);
            this.editButton_message.Name = "editButton_message";
            this.editButton_message.Size = new System.Drawing.Size(235, 25);
            this.editButton_message.TabIndex = 1;
            this.editButton_message.Text = "Edytuj";
            this.editButton_message.UseVisualStyleBackColor = true;
            this.editButton_message.Click += new System.EventHandler(this.editButton_message_Click);
            // 
            // messangerTab
            // 
            this.messangerTab.Controls.Add(this.addButton_messanger);
            this.messangerTab.Controls.Add(this.deleteAllButton_messanger);
            this.messangerTab.Controls.Add(this.messangerTableView);
            this.messangerTab.Controls.Add(this.deleteButton_messanger);
            this.messangerTab.Controls.Add(this.editButton_messanger);
            this.messangerTab.Location = new System.Drawing.Point(4, 22);
            this.messangerTab.Name = "messangerTab";
            this.messangerTab.Padding = new System.Windows.Forms.Padding(3);
            this.messangerTab.Size = new System.Drawing.Size(673, 406);
            this.messangerTab.TabIndex = 1;
            this.messangerTab.Text = "Kurier";
            this.messangerTab.UseVisualStyleBackColor = true;
            // 
            // addButton_messanger
            // 
            this.addButton_messanger.Location = new System.Drawing.Point(281, 361);
            this.addButton_messanger.Name = "addButton_messanger";
            this.addButton_messanger.Size = new System.Drawing.Size(127, 39);
            this.addButton_messanger.TabIndex = 9;
            this.addButton_messanger.Text = "Dodaj";
            this.addButton_messanger.UseVisualStyleBackColor = true;
            // 
            // deleteAllButton_messanger
            // 
            this.deleteAllButton_messanger.Location = new System.Drawing.Point(412, 296);
            this.deleteAllButton_messanger.Name = "deleteAllButton_messanger";
            this.deleteAllButton_messanger.Size = new System.Drawing.Size(140, 54);
            this.deleteAllButton_messanger.TabIndex = 7;
            this.deleteAllButton_messanger.Text = "Usuń wszystko";
            this.deleteAllButton_messanger.UseVisualStyleBackColor = true;
            // 
            // messangerTableView
            // 
            this.messangerTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messangerTableView.Location = new System.Drawing.Point(7, 6);
            this.messangerTableView.Name = "messangerTableView";
            this.messangerTableView.Size = new System.Drawing.Size(659, 284);
            this.messangerTableView.TabIndex = 8;
            // 
            // deleteButton_messanger
            // 
            this.deleteButton_messanger.Location = new System.Drawing.Point(149, 327);
            this.deleteButton_messanger.Name = "deleteButton_messanger";
            this.deleteButton_messanger.Size = new System.Drawing.Size(235, 23);
            this.deleteButton_messanger.TabIndex = 6;
            this.deleteButton_messanger.Text = "Usuń";
            this.deleteButton_messanger.UseVisualStyleBackColor = true;
            // 
            // editButton_messanger
            // 
            this.editButton_messanger.Location = new System.Drawing.Point(149, 296);
            this.editButton_messanger.Name = "editButton_messanger";
            this.editButton_messanger.Size = new System.Drawing.Size(235, 25);
            this.editButton_messanger.TabIndex = 5;
            this.editButton_messanger.Text = "Edytuj";
            this.editButton_messanger.UseVisualStyleBackColor = true;
            // 
            // carTab
            // 
            this.carTab.Controls.Add(this.addButton_vehicle);
            this.carTab.Controls.Add(this.deleteAllButton_vehicle);
            this.carTab.Controls.Add(this.vehicleTableView);
            this.carTab.Controls.Add(this.deleteButton_vehicle);
            this.carTab.Controls.Add(this.editButton_vehicle);
            this.carTab.Location = new System.Drawing.Point(4, 22);
            this.carTab.Name = "carTab";
            this.carTab.Padding = new System.Windows.Forms.Padding(3);
            this.carTab.Size = new System.Drawing.Size(673, 406);
            this.carTab.TabIndex = 2;
            this.carTab.Text = "Pojazd";
            this.carTab.UseVisualStyleBackColor = true;
            // 
            // addButton_vehicle
            // 
            this.addButton_vehicle.Location = new System.Drawing.Point(281, 361);
            this.addButton_vehicle.Name = "addButton_vehicle";
            this.addButton_vehicle.Size = new System.Drawing.Size(127, 39);
            this.addButton_vehicle.TabIndex = 9;
            this.addButton_vehicle.Text = "Dodaj";
            this.addButton_vehicle.UseVisualStyleBackColor = true;
            // 
            // deleteAllButton_vehicle
            // 
            this.deleteAllButton_vehicle.Location = new System.Drawing.Point(412, 296);
            this.deleteAllButton_vehicle.Name = "deleteAllButton_vehicle";
            this.deleteAllButton_vehicle.Size = new System.Drawing.Size(140, 54);
            this.deleteAllButton_vehicle.TabIndex = 7;
            this.deleteAllButton_vehicle.Text = "Usuń wszystko";
            this.deleteAllButton_vehicle.UseVisualStyleBackColor = true;
            // 
            // vehicleTableView
            // 
            this.vehicleTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleTableView.Location = new System.Drawing.Point(7, 6);
            this.vehicleTableView.Name = "vehicleTableView";
            this.vehicleTableView.Size = new System.Drawing.Size(659, 284);
            this.vehicleTableView.TabIndex = 8;
            // 
            // deleteButton_vehicle
            // 
            this.deleteButton_vehicle.Location = new System.Drawing.Point(149, 327);
            this.deleteButton_vehicle.Name = "deleteButton_vehicle";
            this.deleteButton_vehicle.Size = new System.Drawing.Size(235, 23);
            this.deleteButton_vehicle.TabIndex = 6;
            this.deleteButton_vehicle.Text = "Usuń";
            this.deleteButton_vehicle.UseVisualStyleBackColor = true;
            // 
            // editButton_vehicle
            // 
            this.editButton_vehicle.Location = new System.Drawing.Point(149, 296);
            this.editButton_vehicle.Name = "editButton_vehicle";
            this.editButton_vehicle.Size = new System.Drawing.Size(235, 25);
            this.editButton_vehicle.TabIndex = 5;
            this.editButton_vehicle.Text = "Edytuj";
            this.editButton_vehicle.UseVisualStyleBackColor = true;
            // 
            // graphicTab
            // 
            this.graphicTab.Controls.Add(this.addButton_graphic);
            this.graphicTab.Controls.Add(this.deleteAllButton_graphic);
            this.graphicTab.Controls.Add(this.graphicTableView);
            this.graphicTab.Controls.Add(this.deleteButton_graphic);
            this.graphicTab.Controls.Add(this.editButton_graphic);
            this.graphicTab.Location = new System.Drawing.Point(4, 22);
            this.graphicTab.Name = "graphicTab";
            this.graphicTab.Padding = new System.Windows.Forms.Padding(3);
            this.graphicTab.Size = new System.Drawing.Size(673, 406);
            this.graphicTab.TabIndex = 3;
            this.graphicTab.Text = "Grafik";
            this.graphicTab.UseVisualStyleBackColor = true;
            // 
            // addButton_graphic
            // 
            this.addButton_graphic.Location = new System.Drawing.Point(281, 361);
            this.addButton_graphic.Name = "addButton_graphic";
            this.addButton_graphic.Size = new System.Drawing.Size(127, 39);
            this.addButton_graphic.TabIndex = 9;
            this.addButton_graphic.Text = "Dodaj";
            this.addButton_graphic.UseVisualStyleBackColor = true;
            // 
            // deleteAllButton_graphic
            // 
            this.deleteAllButton_graphic.Location = new System.Drawing.Point(412, 296);
            this.deleteAllButton_graphic.Name = "deleteAllButton_graphic";
            this.deleteAllButton_graphic.Size = new System.Drawing.Size(140, 54);
            this.deleteAllButton_graphic.TabIndex = 7;
            this.deleteAllButton_graphic.Text = "Usuń wszystko";
            this.deleteAllButton_graphic.UseVisualStyleBackColor = true;
            // 
            // graphicTableView
            // 
            this.graphicTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.graphicTableView.Location = new System.Drawing.Point(7, 6);
            this.graphicTableView.Name = "graphicTableView";
            this.graphicTableView.Size = new System.Drawing.Size(659, 284);
            this.graphicTableView.TabIndex = 8;
            // 
            // deleteButton_graphic
            // 
            this.deleteButton_graphic.Location = new System.Drawing.Point(149, 327);
            this.deleteButton_graphic.Name = "deleteButton_graphic";
            this.deleteButton_graphic.Size = new System.Drawing.Size(235, 23);
            this.deleteButton_graphic.TabIndex = 6;
            this.deleteButton_graphic.Text = "Usuń";
            this.deleteButton_graphic.UseVisualStyleBackColor = true;
            // 
            // editButton_graphic
            // 
            this.editButton_graphic.Location = new System.Drawing.Point(149, 296);
            this.editButton_graphic.Name = "editButton_graphic";
            this.editButton_graphic.Size = new System.Drawing.Size(235, 25);
            this.editButton_graphic.TabIndex = 5;
            this.editButton_graphic.Text = "Edytuj";
            this.editButton_graphic.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(104, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Obsługa Przesyłek Pocztowych i Kurierskich";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 526);
            this.Controls.Add(this.postTab);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.messageTableView)).EndInit();
            this.postTab.ResumeLayout(false);
            this.messageTab.ResumeLayout(false);
            this.messangerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.messangerTableView)).EndInit();
            this.carTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTableView)).EndInit();
            this.graphicTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphicTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView messageTableView;
        private System.Windows.Forms.TabControl postTab;
        private System.Windows.Forms.TabPage messageTab;
        private System.Windows.Forms.Button addButton_message;
        private System.Windows.Forms.Button deleteAllButton_message;
        private System.Windows.Forms.Button deleteButton_message;
        private System.Windows.Forms.Button editButton_message;
        private System.Windows.Forms.TabPage messangerTab;
        private System.Windows.Forms.TabPage carTab;
        private System.Windows.Forms.TabPage graphicTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton_messanger;
        private System.Windows.Forms.Button deleteAllButton_messanger;
        private System.Windows.Forms.DataGridView messangerTableView;
        private System.Windows.Forms.Button deleteButton_messanger;
        private System.Windows.Forms.Button editButton_messanger;
        private System.Windows.Forms.Button addButton_vehicle;
        private System.Windows.Forms.Button deleteAllButton_vehicle;
        private System.Windows.Forms.DataGridView vehicleTableView;
        private System.Windows.Forms.Button deleteButton_vehicle;
        private System.Windows.Forms.Button editButton_vehicle;
        private System.Windows.Forms.Button addButton_graphic;
        private System.Windows.Forms.Button deleteAllButton_graphic;
        private System.Windows.Forms.DataGridView graphicTableView;
        private System.Windows.Forms.Button deleteButton_graphic;
        private System.Windows.Forms.Button editButton_graphic;
        private System.Windows.Forms.Button refreshButton;
    }
}

