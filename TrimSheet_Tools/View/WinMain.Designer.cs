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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.formContainerPanel = new System.Windows.Forms.Panel();
            this.MaainWindow_MovementSystem = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnMinimize = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.topPanelSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.logoPanelSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.aboutPanelSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.aboutPanel.SuspendLayout();
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
            // aboutPanel
            // 
            this.aboutPanel.Controls.Add(this.aboutPanelSeparator);
            this.aboutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutPanel.Location = new System.Drawing.Point(15, 550);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(170, 150);
            this.aboutPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.topPanelSeparator);
            this.topPanel.Controls.Add(this.btnClose);
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
            // formContainerPanel
            // 
            this.formContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formContainerPanel.Location = new System.Drawing.Point(200, 45);
            this.formContainerPanel.Name = "formContainerPanel";
            this.formContainerPanel.Size = new System.Drawing.Size(750, 655);
            this.formContainerPanel.TabIndex = 2;
            // 
            // MaainWindow_MovementSystem
            // 
            this.MaainWindow_MovementSystem.Fixed = true;
            this.MaainWindow_MovementSystem.Horizontal = true;
            this.MaainWindow_MovementSystem.TargetControl = this.topPanel;
            this.MaainWindow_MovementSystem.Vertical = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AllowAnimations = true;
            this.btnMinimize.AllowMouseEffects = true;
            this.btnMinimize.AllowToggling = false;
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AnimationSpeed = 200;
            this.btnMinimize.AutoGenerateColors = false;
            this.btnMinimize.AutoRoundBorders = false;
            this.btnMinimize.AutoSizeLeftIcon = true;
            this.btnMinimize.AutoSizeRightIcon = true;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMinimize.ButtonText = "";
            this.btnMinimize.ButtonTextMarginLeft = 0;
            this.btnMinimize.ColorContrastOnClick = 45;
            this.btnMinimize.ColorContrastOnHover = 45;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnMinimize.CustomizableEdges = borderEdges5;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMinimize.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMinimize.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMinimize.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMinimize.IconLeftPadding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMinimize.IconMarginLeft = 11;
            this.btnMinimize.IconPadding = 0;
            this.btnMinimize.IconRightAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMinimize.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMinimize.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.btnMinimize.IdleBorderRadius = 1;
            this.btnMinimize.IdleBorderThickness = 1;
            this.btnMinimize.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.btnMinimize.IdleIconLeftImage = global::TrimSheet_Tools.Properties.Resources.btnMinimize;
            this.btnMinimize.IdleIconRightImage = null;
            this.btnMinimize.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnMinimize.IndicateFocus = false;
            this.btnMinimize.Location = new System.Drawing.Point(672, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMinimize.OnDisabledState.BorderRadius = 0;
            this.btnMinimize.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMinimize.OnDisabledState.BorderThickness = 0;
            this.btnMinimize.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMinimize.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMinimize.OnDisabledState.IconLeftImage = null;
            this.btnMinimize.OnDisabledState.IconRightImage = null;
            this.btnMinimize.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMinimize.onHoverState.BorderRadius = 0;
            this.btnMinimize.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMinimize.onHoverState.BorderThickness = 0;
            this.btnMinimize.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMinimize.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.onHoverState.IconLeftImage = null;
            this.btnMinimize.onHoverState.IconRightImage = null;
            this.btnMinimize.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.btnMinimize.OnIdleState.BorderRadius = 0;
            this.btnMinimize.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMinimize.OnIdleState.BorderThickness = 0;
            this.btnMinimize.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.btnMinimize.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.OnIdleState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.btnMinimize;
            this.btnMinimize.OnIdleState.IconRightImage = null;
            this.btnMinimize.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnMinimize.OnPressedState.BorderRadius = 0;
            this.btnMinimize.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMinimize.OnPressedState.BorderThickness = 0;
            this.btnMinimize.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnMinimize.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.OnPressedState.IconLeftImage = null;
            this.btnMinimize.OnPressedState.IconRightImage = null;
            this.btnMinimize.Size = new System.Drawing.Size(32, 26);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimize.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMinimize.TextMarginLeft = 0;
            this.btnMinimize.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnMinimize.UseDefaultRadiusAndThickness = true;
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
            this.topPanelSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.topPanelSeparator.Name = "topPanelSeparator";
            this.topPanelSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.topPanelSeparator.Size = new System.Drawing.Size(720, 14);
            this.topPanelSeparator.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowMouseEffects = true;
            this.btnClose.AllowToggling = false;
            this.btnClose.AnimationSpeed = 200;
            this.btnClose.AutoGenerateColors = false;
            this.btnClose.AutoRoundBorders = false;
            this.btnClose.AutoSizeLeftIcon = true;
            this.btnClose.AutoSizeRightIcon = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.ButtonText = "";
            this.btnClose.ButtonTextMarginLeft = 0;
            this.btnClose.ColorContrastOnClick = 45;
            this.btnClose.ColorContrastOnHover = 45;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges6;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconLeftPadding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnClose.IconMarginLeft = 11;
            this.btnClose.IconPadding = 0;
            this.btnClose.IconRightAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnClose.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClose.IconSize = 25;
            this.btnClose.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.btnClose.IdleBorderRadius = 1;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.btnClose.IdleIconLeftImage = global::TrimSheet_Tools.Properties.Resources.btnClose;
            this.btnClose.IdleIconRightImage = null;
            this.btnClose.IndicateFocus = false;
            this.btnClose.Location = new System.Drawing.Point(711, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.OnDisabledState.BorderRadius = 0;
            this.btnClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnDisabledState.BorderThickness = 0;
            this.btnClose.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.OnDisabledState.IconLeftImage = null;
            this.btnClose.OnDisabledState.IconRightImage = null;
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClose.onHoverState.BorderRadius = 0;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 0;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClose.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.onHoverState.IconLeftImage = null;
            this.btnClose.onHoverState.IconRightImage = null;
            this.btnClose.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.btnClose.OnIdleState.BorderRadius = 0;
            this.btnClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnIdleState.BorderThickness = 0;
            this.btnClose.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnIdleState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.btnClose;
            this.btnClose.OnIdleState.IconRightImage = null;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnClose.OnPressedState.BorderRadius = 0;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 0;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(32, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            // 
            // logoImage
            // 
            this.logoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoImage.Image = global::TrimSheet_Tools.Properties.Resources.LogoImage;
            this.logoImage.Location = new System.Drawing.Point(0, 5);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(170, 61);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.logoPanel.ResumeLayout(false);
            this.aboutPanel.ResumeLayout(false);
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
        private Bunifu.UI.WinForms.BunifuSeparator aboutPanelSeparator;
        public System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel formContainerPanel;
        private Bunifu.Framework.UI.BunifuDragControl MaainWindow_MovementSystem;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMinimize;
        public Bunifu.UI.WinForms.BunifuSeparator topPanelSeparator;
    }
}