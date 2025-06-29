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
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState13 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState14 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState15 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges26 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges27 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges28 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges29 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges30 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinMain));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges25 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MaainWindowTopPanel_MovementSystem = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuToggleSwitch1 = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.btnMinimize = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.topPanelSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.logoPanelSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.trimSettingsBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.uvPlanningBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.helpInfoBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.menuButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.aboutPanelSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.aboutFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.aboutBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.toggleBtnLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaainWindowMenuPanel_MovementSystem = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.formContainerPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.menuButtonsFlowLayoutPanel.SuspendLayout();
            this.aboutFlowLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.menuPanel.Controls.Add(this.aboutFlowLayoutPanel);
            this.menuPanel.Controls.Add(this.menuButtonsFlowLayoutPanel);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 20);
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
            // MaainWindowTopPanel_MovementSystem
            // 
            this.MaainWindowTopPanel_MovementSystem.Fixed = true;
            this.MaainWindowTopPanel_MovementSystem.Horizontal = true;
            this.MaainWindowTopPanel_MovementSystem.TargetControl = this.topPanel;
            this.MaainWindowTopPanel_MovementSystem.Vertical = true;
            // 
            // bunifuToggleSwitch1
            // 
            this.bunifuToggleSwitch1.Animation = 5;
            this.bunifuToggleSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuToggleSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuToggleSwitch1.BackgroundImage")));
            this.bunifuToggleSwitch1.Checked = true;
            this.bunifuToggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuToggleSwitch1.InnerCirclePadding = 3;
            this.bunifuToggleSwitch1.Location = new System.Drawing.Point(9, 18);
            this.bunifuToggleSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuToggleSwitch1.Name = "bunifuToggleSwitch1";
            this.bunifuToggleSwitch1.Size = new System.Drawing.Size(30, 16);
            this.bunifuToggleSwitch1.TabIndex = 0;
            this.bunifuToggleSwitch1.ThumbMargin = 3;
            toggleState13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            toggleState13.BackColorInner = System.Drawing.Color.White;
            toggleState13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            toggleState13.BorderColorInner = System.Drawing.Color.White;
            toggleState13.BorderRadius = 17;
            toggleState13.BorderRadiusInner = 11;
            toggleState13.BorderThickness = 1;
            toggleState13.BorderThicknessInner = 1;
            this.bunifuToggleSwitch1.ToggleStateDisabled = toggleState13;
            toggleState14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            toggleState14.BackColorInner = System.Drawing.Color.White;
            toggleState14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            toggleState14.BorderColorInner = System.Drawing.Color.White;
            toggleState14.BorderRadius = 17;
            toggleState14.BorderRadiusInner = 11;
            toggleState14.BorderThickness = 1;
            toggleState14.BorderThicknessInner = 1;
            this.bunifuToggleSwitch1.ToggleStateOff = toggleState14;
            toggleState15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(65)))), ((int)(((byte)(246)))));
            toggleState15.BackColorInner = System.Drawing.Color.White;
            toggleState15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(65)))), ((int)(((byte)(246)))));
            toggleState15.BorderColorInner = System.Drawing.Color.White;
            toggleState15.BorderRadius = 17;
            toggleState15.BorderRadiusInner = 11;
            toggleState15.BorderThickness = 1;
            toggleState15.BorderThicknessInner = 1;
            this.bunifuToggleSwitch1.ToggleStateOn = toggleState15;
            this.bunifuToggleSwitch1.Value = true;
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
            borderEdges26.BottomLeft = true;
            borderEdges26.BottomRight = true;
            borderEdges26.TopLeft = true;
            borderEdges26.TopRight = true;
            this.btnMinimize.CustomizableEdges = borderEdges26;
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
            borderEdges27.BottomLeft = true;
            borderEdges27.BottomRight = true;
            borderEdges27.TopLeft = true;
            borderEdges27.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges27;
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
            // trimSettingsBtn
            // 
            this.trimSettingsBtn.AllowAnimations = true;
            this.trimSettingsBtn.AllowMouseEffects = true;
            this.trimSettingsBtn.AllowToggling = false;
            this.trimSettingsBtn.AnimationSpeed = 200;
            this.trimSettingsBtn.AutoGenerateColors = false;
            this.trimSettingsBtn.AutoRoundBorders = false;
            this.trimSettingsBtn.AutoSizeLeftIcon = true;
            this.trimSettingsBtn.AutoSizeRightIcon = true;
            this.trimSettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.trimSettingsBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.trimSettingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trimSettingsBtn.BackgroundImage")));
            this.trimSettingsBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.trimSettingsBtn.ButtonText = "Trim Settings";
            this.trimSettingsBtn.ButtonTextMarginLeft = 0;
            this.trimSettingsBtn.ColorContrastOnClick = 45;
            this.trimSettingsBtn.ColorContrastOnHover = 45;
            this.trimSettingsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges28.BottomLeft = true;
            borderEdges28.BottomRight = true;
            borderEdges28.TopLeft = true;
            borderEdges28.TopRight = true;
            this.trimSettingsBtn.CustomizableEdges = borderEdges28;
            this.trimSettingsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.trimSettingsBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.trimSettingsBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.trimSettingsBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.trimSettingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.trimSettingsBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.trimSettingsBtn.Font = new System.Drawing.Font("Mollen Personal Use Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trimSettingsBtn.ForeColor = System.Drawing.Color.White;
            this.trimSettingsBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trimSettingsBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.trimSettingsBtn.IconLeftPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.trimSettingsBtn.IconMarginLeft = 11;
            this.trimSettingsBtn.IconPadding = 2;
            this.trimSettingsBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trimSettingsBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.trimSettingsBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.trimSettingsBtn.IconSize = 25;
            this.trimSettingsBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.trimSettingsBtn.IdleBorderRadius = 5;
            this.trimSettingsBtn.IdleBorderThickness = 1;
            this.trimSettingsBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.trimSettingsBtn.IdleIconLeftImage = global::TrimSheet_Tools.Properties.Resources.TrimSettings_idle;
            this.trimSettingsBtn.IdleIconRightImage = null;
            this.trimSettingsBtn.IndicateFocus = false;
            this.trimSettingsBtn.Location = new System.Drawing.Point(0, 20);
            this.trimSettingsBtn.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.trimSettingsBtn.Name = "trimSettingsBtn";
            this.trimSettingsBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.trimSettingsBtn.OnDisabledState.BorderRadius = 5;
            this.trimSettingsBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.trimSettingsBtn.OnDisabledState.BorderThickness = 0;
            this.trimSettingsBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.trimSettingsBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.trimSettingsBtn.OnDisabledState.IconLeftImage = null;
            this.trimSettingsBtn.OnDisabledState.IconRightImage = null;
            this.trimSettingsBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.trimSettingsBtn.onHoverState.BorderRadius = 5;
            this.trimSettingsBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.trimSettingsBtn.onHoverState.BorderThickness = 0;
            this.trimSettingsBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.trimSettingsBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.trimSettingsBtn.onHoverState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.TrimSettings_hover;
            this.trimSettingsBtn.onHoverState.IconRightImage = null;
            this.trimSettingsBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.trimSettingsBtn.OnIdleState.BorderRadius = 5;
            this.trimSettingsBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.trimSettingsBtn.OnIdleState.BorderThickness = 0;
            this.trimSettingsBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.trimSettingsBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.trimSettingsBtn.OnIdleState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.TrimSettings_idle;
            this.trimSettingsBtn.OnIdleState.IconRightImage = null;
            this.trimSettingsBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(65)))), ((int)(((byte)(246)))));
            this.trimSettingsBtn.OnPressedState.BorderRadius = 5;
            this.trimSettingsBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.trimSettingsBtn.OnPressedState.BorderThickness = 0;
            this.trimSettingsBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(65)))), ((int)(((byte)(246)))));
            this.trimSettingsBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.trimSettingsBtn.OnPressedState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.TrimSettings_hover;
            this.trimSettingsBtn.OnPressedState.IconRightImage = null;
            this.trimSettingsBtn.Size = new System.Drawing.Size(170, 39);
            this.trimSettingsBtn.TabIndex = 2;
            this.trimSettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trimSettingsBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.trimSettingsBtn.TextMarginLeft = 0;
            this.trimSettingsBtn.TextPadding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.trimSettingsBtn.UseDefaultRadiusAndThickness = true;
            this.trimSettingsBtn.Click += new System.EventHandler(this.trimSettingsBtn_Click);
            // 
            // uvPlanningBtn
            // 
            this.uvPlanningBtn.AllowAnimations = true;
            this.uvPlanningBtn.AllowMouseEffects = true;
            this.uvPlanningBtn.AllowToggling = false;
            this.uvPlanningBtn.AnimationSpeed = 200;
            this.uvPlanningBtn.AutoGenerateColors = false;
            this.uvPlanningBtn.AutoRoundBorders = false;
            this.uvPlanningBtn.AutoSizeLeftIcon = true;
            this.uvPlanningBtn.AutoSizeRightIcon = true;
            this.uvPlanningBtn.BackColor = System.Drawing.Color.Transparent;
            this.uvPlanningBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.uvPlanningBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uvPlanningBtn.BackgroundImage")));
            this.uvPlanningBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.uvPlanningBtn.ButtonText = "UV Planning";
            this.uvPlanningBtn.ButtonTextMarginLeft = 0;
            this.uvPlanningBtn.ColorContrastOnClick = 45;
            this.uvPlanningBtn.ColorContrastOnHover = 45;
            this.uvPlanningBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges29.BottomLeft = true;
            borderEdges29.BottomRight = true;
            borderEdges29.TopLeft = true;
            borderEdges29.TopRight = true;
            this.uvPlanningBtn.CustomizableEdges = borderEdges29;
            this.uvPlanningBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.uvPlanningBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.uvPlanningBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.uvPlanningBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.uvPlanningBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.uvPlanningBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.uvPlanningBtn.Font = new System.Drawing.Font("Mollen Personal Use Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uvPlanningBtn.ForeColor = System.Drawing.Color.White;
            this.uvPlanningBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uvPlanningBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.uvPlanningBtn.IconLeftPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uvPlanningBtn.IconMarginLeft = 11;
            this.uvPlanningBtn.IconPadding = 2;
            this.uvPlanningBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uvPlanningBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.uvPlanningBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.uvPlanningBtn.IconSize = 25;
            this.uvPlanningBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.uvPlanningBtn.IdleBorderRadius = 5;
            this.uvPlanningBtn.IdleBorderThickness = 1;
            this.uvPlanningBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.uvPlanningBtn.IdleIconLeftImage = global::TrimSheet_Tools.Properties.Resources.UVPlanning_idle;
            this.uvPlanningBtn.IdleIconRightImage = null;
            this.uvPlanningBtn.IndicateFocus = false;
            this.uvPlanningBtn.Location = new System.Drawing.Point(0, 74);
            this.uvPlanningBtn.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.uvPlanningBtn.Name = "uvPlanningBtn";
            this.uvPlanningBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.uvPlanningBtn.OnDisabledState.BorderRadius = 5;
            this.uvPlanningBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.uvPlanningBtn.OnDisabledState.BorderThickness = 0;
            this.uvPlanningBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.uvPlanningBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.uvPlanningBtn.OnDisabledState.IconLeftImage = null;
            this.uvPlanningBtn.OnDisabledState.IconRightImage = null;
            this.uvPlanningBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.uvPlanningBtn.onHoverState.BorderRadius = 5;
            this.uvPlanningBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.uvPlanningBtn.onHoverState.BorderThickness = 0;
            this.uvPlanningBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.uvPlanningBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.uvPlanningBtn.onHoverState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.UVPlanning_hover;
            this.uvPlanningBtn.onHoverState.IconRightImage = null;
            this.uvPlanningBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.uvPlanningBtn.OnIdleState.BorderRadius = 5;
            this.uvPlanningBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.uvPlanningBtn.OnIdleState.BorderThickness = 0;
            this.uvPlanningBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.uvPlanningBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.uvPlanningBtn.OnIdleState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.UVPlanning_idle;
            this.uvPlanningBtn.OnIdleState.IconRightImage = null;
            this.uvPlanningBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(65)))), ((int)(((byte)(246)))));
            this.uvPlanningBtn.OnPressedState.BorderRadius = 5;
            this.uvPlanningBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.uvPlanningBtn.OnPressedState.BorderThickness = 0;
            this.uvPlanningBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(65)))), ((int)(((byte)(246)))));
            this.uvPlanningBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.uvPlanningBtn.OnPressedState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.UVPlanning_hover;
            this.uvPlanningBtn.OnPressedState.IconRightImage = null;
            this.uvPlanningBtn.Size = new System.Drawing.Size(170, 39);
            this.uvPlanningBtn.TabIndex = 3;
            this.uvPlanningBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uvPlanningBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.uvPlanningBtn.TextMarginLeft = 0;
            this.uvPlanningBtn.TextPadding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.uvPlanningBtn.UseDefaultRadiusAndThickness = true;
            this.uvPlanningBtn.Click += new System.EventHandler(this.uvPlanningBtn_Click);
            // 
            // helpInfoBtn
            // 
            this.helpInfoBtn.AllowAnimations = true;
            this.helpInfoBtn.AllowMouseEffects = true;
            this.helpInfoBtn.AllowToggling = false;
            this.helpInfoBtn.AnimationSpeed = 200;
            this.helpInfoBtn.AutoGenerateColors = false;
            this.helpInfoBtn.AutoRoundBorders = false;
            this.helpInfoBtn.AutoSizeLeftIcon = true;
            this.helpInfoBtn.AutoSizeRightIcon = true;
            this.helpInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.helpInfoBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.helpInfoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpInfoBtn.BackgroundImage")));
            this.helpInfoBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.helpInfoBtn.ButtonText = "Help Information";
            this.helpInfoBtn.ButtonTextMarginLeft = 0;
            this.helpInfoBtn.ColorContrastOnClick = 45;
            this.helpInfoBtn.ColorContrastOnHover = 45;
            this.helpInfoBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges30.BottomLeft = true;
            borderEdges30.BottomRight = true;
            borderEdges30.TopLeft = true;
            borderEdges30.TopRight = true;
            this.helpInfoBtn.CustomizableEdges = borderEdges30;
            this.helpInfoBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.helpInfoBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.helpInfoBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.helpInfoBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.helpInfoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpInfoBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.helpInfoBtn.Font = new System.Drawing.Font("Mollen Personal Use Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpInfoBtn.ForeColor = System.Drawing.Color.White;
            this.helpInfoBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpInfoBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.helpInfoBtn.IconLeftPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.helpInfoBtn.IconMarginLeft = 11;
            this.helpInfoBtn.IconPadding = 2;
            this.helpInfoBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.helpInfoBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.helpInfoBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.helpInfoBtn.IconSize = 25;
            this.helpInfoBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.helpInfoBtn.IdleBorderRadius = 5;
            this.helpInfoBtn.IdleBorderThickness = 1;
            this.helpInfoBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.helpInfoBtn.IdleIconLeftImage = global::TrimSheet_Tools.Properties.Resources.HelpInfo_idle;
            this.helpInfoBtn.IdleIconRightImage = null;
            this.helpInfoBtn.IndicateFocus = false;
            this.helpInfoBtn.Location = new System.Drawing.Point(0, 128);
            this.helpInfoBtn.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.helpInfoBtn.Name = "helpInfoBtn";
            this.helpInfoBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.helpInfoBtn.OnDisabledState.BorderRadius = 5;
            this.helpInfoBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.helpInfoBtn.OnDisabledState.BorderThickness = 0;
            this.helpInfoBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.helpInfoBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.helpInfoBtn.OnDisabledState.IconLeftImage = null;
            this.helpInfoBtn.OnDisabledState.IconRightImage = null;
            this.helpInfoBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.helpInfoBtn.onHoverState.BorderRadius = 5;
            this.helpInfoBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.helpInfoBtn.onHoverState.BorderThickness = 0;
            this.helpInfoBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.helpInfoBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.helpInfoBtn.onHoverState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.HelpInfo_hover;
            this.helpInfoBtn.onHoverState.IconRightImage = null;
            this.helpInfoBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.helpInfoBtn.OnIdleState.BorderRadius = 5;
            this.helpInfoBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.helpInfoBtn.OnIdleState.BorderThickness = 0;
            this.helpInfoBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.helpInfoBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.helpInfoBtn.OnIdleState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.HelpInfo_idle;
            this.helpInfoBtn.OnIdleState.IconRightImage = null;
            this.helpInfoBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(65)))), ((int)(((byte)(246)))));
            this.helpInfoBtn.OnPressedState.BorderRadius = 5;
            this.helpInfoBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.helpInfoBtn.OnPressedState.BorderThickness = 0;
            this.helpInfoBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(65)))), ((int)(((byte)(246)))));
            this.helpInfoBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.helpInfoBtn.OnPressedState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.HelpInfo_hover;
            this.helpInfoBtn.OnPressedState.IconRightImage = null;
            this.helpInfoBtn.Size = new System.Drawing.Size(170, 39);
            this.helpInfoBtn.TabIndex = 4;
            this.helpInfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpInfoBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.helpInfoBtn.TextMarginLeft = 0;
            this.helpInfoBtn.TextPadding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.helpInfoBtn.UseDefaultRadiusAndThickness = true;
            this.helpInfoBtn.Click += new System.EventHandler(this.helpInfoBtn_Click);
            // 
            // menuButtonsFlowLayoutPanel
            // 
            this.menuButtonsFlowLayoutPanel.Controls.Add(this.trimSettingsBtn);
            this.menuButtonsFlowLayoutPanel.Controls.Add(this.uvPlanningBtn);
            this.menuButtonsFlowLayoutPanel.Controls.Add(this.helpInfoBtn);
            this.menuButtonsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButtonsFlowLayoutPanel.Location = new System.Drawing.Point(15, 80);
            this.menuButtonsFlowLayoutPanel.Name = "menuButtonsFlowLayoutPanel";
            this.menuButtonsFlowLayoutPanel.Size = new System.Drawing.Size(170, 172);
            this.menuButtonsFlowLayoutPanel.TabIndex = 2;
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
            this.aboutPanelSeparator.Location = new System.Drawing.Point(3, 3);
            this.aboutPanelSeparator.Name = "aboutPanelSeparator";
            this.aboutPanelSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.aboutPanelSeparator.Size = new System.Drawing.Size(170, 14);
            this.aboutPanelSeparator.TabIndex = 0;
            // 
            // aboutFlowLayoutPanel
            // 
            this.aboutFlowLayoutPanel.Controls.Add(this.aboutPanelSeparator);
            this.aboutFlowLayoutPanel.Controls.Add(this.aboutBtn);
            this.aboutFlowLayoutPanel.Controls.Add(this.panel1);
            this.aboutFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutFlowLayoutPanel.Location = new System.Drawing.Point(15, 566);
            this.aboutFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.aboutFlowLayoutPanel.Name = "aboutFlowLayoutPanel";
            this.aboutFlowLayoutPanel.Size = new System.Drawing.Size(170, 114);
            this.aboutFlowLayoutPanel.TabIndex = 3;
            // 
            // aboutBtn
            // 
            this.aboutBtn.AllowAnimations = true;
            this.aboutBtn.AllowMouseEffects = true;
            this.aboutBtn.AllowToggling = false;
            this.aboutBtn.AnimationSpeed = 200;
            this.aboutBtn.AutoGenerateColors = false;
            this.aboutBtn.AutoRoundBorders = false;
            this.aboutBtn.AutoSizeLeftIcon = true;
            this.aboutBtn.AutoSizeRightIcon = true;
            this.aboutBtn.BackColor = System.Drawing.Color.Transparent;
            this.aboutBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.aboutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutBtn.BackgroundImage")));
            this.aboutBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.aboutBtn.ButtonText = "About";
            this.aboutBtn.ButtonTextMarginLeft = 0;
            this.aboutBtn.ColorContrastOnClick = 45;
            this.aboutBtn.ColorContrastOnHover = 45;
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges25.BottomLeft = true;
            borderEdges25.BottomRight = true;
            borderEdges25.TopLeft = true;
            borderEdges25.TopRight = true;
            this.aboutBtn.CustomizableEdges = borderEdges25;
            this.aboutBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.aboutBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.aboutBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.aboutBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.aboutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.aboutBtn.Font = new System.Drawing.Font("Mollen Personal Use Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.aboutBtn.IconLeftPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.aboutBtn.IconMarginLeft = 11;
            this.aboutBtn.IconPadding = 2;
            this.aboutBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aboutBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.aboutBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.aboutBtn.IconSize = 25;
            this.aboutBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.aboutBtn.IdleBorderRadius = 5;
            this.aboutBtn.IdleBorderThickness = 1;
            this.aboutBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.aboutBtn.IdleIconLeftImage = global::TrimSheet_Tools.Properties.Resources.About_idle;
            this.aboutBtn.IdleIconRightImage = null;
            this.aboutBtn.IndicateFocus = false;
            this.aboutBtn.Location = new System.Drawing.Point(0, 25);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.aboutBtn.OnDisabledState.BorderRadius = 5;
            this.aboutBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.aboutBtn.OnDisabledState.BorderThickness = 0;
            this.aboutBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.aboutBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.aboutBtn.OnDisabledState.IconLeftImage = null;
            this.aboutBtn.OnDisabledState.IconRightImage = null;
            this.aboutBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.aboutBtn.onHoverState.BorderRadius = 5;
            this.aboutBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.aboutBtn.onHoverState.BorderThickness = 0;
            this.aboutBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
            this.aboutBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.onHoverState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.About_hover;
            this.aboutBtn.onHoverState.IconRightImage = null;
            this.aboutBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.aboutBtn.OnIdleState.BorderRadius = 5;
            this.aboutBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.aboutBtn.OnIdleState.BorderThickness = 0;
            this.aboutBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.aboutBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.OnIdleState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.About_idle;
            this.aboutBtn.OnIdleState.IconRightImage = null;
            this.aboutBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(65)))), ((int)(((byte)(246)))));
            this.aboutBtn.OnPressedState.BorderRadius = 5;
            this.aboutBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.aboutBtn.OnPressedState.BorderThickness = 0;
            this.aboutBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(65)))), ((int)(((byte)(246)))));
            this.aboutBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.OnPressedState.IconLeftImage = global::TrimSheet_Tools.Properties.Resources.About_hover;
            this.aboutBtn.OnPressedState.IconRightImage = null;
            this.aboutBtn.Size = new System.Drawing.Size(170, 39);
            this.aboutBtn.TabIndex = 5;
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.aboutBtn.TextMarginLeft = 0;
            this.aboutBtn.TextPadding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.aboutBtn.UseDefaultRadiusAndThickness = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // toggleBtnLabel
            // 
            this.toggleBtnLabel.AutoSize = true;
            this.toggleBtnLabel.Font = new System.Drawing.Font("Mollen Personal Use Lt Nr", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleBtnLabel.ForeColor = System.Drawing.Color.Silver;
            this.toggleBtnLabel.Location = new System.Drawing.Point(52, 19);
            this.toggleBtnLabel.Margin = new System.Windows.Forms.Padding(0);
            this.toggleBtnLabel.Name = "toggleBtnLabel";
            this.toggleBtnLabel.Size = new System.Drawing.Size(48, 14);
            this.toggleBtnLabel.TabIndex = 0;
            this.toggleBtnLabel.Text = "On Front";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toggleBtnLabel);
            this.panel1.Controls.Add(this.bunifuToggleSwitch1);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 50);
            this.panel1.TabIndex = 1;
            // 
            // MaainWindowMenuPanel_MovementSystem
            // 
            this.MaainWindowMenuPanel_MovementSystem.Fixed = true;
            this.MaainWindowMenuPanel_MovementSystem.Horizontal = true;
            this.MaainWindowMenuPanel_MovementSystem.TargetControl = this.menuPanel;
            this.MaainWindowMenuPanel_MovementSystem.Vertical = true;
            // 
            // formContainerPanel
            // 
            this.formContainerPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.formContainerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formContainerPanel.BackgroundImage")));
            this.formContainerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.formContainerPanel.BorderColor = System.Drawing.Color.Transparent;
            this.formContainerPanel.BorderRadius = 3;
            this.formContainerPanel.BorderThickness = 1;
            this.formContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formContainerPanel.Location = new System.Drawing.Point(200, 45);
            this.formContainerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.formContainerPanel.Name = "formContainerPanel";
            this.formContainerPanel.ShowBorders = true;
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
            this.logoPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.menuButtonsFlowLayoutPanel.ResumeLayout(false);
            this.aboutFlowLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox logoImage;
        private Bunifu.UI.WinForms.BunifuSeparator logoPanelSeparator;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuDragControl MaainWindowTopPanel_MovementSystem;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMinimize;
        public Bunifu.UI.WinForms.BunifuSeparator topPanelSeparator;
        private Bunifu.UI.WinForms.BunifuToggleSwitch bunifuToggleSwitch1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton trimSettingsBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton helpInfoBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton uvPlanningBtn;
        private System.Windows.Forms.FlowLayoutPanel menuButtonsFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel aboutFlowLayoutPanel;
        private Bunifu.UI.WinForms.BunifuSeparator aboutPanelSeparator;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton aboutBtn;
        private System.Windows.Forms.Label toggleBtnLabel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl MaainWindowMenuPanel_MovementSystem;
        private Bunifu.UI.WinForms.BunifuPanel formContainerPanel;
    }
}