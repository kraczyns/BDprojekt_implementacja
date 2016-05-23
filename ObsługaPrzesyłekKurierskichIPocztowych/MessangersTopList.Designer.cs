namespace ObsługaPrzesyłekKurierskichIPocztowych
{
    partial class MessangersTopList
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
            this.messangersTopListTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messangersTopListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // messangersTopListTable
            // 
            this.messangersTopListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messangersTopListTable.Location = new System.Drawing.Point(12, 49);
            this.messangersTopListTable.Name = "messangersTopListTable";
            this.messangersTopListTable.Size = new System.Drawing.Size(627, 340);
            this.messangersTopListTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ranking kurierów";
            // 
            // MessangersTopList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messangersTopListTable);
            this.Name = "MessangersTopList";
            this.Text = "MessangersTopList";
            ((System.ComponentModel.ISupportInitialize)(this.messangersTopListTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView messangersTopListTable;
        private System.Windows.Forms.Label label1;
    }
}