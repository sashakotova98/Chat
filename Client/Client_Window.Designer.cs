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
            textBox1 = new TextBox();
            lbMessage = new ListBox();
            btnSend = new Button();
            lbContacts = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(330, 248);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 29);
            textBox1.TabIndex = 4;
            // 
            // lbMessage
            // 
            lbMessage.BackColor = SystemColors.ActiveCaption;
            lbMessage.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbMessage.FormattingEnabled = true;
            lbMessage.ItemHeight = 20;
            lbMessage.Location = new Point(330, 91);
            lbMessage.Margin = new Padding(2, 2, 2, 2);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(409, 124);
            lbMessage.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.Location = new Point(456, 310);
            btnSend.Margin = new Padding(2, 2, 2, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(189, 32);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lbContacts
            // 
            lbContacts.FormattingEnabled = true;
            lbContacts.ItemHeight = 15;
            lbContacts.Location = new Point(42, 44);
            lbContacts.Margin = new Padding(2, 2, 2, 2);
            lbContacts.Name = "lbContacts";
            lbContacts.Size = new Size(262, 289);
            lbContacts.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 8;
            label1.Text = "контакты";
            // 
            // Client_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 377);
            Controls.Add(label1);
            Controls.Add(lbContacts);
            Controls.Add(btnSend);
            Controls.Add(textBox1);
            Controls.Add(lbMessage);
            Name = "Client_Window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox lbMessage;
        private Button btnSend;
        private ListBox lbContacts;
        private Label label1;
    }
}