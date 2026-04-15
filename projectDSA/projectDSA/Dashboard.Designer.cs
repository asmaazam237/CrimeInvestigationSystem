namespace projectDSA
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblDetective = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShortDistance = new System.Windows.Forms.Button();
            this.btnCrimeRecord = new System.Windows.Forms.Button();
            this.btnAddCriminal = new System.Windows.Forms.Button();
            this.btnSimulation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.lblDetective);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 455);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnLogOut.Location = new System.Drawing.Point(0, 406);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(248, 47);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblDetective
            // 
            this.lblDetective.AutoSize = true;
            this.lblDetective.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetective.ForeColor = System.Drawing.Color.White;
            this.lblDetective.Location = new System.Drawing.Point(28, 224);
            this.lblDetective.Name = "lblDetective";
            this.lblDetective.Size = new System.Drawing.Size(186, 50);
            this.lblDetective.TabIndex = 1;
            this.lblDetective.Text = "Detective";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projectDSA.Properties.Resources.detective;
            this.pictureBox1.Location = new System.Drawing.Point(59, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(311, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select an option to get started!";
            // 
            // btnShortDistance
            // 
            this.btnShortDistance.BackColor = System.Drawing.Color.SlateGray;
            this.btnShortDistance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShortDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShortDistance.Location = new System.Drawing.Point(351, 124);
            this.btnShortDistance.Name = "btnShortDistance";
            this.btnShortDistance.Size = new System.Drawing.Size(360, 55);
            this.btnShortDistance.TabIndex = 2;
            this.btnShortDistance.Text = "Find Shortest Routes";
            this.btnShortDistance.UseVisualStyleBackColor = false;
            this.btnShortDistance.Click += new System.EventHandler(this.btnShortDistance_Click);
            // 
            // btnCrimeRecord
            // 
            this.btnCrimeRecord.BackColor = System.Drawing.Color.SlateGray;
            this.btnCrimeRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrimeRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrimeRecord.Location = new System.Drawing.Point(351, 193);
            this.btnCrimeRecord.Name = "btnCrimeRecord";
            this.btnCrimeRecord.Size = new System.Drawing.Size(360, 55);
            this.btnCrimeRecord.TabIndex = 2;
            this.btnCrimeRecord.Text = "View Criminal\'s Record";
            this.btnCrimeRecord.UseVisualStyleBackColor = false;
            this.btnCrimeRecord.Click += new System.EventHandler(this.btnCrimeRecord_Click);
            // 
            // btnAddCriminal
            // 
            this.btnAddCriminal.BackColor = System.Drawing.Color.SlateGray;
            this.btnAddCriminal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCriminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCriminal.Location = new System.Drawing.Point(351, 263);
            this.btnAddCriminal.Name = "btnAddCriminal";
            this.btnAddCriminal.Size = new System.Drawing.Size(360, 55);
            this.btnAddCriminal.TabIndex = 2;
            this.btnAddCriminal.Text = "Add Criminal";
            this.btnAddCriminal.UseVisualStyleBackColor = false;
            this.btnAddCriminal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSimulation
            // 
            this.btnSimulation.BackColor = System.Drawing.Color.SlateGray;
            this.btnSimulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulation.Location = new System.Drawing.Point(351, 333);
            this.btnSimulation.Name = "btnSimulation";
            this.btnSimulation.Size = new System.Drawing.Size(360, 55);
            this.btnSimulation.TabIndex = 3;
            this.btnSimulation.Text = "Crime Analysis";
            this.btnSimulation.UseVisualStyleBackColor = false;
            this.btnSimulation.Click += new System.EventHandler(this.btnSimulation_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSimulation);
            this.Controls.Add(this.btnAddCriminal);
            this.Controls.Add(this.btnCrimeRecord);
            this.Controls.Add(this.btnShortDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDetective;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShortDistance;
        private System.Windows.Forms.Button btnCrimeRecord;
        private System.Windows.Forms.Button btnAddCriminal;
        private System.Windows.Forms.Button btnSimulation;
    }
}