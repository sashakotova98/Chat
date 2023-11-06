namespace Server;

partial class Form1
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
        lbMessage = new ListBox();
        label1 = new Label();
        lbContacts = new ListBox();
        SuspendLayout();
        // 
        // lbMessage
        // 
        lbMessage.BackColor = SystemColors.ActiveCaption;
        lbMessage.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lbMessage.FormattingEnabled = true;
        lbMessage.ItemHeight = 20;
        lbMessage.Location = new Point(294, 47);
        lbMessage.Margin = new Padding(2);
        lbMessage.Name = "lbMessage";
        lbMessage.Size = new Size(591, 284);
        lbMessage.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(28, 17);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(58, 15);
        label1.TabIndex = 10;
        label1.Text = "контакты";
        // 
        // lbContacts
        // 
        lbContacts.FormattingEnabled = true;
        lbContacts.ItemHeight = 15;
        lbContacts.Location = new Point(28, 47);
        lbContacts.Margin = new Padding(2);
        lbContacts.Name = "lbContacts";
        lbContacts.Size = new Size(262, 289);
        lbContacts.TabIndex = 9;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(898, 349);
        Controls.Add(label1);
        Controls.Add(lbContacts);
        Controls.Add(lbMessage);
        Margin = new Padding(2);
        Name = "Form1";
        Text = "Server";
        FormClosing += Form1_FormClosing;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ListBox lbMessage;
    private Label label1;
    private ListBox lbContacts;
}
