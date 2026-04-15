namespace projectDSA
{
    partial class CriminalRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriminalRecord));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectArea = new System.Windows.Forms.ComboBox();
            this.lstViewRec = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the area to view criminal\'s record";
            // 
            // cbSelectArea
            // 
            this.cbSelectArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectArea.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectArea.FormattingEnabled = true;
            this.cbSelectArea.Items.AddRange(new object[] {
            "Clifton",
            "Saddar",
            "Kharadar",
            "Korangi",
            "Gulshan-e-Iqbal",
            "Gulistan-e-Jauhar",
            "DHA",
            "Malir",
            "North Nazimabad",
            "Nazimabad",
            "Orangi Town",
            "Shah Faisal Colony"});
            this.cbSelectArea.Location = new System.Drawing.Point(236, 52);
            this.cbSelectArea.Name = "cbSelectArea";
            this.cbSelectArea.Size = new System.Drawing.Size(394, 28);
            this.cbSelectArea.TabIndex = 2;
            this.cbSelectArea.SelectedIndexChanged += new System.EventHandler(this.cbSelectArea_SelectedIndexChanged);
            // 
            // lstViewRec
            // 
            this.lstViewRec.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewRec.FormattingEnabled = true;
            this.lstViewRec.ItemHeight = 23;
            this.lstViewRec.Location = new System.Drawing.Point(16, 89);
            this.lstViewRec.Name = "lstViewRec";
            this.lstViewRec.Size = new System.Drawing.Size(814, 372);
            this.lstViewRec.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(641, 473);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(188, 53);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projectDSA.Properties.Resources.detective;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CriminalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(842, 538);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstViewRec);
            this.Controls.Add(this.cbSelectArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriminalRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriminalRecord";
            this.Load += new System.EventHandler(this.CriminalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectArea;
        private System.Windows.Forms.ListBox lstViewRec;
        private System.Windows.Forms.Button btnBack;
    }
}