namespace Client
{
    partial class Admin_Window
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
            textBox1 = new TextBox();
            label1 = new Label();
            lbUsersShow = new ListBox();
            lbMessages = new ListBox();
            label2 = new Label();
            tbMessage = new TextBox();
            btnSend = new Button();
            btnDeleteUser = new Button();
            btnBanUser = new Button();
            btnAddNewUser = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 39);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(404, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 100);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 1;
            label1.Text = "Contacts";
            // 
            // lbUsersShow
            // 
            lbUsersShow.FormattingEnabled = true;
            lbUsersShow.ItemHeight = 25;
            lbUsersShow.Location = new Point(41, 143);
            lbUsersShow.Name = "lbUsersShow";
            lbUsersShow.Size = new Size(404, 329);
            lbUsersShow.TabIndex = 2;
            // 
            // lbMessages
            // 
            lbMessages.FormattingEnabled = true;
            lbMessages.ItemHeight = 25;
            lbMessages.Location = new Point(513, 68);
            lbMessages.Name = "lbMessages";
            lbMessages.Size = new Size(463, 404);
            lbMessages.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(513, 25);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 4;
            label2.Text = "Messages";
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(516, 506);
            tbMessage.Multiline = true;
            tbMessage.Name = "tbMessage";
            tbMessage.PlaceholderText = "Enter your message";
            tbMessage.Size = new Size(460, 46);
            tbMessage.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.Location = new Point(630, 585);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(219, 69);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteUser.Location = new Point(71, 510);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(146, 42);
            btnDeleteUser.TabIndex = 8;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnBanUser
            // 
            btnBanUser.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnBanUser.Location = new Point(257, 510);
            btnBanUser.Name = "btnBanUser";
            btnBanUser.Size = new Size(130, 42);
            btnBanUser.TabIndex = 9;
            btnBanUser.Text = "Ban User";
            btnBanUser.UseVisualStyleBackColor = true;
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNewUser.Location = new Point(91, 585);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(336, 64);
            btnAddNewUser.TabIndex = 10;
            btnAddNewUser.Text = "Add new User";
            btnAddNewUser.UseVisualStyleBackColor = true;
            btnAddNewUser.Click += btnAddNewUser_Click;
            // 
            // Admin_Window
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 680);
            Controls.Add(btnAddNewUser);
            Controls.Add(btnBanUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnSend);
            Controls.Add(tbMessage);
            Controls.Add(label2);
            Controls.Add(lbMessages);
            Controls.Add(lbUsersShow);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Admin_Window";
            Text = "Admin_Window";
            Load += Admin_Window_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private ListBox lbUsersShow;
        private ListBox lbMessages;
        private Label label2;
        private TextBox tbMessage;
        private Button btnSend;
        private Button btnDeleteUser;
        private Button btnBanUser;
        private Button btnAddNewUser;
    }
}