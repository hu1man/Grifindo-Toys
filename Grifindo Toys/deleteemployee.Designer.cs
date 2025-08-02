namespace Grifindo_Toys
{
    partial class deleteemployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteemployee));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lst_search = new System.Windows.Forms.ListBox();
            this.txt_search_box = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btn_delete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // lst_search
            // 
            this.lst_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lst_search.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_search.ForeColor = System.Drawing.Color.White;
            this.lst_search.FormattingEnabled = true;
            this.lst_search.ItemHeight = 22;
            this.lst_search.Location = new System.Drawing.Point(245, 147);
            this.lst_search.Name = "lst_search";
            this.lst_search.Size = new System.Drawing.Size(584, 224);
            this.lst_search.TabIndex = 1;
            this.lst_search.SelectedIndexChanged += new System.EventHandler(this.lst_search_SelectedIndexChanged);
            // 
            // txt_search_box
            // 
            this.txt_search_box.AcceptsReturn = false;
            this.txt_search_box.AcceptsTab = false;
            this.txt_search_box.AnimationSpeed = 200;
            this.txt_search_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_search_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_search_box.BackColor = System.Drawing.Color.Transparent;
            this.txt_search_box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_search_box.BackgroundImage")));
            this.txt_search_box.BorderColorActive = System.Drawing.Color.SpringGreen;
            this.txt_search_box.BorderColorDisabled = System.Drawing.Color.SpringGreen;
            this.txt_search_box.BorderColorHover = System.Drawing.Color.SpringGreen;
            this.txt_search_box.BorderColorIdle = System.Drawing.Color.SpringGreen;
            this.txt_search_box.BorderRadius = 35;
            this.txt_search_box.BorderThickness = 1;
            this.txt_search_box.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_search_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_box.DefaultFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_box.DefaultText = "";
            this.txt_search_box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_search_box.ForeColor = System.Drawing.Color.White;
            this.txt_search_box.HideSelection = true;
            this.txt_search_box.IconLeft = null;
            this.txt_search_box.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_box.IconPadding = 10;
            this.txt_search_box.IconRight = null;
            this.txt_search_box.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_box.Lines = new string[0];
            this.txt_search_box.Location = new System.Drawing.Point(245, 83);
            this.txt_search_box.MaxLength = 32767;
            this.txt_search_box.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_search_box.Modified = false;
            this.txt_search_box.Multiline = false;
            this.txt_search_box.Name = "txt_search_box";
            stateProperties1.BorderColor = System.Drawing.Color.SpringGreen;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search_box.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.SpringGreen;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_search_box.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.SpringGreen;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search_box.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.SpringGreen;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search_box.OnIdleState = stateProperties4;
            this.txt_search_box.Padding = new System.Windows.Forms.Padding(3);
            this.txt_search_box.PasswordChar = '\0';
            this.txt_search_box.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search_box.PlaceholderText = "Search Employee";
            this.txt_search_box.ReadOnly = false;
            this.txt_search_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search_box.SelectedText = "";
            this.txt_search_box.SelectionLength = 0;
            this.txt_search_box.SelectionStart = 0;
            this.txt_search_box.ShortcutsEnabled = true;
            this.txt_search_box.Size = new System.Drawing.Size(260, 36);
            this.txt_search_box.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_search_box.TabIndex = 0;
            this.txt_search_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search_box.TextMarginBottom = 0;
            this.txt_search_box.TextMarginLeft = 3;
            this.txt_search_box.TextMarginTop = 0;
            this.txt_search_box.TextPlaceholder = "Search Employee";
            this.txt_search_box.UseSystemPasswordChar = false;
            this.txt_search_box.WordWrap = true;
            this.txt_search_box.TextChanged += new System.EventHandler(this.txt_search_box_TextChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.AllowAnimations = true;
            this.btn_delete.AllowMouseEffects = true;
            this.btn_delete.AllowToggling = false;
            this.btn_delete.AnimationSpeed = 200;
            this.btn_delete.AutoGenerateColors = false;
            this.btn_delete.AutoRoundBorders = false;
            this.btn_delete.AutoSizeLeftIcon = true;
            this.btn_delete.AutoSizeRightIcon = true;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.ButtonText = "Delete Employee Record";
            this.btn_delete.ButtonTextMarginLeft = 0;
            this.btn_delete.ColorContrastOnClick = 45;
            this.btn_delete.ColorContrastOnHover = 45;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_delete.CustomizableEdges = borderEdges1;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_delete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_delete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_delete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_delete.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_delete.IconMarginLeft = 11;
            this.btn_delete.IconPadding = 10;
            this.btn_delete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_delete.IconSize = 25;
            this.btn_delete.IdleBorderColor = System.Drawing.Color.SpringGreen;
            this.btn_delete.IdleBorderRadius = 20;
            this.btn_delete.IdleBorderThickness = 1;
            this.btn_delete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_delete.IdleIconLeftImage = null;
            this.btn_delete.IdleIconRightImage = null;
            this.btn_delete.IndicateFocus = false;
            this.btn_delete.Location = new System.Drawing.Point(619, 390);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_delete.OnDisabledState.BorderRadius = 20;
            this.btn_delete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.OnDisabledState.BorderThickness = 1;
            this.btn_delete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_delete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_delete.OnDisabledState.IconLeftImage = null;
            this.btn_delete.OnDisabledState.IconRightImage = null;
            this.btn_delete.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_delete.onHoverState.BorderRadius = 20;
            this.btn_delete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.onHoverState.BorderThickness = 1;
            this.btn_delete.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_delete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_delete.onHoverState.IconLeftImage = null;
            this.btn_delete.onHoverState.IconRightImage = null;
            this.btn_delete.OnIdleState.BorderColor = System.Drawing.Color.SpringGreen;
            this.btn_delete.OnIdleState.BorderRadius = 20;
            this.btn_delete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.OnIdleState.BorderThickness = 1;
            this.btn_delete.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_delete.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_delete.OnIdleState.IconLeftImage = null;
            this.btn_delete.OnIdleState.IconRightImage = null;
            this.btn_delete.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_delete.OnPressedState.BorderRadius = 20;
            this.btn_delete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_delete.OnPressedState.BorderThickness = 1;
            this.btn_delete.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_delete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_delete.OnPressedState.IconLeftImage = null;
            this.btn_delete.OnPressedState.IconRightImage = null;
            this.btn_delete.Size = new System.Drawing.Size(210, 39);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_delete.TextMarginLeft = 0;
            this.btn_delete.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_delete.UseDefaultRadiusAndThickness = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // deleteemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1184, 625);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lst_search);
            this.Controls.Add(this.txt_search_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(186, 144);
            this.Name = "deleteemployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "deleteemployee";
            this.Load += new System.EventHandler(this.deleteemployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox txt_search_box;
        private System.Windows.Forms.ListBox lst_search;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_delete;
    }
}