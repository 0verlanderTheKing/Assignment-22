namespace Assignment_22
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.shapeLabel = new System.Windows.Forms.Label();
            this.shape = new System.Windows.Forms.ComboBox();
            this.firstLabel = new System.Windows.Forms.Label();
            this.firstInputBox = new System.Windows.Forms.TextBox();
            this.secondLabel = new System.Windows.Forms.Label();
            this.secondInputBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(32, 30);
            this.shapeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(89, 16);
            this.shapeLabel.TabIndex = 0;
            this.shapeLabel.Text = "Select shape:";
            // 
            // shape
            // 
            this.shape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shape.FormattingEnabled = true;
            this.shape.Items.AddRange(new object[] {
            "Circle",
            "Rectangle",
            "Cylinder"});
            this.shape.Location = new System.Drawing.Point(129, 30);
            this.shape.Margin = new System.Windows.Forms.Padding(4);
            this.shape.Name = "shape";
            this.shape.Size = new System.Drawing.Size(305, 24);
            this.shape.TabIndex = 1;
            this.shape.SelectedIndexChanged += new System.EventHandler(this.selectChange);
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(32, 86);
            this.firstLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(53, 16);
            this.firstLabel.TabIndex = 2;
            this.firstLabel.Text = "Radius:";
            // 
            // firstInputBox
            // 
            this.firstInputBox.Location = new System.Drawing.Point(93, 86);
            this.firstInputBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstInputBox.Name = "firstInputBox";
            this.firstInputBox.Size = new System.Drawing.Size(305, 22);
            this.firstInputBox.TabIndex = 3;
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(32, 117);
            this.secondLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(0, 16);
            this.secondLabel.TabIndex = 4;
            // 
            // secondInputBox
            // 
            this.secondInputBox.Location = new System.Drawing.Point(93, 117);
            this.secondInputBox.Margin = new System.Windows.Forms.Padding(4);
            this.secondInputBox.Name = "secondInputBox";
            this.secondInputBox.Size = new System.Drawing.Size(305, 22);
            this.secondInputBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(13, 156);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(133, 37);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(154, 156);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(133, 37);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(295, 156);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(133, 37);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(13, 208);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(429, 71);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(35, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 15);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Area:";
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 300);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.secondInputBox);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstInputBox);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.shape);
            this.Controls.Add(this.shapeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 22";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.ComboBox shape;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.TextBox firstInputBox;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.TextBox secondInputBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}
