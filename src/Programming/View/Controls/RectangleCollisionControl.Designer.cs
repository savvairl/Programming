
namespace Programming.View.Controls
{
    partial class RectangleCollisionControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.SelectedRectangleHeightTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleYTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleXTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleHeightLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleWidthLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleYLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleXLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleIdLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.RectanglesListBox2 = new System.Windows.Forms.ListBox();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Location = new System.Drawing.Point(199, 3);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(478, 321);
            this.CanvasPanel.TabIndex = 31;
            this.CanvasPanel.Resize += new System.EventHandler(this.CanvasPanel_Resize);
            // 
            // SelectedRectangleHeightTextBox
            // 
            this.SelectedRectangleHeightTextBox.Location = new System.Drawing.Point(43, 302);
            this.SelectedRectangleHeightTextBox.Name = "SelectedRectangleHeightTextBox";
            this.SelectedRectangleHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleHeightTextBox.TabIndex = 30;
            this.SelectedRectangleHeightTextBox.TextChanged += new System.EventHandler(this.SelectedRectangleHeightTextBox_TextChanged);
            // 
            // SelectedRectangleWidthTextBox
            // 
            this.SelectedRectangleWidthTextBox.Location = new System.Drawing.Point(43, 277);
            this.SelectedRectangleWidthTextBox.Name = "SelectedRectangleWidthTextBox";
            this.SelectedRectangleWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleWidthTextBox.TabIndex = 29;
            this.SelectedRectangleWidthTextBox.TextChanged += new System.EventHandler(this.SelectedRectangleWidthTextBox_TextChanged);
            // 
            // SelectedRectangleYTextBox
            // 
            this.SelectedRectangleYTextBox.Location = new System.Drawing.Point(43, 251);
            this.SelectedRectangleYTextBox.Name = "SelectedRectangleYTextBox";
            this.SelectedRectangleYTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleYTextBox.TabIndex = 28;
            this.SelectedRectangleYTextBox.TextChanged += new System.EventHandler(this.SelectedRectangleYTextBox_TextChanged);
            // 
            // SelectedRectangleXTextBox
            // 
            this.SelectedRectangleXTextBox.Location = new System.Drawing.Point(43, 225);
            this.SelectedRectangleXTextBox.Name = "SelectedRectangleXTextBox";
            this.SelectedRectangleXTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleXTextBox.TabIndex = 27;
            this.SelectedRectangleXTextBox.TextChanged += new System.EventHandler(this.SelectedRectangleXTextBox_TextChanged);
            // 
            // SelectedRectangleIdTextBox
            // 
            this.SelectedRectangleIdTextBox.Location = new System.Drawing.Point(43, 199);
            this.SelectedRectangleIdTextBox.Name = "SelectedRectangleIdTextBox";
            this.SelectedRectangleIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleIdTextBox.TabIndex = 26;
            // 
            // SelectedRectangleHeightLabel
            // 
            this.SelectedRectangleHeightLabel.AutoSize = true;
            this.SelectedRectangleHeightLabel.Location = new System.Drawing.Point(2, 305);
            this.SelectedRectangleHeightLabel.Name = "SelectedRectangleHeightLabel";
            this.SelectedRectangleHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.SelectedRectangleHeightLabel.TabIndex = 25;
            this.SelectedRectangleHeightLabel.Text = "Height:";
            // 
            // SelectedRectangleWidthLabel
            // 
            this.SelectedRectangleWidthLabel.AutoSize = true;
            this.SelectedRectangleWidthLabel.Location = new System.Drawing.Point(5, 280);
            this.SelectedRectangleWidthLabel.Name = "SelectedRectangleWidthLabel";
            this.SelectedRectangleWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.SelectedRectangleWidthLabel.TabIndex = 24;
            this.SelectedRectangleWidthLabel.Text = "Width:";
            // 
            // SelectedRectangleYLabel
            // 
            this.SelectedRectangleYLabel.AutoSize = true;
            this.SelectedRectangleYLabel.Location = new System.Drawing.Point(26, 254);
            this.SelectedRectangleYLabel.Name = "SelectedRectangleYLabel";
            this.SelectedRectangleYLabel.Size = new System.Drawing.Size(17, 13);
            this.SelectedRectangleYLabel.TabIndex = 23;
            this.SelectedRectangleYLabel.Text = "Y:";
            // 
            // SelectedRectangleXLabel
            // 
            this.SelectedRectangleXLabel.AutoSize = true;
            this.SelectedRectangleXLabel.Location = new System.Drawing.Point(26, 228);
            this.SelectedRectangleXLabel.Name = "SelectedRectangleXLabel";
            this.SelectedRectangleXLabel.Size = new System.Drawing.Size(17, 13);
            this.SelectedRectangleXLabel.TabIndex = 22;
            this.SelectedRectangleXLabel.Text = "X:";
            // 
            // SelectedRectangleIdLabel
            // 
            this.SelectedRectangleIdLabel.AutoSize = true;
            this.SelectedRectangleIdLabel.Location = new System.Drawing.Point(26, 202);
            this.SelectedRectangleIdLabel.Name = "SelectedRectangleIdLabel";
            this.SelectedRectangleIdLabel.Size = new System.Drawing.Size(19, 13);
            this.SelectedRectangleIdLabel.TabIndex = 21;
            this.SelectedRectangleIdLabel.Text = "Id:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(3, 180);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(99, 13);
            this.SelectedRectangleLabel.TabIndex = 20;
            this.SelectedRectangleLabel.Text = "Selected rectangle:";
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(139, 144);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(54, 33);
            this.RemoveRectangleButton.TabIndex = 19;
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            this.RemoveRectangleButton.MouseEnter += new System.EventHandler(this.RemoveRectangleButton_MouseEnter);
            this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveRectangleButton_MouseLeave);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectangleButton.Location = new System.Drawing.Point(15, 144);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(54, 33);
            this.AddRectangleButton.TabIndex = 18;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddRectangleButton_MouseEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            // 
            // RectanglesListBox2
            // 
            this.RectanglesListBox2.FormattingEnabled = true;
            this.RectanglesListBox2.Location = new System.Drawing.Point(15, 22);
            this.RectanglesListBox2.Name = "RectanglesListBox2";
            this.RectanglesListBox2.Size = new System.Drawing.Size(178, 121);
            this.RectanglesListBox2.TabIndex = 17;
            this.RectanglesListBox2.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox2_SelectedIndexChanged);
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(3, 3);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesLabel.TabIndex = 16;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // RectangleCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.SelectedRectangleHeightTextBox);
            this.Controls.Add(this.SelectedRectangleWidthTextBox);
            this.Controls.Add(this.SelectedRectangleYTextBox);
            this.Controls.Add(this.SelectedRectangleXTextBox);
            this.Controls.Add(this.SelectedRectangleIdTextBox);
            this.Controls.Add(this.SelectedRectangleHeightLabel);
            this.Controls.Add(this.SelectedRectangleWidthLabel);
            this.Controls.Add(this.SelectedRectangleYLabel);
            this.Controls.Add(this.SelectedRectangleXLabel);
            this.Controls.Add(this.SelectedRectangleIdLabel);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.RemoveRectangleButton);
            this.Controls.Add(this.AddRectangleButton);
            this.Controls.Add(this.RectanglesListBox2);
            this.Controls.Add(this.RectanglesLabel);
            this.Name = "RectangleCollisionControl";
            this.Size = new System.Drawing.Size(682, 331);
            this.Load += new System.EventHandler(this.RectangleCollisionControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.TextBox SelectedRectangleHeightTextBox;
        private System.Windows.Forms.TextBox SelectedRectangleWidthTextBox;
        private System.Windows.Forms.TextBox SelectedRectangleYTextBox;
        private System.Windows.Forms.TextBox SelectedRectangleXTextBox;
        private System.Windows.Forms.TextBox SelectedRectangleIdTextBox;
        private System.Windows.Forms.Label SelectedRectangleHeightLabel;
        private System.Windows.Forms.Label SelectedRectangleWidthLabel;
        private System.Windows.Forms.Label SelectedRectangleYLabel;
        private System.Windows.Forms.Label SelectedRectangleXLabel;
        private System.Windows.Forms.Label SelectedRectangleIdLabel;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.ListBox RectanglesListBox2;
        private System.Windows.Forms.Label RectanglesLabel;
    }
}
