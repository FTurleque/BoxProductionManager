namespace BoxProductionApp.UserControls
{
    partial class ProductionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxGlobalDefectRate = new System.Windows.Forms.TextBox();
            this.txtBoxDefectRatePerHour = new System.Windows.Forms.TextBox();
            this.txtBoxBoxNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxGlobalDefectRate
            // 
            this.txtBoxGlobalDefectRate.Location = new System.Drawing.Point(265, 98);
            this.txtBoxGlobalDefectRate.Name = "txtBoxGlobalDefectRate";
            this.txtBoxGlobalDefectRate.Size = new System.Drawing.Size(100, 23);
            this.txtBoxGlobalDefectRate.TabIndex = 17;
            this.txtBoxGlobalDefectRate.Text = "0";
            // 
            // txtBoxDefectRatePerHour
            // 
            this.txtBoxDefectRatePerHour.Location = new System.Drawing.Point(265, 56);
            this.txtBoxDefectRatePerHour.Name = "txtBoxDefectRatePerHour";
            this.txtBoxDefectRatePerHour.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDefectRatePerHour.TabIndex = 16;
            this.txtBoxDefectRatePerHour.Text = "0";
            // 
            // txtBoxBoxNumber
            // 
            this.txtBoxBoxNumber.Location = new System.Drawing.Point(265, 15);
            this.txtBoxBoxNumber.Name = "txtBoxBoxNumber";
            this.txtBoxBoxNumber.Size = new System.Drawing.Size(100, 23);
            this.txtBoxBoxNumber.TabIndex = 15;
            this.txtBoxBoxNumber.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Taux défaut depuis démarrage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Taux défaut heure";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nombre de caisses depuis le démarrage";
            // 
            // productionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxGlobalDefectRate);
            this.Controls.Add(this.txtBoxDefectRatePerHour);
            this.Controls.Add(this.txtBoxBoxNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "productionControl";
            this.Size = new System.Drawing.Size(380, 143);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxGlobalDefectRate;
        private TextBox txtBoxDefectRatePerHour;
        private TextBox txtBoxBoxNumber;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
