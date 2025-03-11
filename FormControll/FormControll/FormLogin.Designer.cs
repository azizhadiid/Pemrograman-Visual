namespace FormControll
{
    partial class FormLogin
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
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(73, 98);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(163, 45);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            labelUsername.Click += label1_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.Location = new Point(83, 184);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(153, 45);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password";
            labelPassword.Click += labelPassword_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(272, 105);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Your Username";
            textBoxUsername.Size = new Size(403, 39);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(272, 184);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "*******";
            textBoxPassword.Size = new Size(403, 39);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.LightGreen;
            buttonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(525, 287);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(150, 46);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.LightSalmon;
            buttonClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonClear.ForeColor = SystemColors.ButtonHighlight;
            buttonClear.Location = new Point(359, 287);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(150, 46);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClear);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonClear;
    }
}
