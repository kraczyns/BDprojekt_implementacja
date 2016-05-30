namespace ObsługaPrzesyłekKurierskichIPocztowych
{
    partial class MessengerDesign
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
            this.imieBox = new System.Windows.Forms.TextBox();
            this.nazwiskoBox = new System.Windows.Forms.TextBox();
            this.placowkaBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(66, 122);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(130, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // imieBox
            // 
            this.imieBox.Location = new System.Drawing.Point(103, 21);
            this.imieBox.Name = "imieBox";
            this.imieBox.Size = new System.Drawing.Size(130, 20);
            this.imieBox.TabIndex = 2;
            // 
            // nazwiskoBox
            // 
            this.nazwiskoBox.Location = new System.Drawing.Point(103, 47);
            this.nazwiskoBox.Name = "nazwiskoBox";
            this.nazwiskoBox.Size = new System.Drawing.Size(130, 20);
            this.nazwiskoBox.TabIndex = 3;
            // 
            // placowkaBox
            // 
            this.placowkaBox.FormattingEnabled = true;
            this.placowkaBox.Location = new System.Drawing.Point(103, 73);
            this.placowkaBox.Name = "placowkaBox";
            this.placowkaBox.Size = new System.Drawing.Size(130, 21);
            this.placowkaBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Placówka:";
            // 
            // MessengerDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 177);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.placowkaBox);
            this.Controls.Add(this.nazwiskoBox);
            this.Controls.Add(this.imieBox);
            this.Controls.Add(this.saveButton);
            this.Name = "MessengerDesign";
            this.Text = "MessengerDesign";
            this.Load += new System.EventHandler(this.MessengerDesign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox imieBox;
        private System.Windows.Forms.TextBox nazwiskoBox;
        private System.Windows.Forms.ComboBox placowkaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}