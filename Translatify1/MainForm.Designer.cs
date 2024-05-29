namespace Translatify1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.textOutput = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbSourceLanguage = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTargetLanguage = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTranslate = new Guna.UI2.WinForms.Guna2Button();
            this.label = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.otptpste = new Guna.UI2.WinForms.Guna2Button();
            this.otptcpy = new Guna.UI2.WinForms.Guna2Button();
            this.inptpste = new Guna.UI2.WinForms.Guna2Button();
            this.inptcpy = new Guna.UI2.WinForms.Guna2Button();
            this.close = new Guna.UI2.WinForms.Guna2PictureBox();
            this.minimize = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.BackColor = System.Drawing.Color.Transparent;
            this.textInput.BorderColor = System.Drawing.Color.Black;
            this.textInput.BorderRadius = 20;
            this.textInput.BorderThickness = 0;
            this.textInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textInput.DefaultText = "";
            this.textInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInput.DisabledState.Parent = this.textInput;
            this.textInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInput.FocusedState.Parent = this.textInput;
            this.textInput.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInput.ForeColor = System.Drawing.Color.Black;
            this.textInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInput.HoverState.Parent = this.textInput;
            this.textInput.Location = new System.Drawing.Point(46, 110);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textInput.PasswordChar = '\0';
            this.textInput.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textInput.PlaceholderText = "Type here...";
            this.textInput.SelectedText = "";
            this.textInput.ShadowDecoration.BorderRadius = 20;
            this.textInput.ShadowDecoration.Enabled = true;
            this.textInput.ShadowDecoration.Parent = this.textInput;
            this.textInput.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.textInput.Size = new System.Drawing.Size(278, 366);
            this.textInput.TabIndex = 0;
            this.textInput.TextChanged += new System.EventHandler(this.textInput_TextChanged);
            this.textInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textInput_KeyDown);
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.Color.Transparent;
            this.textOutput.BorderColor = System.Drawing.Color.Black;
            this.textOutput.BorderRadius = 20;
            this.textOutput.BorderThickness = 0;
            this.textOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textOutput.DefaultText = "";
            this.textOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textOutput.DisabledState.Parent = this.textOutput;
            this.textOutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textOutput.FocusedState.Parent = this.textOutput;
            this.textOutput.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutput.ForeColor = System.Drawing.Color.Black;
            this.textOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textOutput.HoverState.Parent = this.textOutput;
            this.textOutput.Location = new System.Drawing.Point(398, 110);
            this.textOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textOutput.PasswordChar = '\0';
            this.textOutput.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textOutput.PlaceholderText = "Translated Text..";
            this.textOutput.ReadOnly = true;
            this.textOutput.SelectedText = "";
            this.textOutput.ShadowDecoration.BorderRadius = 20;
            this.textOutput.ShadowDecoration.Enabled = true;
            this.textOutput.ShadowDecoration.Parent = this.textOutput;
            this.textOutput.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.textOutput.Size = new System.Drawing.Size(278, 366);
            this.textOutput.TabIndex = 1;
            // 
            // cmbSourceLanguage
            // 
            this.cmbSourceLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cmbSourceLanguage.BorderColor = System.Drawing.Color.Black;
            this.cmbSourceLanguage.BorderRadius = 15;
            this.cmbSourceLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSourceLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceLanguage.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSourceLanguage.FocusedState.Parent = this.cmbSourceLanguage;
            this.cmbSourceLanguage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSourceLanguage.ForeColor = System.Drawing.Color.Black;
            this.cmbSourceLanguage.FormattingEnabled = true;
            this.cmbSourceLanguage.HoverState.Parent = this.cmbSourceLanguage;
            this.cmbSourceLanguage.ItemHeight = 30;
            this.cmbSourceLanguage.ItemsAppearance.Parent = this.cmbSourceLanguage;
            this.cmbSourceLanguage.Location = new System.Drawing.Point(98, 63);
            this.cmbSourceLanguage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSourceLanguage.Name = "cmbSourceLanguage";
            this.cmbSourceLanguage.ShadowDecoration.BorderRadius = 15;
            this.cmbSourceLanguage.ShadowDecoration.Enabled = true;
            this.cmbSourceLanguage.ShadowDecoration.Parent = this.cmbSourceLanguage;
            this.cmbSourceLanguage.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.cmbSourceLanguage.Size = new System.Drawing.Size(151, 36);
            this.cmbSourceLanguage.TabIndex = 2;
            this.cmbSourceLanguage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbSourceLanguage.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // cmbTargetLanguage
            // 
            this.cmbTargetLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cmbTargetLanguage.BorderColor = System.Drawing.Color.Black;
            this.cmbTargetLanguage.BorderRadius = 15;
            this.cmbTargetLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTargetLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetLanguage.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTargetLanguage.FocusedState.Parent = this.cmbTargetLanguage;
            this.cmbTargetLanguage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTargetLanguage.ForeColor = System.Drawing.Color.Black;
            this.cmbTargetLanguage.FormattingEnabled = true;
            this.cmbTargetLanguage.HoverState.Parent = this.cmbTargetLanguage;
            this.cmbTargetLanguage.ItemHeight = 30;
            this.cmbTargetLanguage.ItemsAppearance.Parent = this.cmbTargetLanguage;
            this.cmbTargetLanguage.Location = new System.Drawing.Point(466, 63);
            this.cmbTargetLanguage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTargetLanguage.Name = "cmbTargetLanguage";
            this.cmbTargetLanguage.ShadowDecoration.BorderRadius = 15;
            this.cmbTargetLanguage.ShadowDecoration.Enabled = true;
            this.cmbTargetLanguage.ShadowDecoration.Parent = this.cmbTargetLanguage;
            this.cmbTargetLanguage.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.cmbTargetLanguage.Size = new System.Drawing.Size(151, 36);
            this.cmbTargetLanguage.TabIndex = 3;
            this.cmbTargetLanguage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbTargetLanguage.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.Color.Transparent;
            this.btnTranslate.BorderRadius = 20;
            this.btnTranslate.CheckedState.Parent = this.btnTranslate;
            this.btnTranslate.CustomImages.Parent = this.btnTranslate;
            this.btnTranslate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslate.ForeColor = System.Drawing.Color.Black;
            this.btnTranslate.HoverState.Parent = this.btnTranslate;
            this.btnTranslate.Location = new System.Drawing.Point(282, 496);
            this.btnTranslate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.ShadowDecoration.BorderRadius = 20;
            this.btnTranslate.ShadowDecoration.Enabled = true;
            this.btnTranslate.ShadowDecoration.Parent = this.btnTranslate;
            this.btnTranslate.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnTranslate.Size = new System.Drawing.Size(150, 41);
            this.btnTranslate.TabIndex = 4;
            this.btnTranslate.Text = "TRANSLATE!";
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(267, 20);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(193, 37);
            this.label.TabIndex = 6;
            this.label.Text = "TRANSLATIFY";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(718, 39);
            this.guna2Panel1.TabIndex = 13;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ErrorImage = global::Translatify1.Properties.Resources.Untitled_1_1;
            this.guna2PictureBox1.Image = global::Translatify1.Properties.Resources.Untitled_1_1;
            this.guna2PictureBox1.InitialImage = global::Translatify1.Properties.Resources.Untitled_1_1;
            this.guna2PictureBox1.Location = new System.Drawing.Point(9, 10);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(42, 41);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // otptpste
            // 
            this.otptpste.BackColor = System.Drawing.Color.Transparent;
            this.otptpste.BorderColor = System.Drawing.Color.Transparent;
            this.otptpste.BorderRadius = 10;
            this.otptpste.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.otptpste.CheckedState.Parent = this.otptpste;
            this.otptpste.CustomImages.Parent = this.otptpste;
            this.otptpste.FillColor = System.Drawing.Color.White;
            this.otptpste.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.otptpste.ForeColor = System.Drawing.Color.White;
            this.otptpste.HoverState.Parent = this.otptpste;
            this.otptpste.Image = ((System.Drawing.Image)(resources.GetObject("otptpste.Image")));
            this.otptpste.ImageSize = new System.Drawing.Size(25, 25);
            this.otptpste.Location = new System.Drawing.Point(637, 436);
            this.otptpste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.otptpste.Name = "otptpste";
            this.otptpste.PressedColor = System.Drawing.Color.Transparent;
            this.otptpste.ShadowDecoration.Parent = this.otptpste;
            this.otptpste.Size = new System.Drawing.Size(23, 31);
            this.otptpste.TabIndex = 12;
            this.otptpste.UseTransparentBackground = true;
            this.otptpste.Click += new System.EventHandler(this.otptpste_Click);
            // 
            // otptcpy
            // 
            this.otptcpy.BackColor = System.Drawing.Color.Transparent;
            this.otptcpy.BorderColor = System.Drawing.Color.Transparent;
            this.otptcpy.BorderRadius = 10;
            this.otptcpy.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.otptcpy.CheckedState.Parent = this.otptcpy;
            this.otptcpy.CustomImages.Parent = this.otptcpy;
            this.otptcpy.FillColor = System.Drawing.Color.White;
            this.otptcpy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.otptcpy.ForeColor = System.Drawing.Color.White;
            this.otptcpy.HoverState.Parent = this.otptcpy;
            this.otptcpy.Image = ((System.Drawing.Image)(resources.GetObject("otptcpy.Image")));
            this.otptcpy.ImageSize = new System.Drawing.Size(25, 25);
            this.otptcpy.Location = new System.Drawing.Point(609, 436);
            this.otptcpy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.otptcpy.Name = "otptcpy";
            this.otptcpy.PressedColor = System.Drawing.Color.Transparent;
            this.otptcpy.ShadowDecoration.Parent = this.otptcpy;
            this.otptcpy.Size = new System.Drawing.Size(23, 31);
            this.otptcpy.TabIndex = 11;
            this.otptcpy.UseTransparentBackground = true;
            this.otptcpy.Click += new System.EventHandler(this.otptcpy_Click);
            // 
            // inptpste
            // 
            this.inptpste.BackColor = System.Drawing.Color.White;
            this.inptpste.BorderColor = System.Drawing.Color.Transparent;
            this.inptpste.BorderRadius = 10;
            this.inptpste.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.inptpste.CheckedState.Parent = this.inptpste;
            this.inptpste.CustomImages.Parent = this.inptpste;
            this.inptpste.FillColor = System.Drawing.Color.White;
            this.inptpste.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inptpste.ForeColor = System.Drawing.Color.Transparent;
            this.inptpste.HoverState.Parent = this.inptpste;
            this.inptpste.Image = global::Translatify1.Properties.Resources.bxs_paste;
            this.inptpste.ImageSize = new System.Drawing.Size(25, 25);
            this.inptpste.Location = new System.Drawing.Point(282, 436);
            this.inptpste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inptpste.Name = "inptpste";
            this.inptpste.PressedColor = System.Drawing.Color.Transparent;
            this.inptpste.ShadowDecoration.Parent = this.inptpste;
            this.inptpste.Size = new System.Drawing.Size(23, 31);
            this.inptpste.TabIndex = 10;
            this.inptpste.Click += new System.EventHandler(this.inptpste_Click);
            // 
            // inptcpy
            // 
            this.inptcpy.BackColor = System.Drawing.Color.Transparent;
            this.inptcpy.BorderColor = System.Drawing.Color.Transparent;
            this.inptcpy.BorderRadius = 10;
            this.inptcpy.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.inptcpy.CheckedState.Parent = this.inptcpy;
            this.inptcpy.CustomImages.Parent = this.inptcpy;
            this.inptcpy.FillColor = System.Drawing.Color.White;
            this.inptcpy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inptcpy.ForeColor = System.Drawing.Color.White;
            this.inptcpy.HoverState.Parent = this.inptcpy;
            this.inptcpy.Image = ((System.Drawing.Image)(resources.GetObject("inptcpy.Image")));
            this.inptcpy.ImageSize = new System.Drawing.Size(25, 25);
            this.inptcpy.Location = new System.Drawing.Point(254, 436);
            this.inptcpy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inptcpy.Name = "inptcpy";
            this.inptcpy.PressedColor = System.Drawing.Color.Transparent;
            this.inptcpy.ShadowDecoration.Parent = this.inptcpy;
            this.inptcpy.Size = new System.Drawing.Size(23, 31);
            this.inptcpy.TabIndex = 9;
            this.inptcpy.UseTransparentBackground = true;
            this.inptcpy.Click += new System.EventHandler(this.inptcpy_Click);
            // 
            // close
            // 
            this.close.Image = global::Translatify1.Properties.Resources.mingcute_close_fill1;
            this.close.Location = new System.Drawing.Point(680, 10);
            this.close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(19, 20);
            this.close.TabIndex = 8;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("minimize.ErrorImage")));
            this.minimize.FillColor = System.Drawing.Color.Black;
            this.minimize.Image = global::Translatify1.Properties.Resources.mingcute_minimize_fill1;
            this.minimize.Location = new System.Drawing.Point(649, 10);
            this.minimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimize.Name = "minimize";
            this.minimize.ShadowDecoration.Parent = this.minimize;
            this.minimize.Size = new System.Drawing.Size(19, 20);
            this.minimize.TabIndex = 7;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(718, 556);
            this.ControlBox = false;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.otptpste);
            this.Controls.Add(this.otptcpy);
            this.Controls.Add(this.inptpste);
            this.Controls.Add(this.inptcpy);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.cmbTargetLanguage);
            this.Controls.Add(this.cmbSourceLanguage);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translatify";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textInput;
        private Guna.UI2.WinForms.Guna2TextBox textOutput;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSourceLanguage;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTargetLanguage;
        private Guna.UI2.WinForms.Guna2Button btnTranslate;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2PictureBox minimize;
        private Guna.UI2.WinForms.Guna2PictureBox close;
        private Guna.UI2.WinForms.Guna2Button inptcpy;
        private Guna.UI2.WinForms.Guna2Button inptpste;
        private Guna.UI2.WinForms.Guna2Button otptcpy;
        private Guna.UI2.WinForms.Guna2Button otptpste;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

