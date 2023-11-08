namespace Client
{
    partial class Client_Window
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
            tbMessage = new TextBox();
            lbMessage = new ListBox();
            btnSend = new Button();
            lbContacts = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(471, 413);
            tbMessage.Multiline = true;
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(583, 46);
            tbMessage.TabIndex = 4;
            // 
            // lbMessage
            // 
            lbMessage.BackColor = SystemColors.ActiveCaption;
            lbMessage.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbMessage.FormattingEnabled = true;
            lbMessage.ItemHeight = 30;
            lbMessage.Location = new Point(471, 152);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(583, 184);
            lbMessage.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.Location = new Point(651, 517);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(270, 53);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lbContacts
            // 
            lbContacts.FormattingEnabled = true;
            lbContacts.ItemHeight = 25;
            lbContacts.Location = new Point(60, 73);
            lbContacts.Name = "lbContacts";
            lbContacts.Size = new Size(373, 479);
            lbContacts.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 23);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 8;
            label1.Text = "контакты";
            // 
            // Client_Window
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 628);
            Controls.Add(label1);
            Controls.Add(lbContacts);
            Controls.Add(btnSend);
            Controls.Add(tbMessage);
            Controls.Add(lbMessage);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Client_Window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMessage;
        private ListBox lbMessage;
        private Button btnSend;
        private ListBox lbContacts;
        private Label label1;
    }
}