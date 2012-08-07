namespace Paint {
  partial class TextDialog {
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
      this.label1 = new System.Windows.Forms.Label();
      this.textBox = new System.Windows.Forms.TextBox();
      this.fontBtn = new System.Windows.Forms.Button();
      this.cancelBtn = new System.Windows.Forms.Button();
      this.drawBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Text:";
      // 
      // textBox
      // 
      this.textBox.Location = new System.Drawing.Point(12, 25);
      this.textBox.Multiline = true;
      this.textBox.Name = "textBox";
      this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBox.Size = new System.Drawing.Size(367, 65);
      this.textBox.TabIndex = 1;
      // 
      // fontBtn
      // 
      this.fontBtn.Location = new System.Drawing.Point(12, 96);
      this.fontBtn.Name = "fontBtn";
      this.fontBtn.Size = new System.Drawing.Size(75, 23);
      this.fontBtn.TabIndex = 2;
      this.fontBtn.Text = "&Font...";
      this.fontBtn.UseVisualStyleBackColor = true;
      this.fontBtn.Click += new System.EventHandler(this.fontBtn_Click);
      // 
      // cancelBtn
      // 
      this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelBtn.Location = new System.Drawing.Point(304, 96);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(75, 23);
      this.cancelBtn.TabIndex = 3;
      this.cancelBtn.Text = "&Cancel";
      this.cancelBtn.UseVisualStyleBackColor = true;
      // 
      // drawBtn
      // 
      this.drawBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.drawBtn.Location = new System.Drawing.Point(223, 96);
      this.drawBtn.Name = "drawBtn";
      this.drawBtn.Size = new System.Drawing.Size(75, 23);
      this.drawBtn.TabIndex = 4;
      this.drawBtn.Text = "&Draw";
      this.drawBtn.UseVisualStyleBackColor = true;
      // 
      // TextDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(391, 131);
      this.Controls.Add(this.drawBtn);
      this.Controls.Add(this.cancelBtn);
      this.Controls.Add(this.fontBtn);
      this.Controls.Add(this.textBox);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "TextDialog";
      this.Text = "Text";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox;
    private System.Windows.Forms.Button fontBtn;
    private System.Windows.Forms.Button cancelBtn;
    private System.Windows.Forms.Button drawBtn;
  }
}