namespace Client
{
    partial class Login_Window
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
            btn_Register_Login = new Button();
            pass = new TextBox();
            login = new TextBox();
            btn_Enter_Login = new Button();
            SuspendLayout();
            // 
            // btn_Register_Login
            // 
            btn_Register_Login.Location = new Point(259, 235);
            btn_Register_Login.Name = "btn_Register_Login";
            btn_Register_Login.Size = new Size(197, 23);
            btn_Register_Login.TabIndex = 12;
            btn_Register_Login.Text = "Register";
            btn_Register_Login.UseVisualStyleBackColor = true;
            btn_Register_Login.Click += btn_Register_Login_Click;
            // 
            // pass
            // 
            pass.Location = new Point(204, 149);
            pass.Name = "pass";
            pass.PlaceholderText = "Password";
            pass.Size = new Size(337, 23);
            pass.TabIndex = 11;
            // 
            // login
            // 
            login.Location = new Point(204, 94);
            login.Name = "login";
            login.PlaceholderText = "Login";
            login.Size = new Size(337, 23);
            login.TabIndex = 10;
            // 
            // btn_Enter_Login
            // 
            btn_Enter_Login.Location = new Point(259, 201);
            btn_Enter_Login.Name = "btn_Enter_Login";
            btn_Enter_Login.Size = new Size(197, 23);
            btn_Enter_Login.TabIndex = 9;
            btn_Enter_Login.Text = "Enter";
            btn_Enter_Login.UseVisualStyleBackColor = true;
            btn_Enter_Login.Click += btn_Enter_Login_Click;
            // 
            // Login_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Register_Login);
            Controls.Add(pass);
            Controls.Add(login);
            Controls.Add(btn_Enter_Login);
            Name = "Login_Window";
            Text = "Login_Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Register_Login;
        private TextBox pass;
        private TextBox login;
        private Button btn_Enter_Login;
    }
}