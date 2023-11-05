namespace Client
{
    partial class Register_Window
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
            tbLogin = new TextBox();
            tbPassword = new TextBox();
            bntRegistration = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbMsg = new TextBox();
            SuspendLayout();
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbLogin.Location = new Point(95, 57);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(526, 39);
            tbLogin.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbPassword.Location = new Point(95, 163);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(526, 39);
            tbPassword.TabIndex = 1;
            // 
            // bntRegistration
            // 
            bntRegistration.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            bntRegistration.Location = new Point(254, 307);
            bntRegistration.Name = "bntRegistration";
            bntRegistration.Size = new Size(207, 87);
            bntRegistration.TabIndex = 2;
            bntRegistration.Text = "Registration";
            bntRegistration.UseVisualStyleBackColor = true;
            bntRegistration.Click += bntRegistration_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(106, 22);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 3;
            label1.Text = "login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(95, 128);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 4;
            label2.Text = "password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 221);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 14;
            label3.Text = "Messege";
            // 
            // tbMsg
            // 
            tbMsg.BackColor = SystemColors.ActiveBorder;
            tbMsg.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tbMsg.Location = new Point(109, 249);
            tbMsg.Multiline = true;
            tbMsg.Name = "tbMsg";
            tbMsg.Size = new Size(512, 37);
            tbMsg.TabIndex = 13;
            // 
            // Register_Window
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(782, 406);
            Controls.Add(label3);
            Controls.Add(tbMsg);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bntRegistration);
            Controls.Add(tbPassword);
            Controls.Add(tbLogin);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Register_Window";
            Text = "Register_Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLogin;
        private TextBox tbPassword;
        private Button bntRegistration;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbMsg;
    }
}