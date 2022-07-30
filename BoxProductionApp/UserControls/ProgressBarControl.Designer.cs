namespace BoxProductionApp.UserControls
{
    partial class ProgressBarControl
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
            this.lblProdName = new System.Windows.Forms.Label();
            this.progressBarProd = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProdName.Location = new System.Drawing.Point(16, 16);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(86, 21);
            this.lblProdName.TabIndex = 4;
            this.lblProdName.Text = "Production";
            // 
            // progressBarProd
            // 
            this.progressBarProd.Location = new System.Drawing.Point(194, 14);
            this.progressBarProd.Name = "progressBarProd";
            this.progressBarProd.Size = new System.Drawing.Size(396, 23);
            this.progressBarProd.TabIndex = 3;
            // 
            // ProgressBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.progressBarProd);
            this.Name = "ProgressBarControl";
            this.Size = new System.Drawing.Size(606, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProdName;
        private ProgressBar progressBarProd;
    }
}
