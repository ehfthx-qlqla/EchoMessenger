namespace EchoMessenger
{
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
            lbTitle = new Label();
            txtSubmit = new TextBox();
            lstMsgWindow = new ListBox();
            btSend = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("한컴 말랑말랑 Bold", 28F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbTitle.Location = new Point(48, 29);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(465, 72);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Echo Messenger";
            lbTitle.Click += label1_Click;
            // 
            // txtSubmit
            // 
            txtSubmit.Font = new Font("한컴 말랑말랑 Regular", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtSubmit.Location = new Point(48, 608);
            txtSubmit.Name = "txtSubmit";
            txtSubmit.Size = new Size(772, 54);
            txtSubmit.TabIndex = 1;
            txtSubmit.TextChanged += textBox1_TextChanged;
            // 
            // lstMsgWindow
            // 
            lstMsgWindow.Font = new Font("한컴 말랑말랑 Regular", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstMsgWindow.FormattingEnabled = true;
            lstMsgWindow.Location = new Point(48, 139);
            lstMsgWindow.Name = "lstMsgWindow";
            lstMsgWindow.Size = new Size(1043, 420);
            lstMsgWindow.TabIndex = 2;
            lstMsgWindow.SelectedIndexChanged += lstMsgWindow_SelectedIndexChanged;
            // 
            // btSend
            // 
            btSend.Font = new Font("한컴 말랑말랑 Bold", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btSend.Location = new Point(877, 590);
            btSend.Name = "btSend";
            btSend.Size = new Size(214, 90);
            btSend.TabIndex = 3;
            btSend.Text = "전송";
            btSend.UseVisualStyleBackColor = true;
            btSend.Click += btSend_Click;
            // 
            // Form1
            // 
            AcceptButton = btSend;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 717);
            Controls.Add(btSend);
            Controls.Add(lstMsgWindow);
            Controls.Add(txtSubmit);
            Controls.Add(lbTitle);
            Name = "Form1";
            Text = "Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private TextBox txtSubmit;
        private ListBox lstMsgWindow;
        private Button btSend;
    }
}
