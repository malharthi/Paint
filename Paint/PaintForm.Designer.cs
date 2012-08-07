namespace Paint {
  partial class PaintForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
      this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
      this.fileMnu = new System.Windows.Forms.MenuItem();
      this.fileNewMnu = new System.Windows.Forms.MenuItem();
      this.fileOpenMnu = new System.Windows.Forms.MenuItem();
      this.fileSaveMnu = new System.Windows.Forms.MenuItem();
      this.fileSaveAsMnu = new System.Windows.Forms.MenuItem();
      this.sep1 = new System.Windows.Forms.MenuItem();
      this.fileExitMnu = new System.Windows.Forms.MenuItem();
      this.editMnu = new System.Windows.Forms.MenuItem();
      this.editCutMnu = new System.Windows.Forms.MenuItem();
      this.editCopyMnu = new System.Windows.Forms.MenuItem();
      this.editPasteMnu = new System.Windows.Forms.MenuItem();
      this.imageMnu = new System.Windows.Forms.MenuItem();
      this.imageClearMnu = new System.Windows.Forms.MenuItem();
      this.helpMnu = new System.Windows.Forms.MenuItem();
      this.helpAboutMnu = new System.Windows.Forms.MenuItem();
      this.statusBar = new System.Windows.Forms.StatusBar();
      this.pointPanel1 = new System.Windows.Forms.StatusBarPanel();
      this.pointPanel2 = new System.Windows.Forms.StatusBarPanel();
      this.toolsBar = new System.Windows.Forms.ToolBar();
      this.arrowBtn = new System.Windows.Forms.ToolBarButton();
      this.lineBtn = new System.Windows.Forms.ToolBarButton();
      this.pencilBtn = new System.Windows.Forms.ToolBarButton();
      this.rectangleBtn = new System.Windows.Forms.ToolBarButton();
      this.ellipseBtn = new System.Windows.Forms.ToolBarButton();
      this.brushBtn = new System.Windows.Forms.ToolBarButton();
      this.fillBtn = new System.Windows.Forms.ToolBarButton();
      this.textBtn = new System.Windows.Forms.ToolBarButton();
      this.eraserBtn = new System.Windows.Forms.ToolBarButton();
      this.imgContainer = new System.Windows.Forms.Panel();
      this.imageBox = new System.Windows.Forms.PictureBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.brushImageBox = new System.Windows.Forms.PictureBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lineStyleCombo = new System.Windows.Forms.ComboBox();
      this.inverseLink = new System.Windows.Forms.LinkLabel();
      this.primColorBox = new System.Windows.Forms.PictureBox();
      this.secColorBox = new System.Windows.Forms.PictureBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.gradiantStyleCombo = new System.Windows.Forms.ComboBox();
      this.widthCombo = new System.Windows.Forms.ComboBox();
      this.shapeStyleCombo = new System.Windows.Forms.ComboBox();
      this.fillStyleCombo = new System.Windows.Forms.ComboBox();
      this.imageList = new System.Windows.Forms.ImageList(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pointPanel1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pointPanel2)).BeginInit();
      this.imgContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.brushImageBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.primColorBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.secColorBox)).BeginInit();
      this.SuspendLayout();
      // 
      // mainMenu
      // 
      this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMnu,
            this.editMnu,
            this.imageMnu,
            this.helpMnu});
      // 
      // fileMnu
      // 
      this.fileMnu.Index = 0;
      this.fileMnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileNewMnu,
            this.fileOpenMnu,
            this.fileSaveMnu,
            this.fileSaveAsMnu,
            this.sep1,
            this.fileExitMnu});
      this.fileMnu.Text = "File";
      // 
      // fileNewMnu
      // 
      this.fileNewMnu.Index = 0;
      this.fileNewMnu.Text = "&New...";
      this.fileNewMnu.Click += new System.EventHandler(this.fileNewMnu_Click);
      // 
      // fileOpenMnu
      // 
      this.fileOpenMnu.Index = 1;
      this.fileOpenMnu.Text = "&Open...";
      this.fileOpenMnu.Click += new System.EventHandler(this.fileOpenMnu_Click);
      // 
      // fileSaveMnu
      // 
      this.fileSaveMnu.Index = 2;
      this.fileSaveMnu.Text = "&Save...";
      this.fileSaveMnu.Click += new System.EventHandler(this.fileSaveMnu_Click);
      // 
      // fileSaveAsMnu
      // 
      this.fileSaveAsMnu.Index = 3;
      this.fileSaveAsMnu.Text = "S&ave As...";
      this.fileSaveAsMnu.Click += new System.EventHandler(this.fileSaveAsMnu_Click);
      // 
      // sep1
      // 
      this.sep1.Index = 4;
      this.sep1.Text = "-";
      // 
      // fileExitMnu
      // 
      this.fileExitMnu.Index = 5;
      this.fileExitMnu.Text = "&Exit";
      this.fileExitMnu.Click += new System.EventHandler(this.fileExitMnu_Click);
      // 
      // editMnu
      // 
      this.editMnu.Index = 1;
      this.editMnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.editCutMnu,
            this.editCopyMnu,
            this.editPasteMnu});
      this.editMnu.Text = "Edit";
      // 
      // editCutMnu
      // 
      this.editCutMnu.Index = 0;
      this.editCutMnu.Text = "&Cut";
      this.editCutMnu.Click += new System.EventHandler(this.editCutMnu_Click);
      // 
      // editCopyMnu
      // 
      this.editCopyMnu.Index = 1;
      this.editCopyMnu.Text = "C&opy";
      this.editCopyMnu.Click += new System.EventHandler(this.editCopyMnu_Click);
      // 
      // editPasteMnu
      // 
      this.editPasteMnu.Index = 2;
      this.editPasteMnu.Text = "&Paste";
      this.editPasteMnu.Click += new System.EventHandler(this.editPasteMnu_Click);
      // 
      // imageMnu
      // 
      this.imageMnu.Index = 2;
      this.imageMnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.imageClearMnu});
      this.imageMnu.Text = "Image";
      // 
      // imageClearMnu
      // 
      this.imageClearMnu.Index = 0;
      this.imageClearMnu.Text = "&Clear";
      this.imageClearMnu.Click += new System.EventHandler(this.imageClearMnu_Click);
      // 
      // helpMnu
      // 
      this.helpMnu.Index = 3;
      this.helpMnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.helpAboutMnu});
      this.helpMnu.Text = "Help";
      // 
      // helpAboutMnu
      // 
      this.helpAboutMnu.Index = 0;
      this.helpAboutMnu.Text = "&About...";
      // 
      // statusBar
      // 
      this.statusBar.Location = new System.Drawing.Point(0, 422);
      this.statusBar.Name = "statusBar";
      this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.pointPanel1,
            this.pointPanel2});
      this.statusBar.ShowPanels = true;
      this.statusBar.Size = new System.Drawing.Size(739, 22);
      this.statusBar.TabIndex = 1;
      // 
      // pointPanel1
      // 
      this.pointPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
      this.pointPanel1.Name = "pointPanel1";
      this.pointPanel1.Width = 10;
      // 
      // pointPanel2
      // 
      this.pointPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
      this.pointPanel2.Name = "pointPanel2";
      this.pointPanel2.Width = 10;
      // 
      // toolsBar
      // 
      this.toolsBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.arrowBtn,
            this.lineBtn,
            this.pencilBtn,
            this.rectangleBtn,
            this.ellipseBtn,
            this.brushBtn,
            this.fillBtn,
            this.textBtn,
            this.eraserBtn});
      this.toolsBar.Dock = System.Windows.Forms.DockStyle.Left;
      this.toolsBar.DropDownArrows = true;
      this.toolsBar.Location = new System.Drawing.Point(0, 61);
      this.toolsBar.MinimumSize = new System.Drawing.Size(30, 0);
      this.toolsBar.Name = "toolsBar";
      this.toolsBar.ShowToolTips = true;
      this.toolsBar.Size = new System.Drawing.Size(30, 361);
      this.toolsBar.TabIndex = 2;
      this.toolsBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolsBar_ButtonClick);
      // 
      // arrowBtn
      // 
      this.arrowBtn.ImageIndex = 8;
      this.arrowBtn.Name = "arrowBtn";
      this.arrowBtn.Pushed = true;
      // 
      // lineBtn
      // 
      this.lineBtn.ImageIndex = 0;
      this.lineBtn.Name = "lineBtn";
      // 
      // pencilBtn
      // 
      this.pencilBtn.ImageIndex = 2;
      this.pencilBtn.Name = "pencilBtn";
      // 
      // rectangleBtn
      // 
      this.rectangleBtn.ImageIndex = 1;
      this.rectangleBtn.Name = "rectangleBtn";
      // 
      // ellipseBtn
      // 
      this.ellipseBtn.ImageIndex = 4;
      this.ellipseBtn.Name = "ellipseBtn";
      // 
      // brushBtn
      // 
      this.brushBtn.ImageIndex = 3;
      this.brushBtn.Name = "brushBtn";
      // 
      // fillBtn
      // 
      this.fillBtn.ImageIndex = 7;
      this.fillBtn.Name = "fillBtn";
      // 
      // textBtn
      // 
      this.textBtn.ImageIndex = 5;
      this.textBtn.Name = "textBtn";
      // 
      // eraserBtn
      // 
      this.eraserBtn.ImageIndex = 6;
      this.eraserBtn.Name = "eraserBtn";
      // 
      // imgContainer
      // 
      this.imgContainer.AutoScroll = true;
      this.imgContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.imgContainer.Controls.Add(this.imageBox);
      this.imgContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imgContainer.Location = new System.Drawing.Point(30, 61);
      this.imgContainer.Name = "imgContainer";
      this.imgContainer.Size = new System.Drawing.Size(709, 361);
      this.imgContainer.TabIndex = 3;
      // 
      // imageBox
      // 
      this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.imageBox.Location = new System.Drawing.Point(12, 12);
      this.imageBox.Name = "imageBox";
      this.imageBox.Size = new System.Drawing.Size(240, 275);
      this.imageBox.TabIndex = 0;
      this.imageBox.TabStop = false;
      this.imageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox_Paint);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.brushImageBox);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.lineStyleCombo);
      this.panel1.Controls.Add(this.inverseLink);
      this.panel1.Controls.Add(this.primColorBox);
      this.panel1.Controls.Add(this.secColorBox);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.gradiantStyleCombo);
      this.panel1.Controls.Add(this.widthCombo);
      this.panel1.Controls.Add(this.shapeStyleCombo);
      this.panel1.Controls.Add(this.fillStyleCombo);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(739, 61);
      this.panel1.TabIndex = 4;
      // 
      // brushImageBox
      // 
      this.brushImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.brushImageBox.Location = new System.Drawing.Point(271, 31);
      this.brushImageBox.Name = "brushImageBox";
      this.brushImageBox.Size = new System.Drawing.Size(34, 24);
      this.brushImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.brushImageBox.TabIndex = 14;
      this.brushImageBox.TabStop = false;
      this.brushImageBox.Click += new System.EventHandler(this.brushImageBox_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(186, 37);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(79, 13);
      this.label6.TabIndex = 13;
      this.label6.Text = "Texture Brush:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 37);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "Line Style";
      // 
      // lineStyleCombo
      // 
      this.lineStyleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.lineStyleCombo.FormattingEnabled = true;
      this.lineStyleCombo.Location = new System.Drawing.Point(59, 34);
      this.lineStyleCombo.Name = "lineStyleCombo";
      this.lineStyleCombo.Size = new System.Drawing.Size(121, 21);
      this.lineStyleCombo.TabIndex = 11;
      // 
      // inverseLink
      // 
      this.inverseLink.AutoSize = true;
      this.inverseLink.Location = new System.Drawing.Point(690, 37);
      this.inverseLink.Name = "inverseLink";
      this.inverseLink.Size = new System.Drawing.Size(44, 13);
      this.inverseLink.TabIndex = 10;
      this.inverseLink.TabStop = true;
      this.inverseLink.Text = "Inverse";
      this.inverseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inverseLink_LinkClicked);
      // 
      // primColorBox
      // 
      this.primColorBox.BackColor = System.Drawing.Color.DodgerBlue;
      this.primColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.primColorBox.Location = new System.Drawing.Point(702, 9);
      this.primColorBox.Name = "primColorBox";
      this.primColorBox.Size = new System.Drawing.Size(25, 24);
      this.primColorBox.TabIndex = 9;
      this.primColorBox.TabStop = false;
      this.primColorBox.Click += new System.EventHandler(this.ColorBox_Click);
      // 
      // secColorBox
      // 
      this.secColorBox.BackColor = System.Drawing.Color.White;
      this.secColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.secColorBox.Location = new System.Drawing.Point(693, 3);
      this.secColorBox.Name = "secColorBox";
      this.secColorBox.Size = new System.Drawing.Size(25, 24);
      this.secColorBox.TabIndex = 8;
      this.secColorBox.TabStop = false;
      this.secColorBox.Click += new System.EventHandler(this.ColorBox_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(475, 11);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(79, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Gradiant Style:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(366, 11);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(39, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Width:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(186, 11);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(68, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Shape Style:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Fill Style:";
      // 
      // gradiantStyleCombo
      // 
      this.gradiantStyleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.gradiantStyleCombo.FormattingEnabled = true;
      this.gradiantStyleCombo.Location = new System.Drawing.Point(560, 8);
      this.gradiantStyleCombo.Name = "gradiantStyleCombo";
      this.gradiantStyleCombo.Size = new System.Drawing.Size(121, 21);
      this.gradiantStyleCombo.TabIndex = 3;
      // 
      // widthCombo
      // 
      this.widthCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.widthCombo.FormattingEnabled = true;
      this.widthCombo.Location = new System.Drawing.Point(407, 8);
      this.widthCombo.Name = "widthCombo";
      this.widthCombo.Size = new System.Drawing.Size(62, 21);
      this.widthCombo.TabIndex = 2;
      // 
      // shapeStyleCombo
      // 
      this.shapeStyleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.shapeStyleCombo.FormattingEnabled = true;
      this.shapeStyleCombo.Location = new System.Drawing.Point(260, 8);
      this.shapeStyleCombo.Name = "shapeStyleCombo";
      this.shapeStyleCombo.Size = new System.Drawing.Size(100, 21);
      this.shapeStyleCombo.TabIndex = 1;
      // 
      // fillStyleCombo
      // 
      this.fillStyleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.fillStyleCombo.FormattingEnabled = true;
      this.fillStyleCombo.Location = new System.Drawing.Point(59, 8);
      this.fillStyleCombo.Name = "fillStyleCombo";
      this.fillStyleCombo.Size = new System.Drawing.Size(121, 21);
      this.fillStyleCombo.TabIndex = 0;
      // 
      // imageList
      // 
      this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
      this.imageList.TransparentColor = System.Drawing.Color.Red;
      this.imageList.Images.SetKeyName(0, "");
      this.imageList.Images.SetKeyName(1, "");
      this.imageList.Images.SetKeyName(2, "");
      this.imageList.Images.SetKeyName(3, "");
      this.imageList.Images.SetKeyName(4, "");
      this.imageList.Images.SetKeyName(5, "");
      this.imageList.Images.SetKeyName(6, "");
      this.imageList.Images.SetKeyName(7, "");
      this.imageList.Images.SetKeyName(8, "");
      // 
      // PaintForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(739, 444);
      this.Controls.Add(this.imgContainer);
      this.Controls.Add(this.toolsBar);
      this.Controls.Add(this.statusBar);
      this.Controls.Add(this.panel1);
      this.Menu = this.mainMenu;
      this.Name = "PaintForm";
      this.Text = "Paint";
      this.Load += new System.EventHandler(this.PaintForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pointPanel1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pointPanel2)).EndInit();
      this.imgContainer.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.brushImageBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.primColorBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.secColorBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MainMenu mainMenu;
    private System.Windows.Forms.MenuItem fileMnu;
    private System.Windows.Forms.MenuItem editMnu;
    private System.Windows.Forms.MenuItem imageMnu;
    private System.Windows.Forms.MenuItem helpMnu;
    private System.Windows.Forms.StatusBar statusBar;
    private System.Windows.Forms.ToolBar toolsBar;
    private System.Windows.Forms.Panel imgContainer;
    private System.Windows.Forms.PictureBox imageBox;
    private System.Windows.Forms.StatusBarPanel pointPanel1;
    private System.Windows.Forms.StatusBarPanel pointPanel2;
    private System.Windows.Forms.MenuItem helpAboutMnu;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ComboBox gradiantStyleCombo;
    private System.Windows.Forms.ComboBox widthCombo;
    private System.Windows.Forms.ComboBox shapeStyleCombo;
    private System.Windows.Forms.ComboBox fillStyleCombo;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox primColorBox;
    private System.Windows.Forms.PictureBox secColorBox;
    private System.Windows.Forms.LinkLabel inverseLink;
    private System.Windows.Forms.MenuItem imageClearMnu;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox lineStyleCombo;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.PictureBox brushImageBox;
    private System.Windows.Forms.ToolBarButton arrowBtn;
    private System.Windows.Forms.ToolBarButton lineBtn;
    private System.Windows.Forms.ToolBarButton pencilBtn;
    private System.Windows.Forms.ToolBarButton rectangleBtn;
    private System.Windows.Forms.ToolBarButton ellipseBtn;
    private System.Windows.Forms.ToolBarButton brushBtn;
    private System.Windows.Forms.ToolBarButton textBtn;
    private System.Windows.Forms.ToolBarButton eraserBtn;
    private System.Windows.Forms.MenuItem editCutMnu;
    private System.Windows.Forms.MenuItem editCopyMnu;
    private System.Windows.Forms.MenuItem editPasteMnu;
    private System.Windows.Forms.MenuItem fileNewMnu;
    private System.Windows.Forms.MenuItem fileOpenMnu;
    private System.Windows.Forms.MenuItem fileSaveMnu;
    private System.Windows.Forms.MenuItem fileSaveAsMnu;
    private System.Windows.Forms.MenuItem sep1;
    private System.Windows.Forms.MenuItem fileExitMnu;
    private System.Windows.Forms.ToolBarButton fillBtn;
    private System.Windows.Forms.ImageList imageList;
  }
}

