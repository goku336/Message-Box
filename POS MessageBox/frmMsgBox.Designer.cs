namespace POS.MessageBox
{
    partial class frmMsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMsgBox));
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.pctIcon = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblPrompt = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lciImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOK = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpcLeft = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpcRight = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciYes = new DevExpress.XtraLayout.LayoutControlItem();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrompt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpcLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpcRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYes)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnYes);
            this.lcMain.Controls.Add(this.btnCancel);
            this.lcMain.Controls.Add(this.btnNo);
            this.lcMain.Controls.Add(this.btnOK);
            this.lcMain.Controls.Add(this.pctIcon);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.LookAndFeel.SkinName = "Office 2013";
            this.lcMain.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.lcMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lcMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(850, 115, 250, 350);
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(619, 219);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // btnYes
            // 
            this.btnYes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(192)))), ((int)(((byte)(231)))));
            this.btnYes.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnYes.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Appearance.Options.UseBackColor = true;
            this.btnYes.Appearance.Options.UseFont = true;
            this.btnYes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnYes.Location = new System.Drawing.Point(90, 98);
            this.btnYes.Margin = new System.Windows.Forms.Padding(0);
            this.btnYes.MinimumSize = new System.Drawing.Size(140, 60);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(163, 74);
            this.btnYes.StyleController = this.lcMain;
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "&Yes";
            this.btnYes.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(192)))), ((int)(((byte)(231)))));
            this.btnCancel.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(436, 98);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.MinimumSize = new System.Drawing.Size(140, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 74);
            this.btnCancel.StyleController = this.lcMain;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNo
            // 
            this.btnNo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNo.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnNo.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Appearance.Options.UseBackColor = true;
            this.btnNo.Appearance.Options.UseFont = true;
            this.btnNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNo.Location = new System.Drawing.Point(263, 98);
            this.btnNo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNo.MinimumSize = new System.Drawing.Size(140, 60);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(163, 74);
            this.btnNo.StyleController = this.lcMain;
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "&No";
            this.btnNo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(192)))), ((int)(((byte)(231)))));
            this.btnOK.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseBackColor = true;
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOK.Location = new System.Drawing.Point(-83, 98);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0);
            this.btnOK.MinimumSize = new System.Drawing.Size(140, 60);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(163, 74);
            this.btnOK.StyleController = this.lcMain;
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btn_Click);
            // 
            // pctIcon
            // 
            this.pctIcon.Location = new System.Drawing.Point(539, 10);
            this.pctIcon.Name = "pctIcon";
            this.pctIcon.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pctIcon.Properties.Appearance.Options.UseBackColor = true;
            this.pctIcon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pctIcon.Size = new System.Drawing.Size(70, 78);
            this.pctIcon.StyleController = this.lcMain;
            this.pctIcon.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            this.layoutControlGroup1.AppearanceGroup.BackColor2 = System.Drawing.Color.White;
            this.layoutControlGroup1.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblPrompt,
            this.lciImage,
            this.lciOK,
            this.emptySpaceItem5,
            this.emptySpcLeft,
            this.emptySpcRight,
            this.lciNo,
            this.lciCancel,
            this.lciYes});
            this.layoutControlGroup1.Location = new System.Drawing.Point(-103, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(722, 202);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AllowHotTrack = false;
            this.lblPrompt.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.AppearanceItemCaption.Options.UseFont = true;
            this.lblPrompt.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lblPrompt.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblPrompt.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblPrompt.CustomizationFormText = "LabellblPrompt";
            this.lblPrompt.Location = new System.Drawing.Point(0, 0);
            this.lblPrompt.MinSize = new System.Drawing.Size(137, 28);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            this.lblPrompt.Size = new System.Drawing.Size(632, 88);
            this.lblPrompt.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lblPrompt.Text = "LabellblPrompt";
            this.lblPrompt.TextSize = new System.Drawing.Size(106, 19);
            // 
            // lciImage
            // 
            this.lciImage.Control = this.pctIcon;
            this.lciImage.CustomizationFormText = "lciImage";
            this.lciImage.Location = new System.Drawing.Point(632, 0);
            this.lciImage.MinSize = new System.Drawing.Size(24, 24);
            this.lciImage.Name = "lciImage";
            this.lciImage.Size = new System.Drawing.Size(80, 88);
            this.lciImage.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciImage.Text = "lciImage";
            this.lciImage.TextSize = new System.Drawing.Size(0, 0);
            this.lciImage.TextToControlDistance = 0;
            this.lciImage.TextVisible = false;
            this.lciImage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciOK
            // 
            this.lciOK.Control = this.btnOK;
            this.lciOK.CustomizationFormText = "lciOK";
            this.lciOK.Location = new System.Drawing.Point(10, 88);
            this.lciOK.MaxSize = new System.Drawing.Size(173, 84);
            this.lciOK.MinSize = new System.Drawing.Size(173, 84);
            this.lciOK.Name = "lciOK";
            this.lciOK.Size = new System.Drawing.Size(173, 84);
            this.lciOK.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciOK.Text = "lciOK";
            this.lciOK.TextSize = new System.Drawing.Size(0, 0);
            this.lciOK.TextToControlDistance = 0;
            this.lciOK.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            this.emptySpaceItem5.Location = new System.Drawing.Point(10, 172);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(692, 20);
            this.emptySpaceItem5.Text = "emptySpaceItem5";
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpcLeft
            // 
            this.emptySpcLeft.AllowHotTrack = false;
            this.emptySpcLeft.CustomizationFormText = "emptySpaceItem1";
            this.emptySpcLeft.Location = new System.Drawing.Point(0, 88);
            this.emptySpcLeft.Name = "emptySpcLeft";
            this.emptySpcLeft.Size = new System.Drawing.Size(10, 104);
            this.emptySpcLeft.Text = "emptySpcLeft";
            this.emptySpcLeft.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpcRight
            // 
            this.emptySpcRight.AllowHotTrack = false;
            this.emptySpcRight.CustomizationFormText = "emptySpaceItem2";
            this.emptySpcRight.Location = new System.Drawing.Point(702, 88);
            this.emptySpcRight.Name = "emptySpcRight";
            this.emptySpcRight.Size = new System.Drawing.Size(10, 104);
            this.emptySpcRight.Text = "emptySpcRight";
            this.emptySpcRight.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciNo
            // 
            this.lciNo.Control = this.btnNo;
            this.lciNo.CustomizationFormText = "lciNo";
            this.lciNo.Location = new System.Drawing.Point(356, 88);
            this.lciNo.MaxSize = new System.Drawing.Size(173, 84);
            this.lciNo.MinSize = new System.Drawing.Size(173, 84);
            this.lciNo.Name = "lciNo";
            this.lciNo.Size = new System.Drawing.Size(173, 84);
            this.lciNo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciNo.Text = "lciNo";
            this.lciNo.TextSize = new System.Drawing.Size(0, 0);
            this.lciNo.TextToControlDistance = 0;
            this.lciNo.TextVisible = false;
            this.lciNo.TrimClientAreaToControl = false;
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.btnCancel;
            this.lciCancel.CustomizationFormText = "lciCancel";
            this.lciCancel.Location = new System.Drawing.Point(529, 88);
            this.lciCancel.MaxSize = new System.Drawing.Size(173, 84);
            this.lciCancel.MinSize = new System.Drawing.Size(173, 84);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.Size = new System.Drawing.Size(173, 84);
            this.lciCancel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCancel.Text = "lciCancel";
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextToControlDistance = 0;
            this.lciCancel.TextVisible = false;
            // 
            // lciYes
            // 
            this.lciYes.Control = this.btnYes;
            this.lciYes.CustomizationFormText = "lciYes";
            this.lciYes.Location = new System.Drawing.Point(183, 88);
            this.lciYes.MaxSize = new System.Drawing.Size(173, 84);
            this.lciYes.MinSize = new System.Drawing.Size(173, 84);
            this.lciYes.Name = "lciYes";
            this.lciYes.Size = new System.Drawing.Size(173, 84);
            this.lciYes.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciYes.Text = "lciYes";
            this.lciYes.TextSize = new System.Drawing.Size(0, 0);
            this.lciYes.TextToControlDistance = 0;
            this.lciYes.TextVisible = false;
            // 
            // imgLstIcons
            // 
            this.imgLstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstIcons.ImageStream")));
            this.imgLstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstIcons.Images.SetKeyName(0, "Error.png");
            this.imgLstIcons.Images.SetKeyName(1, "Question.png");
            this.imgLstIcons.Images.SetKeyName(2, "Warning.png");
            this.imgLstIcons.Images.SetKeyName(3, "Yes.png");
            this.imgLstIcons.Images.SetKeyName(4, "Information.png");
            // 
            // frmMsgBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(619, 219);
            this.Controls.Add(this.lcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMsgBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrompt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpcLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpcRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.ImageList imgLstIcons;
        internal DevExpress.XtraLayout.SimpleLabelItem lblPrompt;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.PictureEdit pctIcon;
        private DevExpress.XtraLayout.LayoutControlItem lciImage;
        private DevExpress.XtraLayout.LayoutControlItem lciOK;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpcLeft;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpcRight;
        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraLayout.LayoutControlItem lciNo;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
        private DevExpress.XtraLayout.LayoutControlItem lciYes;
    }
}