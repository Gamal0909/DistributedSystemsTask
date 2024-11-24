namespace Task1
{
    partial class Client
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
            textBox3 = new TextBox();
            txtLog = new TextBox();
            Log = new Label();
            Send = new Button();
            txtServerPort = new TextBox();
            ServerPort = new Label();
            txtmsg = new TextBox();
            label1 = new Label();
            txtClientPortnum = new TextBox();
            label2 = new Label();
            txtHostName = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(55, 12);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 65);
            textBox3.TabIndex = 13;
            textBox3.Text = "Client";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(97, 194);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(244, 124);
            txtLog.TabIndex = 12;
            // 
            // Log
            // 
            Log.AutoSize = true;
            Log.Location = new Point(54, 184);
            Log.Name = "Log";
            Log.Size = new Size(37, 20);
            Log.TabIndex = 11;
            Log.Text = "Log:";
            // 
            // Send
            // 
            Send.Location = new Point(54, 387);
            Send.Name = "Send";
            Send.Size = new Size(132, 51);
            Send.TabIndex = 10;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // txtServerPort
            // 
            txtServerPort.Location = new Point(144, 90);
            txtServerPort.Name = "txtServerPort";
            txtServerPort.Size = new Size(125, 27);
            txtServerPort.TabIndex = 9;
            txtServerPort.TextChanged += txtServerPort_TextChanged;
            // 
            // ServerPort
            // 
            ServerPort.AutoSize = true;
            ServerPort.Location = new Point(55, 90);
            ServerPort.Name = "ServerPort";
            ServerPort.Size = new Size(83, 20);
            ServerPort.TabIndex = 8;
            ServerPort.Text = "Server Port:";
            // 
            // txtmsg
            // 
            txtmsg.Location = new Point(97, 347);
            txtmsg.Name = "txtmsg";
            txtmsg.Size = new Size(244, 27);
            txtmsg.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 324);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 14;
            label1.Text = "Send Message to Server :";
            // 
            // txtClientPortnum
            // 
            txtClientPortnum.Location = new Point(144, 122);
            txtClientPortnum.Name = "txtClientPortnum";
            txtClientPortnum.Size = new Size(125, 27);
            txtClientPortnum.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 122);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 16;
            label2.Text = "Client Port:";
            // 
            // txtHostName
            // 
            txtHostName.Location = new Point(144, 155);
            txtHostName.Name = "txtHostName";
            txtHostName.Size = new Size(125, 27);
            txtHostName.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 155);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 18;
            label3.Text = "Host Name :";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtHostName);
            Controls.Add(label3);
            Controls.Add(txtClientPortnum);
            Controls.Add(label2);
            Controls.Add(txtmsg);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(txtLog);
            Controls.Add(Log);
            Controls.Add(Send);
            Controls.Add(txtServerPort);
            Controls.Add(ServerPort);
            Name = "Client";
            Text = "Client";
            Load += Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox txtLog;
        private Label Log;
        private Button Send;
        private TextBox txtServerPort;
        private Label ServerPort;
        private TextBox txtmsg;
        private Label label1;
        private TextBox txtClientPortnum;
        private Label label2;
        private TextBox txtHostName;
        private Label label3;
    }
}