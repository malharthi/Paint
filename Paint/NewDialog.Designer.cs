namespace Paint {
  partial class NewDialog {
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
      this.widthBox = new System.Windows.Forms.NumericUpDown();
      this.heightBox = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.colorBox = new System.Windows.Forms.PictureBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.cancelBtn = new System.Windows.Forms.Button();
      this.okBtn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.heightBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
      this.SuspendLayout();
      // 
      // widthBox
      // 
      this.widthBox.Location = new System.Drawing.Point(12, 29);
      this.widthBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
      this.widthBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.widthBox.Name = "widthBox";
      this.widthBox.Size = new System.Drawing.Size(120, 20);
      this.widthBox.TabIndex = 0;
      this.widthBox.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
      // 
      // heightBox
      // 
      this.heightBox.Location = new System.Drawing.Point(192, 29);
      this.heightBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
      this.heightBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.heightBox.Name = "heightBox";
      this.heightBox.Size = new System.Drawing.Size(120, 20);
      this.heightBox.TabIndex = 1;
      this.heightBox.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Width:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(189, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Height:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 63);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(95, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Background Color:";
      // 
      // colorBox
      // 
      this.colorBox.BackColor = System.Drawing.Color.White;
      this.colorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.colorBox.Location = new System.Drawing.Point(9, 79);
      this.colorBox.Name = "colorBox";
      this.colorBox.Size = new System.Drawing.Size(100, 19);
      this.colorBox.TabIndex = 5;
      this.colorBox.TabStop = false;
      this.colorBox.Click += new System.EventHandler(this.colorBox_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(138, 36);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "pixel";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(318, 36);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(29, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "pixel";
      // 
      // cancelBtn
      // 
      this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelBtn.Location = new System.Drawing.Point(278, 109);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(75, 23);
      this.cancelBtn.TabIndex = 8;
      this.cancelBtn.Text = "&Cancel";
      this.cancelBtn.UseVisualStyleBackColor = true;
      // 
      // okBtn
      // 
      this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.okBtn.Location = new System.Drawing.Point(197, 109);
      this.okBtn.Name = "okBtn";
      this.okBtn.Size = new System.Drawing.Size(75, 23);
      this.okBtn.TabIndex = 9;
      this.okBtn.Text = "&OK";
      this.okBtn.UseVisualStyleBackColor = true;
      // 
      // NewDialog
      // 
      this.AcceptButton = this.okBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelBtn;
      this.ClientSize = new System.Drawing.Size(365, 143);
      this.Controls.Add(this.okBtn);
      this.Controls.Add(this.cancelBtn);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.colorBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.heightBox);
      this.Controls.Add(this.widthBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NewDialog";
      this.ShowInTaskbar = false;
      this.Text = "New";
      ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.heightBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown widthBox;
    private System.Windows.Forms.NumericUpDown heightBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox colorBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button cancelBtn;
    private System.Windows.Forms.Button okBtn;
  }
}