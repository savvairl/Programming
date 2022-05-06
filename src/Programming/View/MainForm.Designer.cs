
namespace Programming.View
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabControl = new System.Windows.Forms.TabPage();
            this.seasonHandleControl1 = new Programming.View.Controls.SeasonHandleControl();
            this.weekdayParsingControl1 = new Programming.View.Controls.WeekdayParsingControl();
            this.enumerationControl1 = new Programming.View.Controls.EnumerationsControl();
            this.ClassesTabControl = new System.Windows.Forms.TabPage();
            this.moviesControl1 = new Programming.View.Controls.MoviesControl();
            this.rectanglesControl1 = new Programming.View.Controls.RectanglesControl();
            this.RectanglesTabControl = new System.Windows.Forms.TabPage();
            this.rectangleCollisionControl1 = new Programming.View.Controls.RectangleCollisionControl();
            this.TabControl.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.ClassesTabControl.SuspendLayout();
            this.RectanglesTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsTabControl);
            this.TabControl.Controls.Add(this.ClassesTabControl);
            this.TabControl.Controls.Add(this.RectanglesTabControl);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(696, 359);
            this.TabControl.TabIndex = 0;
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.seasonHandleControl1);
            this.EnumsTabControl.Controls.Add(this.weekdayParsingControl1);
            this.EnumsTabControl.Controls.Add(this.enumerationControl1);
            this.EnumsTabControl.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabControl.Size = new System.Drawing.Size(688, 333);
            this.EnumsTabControl.TabIndex = 0;
            this.EnumsTabControl.Text = "Enums";
            this.EnumsTabControl.UseVisualStyleBackColor = true;
            // 
            // seasonHandleControl1
            // 
            this.seasonHandleControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seasonHandleControl1.Location = new System.Drawing.Point(352, 241);
            this.seasonHandleControl1.Name = "seasonHandleControl1";
            this.seasonHandleControl1.Size = new System.Drawing.Size(340, 89);
            this.seasonHandleControl1.TabIndex = 11;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weekdayParsingControl1.Location = new System.Drawing.Point(-4, 242);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(343, 95);
            this.weekdayParsingControl1.TabIndex = 10;
            // 
            // enumerationControl1
            // 
            this.enumerationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enumerationControl1.Location = new System.Drawing.Point(0, 6);
            this.enumerationControl1.Name = "enumerationControl1";
            this.enumerationControl1.Size = new System.Drawing.Size(688, 240);
            this.enumerationControl1.TabIndex = 9;
            // 
            // ClassesTabControl
            // 
            this.ClassesTabControl.Controls.Add(this.moviesControl1);
            this.ClassesTabControl.Controls.Add(this.rectanglesControl1);
            this.ClassesTabControl.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabControl.Name = "ClassesTabControl";
            this.ClassesTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabControl.Size = new System.Drawing.Size(688, 333);
            this.ClassesTabControl.TabIndex = 1;
            this.ClassesTabControl.Text = "Classes";
            this.ClassesTabControl.UseVisualStyleBackColor = true;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moviesControl1.Location = new System.Drawing.Point(355, 6);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(337, 327);
            this.moviesControl1.TabIndex = 3;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectanglesControl1.Location = new System.Drawing.Point(0, 6);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(342, 331);
            this.rectanglesControl1.TabIndex = 2;
            // 
            // RectanglesTabControl
            // 
            this.RectanglesTabControl.Controls.Add(this.rectangleCollisionControl1);
            this.RectanglesTabControl.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabControl.Name = "RectanglesTabControl";
            this.RectanglesTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabControl.Size = new System.Drawing.Size(688, 333);
            this.RectanglesTabControl.TabIndex = 2;
            this.RectanglesTabControl.Text = "Rectangles";
            this.RectanglesTabControl.UseVisualStyleBackColor = true;
            // 
            // rectangleCollisionControl1
            // 
            this.rectangleCollisionControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectangleCollisionControl1.Name = "rectangleCollisionControl1";
            this.rectangleCollisionControl1.Size = new System.Drawing.Size(682, 327);
            this.rectangleCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 359);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.TabControl.ResumeLayout(false);
            this.EnumsTabControl.ResumeLayout(false);
            this.ClassesTabControl.ResumeLayout(false);
            this.RectanglesTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EnumsTabControl;
        private System.Windows.Forms.TabPage ClassesTabControl;
        private Controls.SeasonHandleControl seasonHandleControl1;
        private Controls.WeekdayParsingControl weekdayParsingControl1;
        private Controls.EnumerationsControl enumerationControl1;
        private Controls.MoviesControl moviesControl1;
        private Controls.RectanglesControl rectanglesControl1;
        private System.Windows.Forms.TabPage RectanglesTabControl;
        private Controls.RectangleCollisionControl rectangleCollisionControl1;
    }
}

