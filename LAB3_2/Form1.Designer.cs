
namespace LAB3_add
{
    partial class Form1
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
            this.New = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Hide = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.full_up = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.full_right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.full_left = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.full_down = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(578, 104);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(196, 23);
            this.New.TabIndex = 0;
            this.New.Text = "Створити новий об\'єкт";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Hide
            // 
            this.Hide.Location = new System.Drawing.Point(578, 133);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(196, 23);
            this.Hide.TabIndex = 2;
            this.Hide.Text = "Приховати об\'єкт";
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(578, 162);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(196, 23);
            this.Show.TabIndex = 3;
            this.Show.Text = "Показати об\'єкт";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // full_up
            // 
            this.full_up.Location = new System.Drawing.Point(650, 220);
            this.full_up.Name = "full_up";
            this.full_up.Size = new System.Drawing.Size(47, 20);
            this.full_up.TabIndex = 4;
            this.full_up.Text = "▲";
            this.full_up.UseVisualStyleBackColor = true;
            this.full_up.Click += new System.EventHandler(this.full_up_Click);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(650, 246);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(47, 23);
            this.up.TabIndex = 5;
            this.up.Text = "↑";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(698, 272);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(34, 55);
            this.right.TabIndex = 6;
            this.right.Text = "→";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // full_right
            // 
            this.full_right.Location = new System.Drawing.Point(738, 272);
            this.full_right.Name = "full_right";
            this.full_right.Size = new System.Drawing.Size(36, 55);
            this.full_right.TabIndex = 7;
            this.full_right.Text = "►";
            this.full_right.UseVisualStyleBackColor = true;
            this.full_right.Click += new System.EventHandler(this.full_right_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(614, 272);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(33, 55);
            this.left.TabIndex = 8;
            this.left.Text = "←";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // full_left
            // 
            this.full_left.Location = new System.Drawing.Point(572, 272);
            this.full_left.Name = "full_left";
            this.full_left.Size = new System.Drawing.Size(36, 55);
            this.full_left.TabIndex = 9;
            this.full_left.Text = "◄";
            this.full_left.UseVisualStyleBackColor = true;
            this.full_left.Click += new System.EventHandler(this.full_left_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(650, 333);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(47, 23);
            this.down.TabIndex = 10;
            this.down.Text = "↓";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // full_down
            // 
            this.full_down.Location = new System.Drawing.Point(650, 362);
            this.full_down.Name = "full_down";
            this.full_down.Size = new System.Drawing.Size(47, 23);
            this.full_down.TabIndex = 11;
            this.full_down.Text = "▼";
            this.full_down.UseVisualStyleBackColor = true;
            this.full_down.Click += new System.EventHandler(this.full_down_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(653, 275);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(39, 23);
            this.plus.TabIndex = 12;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(653, 304);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(39, 23);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Перелік об\'єктів";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(578, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.full_down);
            this.Controls.Add(this.down);
            this.Controls.Add(this.full_left);
            this.Controls.Add(this.left);
            this.Controls.Add(this.full_right);
            this.Controls.Add(this.right);
            this.Controls.Add(this.up);
            this.Controls.Add(this.full_up);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.New);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Circle Class Demo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button full_up;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button full_right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button full_left;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button full_down;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

