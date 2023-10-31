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
            passReg = new TextBox();
            loginReg = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // passReg
            // 
            passReg.Location = new Point(199, 152);
            passReg.Name = "passReg";
            passReg.PlaceholderText = "Password";
            passReg.Size = new Size(337, 23);
            passReg.TabIndex = 11;
            // 
            // loginReg
            // 
            loginReg.Location = new Point(199, 97);
            loginReg.Name = "loginReg";
            loginReg.PlaceholderText = "Login";
            loginReg.Size = new Size(337, 23);
            loginReg.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(254, 204);
            button1.Name = "button1";
            button1.Size = new Size(197, 23);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // Register_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passReg);
            Controls.Add(loginReg);
            Controls.Add(button1);
            Name = "Register_Window";
            Text = "Register_Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passReg;
        private TextBox loginReg;
        private Button button1;
    }
}