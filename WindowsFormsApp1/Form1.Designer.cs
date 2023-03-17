namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Header = new System.Windows.Forms.Label();
            this.paragraph1 = new System.Windows.Forms.Label();
            this.enterNum = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.checkCorrect = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(238, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(294, 18);
            this.Header.TabIndex = 0;
            this.Header.Text = "გამოიცანი ჩაფიქრებული რიცხვი ^_^";
            this.Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.Click += new System.EventHandler(this.label1_Click);
            // 
            // paragraph1
            // 
            this.paragraph1.AutoSize = true;
            this.paragraph1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paragraph1.Location = new System.Drawing.Point(27, 80);
            this.paragraph1.MaximumSize = new System.Drawing.Size(500, 0);
            this.paragraph1.Name = "paragraph1";
            this.paragraph1.Size = new System.Drawing.Size(486, 30);
            this.paragraph1.TabIndex = 1;
            this.paragraph1.Text = "წესები მარტივია. შეიყვანე ნებისმიერი რიცხვი და მე გეტყვი უფრო დიდია ჩემი ჩაფიქრებ" +
    "ული რიცხვი თუ პატარა, რომ შეძლო გამოცნობა. წარმატებები <3";
            // 
            // enterNum
            // 
            this.enterNum.AutoSize = true;
            this.enterNum.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.enterNum.Location = new System.Drawing.Point(267, 163);
            this.enterNum.Name = "enterNum";
            this.enterNum.Size = new System.Drawing.Size(144, 21);
            this.enterNum.TabIndex = 3;
            this.enterNum.Text = "შეიყვანე რიცხვი";
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(241, 197);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(200, 25);
            this.input.TabIndex = 4;
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // checkCorrect
            // 
            this.checkCorrect.AutoSize = true;
            this.checkCorrect.Location = new System.Drawing.Point(238, 237);
            this.checkCorrect.Name = "checkCorrect";
            this.checkCorrect.Size = new System.Drawing.Size(227, 13);
            this.checkCorrect.TabIndex = 5;
            this.checkCorrect.Text = "არასწორია, სცადე უფრო პატარა რიცხვი";
            this.checkCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterBtn
            // 
            this.enterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterBtn.FlatAppearance.BorderSize = 0;
            this.enterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBtn.Location = new System.Drawing.Point(271, 271);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(128, 23);
            this.enterBtn.TabIndex = 6;
            this.enterBtn.Text = "ENTER";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(271, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "RESTART";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 374);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "გაფრთხილება! ! ! შეიყვანეთ მხოლოდ ციფრები. წინააღმდეგ შემთხვევაში კოდი არ გაიშვებ" +
    "ა! ! !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.checkCorrect);
            this.Controls.Add(this.input);
            this.Controls.Add(this.enterNum);
            this.Controls.Add(this.paragraph1);
            this.Controls.Add(this.Header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label paragraph1;
        private System.Windows.Forms.Label enterNum;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label checkCorrect;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

