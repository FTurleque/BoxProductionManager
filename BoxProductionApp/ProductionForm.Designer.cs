using BoxProductionApp.UserControls;

namespace BoxProductionApp
{
    partial class ProductionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.productionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startAMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startBMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stopBMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stopCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.continueMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.continueAMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.continueBMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.continueCMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBoxA = new System.Windows.Forms.ToolStripStatusLabel();
            this.boxA = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBoxB = new System.Windows.Forms.ToolStripStatusLabel();
            this.boxB = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBoxC = new System.Windows.Forms.ToolStripStatusLabel();
            this.boxC = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageA = new System.Windows.Forms.TabPage();
            this.prodControlA = new BoxProductionApp.UserControls.ProductionControl();
            this.tabPageB = new System.Windows.Forms.TabPage();
            this.prodControlB = new BoxProductionApp.UserControls.ProductionControl();
            this.tabPageC = new System.Windows.Forms.TabPage();
            this.prodControlC = new BoxProductionApp.UserControls.ProductionControl();
            this.progressBarControlA = new BoxProductionApp.UserControls.ProgressBarControl();
            this.progressBarControlC = new BoxProductionApp.UserControls.ProgressBarControl();
            this.progressBarControlB = new BoxProductionApp.UserControls.ProgressBarControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnsControlA = new BoxProductionApp.UserControls.ButtonsControl();
            this.btnsControlB = new BoxProductionApp.UserControls.ButtonsControl();
            this.btnsControlC = new BoxProductionApp.UserControls.ButtonsControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageA.SuspendLayout();
            this.tabPageB.SuspendLayout();
            this.tabPageC.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.productionMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(54, 20);
            this.fileMenu.Text = "&Fichier";
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(111, 22);
            this.exitMenu.Text = "&Quitter";
            this.exitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // productionMenu
            // 
            this.productionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMenu,
            this.stopMenu,
            this.continueMenu});
            this.productionMenu.Name = "productionMenu";
            this.productionMenu.Size = new System.Drawing.Size(78, 20);
            this.productionMenu.Text = "&Production";
            // 
            // startMenu
            // 
            this.startMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAMenu,
            this.startBMenu,
            this.startCMenu});
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(180, 22);
            this.startMenu.Text = "&Démarer";
            // 
            // startAMenu
            // 
            this.startAMenu.Name = "startAMenu";
            this.startAMenu.Size = new System.Drawing.Size(180, 22);
            this.startAMenu.Text = "A";
            this.startAMenu.Click += new System.EventHandler(this.StartProd_Click);
            // 
            // startBMenu
            // 
            this.startBMenu.Name = "startBMenu";
            this.startBMenu.Size = new System.Drawing.Size(180, 22);
            this.startBMenu.Text = "B";
            this.startBMenu.Click += new System.EventHandler(this.StartProd_Click);
            // 
            // startCMenu
            // 
            this.startCMenu.Name = "startCMenu";
            this.startCMenu.Size = new System.Drawing.Size(180, 22);
            this.startCMenu.Text = "C";
            this.startCMenu.Click += new System.EventHandler(this.StartProd_Click);
            // 
            // stopMenu
            // 
            this.stopMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopAMenu,
            this.stopBMenu,
            this.stopCMenu});
            this.stopMenu.Name = "stopMenu";
            this.stopMenu.Size = new System.Drawing.Size(180, 22);
            this.stopMenu.Text = "&Arrêter";
            // 
            // stopAMenu
            // 
            this.stopAMenu.BackColor = System.Drawing.Color.Gray;
            this.stopAMenu.Enabled = false;
            this.stopAMenu.Name = "stopAMenu";
            this.stopAMenu.Size = new System.Drawing.Size(180, 22);
            this.stopAMenu.Text = "A";
            this.stopAMenu.Click += new System.EventHandler(this.StopProd_Click);
            // 
            // stopBMenu
            // 
            this.stopBMenu.BackColor = System.Drawing.Color.Gray;
            this.stopBMenu.Enabled = false;
            this.stopBMenu.Name = "stopBMenu";
            this.stopBMenu.Size = new System.Drawing.Size(180, 22);
            this.stopBMenu.Text = "B";
            this.stopBMenu.Click += new System.EventHandler(this.StopProd_Click);
            // 
            // stopCMenu
            // 
            this.stopCMenu.BackColor = System.Drawing.Color.Gray;
            this.stopCMenu.Enabled = false;
            this.stopCMenu.Name = "stopCMenu";
            this.stopCMenu.Size = new System.Drawing.Size(180, 22);
            this.stopCMenu.Text = "C";
            this.stopCMenu.Click += new System.EventHandler(this.StopProd_Click);
            // 
            // continueMenu
            // 
            this.continueMenu.BackColor = System.Drawing.Color.Transparent;
            this.continueMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.continueAMenu,
            this.continueBMenu,
            this.continueCMenu});
            this.continueMenu.Name = "continueMenu";
            this.continueMenu.Size = new System.Drawing.Size(180, 22);
            this.continueMenu.Text = "&Continuer";
            // 
            // continueAMenu
            // 
            this.continueAMenu.BackColor = System.Drawing.Color.Gray;
            this.continueAMenu.Enabled = false;
            this.continueAMenu.Name = "continueAMenu";
            this.continueAMenu.Size = new System.Drawing.Size(180, 22);
            this.continueAMenu.Text = "A";
            this.continueAMenu.Click += new System.EventHandler(this.ContinueProd_Click);
            // 
            // continueBMenu
            // 
            this.continueBMenu.BackColor = System.Drawing.Color.Gray;
            this.continueBMenu.Enabled = false;
            this.continueBMenu.Name = "continueBMenu";
            this.continueBMenu.Size = new System.Drawing.Size(180, 22);
            this.continueBMenu.Text = "B";
            this.continueBMenu.Click += new System.EventHandler(this.ContinueProd_Click);
            // 
            // continueCMenu
            // 
            this.continueCMenu.BackColor = System.Drawing.Color.Gray;
            this.continueCMenu.Enabled = false;
            this.continueCMenu.Name = "continueCMenu";
            this.continueCMenu.Size = new System.Drawing.Size(180, 22);
            this.continueCMenu.Text = "C";
            this.continueCMenu.Click += new System.EventHandler(this.ContinueProd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBoxA,
            this.boxA,
            this.statusBoxB,
            this.boxB,
            this.statusBoxC,
            this.boxC,
            this.statusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(647, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBoxA
            // 
            this.statusBoxA.Name = "statusBoxA";
            this.statusBoxA.Size = new System.Drawing.Size(57, 17);
            this.statusBoxA.Text = "Caisse A :";
            // 
            // boxA
            // 
            this.boxA.Margin = new System.Windows.Forms.Padding(0, 3, 100, 2);
            this.boxA.Name = "boxA";
            this.boxA.Size = new System.Drawing.Size(0, 17);
            // 
            // statusBoxB
            // 
            this.statusBoxB.Name = "statusBoxB";
            this.statusBoxB.Size = new System.Drawing.Size(51, 17);
            this.statusBoxB.Text = "Caise B :";
            // 
            // boxB
            // 
            this.boxB.Margin = new System.Windows.Forms.Padding(0, 3, 100, 2);
            this.boxB.Name = "boxB";
            this.boxB.Size = new System.Drawing.Size(0, 17);
            // 
            // statusBoxC
            // 
            this.statusBoxC.Name = "statusBoxC";
            this.statusBoxC.Size = new System.Drawing.Size(62, 17);
            this.statusBoxC.Text = "Caisses C :";
            // 
            // boxC
            // 
            this.boxC.Margin = new System.Windows.Forms.Padding(0, 3, 100, 2);
            this.boxC.Name = "boxC";
            this.boxC.Size = new System.Drawing.Size(0, 17);
            // 
            // statusTime
            // 
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(33, 17);
            this.statusTime.Text = "Time";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageA);
            this.tabControl.Controls.Add(this.tabPageB);
            this.tabControl.Controls.Add(this.tabPageC);
            this.tabControl.Location = new System.Drawing.Point(218, 225);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(396, 184);
            this.tabControl.TabIndex = 8;
            // 
            // tabPageA
            // 
            this.tabPageA.Controls.Add(this.prodControlA);
            this.tabPageA.Location = new System.Drawing.Point(4, 24);
            this.tabPageA.Name = "tabPageA";
            this.tabPageA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageA.Size = new System.Drawing.Size(388, 156);
            this.tabPageA.TabIndex = 0;
            this.tabPageA.Text = "Type A";
            this.tabPageA.UseVisualStyleBackColor = true;
            // 
            // prodControlA
            // 
            this.prodControlA.Location = new System.Drawing.Point(5, 6);
            this.prodControlA.Name = "prodControlA";
            this.prodControlA.Size = new System.Drawing.Size(380, 143);
            this.prodControlA.TabIndex = 0;
            // 
            // tabPageB
            // 
            this.tabPageB.Controls.Add(this.prodControlB);
            this.tabPageB.Location = new System.Drawing.Point(4, 24);
            this.tabPageB.Name = "tabPageB";
            this.tabPageB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageB.Size = new System.Drawing.Size(388, 156);
            this.tabPageB.TabIndex = 1;
            this.tabPageB.Text = "Type B";
            this.tabPageB.UseVisualStyleBackColor = true;
            // 
            // prodControlB
            // 
            this.prodControlB.Location = new System.Drawing.Point(5, 6);
            this.prodControlB.Name = "prodControlB";
            this.prodControlB.Size = new System.Drawing.Size(380, 143);
            this.prodControlB.TabIndex = 0;
            // 
            // tabPageC
            // 
            this.tabPageC.Controls.Add(this.prodControlC);
            this.tabPageC.Location = new System.Drawing.Point(4, 24);
            this.tabPageC.Name = "tabPageC";
            this.tabPageC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageC.Size = new System.Drawing.Size(388, 156);
            this.tabPageC.TabIndex = 2;
            this.tabPageC.Text = "Type C";
            this.tabPageC.UseVisualStyleBackColor = true;
            // 
            // prodControlC
            // 
            this.prodControlC.Location = new System.Drawing.Point(5, 6);
            this.prodControlC.Name = "prodControlC";
            this.prodControlC.Size = new System.Drawing.Size(380, 143);
            this.prodControlC.TabIndex = 0;
            // 
            // progressBarControlA
            // 
            this.progressBarControlA.Location = new System.Drawing.Point(23, 415);
            this.progressBarControlA.Name = "progressBarControlA";
            this.progressBarControlA.Size = new System.Drawing.Size(606, 53);
            this.progressBarControlA.TabIndex = 9;
            // 
            // progressBarControlC
            // 
            this.progressBarControlC.Location = new System.Drawing.Point(23, 494);
            this.progressBarControlC.Name = "progressBarControlC";
            this.progressBarControlC.Size = new System.Drawing.Size(606, 53);
            this.progressBarControlC.TabIndex = 10;
            // 
            // progressBarControlB
            // 
            this.progressBarControlB.Location = new System.Drawing.Point(23, 453);
            this.progressBarControlB.Name = "progressBarControlB";
            this.progressBarControlB.Size = new System.Drawing.Size(606, 53);
            this.progressBarControlB.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnsControlA
            // 
            this.btnsControlA.Location = new System.Drawing.Point(27, 46);
            this.btnsControlA.Name = "btnsControlA";
            this.btnsControlA.Size = new System.Drawing.Size(145, 150);
            this.btnsControlA.TabIndex = 26;
            // 
            // btnsControlB
            // 
            this.btnsControlB.Location = new System.Drawing.Point(255, 46);
            this.btnsControlB.Name = "btnsControlB";
            this.btnsControlB.Size = new System.Drawing.Size(145, 150);
            this.btnsControlB.TabIndex = 27;
            // 
            // btnsControlC
            // 
            this.btnsControlC.Location = new System.Drawing.Point(478, 46);
            this.btnsControlC.Name = "btnsControlC";
            this.btnsControlC.Size = new System.Drawing.Size(145, 150);
            this.btnsControlC.TabIndex = 28;
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 576);
            this.Controls.Add(this.btnsControlC);
            this.Controls.Add(this.btnsControlB);
            this.Controls.Add(this.btnsControlA);
            this.Controls.Add(this.progressBarControlB);
            this.Controls.Add(this.progressBarControlC);
            this.Controls.Add(this.progressBarControlA);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductionForm";
            this.Text = "Production de boites";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageA.ResumeLayout(false);
            this.tabPageB.ResumeLayout(false);
            this.tabPageC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem productionMenu;
        private ToolStripMenuItem exitMenu;
        private ToolStripMenuItem startMenu;
        private ToolStripMenuItem stopMenu;
        private ToolStripMenuItem continueMenu;
        private ToolStripMenuItem startAMenu;
        private ToolStripMenuItem startBMenu;
        private ToolStripMenuItem startCMenu;
        private ToolStripMenuItem stopAMenu;
        private ToolStripMenuItem stopBMenu;
        private ToolStripMenuItem stopCMenu;
        private ToolStripMenuItem continueAMenu;
        private ToolStripMenuItem continueBMenu;
        private ToolStripMenuItem continueCMenu;
        private StatusStrip statusStrip1;
        private TabControl tabControl;
        private TabPage tabPageA;
        private TabPage tabPageB;
        private TabPage tabPageC;
        private UserControls.ProductionControl prodControlA;
        private UserControls.ProductionControl prodControlB;
        private UserControls.ProductionControl prodControlC;
        private ToolStripStatusLabel statusBoxA;
        private ToolStripStatusLabel statusBoxB;
        private ToolStripStatusLabel statusBoxC;
        private ToolStripStatusLabel statusTime;
        private UserControls.ProgressBarControl progressBarControlA;
        private UserControls.ProgressBarControl progressBarControlC;
        private UserControls.ProgressBarControl progressBarControlB;
        private ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel boxA;
        private ToolStripStatusLabel boxB;
        private ToolStripStatusLabel boxC;
        private UserControls.ButtonsControl btnsControlA;
        private UserControls.ButtonsControl btnsControlB;
        private UserControls.ButtonsControl btnsControlC;
    }
}