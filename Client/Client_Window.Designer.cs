namespace Client
{
    partial class Client_Window
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
            lblShowConnect = new Label();
            lbUsersShow = new ListBox();
            textBox1 = new TextBox();
            rtbWrite_Show_Message = new RichTextBox();
            SuspendLayout();
            // 
            // lblShowConnect
            // 
            lblShowConnect.BackColor = Color.FromArgb(128, 255, 255);
            lblShowConnect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShowConnect.Location = new Point(659, 9);
            lblShowConnect.Name = "lblShowConnect";
            lblShowConnect.Size = new Size(100, 23);
            lblShowConnect.TabIndex = 0;
            // 
            // lbUsersShow
            // 
            lbUsersShow.FormattingEnabled = true;
            lbUsersShow.ItemHeight = 15;
            lbUsersShow.Location = new Point(25, 127);
            lbUsersShow.Name = "lbUsersShow";
            lbUsersShow.Size = new Size(295, 274);
            lbUsersShow.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 38);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // rtbWrite_Show_Message
            // 
            rtbWrite_Show_Message.Location = new Point(466, 127);
            rtbWrite_Show_Message.Name = "rtbWrite_Show_Message";
            rtbWrite_Show_Message.Size = new Size(293, 274);
            rtbWrite_Show_Message.TabIndex = 3;
            rtbWrite_Show_Message.Text = "Message\n";
            // 
            // Client_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbWrite_Show_Message);
            Controls.Add(textBox1);
            Controls.Add(lbUsersShow);
            Controls.Add(lblShowConnect);
            Name = "Client_Window";
            Text = "Client_Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShowConnect;
        private ListBox lbUsersShow;
        private TextBox textBox1;
        private RichTextBox rtbWrite_Show_Message;
    }
}