namespace Task1
{
    partial class Server
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
            Start = new Button();
            ServerPort = new Label();
            txtServerPort = new TextBox();
            New = new Button();
            txtLog = new TextBox();
            Log = new Label();
            textBox3 = new TextBox();
            txtServerMessage = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Start
            // 
            Start.Location = new Point(34, 363);
            Start.Name = "Start";
            Start.Size = new Size(132, 51);
            Start.TabIndex = 0;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // ServerPort
            // 
            ServerPort.AutoSize = true;
            ServerPort.Location = new Point(34, 114);
            ServerPort.Name = "ServerPort";
            ServerPort.Size = new Size(83, 20);
            ServerPort.TabIndex = 1;
            ServerPort.Text = "Server Port:";
            ServerPort.Click += label1_Click;
            // 
            // txtServerPort
            // 
            txtServerPort.Location = new Point(123, 114);
            txtServerPort.Name = "txtServerPort";
            txtServerPort.Size = new Size(125, 27);
            txtServerPort.TabIndex = 2;
            txtServerPort.TextChanged += textBox1_TextChanged;
            // 
            // New
            // 
            New.Location = new Point(235, 363);
            New.Name = "New";
            New.Size = new Size(132, 51);
            New.TabIndex = 3;
            New.Text = "New";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(77, 163);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(244, 124);
            txtLog.TabIndex = 5;
            // 
            // Log
            // 
            Log.AutoSize = true;
            Log.Location = new Point(34, 153);
            Log.Name = "Log";
            Log.Size = new Size(37, 20);
            Log.TabIndex = 4;
            Log.Text = "Log:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(34, 12);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 65);
            textBox3.TabIndex = 6;
            textBox3.Text = "Server";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // txtServerMessage
            // 
            txtServerMessage.Location = new Point(34, 318);
            txtServerMessage.Name = "txtServerMessage";
            txtServerMessage.Size = new Size(216, 27);
            txtServerMessage.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 290);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 8;
            label1.Text = "Server Message :";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 431);
            Controls.Add(label1);
            Controls.Add(txtServerMessage);
            Controls.Add(textBox3);
            Controls.Add(txtLog);
            Controls.Add(Log);
            Controls.Add(New);
            Controls.Add(txtServerPort);
            Controls.Add(ServerPort);
            Controls.Add(Start);
            Name = "Server";
            Text = "Server";
            Load += Server_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start;
        private Label ServerPort;
        private TextBox txtServerPort;
        private Button New;
        private TextBox txtLog;
        private Label Log;
        private TextBox textBox3;
        private TextBox txtServerMessage;
        private Label label1;
    }
}
