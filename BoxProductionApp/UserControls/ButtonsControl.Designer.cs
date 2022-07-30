namespace BoxProductionApp.UserControls
{
    partial class ButtonsControl
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnEndedProd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.trafficLight = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnStop);
            this.groupBox.Controls.Add(this.btnRestart);
            this.groupBox.Controls.Add(this.btnEndedProd);
            this.groupBox.Controls.Add(this.btnStart);
            this.groupBox.Controls.Add(this.trafficLight);
            this.groupBox.Location = new System.Drawing.Point(3, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(133, 138);
            this.groupBox.TabIndex = 25;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Production";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(51, 80);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 20;
            this.btnStop.Text = "Arrêter";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.StanByProd_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(51, 51);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 19;
            this.btnRestart.Text = "Continuer";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.RestartProd_Click);
            // 
            // btnEndedProd
            // 
            this.btnEndedProd.Enabled = false;
            this.btnEndedProd.Location = new System.Drawing.Point(7, 109);
            this.btnEndedProd.Name = "btnEndedProd";
            this.btnEndedProd.Size = new System.Drawing.Size(119, 23);
            this.btnEndedProd.TabIndex = 26;
            this.btnEndedProd.Text = "Terminer Prod";
            this.btnEndedProd.UseVisualStyleBackColor = true;
            this.btnEndedProd.Click += new System.EventHandler(this.EndedProd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(51, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Démarer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.StartProd_Click);
            // 
            // trafficLight
            // 
            this.trafficLight.BackgroundImage = global::BoxProductionApp.Properties.Resources.Red;
            this.trafficLight.Enabled = false;
            this.trafficLight.Location = new System.Drawing.Point(7, 30);
            this.trafficLight.Name = "trafficLight";
            this.trafficLight.Size = new System.Drawing.Size(32, 66);
            this.trafficLight.TabIndex = 17;
            this.trafficLight.UseVisualStyleBackColor = true;
            // 
            // ButtonsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "ButtonsControl";
            this.Size = new System.Drawing.Size(145, 150);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox;
        private Button btnStop;
        private Button btnRestart;
        private Button btnEndedProd;
        private Button btnStart;
        private Button trafficLight;
    }
}
