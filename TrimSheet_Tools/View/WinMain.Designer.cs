namespace TrimSheet_Tools.View
{
    partial class WinMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinMain));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.logoPanelSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.topPanelSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.aboutPanelSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.formContainerPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Controls.Add(this.aboutPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.menuPanel.Size = new System.Drawing.Size(200, 700);
            this.menuPanel.TabIndex = 0;
            // 
            // aboutPanel
            // 
            this.aboutPanel.Controls.Add(this.aboutPanelSeparator);
            this.aboutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutPanel.Location = new System.Drawing.Point(15, 550);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(170, 150);
            this.aboutPanel.TabIndex = 0;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.logoPanel.Controls.Add(this.logoImage);
            this.logoPanel.Controls.Add(this.logoPanelSeparator);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(15, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.logoPanel.Size = new System.Drawing.Size(170, 80);
            this.logoPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.topPanelSeparator);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(200, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.topPanel.Size = new System.Drawing.Size(750, 45);
            this.topPanel.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // logoImage
            // 
            this.logoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoImage.Location = new System.Drawing.Point(0, 5);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(170, 61);
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            // 
            // logoPanelSeparator
            // 
            this.logoPanelSeparator.BackColor = System.Drawing.Color.Transparent;
            this.logoPanelSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanelSeparator.BackgroundImage")));
            this.logoPanelSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPanelSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.logoPanelSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoPanelSeparator.LineColor = System.Drawing.Color.Silver;
            this.logoPanelSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.logoPanelSeparator.LineThickness = 1;
            this.logoPanelSeparator.Location = new System.Drawing.Point(0, 66);
            this.logoPanelSeparator.Name = "logoPanelSeparator";
            this.logoPanelSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.logoPanelSeparator.Size = new System.Drawing.Size(170, 14);
            this.logoPanelSeparator.TabIndex = 0;
            // 
            // topPanelSeparator
            // 
            this.topPanelSeparator.BackColor = System.Drawing.Color.Transparent;
            this.topPanelSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topPanelSeparator.BackgroundImage")));
            this.topPanelSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topPanelSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.topPanelSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.topPanelSeparator.LineColor = System.Drawing.Color.Silver;
            this.topPanelSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.topPanelSeparator.LineThickness = 1;
            this.topPanelSeparator.Location = new System.Drawing.Point(15, 31);
            this.topPanelSeparator.Name = "topPanelSeparator";
            this.topPanelSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.topPanelSeparator.Size = new System.Drawing.Size(720, 14);
            this.topPanelSeparator.TabIndex = 0;
            // 
            // aboutPanelSeparator
            // 
            this.aboutPanelSeparator.BackColor = System.Drawing.Color.Transparent;
            this.aboutPanelSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutPanelSeparator.BackgroundImage")));
            this.aboutPanelSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutPanelSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.aboutPanelSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutPanelSeparator.LineColor = System.Drawing.Color.Silver;
            this.aboutPanelSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.aboutPanelSeparator.LineThickness = 1;
            this.aboutPanelSeparator.Location = new System.Drawing.Point(0, 0);
            this.aboutPanelSeparator.Name = "aboutPanelSeparator";
            this.aboutPanelSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.aboutPanelSeparator.Size = new System.Drawing.Size(170, 14);
            this.aboutPanelSeparator.TabIndex = 0;
            // 
            // formContainerPanel
            // 
            this.formContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formContainerPanel.Location = new System.Drawing.Point(200, 45);
            this.formContainerPanel.Name = "formContainerPanel";
            this.formContainerPanel.Size = new System.Drawing.Size(750, 655);
            this.formContainerPanel.TabIndex = 2;
            // 
            // WinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.formContainerPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuPanel.ResumeLayout(false);
            this.aboutPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.PictureBox logoImage;
        private Bunifu.UI.WinForms.BunifuSeparator logoPanelSeparator;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuSeparator topPanelSeparator;
        private Bunifu.UI.WinForms.BunifuSeparator aboutPanelSeparator;
        public System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel formContainerPanel;
    }
}