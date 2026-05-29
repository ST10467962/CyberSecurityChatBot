namespace CyberSecurityChatBot
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblTitle.Location = new System.Drawing.Point(160, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(498, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cybersecurity Awareness Assistant ";
            // 
            // rtbChat
            // 
            this.rtbChat.BackColor = System.Drawing.Color.Black;
            this.rtbChat.ForeColor = System.Drawing.Color.Lime;
            this.rtbChat.Location = new System.Drawing.Point(71, 73);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.Size = new System.Drawing.Size(664, 194);
            this.rtbChat.TabIndex = 1;
            this.rtbChat.Text = "";
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(82, 316);
            this.txtUserInput.Multiline = true;
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(258, 38);
            this.txtUserInput.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSend.Font = new System.Drawing.Font("Palatino Linotype", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(600, 316);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(162, 38);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
    }
}

