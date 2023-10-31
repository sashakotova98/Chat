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
            btnUpdate = new Button();
            btnSend_Client = new Button();
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
            lbUsersShow.Location = new Point(12, 96);
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
            rtbWrite_Show_Message.Location = new Point(453, 96);
            rtbWrite_Show_Message.Name = "rtbWrite_Show_Message";
            rtbWrite_Show_Message.Size = new Size(293, 274);
            rtbWrite_Show_Message.TabIndex = 3;
            rtbWrite_Show_Message.Text = "Message\n";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(104, 396);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSend_Client
            // 
            btnSend_Client.Location = new Point(565, 396);
            btnSend_Client.Name = "btnSend_Client";
            btnSend_Client.Size = new Size(75, 23);
            btnSend_Client.TabIndex = 5;
            btnSend_Client.Text = "Send";
            btnSend_Client.UseVisualStyleBackColor = true;
            btnSend_Client.Click += btnSend_Client_Click;
            // 
            // Client_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend_Client);
            Controls.Add(btnUpdate);
            Controls.Add(rtbWrite_Show_Message);
            Controls.Add(textBox1);
            Controls.Add(lbUsersShow);
            Controls.Add(lblShowConnect);
            Name = "Client_Window";
            Text = "Client_Window";
            Load += Client_Window_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShowConnect;
        private ListBox lbUsersShow;
        private TextBox textBox1;
        private RichTextBox rtbWrite_Show_Message;
        private Button btnUpdate;
        private Button btnSend_Client;
    }
}