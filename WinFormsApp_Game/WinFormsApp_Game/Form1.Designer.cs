
namespace WinFormsApp_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_check = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label_k = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.LightGreen;
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_check.Location = new System.Drawing.Point(451, 307);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(130, 47);
            this.button_check.TabIndex = 1;
            this.button_check.Text = "Проверить";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_show
            // 
            this.button_show.BackColor = System.Drawing.Color.Red;
            this.button_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_show.Location = new System.Drawing.Point(216, 307);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(172, 47);
            this.button_show.TabIndex = 2;
            this.button_show.Text = "Показать число";
            this.button_show.UseVisualStyleBackColor = false;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // label_result
            // 
            this.label_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.label_result.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_result.Location = new System.Drawing.Point(2, 4);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(600, 41);
            this.label_result.TabIndex = 3;
            this.label_result.Text = "Здесь отображается результат проверки";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_number
            // 
            this.textBox_number.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_number.Location = new System.Drawing.Point(520, 264);
            this.textBox_number.MaxLength = 4;
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(61, 38);
            this.textBox_number.TabIndex = 4;
            this.textBox_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_number_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(116)))), ((int)(((byte)(50)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(468, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите число:";
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_start.Location = new System.Drawing.Point(21, 307);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(129, 47);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "Новая игра";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_k
            // 
            this.label_k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(168)))), ((int)(((byte)(129)))));
            this.label_k.Cursor = System.Windows.Forms.Cursors.No;
            this.label_k.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_k.Location = new System.Drawing.Point(91, 232);
            this.label_k.Name = "label_k";
            this.label_k.Size = new System.Drawing.Size(30, 46);
            this.label_k.TabIndex = 7;
            // 
            // label_b
            // 
            this.label_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(168)))), ((int)(((byte)(129)))));
            this.label_b.Cursor = System.Windows.Forms.Cursors.No;
            this.label_b.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_b.Location = new System.Drawing.Point(327, 232);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(30, 46);
            this.label_b.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp_Game.Properties.Resources.заставка;
            this.ClientSize = new System.Drawing.Size(603, 379);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_k);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_check);
            this.Name = "Form1";
            this.Text = "Быки и коровы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_k;
        private System.Windows.Forms.Label label_b;
    }
}

