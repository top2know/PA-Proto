namespace MainForm
{
    partial class EnterForm
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
            this.button_Enter = new System.Windows.Forms.Button();
            this.button_Registration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\nДобро пожаловать!\r\n    \r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_Enter
            // 
            this.button_Enter.BackColor = System.Drawing.Color.ForestGreen;
            this.button_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_Enter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Enter.Location = new System.Drawing.Point(133, 300);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(87, 37);
            this.button_Enter.TabIndex = 1;
            this.button_Enter.Text = "Войти";
            this.button_Enter.UseVisualStyleBackColor = false;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // button_Registration
            // 
            this.button_Registration.BackColor = System.Drawing.Color.ForestGreen;
            this.button_Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_Registration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Registration.Location = new System.Drawing.Point(101, 394);
            this.button_Registration.Name = "button_Registration";
            this.button_Registration.Size = new System.Drawing.Size(151, 42);
            this.button_Registration.TabIndex = 2;
            this.button_Registration.Text = "Регистрация";
            this.button_Registration.UseVisualStyleBackColor = false;
            this.button_Registration.Click += new System.EventHandler(this.button_Registration_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.button_Registration);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.label1);
            this.Name = "EnterForm";
            this.Text = "Payment Assistant";
            this.VisibleChanged += new System.EventHandler(this.EnterForm_VisibleChanged);
            this.Leave += new System.EventHandler(this.EnterForm_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.Button button_Registration;
    }
}

