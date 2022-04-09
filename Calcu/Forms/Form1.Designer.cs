namespace Calcu
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
            this.label1 = new System.Windows.Forms.Label();
            this.simpleCalcBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(191, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Калькулятор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // simpleCalcBtn
            // 
            this.simpleCalcBtn.BackColor = System.Drawing.Color.Yellow;
            this.simpleCalcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleCalcBtn.Location = new System.Drawing.Point(56, 140);
            this.simpleCalcBtn.Name = "simpleCalcBtn";
            this.simpleCalcBtn.Size = new System.Drawing.Size(165, 72);
            this.simpleCalcBtn.TabIndex = 1;
            this.simpleCalcBtn.Text = "Простой калькулятор";
            this.simpleCalcBtn.UseVisualStyleBackColor = false;
            this.simpleCalcBtn.Click += new System.EventHandler(this.simpleCalcBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(619, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "Топливный калькулятор";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.ExitBtn.Location = new System.Drawing.Point(300, 289);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(192, 57);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(843, 410);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.simpleCalcBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button simpleCalcBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ExitBtn;
    }
}

