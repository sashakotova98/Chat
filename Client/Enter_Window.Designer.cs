namespace Client
{
    partial class Enter_Window
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
            label2 = new Label();
            label1 = new Label();
            tbPassword = new TextBox();
            tbLogin = new TextBox();
            btnEnter = new Button();
            tbMsg = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(98, 76);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 9;
            label2.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(106, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 8;
            label1.Text = "login";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbPassword.Location = new Point(98, 97);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(369, 29);
            tbPassword.TabIndex = 6;
            tbPassword.Text = "admin";
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbLogin.Location = new Point(98, 36);
            tbLogin.Margin = new Padding(2);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(369, 29);
            tbLogin.TabIndex = 5;
            tbLogin.Text = "admin";
            // 
            // btnEnter
            // 
            btnEnter.BackColor = SystemColors.ButtonHighlight;
            btnEnter.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnter.Location = new Point(195, 208);
            btnEnter.Margin = new Padding(2);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(145, 52);
            btnEnter.TabIndex = 10;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // tbMsg
            // 
            tbMsg.BackColor = SystemColors.ActiveBorder;
            tbMsg.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tbMsg.Location = new Point(108, 154);
            tbMsg.Margin = new Padding(2);
            tbMsg.Multiline = true;
            tbMsg.Name = "tbMsg";
            tbMsg.Size = new Size(360, 24);
            tbMsg.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 137);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 12;
            label3.Text = "Messege";
            // 
            // Enter_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(566, 280);
            Controls.Add(label3);
            Controls.Add(tbMsg);
            Controls.Add(btnEnter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbLogin);
            Margin = new Padding(2);
            Name = "Enter_Window";
            Text = "Enter_Window";
           
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox tbPassword;
        private TextBox tbLogin;
        private Button btnEnter;
        private TextBox tbMsg;
        private Label label3;
    }
}