namespace AppRunner
{
    partial class StartForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginUserNameTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerUserNameTextbox = new System.Windows.Forms.TextBox();
            this.registerEmailTextbox = new System.Windows.Forms.TextBox();
            this.registerPasswordTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(88, 356);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(117, 49);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasło";
            // 
            // loginUserNameTextBox
            // 
            this.loginUserNameTextBox.Location = new System.Drawing.Point(88, 201);
            this.loginUserNameTextBox.Name = "loginUserNameTextBox";
            this.loginUserNameTextBox.Size = new System.Drawing.Size(100, 29);
            this.loginUserNameTextBox.TabIndex = 3;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Location = new System.Drawing.Point(88, 296);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '*';
            this.loginPasswordTextBox.Size = new System.Drawing.Size(100, 29);
            this.loginPasswordTextBox.TabIndex = 4;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(466, 356);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(145, 49);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Zarejestruj";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // registerUserNameTextbox
            // 
            this.registerUserNameTextbox.Location = new System.Drawing.Point(466, 131);
            this.registerUserNameTextbox.Name = "registerUserNameTextbox";
            this.registerUserNameTextbox.Size = new System.Drawing.Size(100, 29);
            this.registerUserNameTextbox.TabIndex = 6;
            // 
            // registerEmailTextbox
            // 
            this.registerEmailTextbox.Location = new System.Drawing.Point(466, 201);
            this.registerEmailTextbox.Name = "registerEmailTextbox";
            this.registerEmailTextbox.Size = new System.Drawing.Size(100, 29);
            this.registerEmailTextbox.TabIndex = 7;
            // 
            // registerPasswordTextbox
            // 
            this.registerPasswordTextbox.Location = new System.Drawing.Point(466, 286);
            this.registerPasswordTextbox.Name = "registerPasswordTextbox";
            this.registerPasswordTextbox.PasswordChar = '*';
            this.registerPasswordTextbox.Size = new System.Drawing.Size(100, 29);
            this.registerPasswordTextbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hasło";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerPasswordTextbox);
            this.Controls.Add(this.registerEmailTextbox);
            this.Controls.Add(this.registerUserNameTextbox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.loginUserNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Name = "StartForm";
            this.Text = "PomodoroTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginUserNameTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox registerUserNameTextbox;
        private System.Windows.Forms.TextBox registerEmailTextbox;
        private System.Windows.Forms.TextBox registerPasswordTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

