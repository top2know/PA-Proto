namespace MainForm
{
    partial class FormEnter
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_PassEnter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_EnterAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(89, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер телефона";
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(94, 235);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(172, 20);
            this.textBox_PhoneNumber.TabIndex = 1;
            // 
            // textBox_PassEnter
            // 
            this.textBox_PassEnter.Location = new System.Drawing.Point(94, 308);
            this.textBox_PassEnter.Name = "textBox_PassEnter";
            this.textBox_PassEnter.PasswordChar = '*';
            this.textBox_PassEnter.Size = new System.Drawing.Size(172, 20);
            this.textBox_PassEnter.TabIndex = 3;
            this.textBox_PassEnter.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(89, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // button_EnterAcc
            // 
            this.button_EnterAcc.BackColor = System.Drawing.Color.ForestGreen;
            this.button_EnterAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_EnterAcc.Location = new System.Drawing.Point(135, 366);
            this.button_EnterAcc.Name = "button_EnterAcc";
            this.button_EnterAcc.Size = new System.Drawing.Size(88, 35);
            this.button_EnterAcc.TabIndex = 4;
            this.button_EnterAcc.Text = "Войти";
            this.button_EnterAcc.UseVisualStyleBackColor = false;
            this.button_EnterAcc.Click += new System.EventHandler(this.button_EnterAcc_Click);
            // 
            // FormEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.button_EnterAcc);
            this.Controls.Add(this.textBox_PassEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.label1);
            this.Name = "FormEnter";
            this.Text = "Payment Assistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_PassEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_EnterAcc;
    }
}